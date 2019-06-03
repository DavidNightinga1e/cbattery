using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace cbattery
{
    public partial class Configurator : Form
    {
        private readonly IconManager _manager;
        private int _currentSelected;
        
        public Configurator()
        {
            InitializeComponent();
            var formatter = new BinaryFormatter();
            try
            {
                using (var fs = new FileStream("manager_data", FileMode.Open))
                    _manager = (IconManager) formatter.Deserialize(fs);
            }
            catch
            {
                // ignored
            }

            if (_manager == null)
                _manager = new IconManager();
            UpdateListOfStints();
            Timer.Enabled = true;
        }

        private void UpdateListOfStints()
        {
            var stints = _manager.Stints.ToArray();
            ListOfStints.Items.Clear();
            foreach (var stint in stints)
            {
                ListOfStints.Items.Add(stint.ToString());
            }

            ListOfStints.SelectedIndex = _currentSelected;
        }

        private void ButtonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                var selected = ListOfStints.SelectedIndex;
                _manager.ChangeStintByIndex(selected, colorDialog.Color);
            }
            UpdateListOfStints();
        }

        private void ButtonRemoveStint_Click(object sender, EventArgs e)
        {
            _manager.RemoveStint(ListOfStints.SelectedIndex);
            UpdateListOfStints();
        }

        private void ListOfStints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfStints.SelectedIndex != -1)
            {
                _currentSelected = ListOfStints.SelectedIndex;
                ButtonColorPicker.BackColor = _manager.Stints[ListOfStints.SelectedIndex].Color;
                UpDownPercent.Value = _manager.Stints[ListOfStints.SelectedIndex].Percent;
            } 
            ListOfStints.SelectedIndex = _currentSelected;
        }

        private void ButtonAddStint_Click(object sender, EventArgs e)
        {
            _manager.AddStint();
            UpdateListOfStints();
        }

        private void TrackBarTester_Scroll(object sender, EventArgs e)
        {
            var percent = TrackBarTester.Value;
            UpdateIcon(percent);
        }

        private void UpDownPercent_ValueChanged(object sender, EventArgs e)
        {
            _manager.ChangeStintByIndex(ListOfStints.SelectedIndex, (int)UpDownPercent.Value);
            UpdateListOfStints();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CheckBoxFromBattery.Checked)
            {
                var batteryInfo = BatteryStatus.GetBatteryInfo();
                var percentf = Math.Floor((float)batteryInfo.CurrentCapacity * 100 / batteryInfo.FullChargeCapacity);
                var percent = Convert.ToSByte(percentf);
                UpdateIcon(percent);
                TrayIcon.Text = BatteryStatus.GetStringInfo();
            }
        }

        
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);
        private void UpdateIcon(int percent)
        {
            var icon = _manager.GetIconByPercent(percent);
            var handle = icon.Handle;
            TrayIcon.Icon = icon;
            DestroyIcon(handle);
            TrayIcon.Visible = true;
        }

        private void OpenConfiguratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void QuitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForExit();
            TrayIcon.Visible = false;
            Application.Exit();
        }

        private void Configurator_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveForExit();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                e.Cancel = true;
            }
            else
                TrayIcon.Visible = false;
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            SaveForExit();
            Application.Exit();
        }
        
        private void SaveForExit()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("manager_data", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _manager);
            }   
        }
    }
}
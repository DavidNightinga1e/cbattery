using System;
using System.CodeDom;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace cbattery
{
    public partial class Configurator : Form
    {
        private readonly UserData _userData;
        private readonly BatteryStatus _batteryStatus;
        private readonly IconManager _manager;
        private int _currentSelected;

        public Configurator()
        {
            InitializeComponent();
            var formatter = new JsonSerializer();
            try
            {
                using (var fs = new FileStream("UserData", FileMode.Open))
                {
                    var sr = new StreamReader(fs);
                    _userData = JsonConvert.DeserializeObject<UserData>(sr.ReadToEnd());
                    sr.Close();
                }
            }
            catch
            {
                _userData = new UserData {IconManager = IconManager.New()};
            }

            _batteryStatus = new BatteryStatus();
            _manager = _userData.IconManager;
            UpdateChecks();
            UpdateListOfStints();
            Timer.Enabled = true;
            _batteryStatus.Update();
        }

        private void UpdateChecks()
        {
            var checks = _userData.TrayTextChecks;
            CheckP.Checked = checks.P;
            CheckC.Checked = checks.C;
            CheckV.Checked = checks.V;
            CheckW.Checked = checks.W;
            CheckD.Checked = checks.D;
            CheckT.Checked = checks.T;
            CheckS.Checked = checks.S;
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
                var color = _manager.Stints[ListOfStints.SelectedIndex].Color;
                ButtonColorPicker.BackColor = Color.FromArgb(color.A / 2, color.R, color.G, color.B);
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
            _manager.ChangeStintByIndex(ListOfStints.SelectedIndex, (int) UpDownPercent.Value);
            UpdateListOfStints();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!CheckBoxTest.Checked)
            {
                _batteryStatus.Update();
            
                BatteryInfoTextBox.Text = _batteryStatus.ToString();

                UpdateIcon(_batteryStatus.Percent);
                
                var tray = "cBattery";
                if (CheckP.Checked)
                    tray += '\n' + _batteryStatus.GetPercent(false);
                if (CheckC.Checked) 
                    tray += '\n' + _batteryStatus.GetCapacity(false);
                if (CheckV.Checked)
                    tray += '\n' + _batteryStatus.GetVoltage(false);
                if (CheckW.Checked)
                    tray += '\n' + _batteryStatus.GetWear(false);
                if (CheckD.Checked)
                    tray += '\n' + _batteryStatus.GetDischarge(false);
                if (CheckT.Checked)
                    tray += '\n' + _batteryStatus.GetTimeEst(false);
                if (CheckS.Checked)
                    tray += '\n' + _batteryStatus.GetTimeEnd(false);

                if (tray.Length > 64)
                    tray = "64 characters limit reached\nDeselect some values";

                TrayIcon.Text = tray;
            }
        }

        
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);
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
                TrayIcon.Dispose();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            SaveForExit();
            Application.Exit();
        }
        
        private void SaveForExit()
        {
            _userData.TrayTextChecks.P = CheckP.Checked;
            _userData.TrayTextChecks.C = CheckC.Checked;
            _userData.TrayTextChecks.V = CheckV.Checked;
            _userData.TrayTextChecks.W = CheckW.Checked;
            _userData.TrayTextChecks.D = CheckD.Checked;
            _userData.TrayTextChecks.T = CheckT.Checked;
            _userData.TrayTextChecks.S = CheckS.Checked;
            using (var fs = new FileStream("UserData", FileMode.OpenOrCreate))
            {
                var sw = new StreamWriter(fs);
                sw.Write(JsonConvert.SerializeObject(_userData));
                sw.Close();
            }   
        }
        
        private void UpdateRateSelector_ValueChanged(object sender, EventArgs e)
        {
            Timer.Interval = (int)UpdateRateSelector.Value;
        }

        private void CheckBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            TrackBarTester.Enabled = CheckBoxTest.Checked;
            if (CheckBoxTest.Checked == true)
            {
                TrayIcon.Icon = Icon;
                TrayIcon.Text = "cBattery\nIcon test mode";
            }
        }
    }
}
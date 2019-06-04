namespace cbattery
{
    partial class Configurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(cbattery.Configurator));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenConfiguratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfStints = new System.Windows.Forms.ListBox();
            this.TrackBarTester = new System.Windows.Forms.TrackBar();
            this.ButtonColorPicker = new System.Windows.Forms.Button();
            this.UpDownPercent = new System.Windows.Forms.NumericUpDown();
            this.ButtonRemoveStint = new System.Windows.Forms.Button();
            this.ButtonAddStint = new System.Windows.Forms.Button();
            this.CheckBoxFromBattery = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.BatteryInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelUpdateRate = new System.Windows.Forms.Label();
            this.UpdateRateSelector = new System.Windows.Forms.NumericUpDown();
            this.CheckP = new System.Windows.Forms.CheckBox();
            this.CheckC = new System.Windows.Forms.CheckBox();
            this.CheckV = new System.Windows.Forms.CheckBox();
            this.CheckW = new System.Windows.Forms.CheckBox();
            this.CheckD = new System.Windows.Forms.CheckBox();
            this.CheckT = new System.Windows.Forms.CheckBox();
            this.CheckS = new System.Windows.Forms.CheckBox();
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.TrackBarTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.UpDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.UpdateRateSelector)).BeginInit();
            this.SuspendLayout();
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon) (resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "cBattery";
            this.TrayIcon.Visible = true;
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.OpenConfiguratorToolStripMenuItem, this.QuitProgramToolStripMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(175, 48);
            this.OpenConfiguratorToolStripMenuItem.Name = "OpenConfiguratorToolStripMenuItem";
            this.OpenConfiguratorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.OpenConfiguratorToolStripMenuItem.Text = "Open Configurator";
            this.OpenConfiguratorToolStripMenuItem.Click +=
                new System.EventHandler(this.OpenConfiguratorToolStripMenuItem_Click);
            this.QuitProgramToolStripMenuItem.Name = "QuitProgramToolStripMenuItem";
            this.QuitProgramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.QuitProgramToolStripMenuItem.Text = "Quit Program";
            this.QuitProgramToolStripMenuItem.Click += new System.EventHandler(this.QuitProgramToolStripMenuItem_Click);
            this.ListOfStints.FormattingEnabled = true;
            this.ListOfStints.ItemHeight = 15;
            this.ListOfStints.Location = new System.Drawing.Point(13, 12);
            this.ListOfStints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListOfStints.Name = "ListOfStints";
            this.ListOfStints.Size = new System.Drawing.Size(148, 184);
            this.ListOfStints.TabIndex = 0;
            this.ListOfStints.SelectedIndexChanged += new System.EventHandler(this.ListOfStints_SelectedIndexChanged);
            this.TrackBarTester.Location = new System.Drawing.Point(183, 74);
            this.TrackBarTester.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackBarTester.Maximum = 100;
            this.TrackBarTester.Name = "TrackBarTester";
            this.TrackBarTester.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarTester.Size = new System.Drawing.Size(45, 122);
            this.TrackBarTester.TabIndex = 1;
            this.TrackBarTester.TickFrequency = 5;
            this.TrackBarTester.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarTester.Scroll += new System.EventHandler(this.TrackBarTester_Scroll);
            this.ButtonColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonColorPicker.Location = new System.Drawing.Point(167, 43);
            this.ButtonColorPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(80, 25);
            this.ButtonColorPicker.TabIndex = 2;
            this.ButtonColorPicker.Text = "Color";
            this.ButtonColorPicker.UseVisualStyleBackColor = true;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            this.UpDownPercent.Location = new System.Drawing.Point(167, 12);
            this.UpDownPercent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpDownPercent.Name = "UpDownPercent";
            this.UpDownPercent.Size = new System.Drawing.Size(80, 23);
            this.UpDownPercent.TabIndex = 3;
            this.UpDownPercent.ValueChanged += new System.EventHandler(this.UpDownPercent_ValueChanged);
            this.ButtonRemoveStint.BackColor = System.Drawing.Color.LavenderBlush;
            this.ButtonRemoveStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRemoveStint.Location = new System.Drawing.Point(68, 207);
            this.ButtonRemoveStint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonRemoveStint.Name = "ButtonRemoveStint";
            this.ButtonRemoveStint.Size = new System.Drawing.Size(48, 23);
            this.ButtonRemoveStint.TabIndex = 4;
            this.ButtonRemoveStint.Text = "Del";
            this.ButtonRemoveStint.UseVisualStyleBackColor = false;
            this.ButtonRemoveStint.Click += new System.EventHandler(this.ButtonRemoveStint_Click);
            this.ButtonAddStint.BackColor = System.Drawing.Color.Honeydew;
            this.ButtonAddStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddStint.Location = new System.Drawing.Point(12, 207);
            this.ButtonAddStint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAddStint.Name = "ButtonAddStint";
            this.ButtonAddStint.Size = new System.Drawing.Size(48, 23);
            this.ButtonAddStint.TabIndex = 5;
            this.ButtonAddStint.Text = "Add";
            this.ButtonAddStint.UseVisualStyleBackColor = false;
            this.ButtonAddStint.Click += new System.EventHandler(this.ButtonAddStint_Click);
            this.CheckBoxFromBattery.Location = new System.Drawing.Point(124, 205);
            this.CheckBoxFromBattery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBoxFromBattery.Name = "CheckBoxFromBattery";
            this.CheckBoxFromBattery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxFromBattery.Size = new System.Drawing.Size(104, 24);
            this.CheckBoxFromBattery.TabIndex = 6;
            this.CheckBoxFromBattery.Text = "From Battery";
            this.CheckBoxFromBattery.UseVisualStyleBackColor = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            this.ButtonQuit.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonQuit.Location = new System.Drawing.Point(430, 12);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(74, 23);
            this.ButtonQuit.TabIndex = 8;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            this.BatteryInfoTextBox.Location = new System.Drawing.Point(254, 42);
            this.BatteryInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BatteryInfoTextBox.Name = "BatteryInfoTextBox";
            this.BatteryInfoTextBox.Size = new System.Drawing.Size(168, 154);
            this.BatteryInfoTextBox.TabIndex = 9;
            this.BatteryInfoTextBox.Text = "Battery info to be displayed here after first update";
            this.LabelUpdateRate.Location = new System.Drawing.Point(254, 14);
            this.LabelUpdateRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUpdateRate.Name = "LabelUpdateRate";
            this.LabelUpdateRate.Size = new System.Drawing.Size(96, 23);
            this.LabelUpdateRate.TabIndex = 10;
            this.LabelUpdateRate.Text = "Update rate (ms)";
            this.UpdateRateSelector.Increment = new decimal(new int[] {100, 0, 0, 0});
            this.UpdateRateSelector.Location = new System.Drawing.Point(355, 12);
            this.UpdateRateSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateRateSelector.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.UpdateRateSelector.Minimum = new decimal(new int[] {100, 0, 0, 0});
            this.UpdateRateSelector.Name = "UpdateRateSelector";
            this.UpdateRateSelector.Size = new System.Drawing.Size(68, 23);
            this.UpdateRateSelector.TabIndex = 11;
            this.UpdateRateSelector.Value = new decimal(new int[] {1000, 0, 0, 0});
            this.UpdateRateSelector.ValueChanged += new System.EventHandler(this.UpdateRateSelector_ValueChanged);
            this.CheckP.Checked = true;
            this.CheckP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckP.Location = new System.Drawing.Point(429, 43);
            this.CheckP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckP.Name = "CheckP";
            this.CheckP.Size = new System.Drawing.Size(34, 24);
            this.CheckP.TabIndex = 12;
            this.CheckP.Text = "P";
            this.CheckP.UseVisualStyleBackColor = true;
            this.CheckC.Checked = true;
            this.CheckC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckC.Location = new System.Drawing.Point(470, 43);
            this.CheckC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckC.Name = "CheckC";
            this.CheckC.Size = new System.Drawing.Size(34, 24);
            this.CheckC.TabIndex = 13;
            this.CheckC.Text = "C";
            this.CheckC.UseVisualStyleBackColor = true;
            this.CheckV.Checked = true;
            this.CheckV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckV.Location = new System.Drawing.Point(429, 63);
            this.CheckV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckV.Name = "CheckV";
            this.CheckV.Size = new System.Drawing.Size(34, 24);
            this.CheckV.TabIndex = 15;
            this.CheckV.Text = "V";
            this.CheckV.UseVisualStyleBackColor = true;
            this.CheckW.Checked = true;
            this.CheckW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckW.Location = new System.Drawing.Point(470, 63);
            this.CheckW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckW.Name = "CheckW";
            this.CheckW.Size = new System.Drawing.Size(43, 24);
            this.CheckW.TabIndex = 14;
            this.CheckW.Text = "W";
            this.CheckW.UseVisualStyleBackColor = true;
            this.CheckD.Checked = true;
            this.CheckD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckD.Location = new System.Drawing.Point(429, 85);
            this.CheckD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckD.Name = "CheckD";
            this.CheckD.Size = new System.Drawing.Size(34, 24);
            this.CheckD.TabIndex = 18;
            this.CheckD.Text = "D";
            this.CheckD.UseVisualStyleBackColor = true;
            this.CheckT.Checked = true;
            this.CheckT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckT.Location = new System.Drawing.Point(470, 85);
            this.CheckT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckT.Name = "CheckT";
            this.CheckT.Size = new System.Drawing.Size(34, 24);
            this.CheckT.TabIndex = 17;
            this.CheckT.Text = "T";
            this.CheckT.UseVisualStyleBackColor = true;
            this.CheckS.Checked = true;
            this.CheckS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckS.Location = new System.Drawing.Point(429, 106);
            this.CheckS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckS.Name = "CheckS";
            this.CheckS.Size = new System.Drawing.Size(34, 24);
            this.CheckS.TabIndex = 16;
            this.CheckS.Text = "S";
            this.CheckS.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 238);
            this.Controls.Add(this.CheckD);
            this.Controls.Add(this.CheckT);
            this.Controls.Add(this.CheckS);
            this.Controls.Add(this.CheckV);
            this.Controls.Add(this.CheckW);
            this.Controls.Add(this.CheckC);
            this.Controls.Add(this.CheckP);
            this.Controls.Add(this.UpdateRateSelector);
            this.Controls.Add(this.LabelUpdateRate);
            this.Controls.Add(this.BatteryInfoTextBox);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.CheckBoxFromBattery);
            this.Controls.Add(this.ButtonAddStint);
            this.Controls.Add(this.ButtonRemoveStint);
            this.Controls.Add(this.UpDownPercent);
            this.Controls.Add(this.ButtonColorPicker);
            this.Controls.Add(this.TrackBarTester);
            this.Controls.Add(this.ListOfStints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Configurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cBattery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configurator_FormClosing);
            this.TrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.TrackBarTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.UpDownPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.UpdateRateSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ListOfStints;
        private System.Windows.Forms.TrackBar TrackBarTester;
        private System.Windows.Forms.Button ButtonColorPicker;
        private System.Windows.Forms.NumericUpDown UpDownPercent;
        private System.Windows.Forms.Button ButtonRemoveStint;
        private System.Windows.Forms.Button ButtonAddStint;
        private System.Windows.Forms.CheckBox CheckBoxFromBattery;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenConfiguratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitProgramToolStripMenuItem;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.RichTextBox BatteryInfoTextBox;
        private System.Windows.Forms.Label LabelUpdateRate;
        private System.Windows.Forms.NumericUpDown UpdateRateSelector;
        private System.Windows.Forms.CheckBox CheckP;
        private System.Windows.Forms.CheckBox CheckC;
        private System.Windows.Forms.CheckBox CheckV;
        private System.Windows.Forms.CheckBox CheckW;
        private System.Windows.Forms.CheckBox CheckD;
        private System.Windows.Forms.CheckBox CheckT;
        private System.Windows.Forms.CheckBox CheckS;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}
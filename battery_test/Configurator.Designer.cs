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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurator));
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
            this.CheckBoxTest = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateRateSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "cBattery";
            this.TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenConfiguratorToolStripMenuItem,
            this.QuitProgramToolStripMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(175, 48);
            // 
            // OpenConfiguratorToolStripMenuItem
            // 
            this.OpenConfiguratorToolStripMenuItem.Name = "OpenConfiguratorToolStripMenuItem";
            this.OpenConfiguratorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.OpenConfiguratorToolStripMenuItem.Text = "Open Configurator";
            this.OpenConfiguratorToolStripMenuItem.Click += new System.EventHandler(this.OpenConfiguratorToolStripMenuItem_Click);
            // 
            // QuitProgramToolStripMenuItem
            // 
            this.QuitProgramToolStripMenuItem.Name = "QuitProgramToolStripMenuItem";
            this.QuitProgramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.QuitProgramToolStripMenuItem.Text = "Quit Program";
            this.QuitProgramToolStripMenuItem.Click += new System.EventHandler(this.QuitProgramToolStripMenuItem_Click);
            // 
            // ListOfStints
            // 
            this.ListOfStints.FormattingEnabled = true;
            this.ListOfStints.Location = new System.Drawing.Point(11, 10);
            this.ListOfStints.Name = "ListOfStints";
            this.ListOfStints.Size = new System.Drawing.Size(127, 160);
            this.ListOfStints.TabIndex = 0;
            this.ListOfStints.SelectedIndexChanged += new System.EventHandler(this.ListOfStints_SelectedIndexChanged);
            // 
            // TrackBarTester
            // 
            this.TrackBarTester.Enabled = false;
            this.TrackBarTester.Location = new System.Drawing.Point(150, 92);
            this.TrackBarTester.Maximum = 100;
            this.TrackBarTester.Name = "TrackBarTester";
            this.TrackBarTester.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarTester.Size = new System.Drawing.Size(45, 107);
            this.TrackBarTester.TabIndex = 1;
            this.TrackBarTester.TickFrequency = 5;
            this.TrackBarTester.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarTester.Scroll += new System.EventHandler(this.TrackBarTester_Scroll);
            // 
            // ButtonColorPicker
            // 
            this.ButtonColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonColorPicker.Location = new System.Drawing.Point(143, 37);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(69, 22);
            this.ButtonColorPicker.TabIndex = 2;
            this.ButtonColorPicker.Text = "Color";
            this.ButtonColorPicker.UseVisualStyleBackColor = true;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            // 
            // UpDownPercent
            // 
            this.UpDownPercent.Location = new System.Drawing.Point(143, 10);
            this.UpDownPercent.Name = "UpDownPercent";
            this.UpDownPercent.Size = new System.Drawing.Size(69, 20);
            this.UpDownPercent.TabIndex = 3;
            this.UpDownPercent.ValueChanged += new System.EventHandler(this.UpDownPercent_ValueChanged);
            // 
            // ButtonRemoveStint
            // 
            this.ButtonRemoveStint.BackColor = System.Drawing.Color.LavenderBlush;
            this.ButtonRemoveStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRemoveStint.Location = new System.Drawing.Point(58, 179);
            this.ButtonRemoveStint.Name = "ButtonRemoveStint";
            this.ButtonRemoveStint.Size = new System.Drawing.Size(41, 20);
            this.ButtonRemoveStint.TabIndex = 4;
            this.ButtonRemoveStint.Text = "Del";
            this.ButtonRemoveStint.UseVisualStyleBackColor = false;
            this.ButtonRemoveStint.Click += new System.EventHandler(this.ButtonRemoveStint_Click);
            // 
            // ButtonAddStint
            // 
            this.ButtonAddStint.BackColor = System.Drawing.Color.Honeydew;
            this.ButtonAddStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddStint.Location = new System.Drawing.Point(10, 179);
            this.ButtonAddStint.Name = "ButtonAddStint";
            this.ButtonAddStint.Size = new System.Drawing.Size(41, 20);
            this.ButtonAddStint.TabIndex = 5;
            this.ButtonAddStint.Text = "Add";
            this.ButtonAddStint.UseVisualStyleBackColor = false;
            this.ButtonAddStint.Click += new System.EventHandler(this.ButtonAddStint_Click);
            // 
            // CheckBoxTest
            // 
            this.CheckBoxTest.Location = new System.Drawing.Point(150, 65);
            this.CheckBoxTest.Name = "CheckBoxTest";
            this.CheckBoxTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxTest.Size = new System.Drawing.Size(52, 21);
            this.CheckBoxTest.TabIndex = 6;
            this.CheckBoxTest.Text = "Test";
            this.CheckBoxTest.UseVisualStyleBackColor = true;
            this.CheckBoxTest.CheckedChanged += new System.EventHandler(this.CheckBoxTest_CheckedChanged);
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonQuit.Location = new System.Drawing.Point(369, 10);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(63, 20);
            this.ButtonQuit.TabIndex = 8;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // BatteryInfoTextBox
            // 
            this.BatteryInfoTextBox.Location = new System.Drawing.Point(218, 36);
            this.BatteryInfoTextBox.Name = "BatteryInfoTextBox";
            this.BatteryInfoTextBox.Size = new System.Drawing.Size(145, 158);
            this.BatteryInfoTextBox.TabIndex = 9;
            this.BatteryInfoTextBox.Text = "Battery info to be displayed here after first update";
            // 
            // LabelUpdateRate
            // 
            this.LabelUpdateRate.Location = new System.Drawing.Point(218, 12);
            this.LabelUpdateRate.Name = "LabelUpdateRate";
            this.LabelUpdateRate.Size = new System.Drawing.Size(82, 20);
            this.LabelUpdateRate.TabIndex = 10;
            this.LabelUpdateRate.Text = "Update rate (ms)";
            // 
            // UpdateRateSelector
            // 
            this.UpdateRateSelector.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpdateRateSelector.Location = new System.Drawing.Point(304, 10);
            this.UpdateRateSelector.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpdateRateSelector.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpdateRateSelector.Name = "UpdateRateSelector";
            this.UpdateRateSelector.Size = new System.Drawing.Size(58, 20);
            this.UpdateRateSelector.TabIndex = 11;
            this.UpdateRateSelector.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpdateRateSelector.ValueChanged += new System.EventHandler(this.UpdateRateSelector_ValueChanged);
            // 
            // CheckP
            // 
            this.CheckP.Checked = true;
            this.CheckP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckP.Location = new System.Drawing.Point(368, 37);
            this.CheckP.Name = "CheckP";
            this.CheckP.Size = new System.Drawing.Size(29, 21);
            this.CheckP.TabIndex = 12;
            this.CheckP.Text = "P";
            this.CheckP.UseVisualStyleBackColor = true;
            // 
            // CheckC
            // 
            this.CheckC.Checked = true;
            this.CheckC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckC.Location = new System.Drawing.Point(368, 55);
            this.CheckC.Name = "CheckC";
            this.CheckC.Size = new System.Drawing.Size(29, 21);
            this.CheckC.TabIndex = 13;
            this.CheckC.Text = "C";
            this.CheckC.UseVisualStyleBackColor = true;
            // 
            // CheckV
            // 
            this.CheckV.Checked = true;
            this.CheckV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckV.Location = new System.Drawing.Point(368, 73);
            this.CheckV.Name = "CheckV";
            this.CheckV.Size = new System.Drawing.Size(29, 21);
            this.CheckV.TabIndex = 15;
            this.CheckV.Text = "V";
            this.CheckV.UseVisualStyleBackColor = true;
            // 
            // CheckW
            // 
            this.CheckW.Checked = true;
            this.CheckW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckW.Location = new System.Drawing.Point(368, 91);
            this.CheckW.Name = "CheckW";
            this.CheckW.Size = new System.Drawing.Size(37, 21);
            this.CheckW.TabIndex = 14;
            this.CheckW.Text = "W";
            this.CheckW.UseVisualStyleBackColor = true;
            // 
            // CheckD
            // 
            this.CheckD.Checked = true;
            this.CheckD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckD.Location = new System.Drawing.Point(368, 109);
            this.CheckD.Name = "CheckD";
            this.CheckD.Size = new System.Drawing.Size(29, 21);
            this.CheckD.TabIndex = 18;
            this.CheckD.Text = "D";
            this.CheckD.UseVisualStyleBackColor = true;
            // 
            // CheckT
            // 
            this.CheckT.Checked = true;
            this.CheckT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckT.Location = new System.Drawing.Point(368, 127);
            this.CheckT.Name = "CheckT";
            this.CheckT.Size = new System.Drawing.Size(29, 21);
            this.CheckT.TabIndex = 17;
            this.CheckT.Text = "T";
            this.CheckT.UseVisualStyleBackColor = true;
            // 
            // CheckS
            // 
            this.CheckS.Checked = true;
            this.CheckS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckS.Location = new System.Drawing.Point(368, 145);
            this.CheckS.Name = "CheckS";
            this.CheckS.Size = new System.Drawing.Size(29, 21);
            this.CheckS.TabIndex = 16;
            this.CheckS.Text = "S";
            this.CheckS.UseVisualStyleBackColor = true;
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 206);
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
            this.Controls.Add(this.CheckBoxTest);
            this.Controls.Add(this.ButtonAddStint);
            this.Controls.Add(this.ButtonRemoveStint);
            this.Controls.Add(this.UpDownPercent);
            this.Controls.Add(this.ButtonColorPicker);
            this.Controls.Add(this.TrackBarTester);
            this.Controls.Add(this.ListOfStints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cBattery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configurator_FormClosing);
            this.TrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateRateSelector)).EndInit();
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
        private System.Windows.Forms.CheckBox CheckBoxTest;
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
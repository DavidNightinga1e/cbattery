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
            this.IconTimer = new System.Windows.Forms.Timer(this.components);
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
            this.ButtonOffsetUp = new System.Windows.Forms.Button();
            this.ButtonOffsetLeft = new System.Windows.Forms.Button();
            this.ButtonOffsetRight = new System.Windows.Forms.Button();
            this.ButtonOffsetDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDownBottomLineWidth = new System.Windows.Forms.NumericUpDown();
            this.TrackBarBottomLineAlpha = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateRateSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBottomLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBottomLineAlpha)).BeginInit();
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
            this.ListOfStints.Location = new System.Drawing.Point(6, 16);
            this.ListOfStints.Name = "ListOfStints";
            this.ListOfStints.Size = new System.Drawing.Size(127, 160);
            this.ListOfStints.TabIndex = 0;
            this.ListOfStints.SelectedIndexChanged += new System.EventHandler(this.ListOfStints_SelectedIndexChanged);
            // 
            // TrackBarTester
            // 
            this.TrackBarTester.Enabled = false;
            this.TrackBarTester.Location = new System.Drawing.Point(145, 98);
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
            this.ButtonColorPicker.Location = new System.Drawing.Point(139, 43);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(69, 22);
            this.ButtonColorPicker.TabIndex = 2;
            this.ButtonColorPicker.Text = "Color";
            this.ButtonColorPicker.UseVisualStyleBackColor = true;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            // 
            // UpDownPercent
            // 
            this.UpDownPercent.Location = new System.Drawing.Point(138, 16);
            this.UpDownPercent.Name = "UpDownPercent";
            this.UpDownPercent.Size = new System.Drawing.Size(69, 20);
            this.UpDownPercent.TabIndex = 3;
            this.UpDownPercent.ValueChanged += new System.EventHandler(this.UpDownPercent_ValueChanged);
            // 
            // ButtonRemoveStint
            // 
            this.ButtonRemoveStint.BackColor = System.Drawing.Color.LavenderBlush;
            this.ButtonRemoveStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRemoveStint.Location = new System.Drawing.Point(52, 185);
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
            this.ButtonAddStint.Location = new System.Drawing.Point(5, 185);
            this.ButtonAddStint.Name = "ButtonAddStint";
            this.ButtonAddStint.Size = new System.Drawing.Size(41, 20);
            this.ButtonAddStint.TabIndex = 5;
            this.ButtonAddStint.Text = "Add";
            this.ButtonAddStint.UseVisualStyleBackColor = false;
            this.ButtonAddStint.Click += new System.EventHandler(this.ButtonAddStint_Click);
            // 
            // CheckBoxTest
            // 
            this.CheckBoxTest.Location = new System.Drawing.Point(145, 71);
            this.CheckBoxTest.Name = "CheckBoxTest";
            this.CheckBoxTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxTest.Size = new System.Drawing.Size(52, 21);
            this.CheckBoxTest.TabIndex = 6;
            this.CheckBoxTest.Text = "Test";
            this.CheckBoxTest.UseVisualStyleBackColor = true;
            this.CheckBoxTest.CheckedChanged += new System.EventHandler(this.CheckBoxTest_CheckedChanged);
            // 
            // IconTimer
            // 
            this.IconTimer.Interval = 300;
            this.IconTimer.Tick += new System.EventHandler(this.IconTimer_Tick);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonQuit.Location = new System.Drawing.Point(389, 311);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(63, 20);
            this.ButtonQuit.TabIndex = 8;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // BatteryInfoTextBox
            // 
            this.BatteryInfoTextBox.Location = new System.Drawing.Point(6, 40);
            this.BatteryInfoTextBox.Name = "BatteryInfoTextBox";
            this.BatteryInfoTextBox.Size = new System.Drawing.Size(145, 158);
            this.BatteryInfoTextBox.TabIndex = 9;
            this.BatteryInfoTextBox.Text = "Battery info to be displayed here after first update";
            // 
            // LabelUpdateRate
            // 
            this.LabelUpdateRate.Location = new System.Drawing.Point(6, 16);
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
            this.UpdateRateSelector.Location = new System.Drawing.Point(92, 14);
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
            this.CheckP.Location = new System.Drawing.Point(172, 41);
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
            this.CheckC.Location = new System.Drawing.Point(172, 59);
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
            this.CheckV.Location = new System.Drawing.Point(172, 77);
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
            this.CheckW.Location = new System.Drawing.Point(172, 95);
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
            this.CheckD.Location = new System.Drawing.Point(172, 113);
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
            this.CheckT.Location = new System.Drawing.Point(172, 131);
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
            this.CheckS.Location = new System.Drawing.Point(172, 149);
            this.CheckS.Name = "CheckS";
            this.CheckS.Size = new System.Drawing.Size(29, 21);
            this.CheckS.TabIndex = 16;
            this.CheckS.Text = "S";
            this.CheckS.UseVisualStyleBackColor = true;
            // 
            // ButtonOffsetUp
            // 
            this.ButtonOffsetUp.Location = new System.Drawing.Point(41, 18);
            this.ButtonOffsetUp.Name = "ButtonOffsetUp";
            this.ButtonOffsetUp.Size = new System.Drawing.Size(24, 24);
            this.ButtonOffsetUp.TabIndex = 19;
            this.ButtonOffsetUp.Text = "↑";
            this.ButtonOffsetUp.UseVisualStyleBackColor = true;
            this.ButtonOffsetUp.Click += new System.EventHandler(this.ButtonOffsetUp_Click);
            // 
            // ButtonOffsetLeft
            // 
            this.ButtonOffsetLeft.Location = new System.Drawing.Point(11, 48);
            this.ButtonOffsetLeft.Name = "ButtonOffsetLeft";
            this.ButtonOffsetLeft.Size = new System.Drawing.Size(24, 24);
            this.ButtonOffsetLeft.TabIndex = 20;
            this.ButtonOffsetLeft.Text = "←";
            this.ButtonOffsetLeft.UseVisualStyleBackColor = true;
            this.ButtonOffsetLeft.Click += new System.EventHandler(this.ButtonOffsetLeft_Click);
            // 
            // ButtonOffsetRight
            // 
            this.ButtonOffsetRight.Location = new System.Drawing.Point(71, 48);
            this.ButtonOffsetRight.Name = "ButtonOffsetRight";
            this.ButtonOffsetRight.Size = new System.Drawing.Size(24, 24);
            this.ButtonOffsetRight.TabIndex = 21;
            this.ButtonOffsetRight.Text = "→";
            this.ButtonOffsetRight.UseVisualStyleBackColor = true;
            this.ButtonOffsetRight.Click += new System.EventHandler(this.ButtonOffsetRight_Click);
            // 
            // ButtonOffsetDown
            // 
            this.ButtonOffsetDown.Location = new System.Drawing.Point(41, 76);
            this.ButtonOffsetDown.Name = "ButtonOffsetDown";
            this.ButtonOffsetDown.Size = new System.Drawing.Size(24, 24);
            this.ButtonOffsetDown.TabIndex = 22;
            this.ButtonOffsetDown.Text = "↓";
            this.ButtonOffsetDown.UseVisualStyleBackColor = true;
            this.ButtonOffsetDown.Click += new System.EventHandler(this.ButtonOffsetDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListOfStints);
            this.groupBox1.Controls.Add(this.TrackBarTester);
            this.groupBox1.Controls.Add(this.ButtonColorPicker);
            this.groupBox1.Controls.Add(this.UpDownPercent);
            this.groupBox1.Controls.Add(this.ButtonRemoveStint);
            this.groupBox1.Controls.Add(this.ButtonAddStint);
            this.groupBox1.Controls.Add(this.CheckBoxTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 213);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Stints";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LabelUpdateRate);
            this.groupBox2.Controls.Add(this.BatteryInfoTextBox);
            this.groupBox2.Controls.Add(this.UpdateRateSelector);
            this.groupBox2.Controls.Add(this.CheckP);
            this.groupBox2.Controls.Add(this.CheckC);
            this.groupBox2.Controls.Add(this.CheckW);
            this.groupBox2.Controls.Add(this.CheckV);
            this.groupBox2.Controls.Add(this.CheckD);
            this.groupBox2.Controls.Add(this.CheckS);
            this.groupBox2.Controls.Add(this.CheckT);
            this.groupBox2.Location = new System.Drawing.Point(233, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 213);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Battery Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "To Tray:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TrackBarBottomLineAlpha);
            this.groupBox3.Controls.Add(this.UpDownBottomLineWidth);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ButtonOffsetRight);
            this.groupBox3.Controls.Add(this.ButtonOffsetUp);
            this.groupBox3.Controls.Add(this.ButtonOffsetLeft);
            this.groupBox3.Controls.Add(this.ButtonOffsetDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 111);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Icon Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bottom Line Width";
            // 
            // UpDownBottomLineWidth
            // 
            this.UpDownBottomLineWidth.Location = new System.Drawing.Point(108, 32);
            this.UpDownBottomLineWidth.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.UpDownBottomLineWidth.Name = "UpDownBottomLineWidth";
            this.UpDownBottomLineWidth.Size = new System.Drawing.Size(89, 20);
            this.UpDownBottomLineWidth.TabIndex = 20;
            this.UpDownBottomLineWidth.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // TrackBarBottomLineAlpha
            // 
            this.TrackBarBottomLineAlpha.Location = new System.Drawing.Point(108, 60);
            this.TrackBarBottomLineAlpha.Maximum = 255;
            this.TrackBarBottomLineAlpha.Name = "TrackBarBottomLineAlpha";
            this.TrackBarBottomLineAlpha.Size = new System.Drawing.Size(82, 45);
            this.TrackBarBottomLineAlpha.TabIndex = 26;
            this.TrackBarBottomLineAlpha.TickFrequency = 90;
            this.TrackBarBottomLineAlpha.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarBottomLineAlpha.Scroll += new System.EventHandler(this.TrackBarBottomLineAlpha_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Transparancy";
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonQuit);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBottomLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBottomLineAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfStints;
        private System.Windows.Forms.TrackBar TrackBarTester;
        private System.Windows.Forms.Button ButtonColorPicker;
        private System.Windows.Forms.NumericUpDown UpDownPercent;
        private System.Windows.Forms.Button ButtonRemoveStint;
        private System.Windows.Forms.Button ButtonAddStint;
        private System.Windows.Forms.CheckBox CheckBoxTest;
        private System.Windows.Forms.Timer IconTimer;
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
        private System.Windows.Forms.Button ButtonOffsetUp;
        private System.Windows.Forms.Button ButtonOffsetLeft;
        private System.Windows.Forms.Button ButtonOffsetRight;
        private System.Windows.Forms.Button ButtonOffsetDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown UpDownBottomLineWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrackBarBottomLineAlpha;
        private System.Windows.Forms.Label label3;
    }
}
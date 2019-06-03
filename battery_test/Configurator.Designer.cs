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
                new System.ComponentModel.ComponentResourceManager(typeof(Configurator));
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
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.TrackBarTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.UpDownPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon) (resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "cBattery";
            this.TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.OpenConfiguratorToolStripMenuItem, this.QuitProgramToolStripMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(175, 48);
            // 
            // OpenConfiguratorToolStripMenuItem
            // 
            this.OpenConfiguratorToolStripMenuItem.Name = "OpenConfiguratorToolStripMenuItem";
            this.OpenConfiguratorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.OpenConfiguratorToolStripMenuItem.Text = "Open Configurator";
            this.OpenConfiguratorToolStripMenuItem.Click +=
                new System.EventHandler(this.OpenConfiguratorToolStripMenuItem_Click);
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
            this.ListOfStints.ItemHeight = 15;
            this.ListOfStints.Location = new System.Drawing.Point(13, 12);
            this.ListOfStints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListOfStints.Name = "ListOfStints";
            this.ListOfStints.Size = new System.Drawing.Size(148, 184);
            this.ListOfStints.TabIndex = 0;
            this.ListOfStints.SelectedIndexChanged += new System.EventHandler(this.ListOfStints_SelectedIndexChanged);
            // 
            // TrackBarTester
            // 
            this.TrackBarTester.Location = new System.Drawing.Point(255, 42);
            this.TrackBarTester.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackBarTester.Maximum = 100;
            this.TrackBarTester.Name = "TrackBarTester";
            this.TrackBarTester.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarTester.Size = new System.Drawing.Size(45, 183);
            this.TrackBarTester.TabIndex = 1;
            this.TrackBarTester.TickFrequency = 5;
            this.TrackBarTester.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarTester.Scroll += new System.EventHandler(this.TrackBarTester_Scroll);
            // 
            // ButtonColorPicker
            // 
            this.ButtonColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonColorPicker.Location = new System.Drawing.Point(167, 43);
            this.ButtonColorPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(80, 25);
            this.ButtonColorPicker.TabIndex = 2;
            this.ButtonColorPicker.Text = "Color";
            this.ButtonColorPicker.UseVisualStyleBackColor = true;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            // 
            // UpDownPercent
            // 
            this.UpDownPercent.Location = new System.Drawing.Point(167, 14);
            this.UpDownPercent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpDownPercent.Name = "UpDownPercent";
            this.UpDownPercent.Size = new System.Drawing.Size(80, 23);
            this.UpDownPercent.TabIndex = 3;
            this.UpDownPercent.ValueChanged += new System.EventHandler(this.UpDownPercent_ValueChanged);
            // 
            // ButtonRemoveStint
            // 
            this.ButtonRemoveStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRemoveStint.Location = new System.Drawing.Point(68, 207);
            this.ButtonRemoveStint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonRemoveStint.Name = "ButtonRemoveStint";
            this.ButtonRemoveStint.Size = new System.Drawing.Size(48, 23);
            this.ButtonRemoveStint.TabIndex = 4;
            this.ButtonRemoveStint.Text = "Del";
            this.ButtonRemoveStint.UseVisualStyleBackColor = true;
            this.ButtonRemoveStint.Click += new System.EventHandler(this.ButtonRemoveStint_Click);
            // 
            // ButtonAddStint
            // 
            this.ButtonAddStint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddStint.Location = new System.Drawing.Point(12, 207);
            this.ButtonAddStint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAddStint.Name = "ButtonAddStint";
            this.ButtonAddStint.Size = new System.Drawing.Size(48, 23);
            this.ButtonAddStint.TabIndex = 5;
            this.ButtonAddStint.Text = "Add";
            this.ButtonAddStint.UseVisualStyleBackColor = true;
            this.ButtonAddStint.Click += new System.EventHandler(this.ButtonAddStint_Click);
            // 
            // CheckBoxFromBattery
            // 
            this.CheckBoxFromBattery.Location = new System.Drawing.Point(124, 205);
            this.CheckBoxFromBattery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBoxFromBattery.Name = "CheckBoxFromBattery";
            this.CheckBoxFromBattery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxFromBattery.Size = new System.Drawing.Size(104, 24);
            this.CheckBoxFromBattery.TabIndex = 6;
            this.CheckBoxFromBattery.Text = "From Battery";
            this.CheckBoxFromBattery.UseVisualStyleBackColor = true;
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
            this.ButtonQuit.Location = new System.Drawing.Point(255, 12);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(68, 23);
            this.ButtonQuit.TabIndex = 8;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 241);
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
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}
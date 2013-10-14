namespace skypeRobotController_Slave
{
    partial class skypeRobotController_Slave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skypeRobotController_Slave));
            this.Serial = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.msg_listbox = new System.Windows.Forms.TextBox();
            this.user_combobox = new System.Windows.Forms.ComboBox();
            this.port_combobox = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabUsers = new System.Windows.Forms.TabControl();
            this.Admin = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.one_tabPage = new System.Windows.Forms.TabPage();
            this.stop_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.two_tabPage = new System.Windows.Forms.TabPage();
            this.two_button = new System.Windows.Forms.Button();
            this.three_TabPage = new System.Windows.Forms.TabPage();
            this.LineFollowSelectBut = new System.Windows.Forms.Button();
            this.Serial.SuspendLayout();
            this.Admin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.one_tabPage.SuspendLayout();
            this.two_tabPage.SuspendLayout();
            this.three_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.Controls.Add(this.findButton);
            this.Serial.Controls.Add(this.msg_listbox);
            this.Serial.Controls.Add(this.user_combobox);
            this.Serial.Controls.Add(this.port_combobox);
            this.Serial.Location = new System.Drawing.Point(3, 208);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(284, 147);
            this.Serial.TabIndex = 0;
            this.Serial.TabStop = false;
            this.Serial.Text = "Serial";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(114, 20);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(36, 20);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // msg_listbox
            // 
            this.msg_listbox.Location = new System.Drawing.Point(6, 46);
            this.msg_listbox.Multiline = true;
            this.msg_listbox.Name = "msg_listbox";
            this.msg_listbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msg_listbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msg_listbox.Size = new System.Drawing.Size(271, 95);
            this.msg_listbox.TabIndex = 1;
            this.msg_listbox.WordWrap = false;
            this.msg_listbox.TextChanged += new System.EventHandler(this.msg_listbox_TextChanged);
            // 
            // user_combobox
            // 
            this.user_combobox.FormattingEnabled = true;
            this.user_combobox.Location = new System.Drawing.Point(169, 19);
            this.user_combobox.Name = "user_combobox";
            this.user_combobox.Size = new System.Drawing.Size(108, 21);
            this.user_combobox.TabIndex = 2;
            this.user_combobox.Text = "User";
            this.user_combobox.SelectedIndexChanged += new System.EventHandler(this.user_combobox_SelectedIndexChanged);
            // 
            // port_combobox
            // 
            this.port_combobox.FormattingEnabled = true;
            this.port_combobox.Location = new System.Drawing.Point(6, 19);
            this.port_combobox.Name = "port_combobox";
            this.port_combobox.Size = new System.Drawing.Size(103, 21);
            this.port_combobox.TabIndex = 0;
            this.port_combobox.Text = "Serial Port";
            this.port_combobox.SelectedIndexChanged += new System.EventHandler(this.SerialPort_SelectedIndexChanged);
            // 
            // tabUsers
            // 
            this.tabUsers.Location = new System.Drawing.Point(9, 8);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(260, 194);
            this.tabUsers.TabIndex = 1;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.tabControl1);
            this.Admin.Location = new System.Drawing.Point(286, 8);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(197, 341);
            this.Admin.TabIndex = 2;
            this.Admin.TabStop = false;
            this.Admin.Text = "Admin";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.one_tabPage);
            this.tabControl1.Controls.Add(this.two_tabPage);
            this.tabControl1.Controls.Add(this.three_TabPage);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 309);
            this.tabControl1.TabIndex = 11;
            // 
            // one_tabPage
            // 
            this.one_tabPage.Controls.Add(this.stop_button);
            this.one_tabPage.Controls.Add(this.up_button);
            this.one_tabPage.Controls.Add(this.one_button);
            this.one_tabPage.Controls.Add(this.right_button);
            this.one_tabPage.Controls.Add(this.down_button);
            this.one_tabPage.Controls.Add(this.left_button);
            this.one_tabPage.Location = new System.Drawing.Point(4, 22);
            this.one_tabPage.Name = "one_tabPage";
            this.one_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.one_tabPage.Size = new System.Drawing.Size(177, 283);
            this.one_tabPage.TabIndex = 0;
            this.one_tabPage.Text = "1 - Assis. Navig.";
            this.one_tabPage.UseVisualStyleBackColor = true;
            this.one_tabPage.Click += new System.EventHandler(this.one_tabPage_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(63, 121);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(50, 50);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(63, 65);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(50, 50);
            this.up_button.TabIndex = 3;
            this.up_button.Text = "Up";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(22, 18);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(134, 25);
            this.one_button.TabIndex = 9;
            this.one_button.Text = "Select";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(119, 121);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(50, 50);
            this.right_button.TabIndex = 8;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(63, 177);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(50, 50);
            this.down_button.TabIndex = 5;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(7, 121);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(50, 50);
            this.left_button.TabIndex = 7;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // two_tabPage
            // 
            this.two_tabPage.Controls.Add(this.two_button);
            this.two_tabPage.Location = new System.Drawing.Point(4, 22);
            this.two_tabPage.Name = "two_tabPage";
            this.two_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.two_tabPage.Size = new System.Drawing.Size(177, 283);
            this.two_tabPage.TabIndex = 1;
            this.two_tabPage.Text = "2 - Obs. Avoid.";
            this.two_tabPage.UseVisualStyleBackColor = true;
            this.two_tabPage.Click += new System.EventHandler(this.two_tabPage_Click);
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(19, 19);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(134, 25);
            this.two_button.TabIndex = 10;
            this.two_button.Text = "Select";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.two_button_Click);
            // 
            // three_TabPage
            // 
            this.three_TabPage.Controls.Add(this.LineFollowSelectBut);
            this.three_TabPage.Location = new System.Drawing.Point(4, 22);
            this.three_TabPage.Name = "three_TabPage";
            this.three_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.three_TabPage.Size = new System.Drawing.Size(177, 283);
            this.three_TabPage.TabIndex = 2;
            this.three_TabPage.Text = "3 - LineFollow";
            this.three_TabPage.UseVisualStyleBackColor = true;
            // 
            // LineFollowSelectBut
            // 
            this.LineFollowSelectBut.Location = new System.Drawing.Point(23, 18);
            this.LineFollowSelectBut.Name = "LineFollowSelectBut";
            this.LineFollowSelectBut.Size = new System.Drawing.Size(134, 25);
            this.LineFollowSelectBut.TabIndex = 11;
            this.LineFollowSelectBut.Text = "Select";
            this.LineFollowSelectBut.UseVisualStyleBackColor = true;
            this.LineFollowSelectBut.Click += new System.EventHandler(this.LineFollowSelectBut_Click);
            // 
            // skypeRobotController_Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 359);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.tabUsers);
            this.Controls.Add(this.Serial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "skypeRobotController_Slave";
            this.Text = "skypeRobotController_Slave";
            this.Serial.ResumeLayout(false);
            this.Serial.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.one_tabPage.ResumeLayout(false);
            this.two_tabPage.ResumeLayout(false);
            this.three_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Serial;
        private System.Windows.Forms.ComboBox port_combobox;
        private System.IO.Ports.SerialPort serialPort;
        public System.Windows.Forms.TextBox msg_listbox;
        private System.Windows.Forms.ComboBox user_combobox;
        private System.Windows.Forms.TabControl tabUsers;
        private System.Windows.Forms.GroupBox Admin;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage one_tabPage;
        private System.Windows.Forms.TabPage two_tabPage;
        private System.Windows.Forms.TabPage three_TabPage;
        private System.Windows.Forms.Button LineFollowSelectBut;
        private System.Windows.Forms.Button findButton;
    }
}
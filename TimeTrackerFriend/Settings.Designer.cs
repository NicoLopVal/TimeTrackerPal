﻿
namespace TimeTrackerFriend
{
    partial class formSettings
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
            this.txbFileDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFolderDirectory = new System.Windows.Forms.Label();
            this.nudSaveTime = new System.Windows.Forms.NumericUpDown();
            this.lblSaveTime = new System.Windows.Forms.Label();
            this.lblSettingsLine = new System.Windows.Forms.Label();
            this.lblReminderOps = new System.Windows.Forms.Label();
            this.nudReminderTime = new System.Windows.Forms.NumericUpDown();
            this.lblReminderTime = new System.Windows.Forms.Label();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.chkbSaveActive = new System.Windows.Forms.CheckBox();
            this.chkbReminderActive = new System.Windows.Forms.CheckBox();
            this.rdbSettingsFlash = new System.Windows.Forms.RadioButton();
            this.rdbMessenger = new System.Windows.Forms.RadioButton();
            this.jiraTitleSettingsLabel = new System.Windows.Forms.Label();
            this.JiraSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.jiraUsernameTextBox = new System.Windows.Forms.TextBox();
            this.jiraUsernameLabel = new System.Windows.Forms.Label();
            this.tokenJiraLabel = new System.Windows.Forms.Label();
            this.jiraTokenTextBox = new System.Windows.Forms.TextBox();
            this.saveToPCJiraSettingsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFileDirectory
            // 
            this.txbFileDirectory.Enabled = false;
            this.txbFileDirectory.Location = new System.Drawing.Point(22, 37);
            this.txbFileDirectory.Name = "txbFileDirectory";
            this.txbFileDirectory.Size = new System.Drawing.Size(234, 23);
            this.txbFileDirectory.TabIndex = 0;
            this.txbFileDirectory.Text = "C:\\Users\\BairesDev NLV\\Documents\\TTPal History";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(271, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFolderDirectory
            // 
            this.lblFolderDirectory.AutoSize = true;
            this.lblFolderDirectory.Enabled = false;
            this.lblFolderDirectory.Location = new System.Drawing.Point(22, 19);
            this.lblFolderDirectory.Name = "lblFolderDirectory";
            this.lblFolderDirectory.Size = new System.Drawing.Size(118, 15);
            this.lblFolderDirectory.TabIndex = 2;
            this.lblFolderDirectory.Text = "Save Folder Directory";
            // 
            // nudSaveTime
            // 
            this.nudSaveTime.Enabled = false;
            this.nudSaveTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSaveTime.Location = new System.Drawing.Point(22, 76);
            this.nudSaveTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSaveTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSaveTime.Name = "nudSaveTime";
            this.nudSaveTime.Size = new System.Drawing.Size(120, 23);
            this.nudSaveTime.TabIndex = 4;
            this.nudSaveTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblSaveTime
            // 
            this.lblSaveTime.AutoSize = true;
            this.lblSaveTime.Enabled = false;
            this.lblSaveTime.Location = new System.Drawing.Point(165, 84);
            this.lblSaveTime.Name = "lblSaveTime";
            this.lblSaveTime.Size = new System.Drawing.Size(181, 15);
            this.lblSaveTime.TabIndex = 5;
            this.lblSaveTime.Text = "Minutes between save procedure";
            // 
            // lblSettingsLine
            // 
            this.lblSettingsLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSettingsLine.Location = new System.Drawing.Point(12, 111);
            this.lblSettingsLine.Name = "lblSettingsLine";
            this.lblSettingsLine.Size = new System.Drawing.Size(352, 2);
            this.lblSettingsLine.TabIndex = 6;
            // 
            // lblReminderOps
            // 
            this.lblReminderOps.AutoSize = true;
            this.lblReminderOps.Location = new System.Drawing.Point(22, 142);
            this.lblReminderOps.Name = "lblReminderOps";
            this.lblReminderOps.Size = new System.Drawing.Size(106, 15);
            this.lblReminderOps.TabIndex = 7;
            this.lblReminderOps.Text = "Reminder Options:";
            // 
            // nudReminderTime
            // 
            this.nudReminderTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudReminderTime.Location = new System.Drawing.Point(22, 172);
            this.nudReminderTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudReminderTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReminderTime.Name = "nudReminderTime";
            this.nudReminderTime.Size = new System.Drawing.Size(120, 23);
            this.nudReminderTime.TabIndex = 8;
            this.nudReminderTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblReminderTime
            // 
            this.lblReminderTime.AutoSize = true;
            this.lblReminderTime.Location = new System.Drawing.Point(157, 180);
            this.lblReminderTime.Name = "lblReminderTime";
            this.lblReminderTime.Size = new System.Drawing.Size(189, 15);
            this.lblReminderTime.TabIndex = 9;
            this.lblReminderTime.Text = "Mins between reminder procedure";
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(22, 302);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 10;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 2);
            this.label1.TabIndex = 11;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Location = new System.Drawing.Point(271, 302);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsSave.TabIndex = 12;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // chkbSaveActive
            // 
            this.chkbSaveActive.AutoSize = true;
            this.chkbSaveActive.Location = new System.Drawing.Point(331, 17);
            this.chkbSaveActive.Name = "chkbSaveActive";
            this.chkbSaveActive.Size = new System.Drawing.Size(15, 14);
            this.chkbSaveActive.TabIndex = 13;
            this.chkbSaveActive.UseVisualStyleBackColor = true;
            this.chkbSaveActive.CheckedChanged += new System.EventHandler(this.chkbSaveActive_CheckedChanged);
            // 
            // chkbReminderActive
            // 
            this.chkbReminderActive.AutoSize = true;
            this.chkbReminderActive.Checked = true;
            this.chkbReminderActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbReminderActive.Location = new System.Drawing.Point(331, 126);
            this.chkbReminderActive.Name = "chkbReminderActive";
            this.chkbReminderActive.Size = new System.Drawing.Size(15, 14);
            this.chkbReminderActive.TabIndex = 14;
            this.chkbReminderActive.UseVisualStyleBackColor = true;
            this.chkbReminderActive.CheckedChanged += new System.EventHandler(this.chkbReminderActive_CheckedChanged);
            // 
            // rdbSettingsFlash
            // 
            this.rdbSettingsFlash.AutoSize = true;
            this.rdbSettingsFlash.Location = new System.Drawing.Point(250, 140);
            this.rdbSettingsFlash.Name = "rdbSettingsFlash";
            this.rdbSettingsFlash.Size = new System.Drawing.Size(52, 19);
            this.rdbSettingsFlash.TabIndex = 15;
            this.rdbSettingsFlash.Text = "Flash";
            this.rdbSettingsFlash.UseVisualStyleBackColor = true;
            // 
            // rdbMessenger
            // 
            this.rdbMessenger.AutoSize = true;
            this.rdbMessenger.Checked = true;
            this.rdbMessenger.Location = new System.Drawing.Point(148, 140);
            this.rdbMessenger.Name = "rdbMessenger";
            this.rdbMessenger.Size = new System.Drawing.Size(82, 19);
            this.rdbMessenger.TabIndex = 16;
            this.rdbMessenger.TabStop = true;
            this.rdbMessenger.Text = "Messenger";
            this.rdbMessenger.UseVisualStyleBackColor = true;
            // 
            // jiraTitleSettingsLabel
            // 
            this.jiraTitleSettingsLabel.AutoSize = true;
            this.jiraTitleSettingsLabel.Enabled = false;
            this.jiraTitleSettingsLabel.Location = new System.Drawing.Point(22, 220);
            this.jiraTitleSettingsLabel.Name = "jiraTitleSettingsLabel";
            this.jiraTitleSettingsLabel.Size = new System.Drawing.Size(174, 15);
            this.jiraTitleSettingsLabel.TabIndex = 17;
            this.jiraTitleSettingsLabel.Text = "Load issues to Jira when closing";
            // 
            // JiraSettingsCheckBox
            // 
            this.JiraSettingsCheckBox.AutoSize = true;
            this.JiraSettingsCheckBox.Location = new System.Drawing.Point(331, 220);
            this.JiraSettingsCheckBox.Name = "JiraSettingsCheckBox";
            this.JiraSettingsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.JiraSettingsCheckBox.TabIndex = 18;
            this.JiraSettingsCheckBox.UseVisualStyleBackColor = true;
            this.JiraSettingsCheckBox.CheckedChanged += new System.EventHandler(this.JiraSettingsCheckBox_CheckedChanged);
            // 
            // jiraUsernameTextBox
            // 
            this.jiraUsernameTextBox.Enabled = false;
            this.jiraUsernameTextBox.Location = new System.Drawing.Point(96, 242);
            this.jiraUsernameTextBox.Name = "jiraUsernameTextBox";
            this.jiraUsernameTextBox.Size = new System.Drawing.Size(100, 23);
            this.jiraUsernameTextBox.TabIndex = 19;
            // 
            // jiraUsernameLabel
            // 
            this.jiraUsernameLabel.AutoSize = true;
            this.jiraUsernameLabel.Enabled = false;
            this.jiraUsernameLabel.Location = new System.Drawing.Point(22, 245);
            this.jiraUsernameLabel.Name = "jiraUsernameLabel";
            this.jiraUsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.jiraUsernameLabel.TabIndex = 20;
            this.jiraUsernameLabel.Text = "Username:";
            // 
            // tokenJiraLabel
            // 
            this.tokenJiraLabel.AutoSize = true;
            this.tokenJiraLabel.Enabled = false;
            this.tokenJiraLabel.Location = new System.Drawing.Point(26, 274);
            this.tokenJiraLabel.Name = "tokenJiraLabel";
            this.tokenJiraLabel.Size = new System.Drawing.Size(61, 15);
            this.tokenJiraLabel.TabIndex = 22;
            this.tokenJiraLabel.Text = "Jira Token:";
            // 
            // jiraTokenTextBox
            // 
            this.jiraTokenTextBox.Enabled = false;
            this.jiraTokenTextBox.Location = new System.Drawing.Point(96, 271);
            this.jiraTokenTextBox.Name = "jiraTokenTextBox";
            this.jiraTokenTextBox.Size = new System.Drawing.Size(206, 23);
            this.jiraTokenTextBox.TabIndex = 21;
            // 
            // saveToPCJiraSettingsCheckBox
            // 
            this.saveToPCJiraSettingsCheckBox.AutoSize = true;
            this.saveToPCJiraSettingsCheckBox.Checked = true;
            this.saveToPCJiraSettingsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToPCJiraSettingsCheckBox.Enabled = false;
            this.saveToPCJiraSettingsCheckBox.Location = new System.Drawing.Point(202, 244);
            this.saveToPCJiraSettingsCheckBox.Name = "saveToPCJiraSettingsCheckBox";
            this.saveToPCJiraSettingsCheckBox.Size = new System.Drawing.Size(104, 19);
            this.saveToPCJiraSettingsCheckBox.TabIndex = 23;
            this.saveToPCJiraSettingsCheckBox.Text = "Save to this PC";
            this.saveToPCJiraSettingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 332);
            this.Controls.Add(this.saveToPCJiraSettingsCheckBox);
            this.Controls.Add(this.tokenJiraLabel);
            this.Controls.Add(this.jiraTokenTextBox);
            this.Controls.Add(this.jiraUsernameLabel);
            this.Controls.Add(this.jiraUsernameTextBox);
            this.Controls.Add(this.JiraSettingsCheckBox);
            this.Controls.Add(this.jiraTitleSettingsLabel);
            this.Controls.Add(this.rdbMessenger);
            this.Controls.Add(this.rdbSettingsFlash);
            this.Controls.Add(this.chkbReminderActive);
            this.Controls.Add(this.chkbSaveActive);
            this.Controls.Add(this.btnSettingsSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.lblReminderTime);
            this.Controls.Add(this.nudReminderTime);
            this.Controls.Add(this.lblReminderOps);
            this.Controls.Add(this.lblSettingsLine);
            this.Controls.Add(this.lblSaveTime);
            this.Controls.Add(this.nudSaveTime);
            this.Controls.Add(this.lblFolderDirectory);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txbFileDirectory);
            this.MaximumSize = new System.Drawing.Size(392, 390);
            this.MinimumSize = new System.Drawing.Size(392, 310);
            this.Name = "formSettings";
            this.Text = "TT Pal Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudSaveTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFileDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFolderDirectory;
        private System.Windows.Forms.NumericUpDown nudSaveTime;
        private System.Windows.Forms.Label lblSaveTime;
        private System.Windows.Forms.Label lblSettingsLine;
        private System.Windows.Forms.Label lblReminderOps;
        private System.Windows.Forms.NumericUpDown nudReminderTime;
        private System.Windows.Forms.Label lblReminderTime;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.CheckBox chkbSaveActive;
        private System.Windows.Forms.CheckBox chkbReminderActive;
        private System.Windows.Forms.RadioButton rdbSettingsFlash;
        private System.Windows.Forms.RadioButton rdbMessenger;
        private System.Windows.Forms.Label jiraTitleSettingsLabel;
        private System.Windows.Forms.CheckBox JiraSettingsCheckBox;
        private System.Windows.Forms.TextBox jiraUsernameTextBox;
        private System.Windows.Forms.Label jiraUsernameLabel;
        private System.Windows.Forms.Label tokenJiraLabel;
        private System.Windows.Forms.TextBox jiraTokenTextBox;
        private System.Windows.Forms.CheckBox saveToPCJiraSettingsCheckBox;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeTrackerFriend
{
    public partial class formSettings : Form
    {
        private readonly frmMainWindow _mainForm;

        public formSettings(frmMainWindow mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            txbFileDirectory.Text = _mainForm._saveDirectory;
            ShowInTaskbar = false;
            txbFileDirectory.Text = _mainForm._saveDirectory;
            nudSaveTime.Value = _mainForm._saveTime;
            nudReminderTime.Value = _mainForm._reminderTime;
            if (_mainForm._reminderOption != ReminderOptions.Messenger.ToString())
                rdbSettingsFlash.Checked = true;
            if (_mainForm._saveActivated)
                chkbSaveActive.Checked = true;
            if (_mainForm._reminderActivated)
                chkbReminderActive.Checked = true;
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(txbFileDirectory.Text) || !chkbSaveActive.Checked)
            {
                _mainForm._saveActivated = chkbSaveActive.Checked;
                _mainForm._reminderActivated = chkbReminderActive.Checked;
                _mainForm._saveTime = (int)nudSaveTime.Value;
                _mainForm._reminderTime = (int)nudReminderTime.Value;
                if (rdbSettingsFlash.Checked)
                    _mainForm._reminderOption = rdbSettingsFlash.Text;
                else
                    _mainForm._reminderOption = rdbMessenger.Text;
                _mainForm._saveDirectory = txbFileDirectory.Text;
                Close();
            }
            else
                MessageBox.Show("Invalid directory, use another one or deactivate the save option.");

            if(this.JiraSettingsCheckBox.Checked == true) //TO BE IMPLEMENTED
            {
                try
                {
                    var jiraConnection = new JiraApiService(this.jiraUsernameTextBox.Text, this.jiraTokenTextBox.Text);
                    jiraConnection.ValidateCredentials();
                }
                catch
                {
                    string errorMessage = "Couldnt stablish a connection to Jira API with the credentials provided";
                    MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
        }

        private void chkbSaveActive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbSaveActive.Checked)
            {
                btnBrowse.Enabled = true;
                txbFileDirectory.Enabled = true;
                nudSaveTime.Enabled = true;
                lblSaveTime.Enabled = true;
                lblFolderDirectory.Enabled = true;
            }
            else
            {
                btnBrowse.Enabled = false;
                txbFileDirectory.Enabled = false;
                nudSaveTime.Enabled = false;
                lblSaveTime.Enabled = false;
                lblFolderDirectory.Enabled = false;
            }
        }

        private void chkbReminderActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbReminderActive.Checked)
            {
                rdbMessenger.Enabled = true;
                rdbSettingsFlash.Enabled = true;
                nudReminderTime.Enabled = true;
                lblReminderOps.Enabled = true;
                lblReminderTime.Enabled = true;
            }
            else
            {
                rdbMessenger.Enabled = false;
                rdbSettingsFlash.Enabled = false;
                nudReminderTime.Enabled = false;
                lblReminderOps.Enabled = false;
                lblReminderTime.Enabled = false;
            }
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close?";
            string caption = "Changes will not be saved";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            fBD.ShowDialog();
            txbFileDirectory.Text = fBD.SelectedPath;
        }
    }
}

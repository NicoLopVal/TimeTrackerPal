using System;
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
        frmMainWindow firstForm;

        public formSettings(frmMainWindow first)
        {
            InitializeComponent();
            firstForm = first;
            txbFileDirectory.Text = firstForm.saveDirectory;
            ShowInTaskbar = false;
            txbFileDirectory.Text = firstForm.saveDirectory;
            nudSaveTime.Value = firstForm.saveTime;
            nudReminderTime.Value = firstForm.reminderTime;
            if (firstForm.reminderOption != "Messenger")
                rdbSettingsFlash.Checked = true;
            if (firstForm.saveActivated)
                chkbSaveActive.Checked = true;
            if (firstForm.reminderActivated)
                chkbReminderActive.Checked = true;
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(txbFileDirectory.Text) || !firstForm.saveActivated)
            {
                firstForm.saveActivated = chkbSaveActive.Checked;
                firstForm.reminderActivated = chkbReminderActive.Checked;
                firstForm.saveTime = (int)nudSaveTime.Value;
                firstForm.reminderTime = (int)nudReminderTime.Value;
                if (rdbSettingsFlash.Checked)
                    firstForm.reminderOption = rdbSettingsFlash.Text;
                else
                    firstForm.reminderOption = rdbMessenger.Text;
                firstForm.saveDirectory = txbFileDirectory.Text;
                Close();
            }
            else
                MessageBox.Show("Invalid directory, use another one or deactivate the save option.");
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
                //rdbSettingsFlash.Enabled = true;
                nudReminderTime.Enabled = true;
                lblReminderOps.Enabled = true;
                lblReminderTime.Enabled = true;
            }
            else
            {
                rdbMessenger.Enabled = false;
                //rdbSettingsFlash.Enabled = false;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace TimeTrackerFriend
{
    internal class EventHandlersService
    {
        private static frmMainWindow _mainForm;
        private formSettings _formsettings;

        public EventHandlersService(frmMainWindow mainForm)
        {
            _mainForm = mainForm;
        }

        public void btnStart_Click(object sender, EventArgs e)
        {

            GetTimerByName("mainTimer").Start();
            _mainForm.TotalTimer.Enabled = true;
            foreach (var radioButton in _mainForm.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    int index = int.Parse(SharedFunctions.RemoveNonNumericCharacters(radioButton.Name));
                    var currentNamedTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "TaskTimer" + index);
                    currentNamedTimer.Start();
                }

            }
            _mainForm.lblPaused.Visible = false;
            _mainForm._running = true;
        }

        public void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            int index = int.Parse(SharedFunctions.RemoveNonNumericCharacters(((RadioButton)sender).Name));
            var currentTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "TaskTimer" + index);
            if (_mainForm._running && _mainForm.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Name.Contains(index.ToString())).Checked)
            {
                currentTimer.Start();
            }
            else if (_mainForm._running && !_mainForm.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Name.Contains(index.ToString())).Checked)
            {
                currentTimer.Stop();
            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            foreach (NamedTimer NamedTimer in _mainForm._timers)
            {
                NamedTimer.Stop();
            }
            _mainForm.lblPaused.Visible = true;
            _mainForm._running = false;
        }

        public void btnReset_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to reset all the timer?";
            string caption = "Reset will errase all progress!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
                return;
            foreach (NamedTimer NamedTimer in _mainForm._timers)
            {
                NamedTimer.Reset();
            }
            foreach (var timeLabel in _mainForm.Controls.OfType<Label>().Where(lb => lb.Name.Contains("timerTaskLabel")))
            {
                timeLabel.Text = "00:00:00";
            }
            _mainForm._running = false;
            _mainForm.lblPaused.Visible = true;

        }

        public void TotalTimer_Tick(object sender, EventArgs e)
        {
            var mainTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "mainTimer");
            mainTimer.Tick();

            _mainForm.timerTaskLabelMain.Text = mainTimer.GetFormattedElapsed();

            foreach (var radioButton in _mainForm.Controls.OfType<RadioButton>().Where(rb => rb.Name.Contains("recordRadioButton")))
            {
                string index = SharedFunctions.RemoveNonNumericCharacters(radioButton.Name);
                if (radioButton.Checked)
                {
                    var currentNamedTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "TaskTimer" + index);
                    currentNamedTimer.Tick();
                    string timerTaskLabelName = "timerTaskLabel" + index;
                    _mainForm.Controls.OfType<Label>().FirstOrDefault(l => l.Name.Equals(timerTaskLabelName)).Text = currentNamedTimer.GetFormattedElapsed();
                }
            }


            if (_mainForm._reminderActivated && _mainForm._reminderOption == ReminderOptions.Messenger.ToString())
                _mainForm.ShowReminderWindow(mainTimer);
            if (_mainForm._reminderActivated && _mainForm._reminderOption == ReminderOptions.Flash.ToString())
                _mainForm.ShowFlashReminder(mainTimer);
            if (_mainForm._saveActivated)
            {
                if (mainTimer.Minutes() % _mainForm._saveTime == 0 && mainTimer.Minutes() > 0 && mainTimer.Seconds() >= 0 && mainTimer.Seconds() <= 3 && !_mainForm._savedConfirmed)
                    _mainForm.SaveProcess();
                if (mainTimer.Minutes() % _mainForm._saveTime == 0 && mainTimer.Seconds() >= 57 && _mainForm._savedConfirmed)
                    _mainForm._savedConfirmed = false;
            }

        }

        public void btnAddRow_Click(object sender, EventArgs e)
        {
            int newIndex = _mainForm.Controls.OfType<RadioButton>().Where(rb => rb.Name.Contains("recordRadioButton")).Count();
            _mainForm.btnDeleteRow.Visible = true;
            SharedFunctions.CreateTaskControllers(_mainForm,this,newIndex);
            _mainForm.btnAddRow.Top += Constants.recordControlHeight;
            _mainForm.btnDeleteRow.Top += Constants.recordControlHeight;
            _mainForm.btnReset.Top += Constants.recordControlHeight;
            _mainForm.btnStart.Top += Constants.recordControlHeight;
            _mainForm.btnStop.Top += Constants.recordControlHeight;
            _mainForm.Height += Constants.recordControlHeight;

        }

        public void btnDeleteRow_Click(object sender, EventArgs e)
        {
            int indexToRemove = _mainForm.Controls.OfType<RadioButton>().Where(rb => rb.Name.Contains("recordRadioButton")).Count() - 1;

            if (_mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name == "timerTaskLabel" + indexToRemove).Text != "00:00:00" ||
               !string.IsNullOrEmpty(_mainForm.Controls.OfType<TextBox>().FirstOrDefault(lb => lb.Name == "descriptionTaskTextBox" + indexToRemove).Text) ||
               !string.IsNullOrEmpty(_mainForm.Controls.OfType<TextBox>().FirstOrDefault(lb => lb.Name == "commentsTaskTextBox" + indexToRemove).Text))
            {
                string message = "Information in _mainForm record will be lost forever, do you wish to continue?";
                string caption = "Potential information loss!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                    return;
            }

            SharedFunctions.RemoveTaskControlsByIndex(_mainForm, indexToRemove);
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            _formsettings = new formSettings(_mainForm);
            _formsettings.Location = new Point(200, 200);
            _formsettings.ShowDialog();
        }

        public void btnCloseProgram_Click(object sender, EventArgs e)
        {
            _mainForm._formbackground = new formBackground(_mainForm);
            _mainForm.Location = new Point(SystemInformation.VirtualScreen.Width, -105);
            _mainForm._formbackground.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _mainForm._formbackground.ControlBox = false;
            _mainForm._formbackground.BackColor = Color.LimeGreen;
            _mainForm._formbackground.TransparencyKey = Color.LimeGreen;
            _mainForm._formbackground.Location = new Point(_mainForm.reminderVerticalPos, -105);
            _mainForm._formbackground.FormBorderStyle = FormBorderStyle.FixedSingle;
            _mainForm._formbackground.ChangeActiveTask(GetOngoingTaskDescription());
            _mainForm._formbackground.Show();
            _mainForm.hideActivated = true;
        }

        public void lblHoverColorChanger(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Cyan;
        }

        public void lblHoverLeaveColorChanger(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        public void lblModifyTimeEvent(object sender, EventArgs e)
        {
            int radioButtonCount = _mainForm.Controls.OfType<RadioButton>().Count(r => r.Visible);
            var selectedLabel = (Label)sender;
            var timeChangerBox = new GroupBox();
            timeChangerBox.Name = "timeChangerBox" + SharedFunctions.RemoveNonNumericCharacters(selectedLabel.Name);
            timeChangerBox.Size = new Size(180, 40);
            timeChangerBox.Location = selectedLabel.Location;

            var timeMaskedTxtBox = new MaskedTextBox();
            timeMaskedTxtBox.Mask = "00:00:00";
            timeMaskedTxtBox.Size = new Size(60, 23);
            timeMaskedTxtBox.Location = new Point(12, 12);
            timeMaskedTxtBox.PromptChar = '0';
            timeMaskedTxtBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            timeMaskedTxtBox.TextChanged += InputTextValidator;

            var recordSelectorComboBox = new ComboBox();
            recordSelectorComboBox.Size = new Size(42, 23);
            recordSelectorComboBox.Location = new Point(78, 12);
            foreach (int number in Enumerable.Range(0, radioButtonCount).ToArray())
            {
                if (number.ToString() != SharedFunctions.RemoveNonNumericCharacters(selectedLabel.Name))
                    recordSelectorComboBox.Items.Add(number.ToString());
            }
            recordSelectorComboBox.SelectedItem = "1";

            var myButton = new Button();
            myButton.Text = "Ok";
            myButton.Size = new Size(39, 23);
            myButton.Location = new Point(126, 12);
            myButton.Click += TimeModifierOkButton_Click;

            var parentIndexLabel = new Label();
            parentIndexLabel.Name = "ParentLabel";
            parentIndexLabel.Text = selectedLabel.Name;
            parentIndexLabel.Visible = false;

            timeChangerBox.Visible = true;

            timeChangerBox.Controls.Add(myButton);
            timeChangerBox.Controls.Add(timeMaskedTxtBox);
            timeChangerBox.Controls.Add(recordSelectorComboBox);

            _mainForm.Controls.Add(timeChangerBox);

            timeChangerBox.BringToFront();
        }

        public static void TimeModifierOkButton_Click(object sender, EventArgs e)
        {
            GroupBox timeChangerBox = (GroupBox)((Button)sender).Parent;
            long minutes;
            long seconds;
            long hours;
            var selectedTime = timeChangerBox.Controls.OfType<MaskedTextBox>().FirstOrDefault().Text;
            long.TryParse(selectedTime.Split(':')[0], out hours);
            long.TryParse(selectedTime.Split(':')[1], out minutes);
            long.TryParse(selectedTime.Split(':')[2], out seconds);
            var fromIndex = SharedFunctions.RemoveNonNumericCharacters(timeChangerBox.Name);
            var toIndex = timeChangerBox.Controls.OfType<ComboBox>().FirstOrDefault().Text;

            var fromTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "TaskTimer" + fromIndex);
            var toTimer = (NamedTimer)_mainForm._timers.Find(sw => ((NamedTimer)sw).Name == "TaskTimer" + toIndex);

            fromTimer.AddSeconds((hours * 3600 + minutes * 60 + seconds) * -1);
            toTimer.AddSeconds((hours * 3600 + minutes * 60 + seconds));

            _mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name == "timerTaskLabel" + fromIndex).Text = fromTimer.GetFormattedElapsed();
            _mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name == "timerTaskLabel" + toIndex).Text = toTimer.GetFormattedElapsed();

            _mainForm.Controls.Remove(timeChangerBox);
        }

        private static void InputTextValidator(object sender, EventArgs e)
        {
            var selectedTime = ((MaskedTextBox)sender).Text;
            var hours = int.Parse(selectedTime.Split(':')[0]);
            var minutes = int.Parse(selectedTime.Split(':')[1]) > 59 ? "59" : selectedTime.Split(':')[1];
            var seconds = int.Parse(selectedTime.Split(':')[2]) > 59 ? "59" : selectedTime.Split(':')[2];
            var totalSecondsToMove = (hours * 3600) + (int.Parse(minutes) * 60) + int.Parse(seconds);

            var currentIndex = SharedFunctions.RemoveNonNumericCharacters(_mainForm.Controls.OfType<RadioButton>().FirstOrDefault(cb => cb.Checked == true).Name);
            var currentElapsed = _mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name.Equals("timerTaskLabel" + currentIndex)).Text.Split(':');
            var totalSecondsElapsed = (int.Parse(currentElapsed[0]) * 3600) + (int.Parse(currentElapsed[1]) * 60) + int.Parse(currentElapsed[2]);

            if (totalSecondsToMove > totalSecondsElapsed)
                totalSecondsToMove = totalSecondsElapsed;


            ((MaskedTextBox)sender).Text = SharedFunctions.FormatSecondsForLabel(totalSecondsToMove);
        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            if (SharedFunctions.HasElapsedTime(_mainForm))
            {
                string message = "Loading a file will erase all elapsed time and activities, are you sure you want to continue?";
                string caption = "Loading a file will errase all progress!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                    return;
            }

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.ShowDialog();
            var path = openFileDialog.FileName;

            SharedFunctions.LoadFile(_mainForm,this, path);
        }

        private static NamedTimer GetTimerByName(string reference)
        {
            return (NamedTimer)_mainForm._timers.Find(t => ((NamedTimer)t).Name == reference);
        }
        private static string GetOngoingTaskDescription()
        {
            int activeTaskIndex = int.Parse(SharedFunctions.RemoveNonNumericCharacters(_mainForm.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked == true).Name));

            return _mainForm.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name.Equals("descriptionTaskTextBox" + activeTaskIndex)).Text;
        }
    }
}

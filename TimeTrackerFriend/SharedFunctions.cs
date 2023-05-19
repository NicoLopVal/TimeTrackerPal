using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TimeTrackerFriend
{
    internal class SharedFunctions
    {

        public static string RemoveNonNumericCharacters(string input)
        {
            string pattern = "[^0-9]";
            return Regex.Replace(input, pattern, "");
        }

        public static void CreateTaskControllers(frmMainWindow mainForm, EventHandlersService eventHandlersService, int numberReference)
        {
            var TaskTimer = new NamedTimer("TaskTimer" + numberReference.ToString());
            mainForm._timers.Add(TaskTimer);

            var taskNumberLabel = new Label();
            taskNumberLabel.Name = "taskNumberLabel" + numberReference.ToString();
            taskNumberLabel.Location = new Point(Constants.labelNumberBasePointX, Constants.labelNumberBasePointY + (numberReference * Constants.recordControlHeight));
            taskNumberLabel.Text = numberReference.ToString();
            taskNumberLabel.Size = new Size(19, 23);
            taskNumberLabel.Font = new Font("Arial", 7);
            taskNumberLabel.TextAlign = ContentAlignment.MiddleRight;

            var recordRadioButton = new RadioButton();
            recordRadioButton.Size = new Size(14, 13);
            recordRadioButton.Name = "recordRadioButton" + numberReference.ToString();
            recordRadioButton.Location = new Point(Constants.radioButtonBasePointX, Constants.radioButtonBasePointY + (numberReference * Constants.recordControlHeight));
            recordRadioButton.CheckedChanged += new EventHandler(eventHandlersService.radioButtons_CheckedChanged);

            var timerTaskLabel = new Label();
            timerTaskLabel.Font = new Font("Arial", 12);
            timerTaskLabel.Name = "timerTaskLabel" + numberReference.ToString();
            timerTaskLabel.Text = "00:00:00";
            timerTaskLabel.Size = new Size(70, 23);
            timerTaskLabel.Location = new Point(Constants.timerTaskLabelBasePointX, Constants.timerTaskLabelBasePointY + (numberReference * Constants.recordControlHeight));
            timerTaskLabel.Enter += new EventHandler(eventHandlersService.lblHoverColorChanger);
            timerTaskLabel.Leave += new EventHandler(eventHandlersService.lblHoverLeaveColorChanger);
            timerTaskLabel.DoubleClick += new EventHandler(eventHandlersService.lblModifyTimeEvent);

            var descriptionTaskTextBox = new TextBox();
            descriptionTaskTextBox.Size = new Size(201, 23);
            descriptionTaskTextBox.Location = new Point(Constants.descriptionTextBoxBasePointX, Constants.descriptionTextBoxBasePointY + (numberReference * Constants.recordControlHeight));
            descriptionTaskTextBox.Name = "descriptionTaskTextBox" + numberReference.ToString();

            var commentsTaskTextBox = new TextBox();
            commentsTaskTextBox.Size = new Size(314, 23);
            commentsTaskTextBox.Location = new Point(Constants.commentsTextBoxBasePointX, Constants.commentsTextBoxBasePointY + (numberReference * Constants.recordControlHeight));
            commentsTaskTextBox.Name = "commentsTaskTextBox" + numberReference.ToString();


            if (numberReference == 0)
            {
                recordRadioButton.Checked = true;
                descriptionTaskTextBox.Text = "Email/Jira/Slack/TT/Jenkins";
            }
            else
            {
                recordRadioButton.Checked = false;
            }

            mainForm.Controls.Add(taskNumberLabel);
            mainForm.Controls.Add(recordRadioButton);
            mainForm.Controls.Add(descriptionTaskTextBox);
            mainForm.Controls.Add(commentsTaskTextBox);
            mainForm.Controls.Add(timerTaskLabel);
        }

        public static void RemoveTaskControlsByIndex(frmMainWindow mainForm, int index)
        {
            RadioButton radioButtonToRemove = mainForm.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Name.Equals("recordRadioButton" + index));
            if (radioButtonToRemove != null)
                mainForm.Controls.Remove(radioButtonToRemove);

            Label numberLabelToRemove = mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name.Equals("taskNumberLabel" + index));
            if (numberLabelToRemove != null)
                mainForm.Controls.Remove(numberLabelToRemove);

            Label labelToRemove = mainForm.Controls.OfType<Label>().FirstOrDefault(rb => rb.Name.Equals("timerTaskLabel" + index));
            if (labelToRemove != null)
                mainForm.Controls.Remove(labelToRemove);

            TextBox descriptionToRemove = mainForm.Controls.OfType<TextBox>().FirstOrDefault(rb => rb.Name.Equals("descriptionTaskTextBox" + index));
            if (descriptionToRemove != null)
                mainForm.Controls.Remove(descriptionToRemove);

            TextBox commentToRemove = mainForm.Controls.OfType<TextBox>().FirstOrDefault(rb => rb.Name.Equals("commentsTaskTextBox" + index));
            if (commentToRemove != null)
                mainForm.Controls.Remove(commentToRemove);

            if (Constants.initialSlots >= index)
                mainForm.btnDeleteRow.Visible = false;

            mainForm.btnAddRow.Top -= Constants.recordControlHeight;
            mainForm.btnReset.Top -= Constants.recordControlHeight;
            mainForm.btnStart.Top -= Constants.recordControlHeight;
            mainForm.btnStop.Top -= Constants.recordControlHeight;
            mainForm.btnDeleteRow.Top -= Constants.recordControlHeight;
            mainForm.Height -= Constants.recordControlHeight;
        }

        public static void LoadFile(frmMainWindow mainForm, EventHandlersService eventHandlersService, string path)
        {

            var mainTimer = (NamedTimer)mainForm._timers.FirstOrDefault(t => ((NamedTimer)t).Name.Equals("mainTimer"));
            mainTimer.Reset();

            for (int i = 0; i < mainForm._timers.Count() ; i++){
                RemoveTaskControlsByIndex(mainForm, i);
            }

            using (var reader = new StreamReader(path))
            {
                string line;
                var currentIndex = 0;
                var totalSeconds = 0;
                try
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == $"Elapsed Time\tTask Name\tComments")
                            continue;

                        var lineContent = line.Split('\t');
                        var currentElapsed = lineContent[0].Split(':');
                        var elapsedSeconds = int.Parse(currentElapsed[0]) * 3600 + int.Parse(currentElapsed[1]) * 60 + int.Parse(currentElapsed[2]);
                        totalSeconds += elapsedSeconds;


                        CreateTaskControllers(mainForm, eventHandlersService, currentIndex);

                        ((NamedTimer)mainForm._timers.FirstOrDefault(t => ((NamedTimer)t).Name.Equals("TaskTimer" + currentIndex))).AddSeconds(elapsedSeconds);
                        mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name.Equals("timerTaskLabel" + currentIndex)).Text = lineContent[0];
                        mainForm.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name.Equals("descriptionTaskTextBox" + currentIndex)).Text = lineContent[1];
                        mainForm.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name.Equals("commentsTaskTextBox" + currentIndex)).Text = lineContent[2];
                        currentIndex++;
                    }
                ((NamedTimer)mainForm._timers.FirstOrDefault(t => ((NamedTimer)t).Name.Equals("mainTimer"))).AddSeconds(totalSeconds);
                    mainForm.timerTaskLabelMain.Text = mainTimer.GetFormattedElapsed();
                    RelocateManageTimeButtons(mainForm, currentIndex);
                    mainForm.Height = Constants.mainHeightBasePointY + Constants.recordControlHeight * currentIndex;
                }
                catch
                {
                    mainForm.CreateControls();
                    MessageBox.Show("The file doesn't match the format or is corrupted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        public static bool HasElapsedTime(frmMainWindow mainForm) => mainForm.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name.Equals("timerTaskLabelMain")).Text == "00:00:00" ? true : false;

        private static void RelocateManageTimeButtons(frmMainWindow mainForm, int totalTasks)
        {
            mainForm.btnStart.Location = new Point(Constants.startButtonBasePointX, Constants.startButtonBasePointY + Constants.recordControlHeight * totalTasks);
            mainForm.btnReset.Location = new Point(Constants.resetButtonBasePointX, Constants.resetButtonBasePointY + Constants.recordControlHeight * totalTasks);
            mainForm.btnStop.Location = new Point(Constants.stopButtonBasePointX, Constants.stopButtonBasePointY + Constants.recordControlHeight * totalTasks);
            mainForm.btnAddRow.Location = new Point(Constants.addButtonBasePointX, Constants.addButtonBasePointY + Constants.recordControlHeight * totalTasks);
            mainForm.btnDeleteRow.Location = new Point(Constants.deleteButtonBasePointX, Constants.deleteButtonBasePointY + Constants.recordControlHeight * totalTasks);
        }

        public static string FormatSecondsForLabel(int totalSeconds)
        {
            var hours = (int)Math.Floor((double)totalSeconds / 3600);
            var minutes = (int)Math.Floor(((double)totalSeconds - (hours * 3600)) / 60);
            var seconds = (int)(totalSeconds - (hours * 3600) - (minutes * 60));
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }

        public static bool HasJiraTaskCodeFormat(string input)
        {
            string pattern = @"^[a-zA-Z]+\-\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}

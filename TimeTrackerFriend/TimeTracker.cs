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
using System.Windows.Forms.Design;

namespace TimeTrackerFriend
{
    public partial class frmMainWindow : Form
    {
        formFlash formflash;
        public bool _running = false;
        public bool hideActivated = false;
        public bool _reminderActivated = false;
        public bool _saveActivated = false;
        public bool _savedConfirmed = false;
        public bool reminderInterrupted = false;
        public bool _flashCreated = false;
        public string _reminderOption = ReminderOptions.Messenger.ToString();
        public string currentTaskName;
        public string _saveDirectory = "C:\\Users\\BairesDev NLV\\TTPal History";
        public int reminderVerticalPos = 70;
        public int _reminderTime = 15;
        public int _saveTime = 15;
        public List<Object> _timers = new List<Object>();
        public formBackground _formbackground;
        private EventHandlersService _eventHandlersService;



        public frmMainWindow()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ShowInTaskbar = false;
            this.TopMost = true;
            TotalTimer.Interval = 1000;
            _eventHandlersService = new EventHandlersService(this);
            TotalTimer.Tick += _eventHandlersService.TotalTimer_Tick;
            btnStart.Click += _eventHandlersService.btnStart_Click;
            btnReset.Click += _eventHandlersService.btnReset_Click;
            btnStop.Click += _eventHandlersService.btnStop_Click;
            btnAddRow.Click += _eventHandlersService.btnAddRow_Click;
            btnDeleteRow.Click += _eventHandlersService.btnDeleteRow_Click;
            btnSettings.Click += _eventHandlersService.btnSettings_Click;
            btnCloseProgram.Click += _eventHandlersService.btnCloseProgram_Click;
            btnLoad.Click += _eventHandlersService.btnLoad_Click;
            CreateControls();
        }

        public void CreateControls()
        {
            var mainTimer = new NamedTimer("mainTimer");
            _timers.Add(mainTimer);

            for (int i = 0; i < Constants.initialSlots; i++)
            {
                SharedFunctions.CreateTaskControllers(this,_eventHandlersService,i);
            }

            this.btnReset.Location = new Point(Constants.resetButtonBasePointX, Constants.resetButtonBasePointY + Constants.initialSlots * Constants.recordControlHeight);
            this.btnStart.Location = new Point(Constants.startButtonBasePointX, Constants.startButtonBasePointY + Constants.initialSlots * Constants.recordControlHeight);
            this.btnStop.Location = new Point(Constants.stopButtonBasePointX, Constants.stopButtonBasePointY + Constants.initialSlots * Constants.recordControlHeight);
            this.btnAddRow.Location = new Point(Constants.addButtonBasePointX, Constants.addButtonBasePointY + Constants.initialSlots * Constants.recordControlHeight);
            this.btnDeleteRow.Location = new Point(Constants.deleteButtonBasePointX, Constants.deleteButtonBasePointY + Constants.initialSlots * Constants.recordControlHeight);
            this.Height = Constants.mainHeightBasePointY + Constants.initialSlots * Constants.recordControlHeight;
        }

        public void ShowReminderWindow(NamedTimer mainTimeStamp)
        {
            if (mainTimeStamp.Minutes() % _reminderTime == 0 && mainTimeStamp.Minutes() > 0 && mainTimeStamp.Seconds() >= 0 && mainTimeStamp.Seconds() <= 3 && hideActivated && !reminderInterrupted)
                _formbackground.WindowReminderOpen();
            if (mainTimeStamp.Minutes() % _reminderTime == 0 && mainTimeStamp.Minutes() > 0 && mainTimeStamp.Seconds() >= 18 && mainTimeStamp.Seconds() <= 21 && hideActivated && !reminderInterrupted)
                _formbackground.WindowReminderClose();
            if (mainTimeStamp.Minutes() % _reminderTime == 0 && mainTimeStamp.Seconds() >= 57 && reminderInterrupted)
                reminderInterrupted = false;
        }

        public void ShowFlashReminder(NamedTimer mainTimeStamp)
        {
            if (mainTimeStamp.Minutes() % _reminderTime == 0 && mainTimeStamp.Minutes() > 0 && mainTimeStamp.Seconds() >= 0 && mainTimeStamp.Seconds() <= 3 && hideActivated && !reminderInterrupted)
            {
                if (!_flashCreated)
                {
                    formflash = new formFlash();
                    formflash.Size = new Size(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y);
                    formflash.Location = new Point(0, 0);
                    formflash.Show();
                    _flashCreated = true;
                }
                else
                    formflash.FlashDisapear();
            }
            if (mainTimeStamp.Minutes() % _reminderTime == 0 && mainTimeStamp.Minutes() > 0 && mainTimeStamp.Seconds() >= 57 && hideActivated && _flashCreated)
            {
                _flashCreated = false;
            }
        }

        public void SaveProcess()
        {
            DateTime thisDay = DateTime.Today;
            string path = _saveDirectory + @"\TTPal_" + thisDay.Year.ToString() + "-" + thisDay.Month.ToString() + "-" + thisDay.Day.ToString() + ".txt";
            string fileBody = "Elapsed Time" + "\t" + "Task Name" + "\t" + "Comments" + "\n";
            int totalRecords = this.Controls.OfType<RadioButton>().Where(rb => rb.Name.Contains("recordRadioButton")).Count();
            for(int i = 0; i < totalRecords; i++)
            {
                fileBody +=
                this.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name.Equals("timerTaskLabel" + i)).Text + "\t" +
                this.Controls.OfType<TextBox>().FirstOrDefault(lb => lb.Name.Equals("descriptionTaskTextBox" + i)).Text + "\t" +
                this.Controls.OfType<TextBox>().FirstOrDefault(lb => lb.Name.Equals("commentsTaskTextBox" + i)).Text + "\n";
            }
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(fileBody);
            }
            _savedConfirmed = true;
        }

        private void frmMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            string message = "Are you sure you want to close?";
            string caption = "Changes will not be saved";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if(_saveActivated)
                    SaveProcess();
                Application.Exit();
            }
        }
    }
}

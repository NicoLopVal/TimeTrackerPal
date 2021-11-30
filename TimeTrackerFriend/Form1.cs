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

namespace TimeTrackerFriend
{
    public partial class frmMainWindow : Form
    {
        private formSettings formsettings;
        formBackground formbackground;
        private int visibleRows = 3;
        bool running = false;
        public bool hideActivated = false;
        public string currentTaskName;
        public bool reminderInterrupted = false;
        public int reminderVerticalPos = 70;
        public bool savedConfirmed = false;             // Variable to make sure save iteration is only made once
        public bool saveActivated = false;              //Variables from the settings Section
        public bool reminderActivated = false;          //                                  |
        public int saveTime = 15;                       //                                  |
        public int reminderTime = 15;                   //                                  |
        public string reminderOption = "Messenger";     //                                  |
        public string saveDirectory = "";               //Variables from the settings Section
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stpwTask1 = new Stopwatch();
        Stopwatch stpwTask2 = new Stopwatch();
        Stopwatch stpwTask3 = new Stopwatch();
        Stopwatch stpwTask4 = new Stopwatch();
        Stopwatch stpwTask5 = new Stopwatch();
        Stopwatch stpwTask6 = new Stopwatch();
        Stopwatch stpwTask7 = new Stopwatch();
        Stopwatch stpwTask8 = new Stopwatch();
        Stopwatch stpwTask9 = new Stopwatch();
        Stopwatch stpwTask10 = new Stopwatch();

        public frmMainWindow()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.TopMost = true;
            formbackground = new formBackground(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            stopWatch.Start();
            TotalTimer.Enabled = true;
            TotalTimer.Tick += new EventHandler(TotalTimer_Tick);
            rdbTask1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask5.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask6.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask7.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask8.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask9.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbTask10.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            if (rdbTask1.Checked == true)
                stpwTask1.Start();
            if (rdbTask2.Checked == true)
                stpwTask2.Start();
            if (rdbTask3.Checked == true)
                stpwTask3.Start();
            if (rdbTask4.Checked == true)
                stpwTask4.Start();
            if (rdbTask5.Checked == true)
                stpwTask5.Start();
            if (rdbTask6.Checked == true)
                stpwTask6.Start();
            if (rdbTask7.Checked == true)
                stpwTask7.Start();
            if (rdbTask8.Checked == true)
                stpwTask8.Start();
            if (rdbTask9.Checked == true)
                stpwTask9.Start();
            if (rdbTask10.Checked == true)
                stpwTask10.Start();
            lblPaused.Visible = false;
            running = true;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && running)
            {
                if (rb.Name == "rdbTask1")
                    stpwTask1.Start();
                if (rb.Name == "rdbTask2")
                    stpwTask2.Start();
                if (rb.Name == "rdbTask3")
                    stpwTask3.Start();
                if (rb.Name == "rdbTask4")
                    stpwTask4.Start();
                if (rb.Name == "rdbTask5")
                    stpwTask5.Start();
                if (rb.Name == "rdbTask6")
                    stpwTask6.Start();
                if (rb.Name == "rdbTask7")
                    stpwTask7.Start();
                if (rb.Name == "rdbTask8")
                    stpwTask8.Start();
                if (rb.Name == "rdbTask9")
                    stpwTask9.Start();
                if (rb.Name == "rdbTask10")
                    stpwTask10.Start();
            }
            if (!rb.Checked && running)
            {
                if (rb.Name == "rdbTask1")
                    stpwTask1.Stop();
                if (rb.Name == "rdbTask2")
                    stpwTask2.Stop();
                if (rb.Name == "rdbTask3")
                    stpwTask3.Stop();
                if (rb.Name == "rdbTask4")
                    stpwTask4.Stop();
                if (rb.Name == "rdbTask5")
                    stpwTask5.Stop();
                if (rb.Name == "rdbTask6")
                    stpwTask6.Stop();
                if (rb.Name == "rdbTask7")
                    stpwTask7.Stop();
                if (rb.Name == "rdbTask8")
                    stpwTask8.Stop();
                if (rb.Name == "rdbTask9")
                    stpwTask9.Stop();
                if (rb.Name == "rdbTask10")
                    stpwTask10.Stop();
            }



        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            stpwTask1.Stop();
            stpwTask2.Stop();
            stpwTask3.Stop();
            stpwTask4.Stop();
            stpwTask5.Stop();
            stpwTask6.Stop();
            stpwTask7.Stop();
            stpwTask8.Stop();
            stpwTask9.Stop();
            stpwTask10.Stop();
            lblPaused.Visible = true;
            running = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string message = "Are you sure you want to reset all the timer?";
                string caption = "Reset will errase all progress!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                    break;
                stopWatch.Reset();
                stpwTask1.Reset();
                stpwTask1.Reset();
                stpwTask2.Reset();
                stpwTask3.Reset();
                stpwTask4.Reset();
                stpwTask5.Reset();
                stpwTask6.Reset();
                stpwTask7.Reset();
                stpwTask8.Reset();
                stpwTask9.Reset();
                stpwTask10.Reset();
                lblTotalTimer.Text = "0:00:00";
                lblTimer1.Text = "0:00:00";
                lblTimer2.Text = "0:00:00";
                lblTimer3.Text = "0:00:00";
                lblTimer4.Text = "0:00:00";
                lblTimer5.Text = "0:00:00";
                lblTimer6.Text = "0:00:00";
                lblTimer7.Text = "0:00:00";
                lblTimer8.Text = "0:00:00";
                lblTimer9.Text = "0:00:00";
                lblTimer10.Text = "0:00:00";
                running = false;
                lblPaused.Visible = true;
                break;
            }
                        
        }

        private void TotalTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan myTs = new TimeSpan(0, 0, 0, 0, (int)stopWatch.Elapsed.TotalMilliseconds);
            string minuteAdd = "";
            string secondsAdd = "";
            if(myTs.Minutes.ToString().Length < 2)
                minuteAdd = "0";
            else
                minuteAdd = "";
            if (myTs.Seconds.ToString().Length < 2)
                secondsAdd = "0";
            else
                secondsAdd = "";
            this.lblTotalTimer.Text = myTs.Hours.ToString() + ":" 
                + minuteAdd + myTs.Minutes.ToString() + ":" 
                + secondsAdd + myTs.Seconds.ToString();

            if(rdbTask1.Checked == true)
            {
                TimeSpan tmsTask1 = new TimeSpan(0, 0, 0, 0, (int)stpwTask1.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask1.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask1.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer1.Text = tmsTask1.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask1.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask1.Seconds.ToString();
            }

            if (rdbTask2.Checked == true)
            {
                TimeSpan tmsTask2 = new TimeSpan(0, 0, 0, 0, (int)stpwTask2.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask2.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask2.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer2.Text = tmsTask2.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask2.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask2.Seconds.ToString();
            }

            if (rdbTask3.Checked == true)
            {
                TimeSpan tmsTask3 = new TimeSpan(0, 0, 0, 0, (int)stpwTask3.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask3.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask3.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer3.Text = tmsTask3.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask3.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask3.Seconds.ToString();
            }

            if (rdbTask4.Checked == true)
            {
                TimeSpan tmsTask4 = new TimeSpan(0, 0, 0, 0, (int)stpwTask4.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask4.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask4.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer4.Text = tmsTask4.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask4.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask4.Seconds.ToString();
            }

            if (rdbTask5.Checked == true)
            {
                TimeSpan tmsTask5 = new TimeSpan(0, 0, 0, 0, (int)stpwTask5.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask5.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask5.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer5.Text = tmsTask5.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask5.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask5.Seconds.ToString();
            }

            if (rdbTask6.Checked == true)
            {
                TimeSpan tmsTask6 = new TimeSpan(0, 0, 0, 0, (int)stpwTask6.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask6.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask6.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer6.Text = tmsTask6.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask6.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask6.Seconds.ToString();
            }

            if (rdbTask7.Checked == true)
            {
                TimeSpan tmsTask7 = new TimeSpan(0, 0, 0, 0, (int)stpwTask7.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask7.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask7.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer7.Text = tmsTask7.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask7.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask7.Seconds.ToString();
            }

            if (rdbTask8.Checked == true)
            {
                TimeSpan tmsTask8 = new TimeSpan(0, 0, 0, 0, (int)stpwTask8.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask8.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask8.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer8.Text = tmsTask8.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask8.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask8.Seconds.ToString();
            }

            if (rdbTask9.Checked == true)
            {
                TimeSpan tmsTask9 = new TimeSpan(0, 0, 0, 0, (int)stpwTask9.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask9.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask9.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer9.Text = tmsTask9.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask9.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask9.Seconds.ToString();
            }

            if (rdbTask10.Checked == true)
            {
                TimeSpan tmsTask10 = new TimeSpan(0, 0, 0, 0, (int)stpwTask10.Elapsed.TotalMilliseconds);
                string minuteAddTsk = "";
                string secondsAddTsk = "";
                if (tmsTask10.Minutes.ToString().Length < 2)
                    minuteAddTsk = "0";
                else
                    minuteAddTsk = "";
                if (tmsTask10.Seconds.ToString().Length < 2)
                    secondsAddTsk = "0";
                else
                    secondsAddTsk = "";
                this.lblTimer10.Text = tmsTask10.Hours.ToString() + ":"
                    + minuteAddTsk + tmsTask10.Minutes.ToString() + ":"
                    + secondsAddTsk + tmsTask10.Seconds.ToString();
            }
            if (reminderActivated)
            {
                if (myTs.Minutes % reminderTime == 0 && myTs.Minutes > 0 && myTs.Seconds >= 0 && myTs.Seconds <= 3 && hideActivated && !reminderInterrupted)
                    formbackground.WindowReminderOpen(myTs);
                if (myTs.Minutes % reminderTime == 0 && myTs.Minutes > 0 && myTs.Seconds >= 18 && myTs.Seconds <= 21 && hideActivated && !reminderInterrupted)
                    formbackground.WindowReminderClose(myTs);
                if (myTs.Minutes % reminderTime == 0 && myTs.Seconds >= 57 && reminderInterrupted)
                    reminderInterrupted = false;
            }
            if (saveActivated)
            {
                if (myTs.Minutes % saveTime == 0 && myTs.Minutes > 0 && myTs.Seconds >= 0 && myTs.Seconds <= 3 && !savedConfirmed)
                    SaveProcess();
                if (myTs.Minutes % saveTime == 0 && myTs.Seconds >= 57 && savedConfirmed)
                    savedConfirmed = false;
            }

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (visibleRows)
            {
                case 3:
                    rdbTask4.Visible = true;
                    txbTask4.Visible = true;
                    txbComment4.Visible = true;
                    lblTimer4.Visible = true;
                    visibleRows = 4;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Visible = true;                    
                    break;

                case 4:
                    rdbTask5.Visible = true;
                    txbTask5.Visible = true;
                    txbComment5.Visible = true;
                    lblTimer5.Visible = true;
                    visibleRows = 5;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;

                case 5:
                    rdbTask6.Visible = true;
                    txbTask6.Visible = true;
                    txbComment6.Visible = true;
                    lblTimer6.Visible = true;
                    visibleRows = 6;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;

                case 6:
                    rdbTask7.Visible = true;
                    txbTask7.Visible = true;
                    txbComment7.Visible = true;
                    lblTimer7.Visible = true;
                    visibleRows = 7;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;

                case 7:
                    rdbTask8.Visible = true;
                    txbTask8.Visible = true;
                    txbComment8.Visible = true;
                    lblTimer8.Visible = true;
                    visibleRows = 8;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;

                case 8:
                    rdbTask9.Visible = true;
                    txbTask9.Visible = true;
                    txbComment9.Visible = true;
                    lblTimer9.Visible = true;
                    visibleRows = 9;
                    btnAddRow.Top += 29;
                    btnReset.Top += 29;
                    btnStart.Top += 29;
                    btnStop.Top += 29;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;

                case 9:
                    rdbTask10.Visible = true;
                    txbTask10.Visible = true;
                    txbComment10.Visible = true;
                    lblTimer10.Visible = true;
                    visibleRows = 10;
                    btnAddRow.Visible = false;
                    Height += 29;
                    btnDeleteRow.Top += 29;
                    break;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            switch (visibleRows)
            {
                case 4:
                    if(rdbTask4.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask4.Visible = false;
                    txbTask4.Visible = false;
                    txbComment4.Visible = false;
                    lblTimer4.Visible = false;
                    btnDeleteRow.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 5:
                    if (rdbTask5.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask5.Visible = false;
                    txbTask5.Visible = false;
                    txbComment5.Visible = false;
                    lblTimer5.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    btnDeleteRow.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 6:
                    if (rdbTask6.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask6.Visible = false;
                    txbTask6.Visible = false;
                    txbComment6.Visible = false;
                    lblTimer6.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    btnDeleteRow.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 7:
                    if (rdbTask7.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask7.Visible = false;
                    txbTask7.Visible = false;
                    txbComment7.Visible = false;
                    lblTimer7.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    btnDeleteRow.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 8:
                    if (rdbTask8.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask8.Visible = false;
                    txbTask8.Visible = false;
                    txbComment8.Visible = false;
                    lblTimer8.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    btnDeleteRow.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 9:
                    if (rdbTask9.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask9.Visible = false;
                    txbTask9.Visible = false;
                    txbComment9.Visible = false;
                    lblTimer9.Visible = false;
                    btnAddRow.Top -= 29;
                    btnReset.Top -= 29;
                    btnStart.Top -= 29;
                    btnStop.Top -= 29;
                    btnDeleteRow.Top -= 29;
                    Height -= 29;
                    visibleRows -= 1;
                    break;

                case 10:
                    if (rdbTask10.Checked == true)
                    {
                        MessageBox.Show("Cannot take an active task");
                        break;
                    }
                    rdbTask10.Visible = false;
                    txbTask10.Visible = false;
                    txbComment10.Visible = false;
                    lblTimer10.Visible = false;
                    btnAddRow.Visible = true;
                    btnDeleteRow.Top -= 29;
                    visibleRows -= 1;
                    break;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            formsettings = new formSettings(this);
            formsettings.Location = new Point(200, 200);
            formsettings.ShowDialog();
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            formBackground formbackground = new formBackground(this);
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width, 0);
            formbackground.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formbackground.ControlBox = false;
            formbackground.BackColor = Color.LimeGreen;
            formbackground.TransparencyKey = Color.LimeGreen;
            formbackground.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 30, reminderVerticalPos);
            formbackground.FormBorderStyle = FormBorderStyle.FixedSingle;
            formbackground.ChangeActiveTask(GetCheckedRadioButton());
            formbackground.Show();
            hideActivated = true;
        }

        private string GetCheckedRadioButton()
        {
            string checkedRdb = "";
            if (rdbTask1.Checked)
                checkedRdb = txbTask1.Text;
            else if(rdbTask2.Checked)
                checkedRdb = txbTask2.Text;
            else if (rdbTask3.Checked)
                checkedRdb = txbTask3.Text;
            else if (rdbTask4.Checked)
                checkedRdb = txbTask4.Text;
            else if (rdbTask5.Checked)
                checkedRdb = txbTask5.Text;
            else if (rdbTask6.Checked)
                checkedRdb = txbTask6.Text;
            else if (rdbTask7.Checked)
                checkedRdb = txbTask7.Text;
            else if (rdbTask8.Checked)
                checkedRdb = txbTask8.Text;
            else if (rdbTask9.Checked)
                checkedRdb = txbTask9.Text;
            else
                checkedRdb = txbTask10.Text;

            return checkedRdb;
        }

        private void SaveProcess()
        {
            DateTime thisDay = DateTime.Today;
            string path = saveDirectory + @"\TTPal_" + thisDay.Year.ToString() + "-" + thisDay.Month.ToString() + "-" + thisDay.Day.ToString() + ".txt";
            string toSave = "Elapsed Time" + "\t" + "Task Name" + "\t" + "Comments" + "\n" 
                + lblTimer1.Text + "\t" + txbTask1.Text + "\t" + txbComment1.Text + "\n"
                + lblTimer2.Text + "\t" + txbTask2.Text + "\t" + txbComment2.Text + "\n"
                + lblTimer3.Text + "\t" + txbTask3.Text + "\t" + txbComment3.Text + "\n"
                + lblTimer4.Text + "\t" + txbTask4.Text + "\t" + txbComment4.Text + "\n"
                + lblTimer5.Text + "\t" + txbTask5.Text + "\t" + txbComment5.Text + "\n"
                + lblTimer6.Text + "\t" + txbTask6.Text + "\t" + txbComment6.Text + "\n"
                + lblTimer7.Text + "\t" + txbTask7.Text + "\t" + txbComment7.Text + "\n"
                + lblTimer8.Text + "\t" + txbTask8.Text + "\t" + txbComment8.Text + "\n"
                + lblTimer9.Text + "\t" + txbTask9.Text + "\t" + txbComment9.Text + "\n"
                + lblTimer10.Text + "\t" + txbTask10.Text + "\t" + txbComment10.Text;
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(toSave);
            }
            savedConfirmed = true;
        }
    }
}

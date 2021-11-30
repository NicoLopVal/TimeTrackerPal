using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;

namespace TimeTrackerFriend
{
    public partial class formBackground : Form
    {
        frmMainWindow firstForm;
        int positionWidth = Screen.PrimaryScreen.Bounds.Width - 30;
        public const int WM_NCLBUTTONDOWN = 0xA1;   //Moving reminder form with the button solution: https://stackoverflow.com/questions/13477228/moving-window-by-click-drag-on-a-control
        public const int HTCAPTION = 0x2;                                                   //          |
        [System.Runtime.InteropServices.DllImport("User32.dll")]                            //          |
        public static extern bool ReleaseCapture();                                         //          |
        [System.Runtime.InteropServices.DllImport("User32.dll")]                            //          |
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); //Until Here
        
        
        public formBackground(frmMainWindow first)
        {
            InitializeComponent();
            firstForm = first;
            ShowInTaskbar = false;
            this.TopMost = true;
            positionWidth = Screen.PrimaryScreen.Bounds.Width - 30;
        }

        private void btnOpenProgram_Click(object sender, EventArgs e)       //Button to get out of the hide status of the program
        {
            firstForm.Location = new Point(500, 500);
            firstForm.hideActivated = false;
            Close();
        }

        public void WindowReminderOpen(TimeSpan myTS)       //Moves the reminder form into the screen
        {
            positionWidth -= 5;
            ActiveForm.Location = new Point(positionWidth, firstForm.reminderVerticalPos);
        }

        public void WindowReminderClose(TimeSpan myTS)      //Moves the reminder form out of the screen
        {
            positionWidth += 5;
            ActiveForm.Location = new Point(positionWidth, firstForm.reminderVerticalPos);
        }

        private void btnBigReminder_Click(object sender, EventArgs e)       //The same button as the btnOpenProgram, but bigger. Just used 4 the reminder
        {
            firstForm.Location = new Point(500, 500);
            firstForm.hideActivated = false;
            firstForm.reminderInterrupted = true;
            Close();
        }

        public void ChangeActiveTask(string task)           // Used to change the text of the button on the reminder from the main form
        {
            btnBigReminder.Text = "Are you working on: " + task;
        }

        private void btnMoveReminder_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
            ActiveForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 30, Cursor.Position.Y);     //Makes the reminder go to its X position and new Y position
            firstForm.reminderVerticalPos = ActiveForm.Location.Y;
        }
    }
}

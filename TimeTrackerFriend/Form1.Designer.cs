
using System.Windows.Forms;

namespace TimeTrackerFriend
{
    partial class frmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            while (true)
            {
                string message = "Are you sure you want to close Time Tracker Pal?";
                string caption = "Time Tracker Pal will stop running";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                    break;
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.txbComment1 = new System.Windows.Forms.TextBox();
            this.txbComment2 = new System.Windows.Forms.TextBox();
            this.txbComment3 = new System.Windows.Forms.TextBox();
            this.txbComment4 = new System.Windows.Forms.TextBox();
            this.lblTimer1 = new System.Windows.Forms.Label();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.lblTimer3 = new System.Windows.Forms.Label();
            this.lblTimer4 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTotalTimer = new System.Windows.Forms.Label();
            this.lblTotalTimeTitle = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txbTask1 = new System.Windows.Forms.TextBox();
            this.txbTask2 = new System.Windows.Forms.TextBox();
            this.txbTask3 = new System.Windows.Forms.TextBox();
            this.txbTask4 = new System.Windows.Forms.TextBox();
            this.rdbTask1 = new System.Windows.Forms.RadioButton();
            this.rdbTask2 = new System.Windows.Forms.RadioButton();
            this.rdbTask3 = new System.Windows.Forms.RadioButton();
            this.rdbTask4 = new System.Windows.Forms.RadioButton();
            this.TotalTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblCommets = new System.Windows.Forms.Label();
            this.rdbTask5 = new System.Windows.Forms.RadioButton();
            this.txbTask5 = new System.Windows.Forms.TextBox();
            this.lblTimer5 = new System.Windows.Forms.Label();
            this.txbComment5 = new System.Windows.Forms.TextBox();
            this.rdbTask6 = new System.Windows.Forms.RadioButton();
            this.txbTask6 = new System.Windows.Forms.TextBox();
            this.lblTimer6 = new System.Windows.Forms.Label();
            this.txbComment6 = new System.Windows.Forms.TextBox();
            this.rdbTask7 = new System.Windows.Forms.RadioButton();
            this.txbTask7 = new System.Windows.Forms.TextBox();
            this.lblTimer7 = new System.Windows.Forms.Label();
            this.txbComment7 = new System.Windows.Forms.TextBox();
            this.rdbTask8 = new System.Windows.Forms.RadioButton();
            this.txbTask8 = new System.Windows.Forms.TextBox();
            this.lblTimer8 = new System.Windows.Forms.Label();
            this.txbComment8 = new System.Windows.Forms.TextBox();
            this.rdbTask9 = new System.Windows.Forms.RadioButton();
            this.txbTask9 = new System.Windows.Forms.TextBox();
            this.lblTimer9 = new System.Windows.Forms.Label();
            this.txbComment9 = new System.Windows.Forms.TextBox();
            this.rdbTask10 = new System.Windows.Forms.RadioButton();
            this.txbTask10 = new System.Windows.Forms.TextBox();
            this.lblTimer10 = new System.Windows.Forms.Label();
            this.txbComment10 = new System.Windows.Forms.TextBox();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.lblWoking = new System.Windows.Forms.Label();
            this.lblPaused = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRow.Location = new System.Drawing.Point(634, 167);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(29, 23);
            this.btnDeleteRow.TabIndex = 0;
            this.btnDeleteRow.Text = "-";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Visible = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // txbComment1
            // 
            this.txbComment1.Location = new System.Drawing.Point(314, 80);
            this.txbComment1.Name = "txbComment1";
            this.txbComment1.Size = new System.Drawing.Size(314, 23);
            this.txbComment1.TabIndex = 1;
            // 
            // txbComment2
            // 
            this.txbComment2.Location = new System.Drawing.Point(314, 109);
            this.txbComment2.Name = "txbComment2";
            this.txbComment2.Size = new System.Drawing.Size(314, 23);
            this.txbComment2.TabIndex = 2;
            // 
            // txbComment3
            // 
            this.txbComment3.Location = new System.Drawing.Point(314, 138);
            this.txbComment3.Name = "txbComment3";
            this.txbComment3.Size = new System.Drawing.Size(314, 23);
            this.txbComment3.TabIndex = 3;
            // 
            // txbComment4
            // 
            this.txbComment4.Location = new System.Drawing.Point(314, 167);
            this.txbComment4.Name = "txbComment4";
            this.txbComment4.Size = new System.Drawing.Size(314, 23);
            this.txbComment4.TabIndex = 4;
            this.txbComment4.Visible = false;
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer1.Location = new System.Drawing.Point(40, 82);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(61, 21);
            this.lblTimer1.TabIndex = 5;
            this.lblTimer1.Text = "0:00:00";
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer2.Location = new System.Drawing.Point(40, 111);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(61, 21);
            this.lblTimer2.TabIndex = 6;
            this.lblTimer2.Text = "0:00:00";
            // 
            // lblTimer3
            // 
            this.lblTimer3.AutoSize = true;
            this.lblTimer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer3.Location = new System.Drawing.Point(40, 140);
            this.lblTimer3.Name = "lblTimer3";
            this.lblTimer3.Size = new System.Drawing.Size(61, 21);
            this.lblTimer3.TabIndex = 7;
            this.lblTimer3.Text = "0:00:00";
            // 
            // lblTimer4
            // 
            this.lblTimer4.AutoSize = true;
            this.lblTimer4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer4.Location = new System.Drawing.Point(40, 169);
            this.lblTimer4.Name = "lblTimer4";
            this.lblTimer4.Size = new System.Drawing.Size(61, 21);
            this.lblTimer4.TabIndex = 8;
            this.lblTimer4.Text = "0:00:00";
            this.lblTimer4.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblTotalTimer
            // 
            this.lblTotalTimer.AutoSize = true;
            this.lblTotalTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTimer.Location = new System.Drawing.Point(362, 12);
            this.lblTotalTimer.Name = "lblTotalTimer";
            this.lblTotalTimer.Size = new System.Drawing.Size(61, 21);
            this.lblTotalTimer.TabIndex = 14;
            this.lblTotalTimer.Text = "0:00:00";
            // 
            // lblTotalTimeTitle
            // 
            this.lblTotalTimeTitle.AutoSize = true;
            this.lblTotalTimeTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTimeTitle.Location = new System.Drawing.Point(276, 12);
            this.lblTotalTimeTitle.Name = "lblTotalTimeTitle";
            this.lblTotalTimeTitle.Size = new System.Drawing.Size(80, 21);
            this.lblTotalTimeTitle.TabIndex = 15;
            this.lblTotalTimeTitle.Text = "Total Time";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddRow.Location = new System.Drawing.Point(305, 167);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(25, 29);
            this.btnAddRow.TabIndex = 16;
            this.btnAddRow.Text = "+";
            this.btnAddRow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start/Resume";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(539, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txbTask1
            // 
            this.txbTask1.Location = new System.Drawing.Point(107, 80);
            this.txbTask1.Name = "txbTask1";
            this.txbTask1.Size = new System.Drawing.Size(201, 23);
            this.txbTask1.TabIndex = 20;
            // 
            // txbTask2
            // 
            this.txbTask2.Location = new System.Drawing.Point(107, 109);
            this.txbTask2.Name = "txbTask2";
            this.txbTask2.Size = new System.Drawing.Size(201, 23);
            this.txbTask2.TabIndex = 21;
            // 
            // txbTask3
            // 
            this.txbTask3.Location = new System.Drawing.Point(107, 138);
            this.txbTask3.Name = "txbTask3";
            this.txbTask3.Size = new System.Drawing.Size(201, 23);
            this.txbTask3.TabIndex = 22;
            // 
            // txbTask4
            // 
            this.txbTask4.Location = new System.Drawing.Point(107, 167);
            this.txbTask4.Name = "txbTask4";
            this.txbTask4.Size = new System.Drawing.Size(201, 23);
            this.txbTask4.TabIndex = 23;
            this.txbTask4.Visible = false;
            // 
            // rdbTask1
            // 
            this.rdbTask1.AutoSize = true;
            this.rdbTask1.Checked = true;
            this.rdbTask1.Location = new System.Drawing.Point(19, 88);
            this.rdbTask1.Name = "rdbTask1";
            this.rdbTask1.Size = new System.Drawing.Size(14, 13);
            this.rdbTask1.TabIndex = 24;
            this.rdbTask1.TabStop = true;
            this.rdbTask1.UseVisualStyleBackColor = true;
            // 
            // rdbTask2
            // 
            this.rdbTask2.AutoSize = true;
            this.rdbTask2.Location = new System.Drawing.Point(19, 119);
            this.rdbTask2.Name = "rdbTask2";
            this.rdbTask2.Size = new System.Drawing.Size(14, 13);
            this.rdbTask2.TabIndex = 25;
            this.rdbTask2.UseVisualStyleBackColor = true;
            // 
            // rdbTask3
            // 
            this.rdbTask3.AutoSize = true;
            this.rdbTask3.Location = new System.Drawing.Point(19, 148);
            this.rdbTask3.Name = "rdbTask3";
            this.rdbTask3.Size = new System.Drawing.Size(14, 13);
            this.rdbTask3.TabIndex = 26;
            this.rdbTask3.UseVisualStyleBackColor = true;
            // 
            // rdbTask4
            // 
            this.rdbTask4.AutoSize = true;
            this.rdbTask4.Location = new System.Drawing.Point(19, 177);
            this.rdbTask4.Name = "rdbTask4";
            this.rdbTask4.Size = new System.Drawing.Size(14, 13);
            this.rdbTask4.TabIndex = 27;
            this.rdbTask4.UseVisualStyleBackColor = true;
            this.rdbTask4.Visible = false;
            // 
            // lblTaskTime
            // 
            this.lblTaskTime.AutoSize = true;
            this.lblTaskTime.Location = new System.Drawing.Point(41, 56);
            this.lblTaskTime.Name = "lblTaskTime";
            this.lblTaskTime.Size = new System.Drawing.Size(58, 15);
            this.lblTaskTime.TabIndex = 28;
            this.lblTaskTime.Text = "Task Time";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(161, 56);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(92, 15);
            this.lblTask.TabIndex = 29;
            this.lblTask.Text = "Task Description";
            // 
            // lblCommets
            // 
            this.lblCommets.AutoSize = true;
            this.lblCommets.Location = new System.Drawing.Point(438, 56);
            this.lblCommets.Name = "lblCommets";
            this.lblCommets.Size = new System.Drawing.Size(66, 15);
            this.lblCommets.TabIndex = 30;
            this.lblCommets.Text = "Comments";
            // 
            // rdbTask5
            // 
            this.rdbTask5.AutoSize = true;
            this.rdbTask5.Location = new System.Drawing.Point(19, 206);
            this.rdbTask5.Name = "rdbTask5";
            this.rdbTask5.Size = new System.Drawing.Size(14, 13);
            this.rdbTask5.TabIndex = 34;
            this.rdbTask5.UseVisualStyleBackColor = true;
            this.rdbTask5.Visible = false;
            // 
            // txbTask5
            // 
            this.txbTask5.Location = new System.Drawing.Point(107, 196);
            this.txbTask5.Name = "txbTask5";
            this.txbTask5.Size = new System.Drawing.Size(201, 23);
            this.txbTask5.TabIndex = 33;
            this.txbTask5.Visible = false;
            // 
            // lblTimer5
            // 
            this.lblTimer5.AutoSize = true;
            this.lblTimer5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer5.Location = new System.Drawing.Point(40, 198);
            this.lblTimer5.Name = "lblTimer5";
            this.lblTimer5.Size = new System.Drawing.Size(61, 21);
            this.lblTimer5.TabIndex = 32;
            this.lblTimer5.Text = "0:00:00";
            this.lblTimer5.Visible = false;
            // 
            // txbComment5
            // 
            this.txbComment5.Location = new System.Drawing.Point(314, 196);
            this.txbComment5.Name = "txbComment5";
            this.txbComment5.Size = new System.Drawing.Size(314, 23);
            this.txbComment5.TabIndex = 31;
            this.txbComment5.Visible = false;
            // 
            // rdbTask6
            // 
            this.rdbTask6.AutoSize = true;
            this.rdbTask6.Location = new System.Drawing.Point(19, 235);
            this.rdbTask6.Name = "rdbTask6";
            this.rdbTask6.Size = new System.Drawing.Size(14, 13);
            this.rdbTask6.TabIndex = 38;
            this.rdbTask6.UseVisualStyleBackColor = true;
            this.rdbTask6.Visible = false;
            // 
            // txbTask6
            // 
            this.txbTask6.Location = new System.Drawing.Point(107, 225);
            this.txbTask6.Name = "txbTask6";
            this.txbTask6.Size = new System.Drawing.Size(201, 23);
            this.txbTask6.TabIndex = 37;
            this.txbTask6.Visible = false;
            // 
            // lblTimer6
            // 
            this.lblTimer6.AutoSize = true;
            this.lblTimer6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer6.Location = new System.Drawing.Point(40, 227);
            this.lblTimer6.Name = "lblTimer6";
            this.lblTimer6.Size = new System.Drawing.Size(61, 21);
            this.lblTimer6.TabIndex = 36;
            this.lblTimer6.Text = "0:00:00";
            this.lblTimer6.Visible = false;
            // 
            // txbComment6
            // 
            this.txbComment6.Location = new System.Drawing.Point(314, 225);
            this.txbComment6.Name = "txbComment6";
            this.txbComment6.Size = new System.Drawing.Size(314, 23);
            this.txbComment6.TabIndex = 35;
            this.txbComment6.Visible = false;
            // 
            // rdbTask7
            // 
            this.rdbTask7.AutoSize = true;
            this.rdbTask7.Location = new System.Drawing.Point(19, 264);
            this.rdbTask7.Name = "rdbTask7";
            this.rdbTask7.Size = new System.Drawing.Size(14, 13);
            this.rdbTask7.TabIndex = 42;
            this.rdbTask7.UseVisualStyleBackColor = true;
            this.rdbTask7.Visible = false;
            // 
            // txbTask7
            // 
            this.txbTask7.Location = new System.Drawing.Point(107, 254);
            this.txbTask7.Name = "txbTask7";
            this.txbTask7.Size = new System.Drawing.Size(201, 23);
            this.txbTask7.TabIndex = 41;
            this.txbTask7.Visible = false;
            // 
            // lblTimer7
            // 
            this.lblTimer7.AutoSize = true;
            this.lblTimer7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer7.Location = new System.Drawing.Point(40, 256);
            this.lblTimer7.Name = "lblTimer7";
            this.lblTimer7.Size = new System.Drawing.Size(61, 21);
            this.lblTimer7.TabIndex = 40;
            this.lblTimer7.Text = "0:00:00";
            this.lblTimer7.Visible = false;
            // 
            // txbComment7
            // 
            this.txbComment7.Location = new System.Drawing.Point(314, 254);
            this.txbComment7.Name = "txbComment7";
            this.txbComment7.Size = new System.Drawing.Size(314, 23);
            this.txbComment7.TabIndex = 39;
            this.txbComment7.Visible = false;
            // 
            // rdbTask8
            // 
            this.rdbTask8.AutoSize = true;
            this.rdbTask8.Location = new System.Drawing.Point(19, 293);
            this.rdbTask8.Name = "rdbTask8";
            this.rdbTask8.Size = new System.Drawing.Size(14, 13);
            this.rdbTask8.TabIndex = 46;
            this.rdbTask8.UseVisualStyleBackColor = true;
            this.rdbTask8.Visible = false;
            // 
            // txbTask8
            // 
            this.txbTask8.Location = new System.Drawing.Point(107, 283);
            this.txbTask8.Name = "txbTask8";
            this.txbTask8.Size = new System.Drawing.Size(201, 23);
            this.txbTask8.TabIndex = 45;
            this.txbTask8.Visible = false;
            // 
            // lblTimer8
            // 
            this.lblTimer8.AutoSize = true;
            this.lblTimer8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer8.Location = new System.Drawing.Point(40, 285);
            this.lblTimer8.Name = "lblTimer8";
            this.lblTimer8.Size = new System.Drawing.Size(61, 21);
            this.lblTimer8.TabIndex = 44;
            this.lblTimer8.Text = "0:00:00";
            this.lblTimer8.Visible = false;
            // 
            // txbComment8
            // 
            this.txbComment8.Location = new System.Drawing.Point(314, 283);
            this.txbComment8.Name = "txbComment8";
            this.txbComment8.Size = new System.Drawing.Size(314, 23);
            this.txbComment8.TabIndex = 43;
            this.txbComment8.Visible = false;
            // 
            // rdbTask9
            // 
            this.rdbTask9.AutoSize = true;
            this.rdbTask9.Location = new System.Drawing.Point(19, 322);
            this.rdbTask9.Name = "rdbTask9";
            this.rdbTask9.Size = new System.Drawing.Size(14, 13);
            this.rdbTask9.TabIndex = 50;
            this.rdbTask9.UseVisualStyleBackColor = true;
            this.rdbTask9.Visible = false;
            // 
            // txbTask9
            // 
            this.txbTask9.Location = new System.Drawing.Point(107, 312);
            this.txbTask9.Name = "txbTask9";
            this.txbTask9.Size = new System.Drawing.Size(201, 23);
            this.txbTask9.TabIndex = 49;
            this.txbTask9.Visible = false;
            // 
            // lblTimer9
            // 
            this.lblTimer9.AutoSize = true;
            this.lblTimer9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer9.Location = new System.Drawing.Point(40, 314);
            this.lblTimer9.Name = "lblTimer9";
            this.lblTimer9.Size = new System.Drawing.Size(61, 21);
            this.lblTimer9.TabIndex = 48;
            this.lblTimer9.Text = "0:00:00";
            this.lblTimer9.Visible = false;
            // 
            // txbComment9
            // 
            this.txbComment9.Location = new System.Drawing.Point(314, 312);
            this.txbComment9.Name = "txbComment9";
            this.txbComment9.Size = new System.Drawing.Size(314, 23);
            this.txbComment9.TabIndex = 47;
            this.txbComment9.Visible = false;
            // 
            // rdbTask10
            // 
            this.rdbTask10.AutoSize = true;
            this.rdbTask10.Location = new System.Drawing.Point(19, 351);
            this.rdbTask10.Name = "rdbTask10";
            this.rdbTask10.Size = new System.Drawing.Size(14, 13);
            this.rdbTask10.TabIndex = 54;
            this.rdbTask10.UseVisualStyleBackColor = true;
            this.rdbTask10.Visible = false;
            // 
            // txbTask10
            // 
            this.txbTask10.Location = new System.Drawing.Point(107, 341);
            this.txbTask10.Name = "txbTask10";
            this.txbTask10.Size = new System.Drawing.Size(201, 23);
            this.txbTask10.TabIndex = 53;
            this.txbTask10.Visible = false;
            // 
            // lblTimer10
            // 
            this.lblTimer10.AutoSize = true;
            this.lblTimer10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer10.Location = new System.Drawing.Point(40, 343);
            this.lblTimer10.Name = "lblTimer10";
            this.lblTimer10.Size = new System.Drawing.Size(61, 21);
            this.lblTimer10.TabIndex = 52;
            this.lblTimer10.Text = "0:00:00";
            this.lblTimer10.Visible = false;
            // 
            // txbComment10
            // 
            this.txbComment10.Location = new System.Drawing.Point(314, 341);
            this.txbComment10.Name = "txbComment10";
            this.txbComment10.Size = new System.Drawing.Size(314, 23);
            this.txbComment10.TabIndex = 51;
            this.txbComment10.Visible = false;
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseProgram.Location = new System.Drawing.Point(588, 10);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(75, 23);
            this.btnCloseProgram.TabIndex = 55;
            this.btnCloseProgram.Text = "Hide";
            this.btnCloseProgram.UseVisualStyleBackColor = false;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // lblWoking
            // 
            this.lblWoking.AutoSize = true;
            this.lblWoking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWoking.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblWoking.Location = new System.Drawing.Point(305, 33);
            this.lblWoking.Name = "lblWoking";
            this.lblWoking.Size = new System.Drawing.Size(86, 20);
            this.lblWoking.TabIndex = 56;
            this.lblWoking.Text = "Running ▶";
            // 
            // lblPaused
            // 
            this.lblPaused.AutoSize = true;
            this.lblPaused.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaused.ForeColor = System.Drawing.Color.Red;
            this.lblPaused.Location = new System.Drawing.Point(306, 33);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(85, 20);
            this.lblPaused.TabIndex = 57;
            this.lblPaused.Text = "Paused ⏸";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 241);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.lblWoking);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.rdbTask10);
            this.Controls.Add(this.txbTask10);
            this.Controls.Add(this.lblTimer10);
            this.Controls.Add(this.txbComment10);
            this.Controls.Add(this.rdbTask9);
            this.Controls.Add(this.txbTask9);
            this.Controls.Add(this.lblTimer9);
            this.Controls.Add(this.txbComment9);
            this.Controls.Add(this.rdbTask8);
            this.Controls.Add(this.txbTask8);
            this.Controls.Add(this.lblTimer8);
            this.Controls.Add(this.txbComment8);
            this.Controls.Add(this.rdbTask7);
            this.Controls.Add(this.txbTask7);
            this.Controls.Add(this.lblTimer7);
            this.Controls.Add(this.txbComment7);
            this.Controls.Add(this.rdbTask6);
            this.Controls.Add(this.txbTask6);
            this.Controls.Add(this.lblTimer6);
            this.Controls.Add(this.txbComment6);
            this.Controls.Add(this.rdbTask5);
            this.Controls.Add(this.txbTask5);
            this.Controls.Add(this.lblTimer5);
            this.Controls.Add(this.txbComment5);
            this.Controls.Add(this.lblCommets);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblTaskTime);
            this.Controls.Add(this.rdbTask4);
            this.Controls.Add(this.rdbTask3);
            this.Controls.Add(this.rdbTask2);
            this.Controls.Add(this.rdbTask1);
            this.Controls.Add(this.txbTask4);
            this.Controls.Add(this.txbTask3);
            this.Controls.Add(this.txbTask2);
            this.Controls.Add(this.txbTask1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.lblTotalTimeTitle);
            this.Controls.Add(this.lblTotalTimer);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblTimer4);
            this.Controls.Add(this.lblTimer3);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.txbComment4);
            this.Controls.Add(this.txbComment3);
            this.Controls.Add(this.txbComment2);
            this.Controls.Add(this.txbComment1);
            this.Controls.Add(this.btnDeleteRow);
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximumSize = new System.Drawing.Size(690, 450);
            this.MinimumSize = new System.Drawing.Size(690, 280);
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Tracker Pal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.TextBox txbComment1;
        private System.Windows.Forms.TextBox txbComment2;
        private System.Windows.Forms.TextBox txbComment3;
        private System.Windows.Forms.TextBox txbComment4;
        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Label lblTimer3;
        private System.Windows.Forms.Label lblTimer4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblTotalTimer;
        private System.Windows.Forms.Label lblTotalTimeTitle;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txbTask1;
        private System.Windows.Forms.TextBox txbTask2;
        private System.Windows.Forms.TextBox txbTask3;
        private System.Windows.Forms.TextBox txbTask4;
        private System.Windows.Forms.RadioButton rdbTask1;
        private System.Windows.Forms.RadioButton rdbTask2;
        private System.Windows.Forms.RadioButton rdbTask3;
        private System.Windows.Forms.RadioButton rdbTask4;
        private System.Windows.Forms.Timer TotalTimer;
        private System.Windows.Forms.Label lblTaskTime;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblCommets;
        private System.Windows.Forms.RadioButton rdbTask5;
        private System.Windows.Forms.TextBox txbTask5;
        private System.Windows.Forms.Label lblTimer5;
        private System.Windows.Forms.TextBox txbComment5;
        private System.Windows.Forms.RadioButton rdbTask6;
        private System.Windows.Forms.TextBox txbTask6;
        private System.Windows.Forms.Label lblTimer6;
        private System.Windows.Forms.TextBox txbComment6;
        private System.Windows.Forms.RadioButton rdbTask7;
        private System.Windows.Forms.TextBox txbTask7;
        private System.Windows.Forms.Label lblTimer7;
        private System.Windows.Forms.TextBox txbComment7;
        private System.Windows.Forms.RadioButton rdbTask8;
        private System.Windows.Forms.TextBox txbTask8;
        private System.Windows.Forms.Label lblTimer8;
        private System.Windows.Forms.TextBox txbComment8;
        private System.Windows.Forms.RadioButton rdbTask9;
        private System.Windows.Forms.TextBox txbTask9;
        private System.Windows.Forms.Label lblTimer9;
        private System.Windows.Forms.TextBox txbComment9;
        private System.Windows.Forms.RadioButton rdbTask10;
        private System.Windows.Forms.TextBox txbTask10;
        private System.Windows.Forms.Label lblTimer10;
        private System.Windows.Forms.TextBox txbComment10;
        private System.Windows.Forms.Button btnCloseProgram;
        private Label lblWoking;
        private Label lblPaused;
    }
}


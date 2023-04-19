
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.timerTaskLabelMain = new System.Windows.Forms.Label();
            this.lblTotalTimeTitle = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.TotalTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblCommets = new System.Windows.Forms.Label();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.lblWoking = new System.Windows.Forms.Label();
            this.lblPaused = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
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
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(57, 23);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // timerTaskLabelMain
            // 
            this.timerTaskLabelMain.AutoSize = true;
            this.timerTaskLabelMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerTaskLabelMain.Location = new System.Drawing.Point(362, 12);
            this.timerTaskLabelMain.Name = "timerTaskLabelMain";
            this.timerTaskLabelMain.Size = new System.Drawing.Size(61, 21);
            this.timerTaskLabelMain.TabIndex = 14;
            this.timerTaskLabelMain.Text = "0:00:00";
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
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start/Resume";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(539, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
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
            // btnCloseProgram
            // 
            this.btnCloseProgram.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseProgram.Location = new System.Drawing.Point(588, 10);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(75, 23);
            this.btnCloseProgram.TabIndex = 55;
            this.btnCloseProgram.Text = "Hide";
            this.btnCloseProgram.UseVisualStyleBackColor = false;
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(75, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(42, 23);
            this.btnLoad.TabIndex = 58;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 232);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.lblWoking);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.lblCommets);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblTaskTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.lblTotalTimeTitle);
            this.Controls.Add(this.timerTaskLabelMain);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDeleteRow);
            this.Location = new System.Drawing.Point(500, 500);
            this.MinimumSize = new System.Drawing.Size(690, 240);
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Tracker Pal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblTotalTimeTitle;
        private System.Windows.Forms.Label lblTaskTime;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblCommets;
        private System.Windows.Forms.Button btnCloseProgram;
        private Label lblWoking;
        public Timer TotalTimer;
        public Label lblPaused;
        public Label timerTaskLabelMain;
        public Button btnDeleteRow;
        public Button btnAddRow;
        public Button btnReset;
        public Button btnStart;
        public Button btnStop;
        private Button btnLoad;
    }
}



namespace TimeTrackerFriend
{
    partial class formBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBackground));
            this.btnOpenProgram = new System.Windows.Forms.Button();
            this.btnBigReminder = new System.Windows.Forms.Button();
            this.btnMoveReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenProgram
            // 
            this.btnOpenProgram.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenProgram.BackgroundImage")));
            this.btnOpenProgram.Location = new System.Drawing.Point(0, 0);
            this.btnOpenProgram.Name = "btnOpenProgram";
            this.btnOpenProgram.Size = new System.Drawing.Size(29, 30);
            this.btnOpenProgram.TabIndex = 0;
            this.btnOpenProgram.UseVisualStyleBackColor = false;
            this.btnOpenProgram.Click += new System.EventHandler(this.btnOpenProgram_Click);
            // 
            // btnBigReminder
            // 
            this.btnBigReminder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBigReminder.Location = new System.Drawing.Point(32, 0);
            this.btnBigReminder.Name = "btnBigReminder";
            this.btnBigReminder.Size = new System.Drawing.Size(185, 135);
            this.btnBigReminder.TabIndex = 1;
            this.btnBigReminder.Text = "Are you working on: ";
            this.btnBigReminder.UseVisualStyleBackColor = true;
            this.btnBigReminder.Click += new System.EventHandler(this.btnBigReminder_Click);
            // 
            // btnMoveReminder
            // 
            this.btnMoveReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveReminder.Image")));
            this.btnMoveReminder.Location = new System.Drawing.Point(0, 28);
            this.btnMoveReminder.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveReminder.Name = "btnMoveReminder";
            this.btnMoveReminder.Size = new System.Drawing.Size(30, 15);
            this.btnMoveReminder.TabIndex = 2;
            this.btnMoveReminder.UseVisualStyleBackColor = true;
            this.btnMoveReminder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveReminder_MouseDown);
            // 
            // formBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 135);
            this.Controls.Add(this.btnMoveReminder);
            this.Controls.Add(this.btnBigReminder);
            this.Controls.Add(this.btnOpenProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(220, 135);
            this.MinimumSize = new System.Drawing.Size(220, 135);
            this.Name = "formBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProgram;
        private System.Windows.Forms.Button btnBigReminder;
        private System.Windows.Forms.Button btnMoveReminder;
    }
}
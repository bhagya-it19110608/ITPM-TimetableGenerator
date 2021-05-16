
namespace Member3
{
    partial class FormAddNotAvailableTimeOfLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNotAvailableTimeOfLecturer));
            this.buttonLecturerConsecutive = new System.Windows.Forms.Button();
            this.buttonLecturerNonOverlapping = new System.Windows.Forms.Button();
            this.buttonLecturerNotAvailableTimes = new System.Windows.Forms.Button();
            this.panelContentLecturerContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonLecturerConsecutive
            // 
            this.buttonLecturerConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonLecturerConsecutive.FlatAppearance.BorderSize = 0;
            this.buttonLecturerConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLecturerConsecutive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturerConsecutive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonLecturerConsecutive.Location = new System.Drawing.Point(0, 1);
            this.buttonLecturerConsecutive.Name = "buttonLecturerConsecutive";
            this.buttonLecturerConsecutive.Size = new System.Drawing.Size(200, 47);
            this.buttonLecturerConsecutive.TabIndex = 1;
            this.buttonLecturerConsecutive.Text = "Consecutive";
            this.buttonLecturerConsecutive.UseVisualStyleBackColor = false;
            // 
            // buttonLecturerNonOverlapping
            // 
            this.buttonLecturerNonOverlapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonLecturerNonOverlapping.FlatAppearance.BorderSize = 0;
            this.buttonLecturerNonOverlapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLecturerNonOverlapping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturerNonOverlapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonLecturerNonOverlapping.Location = new System.Drawing.Point(217, 1);
            this.buttonLecturerNonOverlapping.Name = "buttonLecturerNonOverlapping";
            this.buttonLecturerNonOverlapping.Size = new System.Drawing.Size(200, 47);
            this.buttonLecturerNonOverlapping.TabIndex = 2;
            this.buttonLecturerNonOverlapping.Text = "Non Overlapping";
            this.buttonLecturerNonOverlapping.UseVisualStyleBackColor = false;
            // 
            // buttonLecturerNotAvailableTimes
            // 
            this.buttonLecturerNotAvailableTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonLecturerNotAvailableTimes.FlatAppearance.BorderSize = 0;
            this.buttonLecturerNotAvailableTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLecturerNotAvailableTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturerNotAvailableTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonLecturerNotAvailableTimes.Location = new System.Drawing.Point(435, 1);
            this.buttonLecturerNotAvailableTimes.Name = "buttonLecturerNotAvailableTimes";
            this.buttonLecturerNotAvailableTimes.Size = new System.Drawing.Size(200, 47);
            this.buttonLecturerNotAvailableTimes.TabIndex = 3;
            this.buttonLecturerNotAvailableTimes.Text = "Not Avaiable Times";
            this.buttonLecturerNotAvailableTimes.UseVisualStyleBackColor = false;
            this.buttonLecturerNotAvailableTimes.Click += new System.EventHandler(this.buttonLecturerNotAvailableTimes_Click);
            // 
            // panelContentLecturerContent
            // 
            this.panelContentLecturerContent.Location = new System.Drawing.Point(38, 78);
            this.panelContentLecturerContent.Name = "panelContentLecturerContent";
            this.panelContentLecturerContent.Size = new System.Drawing.Size(1097, 463);
            this.panelContentLecturerContent.TabIndex = 4;
            // 
            // FormAddNotAvailableTimeOfLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.panelContentLecturerContent);
            this.Controls.Add(this.buttonLecturerNotAvailableTimes);
            this.Controls.Add(this.buttonLecturerNonOverlapping);
            this.Controls.Add(this.buttonLecturerConsecutive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddNotAvailableTimeOfLecturer";
            this.Text = "FormAddNotAvailableTimeOfLecturer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLecturerConsecutive;
        private System.Windows.Forms.Button buttonLecturerNonOverlapping;
        private System.Windows.Forms.Button buttonLecturerNotAvailableTimes;
        private System.Windows.Forms.Panel panelContentLecturerContent;
    }
}
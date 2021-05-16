
namespace Member3
{
    partial class FormSessionExtend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSessionExtend));
            this.panelContentSessionContent = new System.Windows.Forms.Panel();
            this.buttonSessionNotAvailableTimes = new System.Windows.Forms.Button();
            this.buttonSessionNonOverlapping = new System.Windows.Forms.Button();
            this.buttonSessionConsecutive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContentSessionContent
            // 
            this.panelContentSessionContent.BackColor = System.Drawing.Color.White;
            this.panelContentSessionContent.Location = new System.Drawing.Point(40, 52);
            this.panelContentSessionContent.Name = "panelContentSessionContent";
            this.panelContentSessionContent.Size = new System.Drawing.Size(1142, 487);
            this.panelContentSessionContent.TabIndex = 8;
            // 
            // buttonSessionNotAvailableTimes
            // 
            this.buttonSessionNotAvailableTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonSessionNotAvailableTimes.FlatAppearance.BorderSize = 0;
            this.buttonSessionNotAvailableTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionNotAvailableTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionNotAvailableTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonSessionNotAvailableTimes.Location = new System.Drawing.Point(433, 1);
            this.buttonSessionNotAvailableTimes.Name = "buttonSessionNotAvailableTimes";
            this.buttonSessionNotAvailableTimes.Size = new System.Drawing.Size(200, 47);
            this.buttonSessionNotAvailableTimes.TabIndex = 7;
            this.buttonSessionNotAvailableTimes.Text = "Not Avaiable Times";
            this.buttonSessionNotAvailableTimes.UseVisualStyleBackColor = false;
            this.buttonSessionNotAvailableTimes.Click += new System.EventHandler(this.buttonSessionNotAvailableTimes_Click);
            // 
            // buttonSessionNonOverlapping
            // 
            this.buttonSessionNonOverlapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonSessionNonOverlapping.FlatAppearance.BorderSize = 0;
            this.buttonSessionNonOverlapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionNonOverlapping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionNonOverlapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonSessionNonOverlapping.Location = new System.Drawing.Point(217, 1);
            this.buttonSessionNonOverlapping.Name = "buttonSessionNonOverlapping";
            this.buttonSessionNonOverlapping.Size = new System.Drawing.Size(200, 47);
            this.buttonSessionNonOverlapping.TabIndex = 6;
            this.buttonSessionNonOverlapping.Text = "Non Overlapping";
            this.buttonSessionNonOverlapping.UseVisualStyleBackColor = false;
            // 
            // buttonSessionConsecutive
            // 
            this.buttonSessionConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonSessionConsecutive.FlatAppearance.BorderSize = 0;
            this.buttonSessionConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionConsecutive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionConsecutive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonSessionConsecutive.Location = new System.Drawing.Point(0, 1);
            this.buttonSessionConsecutive.Name = "buttonSessionConsecutive";
            this.buttonSessionConsecutive.Size = new System.Drawing.Size(200, 47);
            this.buttonSessionConsecutive.TabIndex = 5;
            this.buttonSessionConsecutive.Text = "Consecutive";
            this.buttonSessionConsecutive.UseVisualStyleBackColor = false;
            // 
            // FormSessionExtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.panelContentSessionContent);
            this.Controls.Add(this.buttonSessionNotAvailableTimes);
            this.Controls.Add(this.buttonSessionNonOverlapping);
            this.Controls.Add(this.buttonSessionConsecutive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSessionExtend";
            this.Text = "FormSessionExtend";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContentSessionContent;
        private System.Windows.Forms.Button buttonSessionNotAvailableTimes;
        private System.Windows.Forms.Button buttonSessionNonOverlapping;
        private System.Windows.Forms.Button buttonSessionConsecutive;
    }
}
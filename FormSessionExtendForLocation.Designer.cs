
namespace Member3
{
    partial class FormSessionExtendForLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSessionExtendForLocation));
            this.panelContentLocationSessionContent = new System.Windows.Forms.Panel();
            this.buttonLocationSessionNotAvailableTimes = new System.Windows.Forms.Button();
            this.buttonLocationSessionConsecutive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContentLocationSessionContent
            // 
            this.panelContentLocationSessionContent.BackColor = System.Drawing.Color.White;
            this.panelContentLocationSessionContent.Location = new System.Drawing.Point(40, 51);
            this.panelContentLocationSessionContent.Name = "panelContentLocationSessionContent";
            this.panelContentLocationSessionContent.Size = new System.Drawing.Size(1142, 487);
            this.panelContentLocationSessionContent.TabIndex = 12;
            // 
            // buttonLocationSessionNotAvailableTimes
            // 
            this.buttonLocationSessionNotAvailableTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonLocationSessionNotAvailableTimes.FlatAppearance.BorderSize = 0;
            this.buttonLocationSessionNotAvailableTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocationSessionNotAvailableTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocationSessionNotAvailableTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonLocationSessionNotAvailableTimes.Location = new System.Drawing.Point(217, 0);
            this.buttonLocationSessionNotAvailableTimes.Name = "buttonLocationSessionNotAvailableTimes";
            this.buttonLocationSessionNotAvailableTimes.Size = new System.Drawing.Size(200, 47);
            this.buttonLocationSessionNotAvailableTimes.TabIndex = 11;
            this.buttonLocationSessionNotAvailableTimes.Text = "Not Avaiable Times";
            this.buttonLocationSessionNotAvailableTimes.UseVisualStyleBackColor = false;
            this.buttonLocationSessionNotAvailableTimes.Click += new System.EventHandler(this.buttonLocationSessionNotAvailableTimes_Click);
            // 
            // buttonLocationSessionConsecutive
            // 
            this.buttonLocationSessionConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonLocationSessionConsecutive.FlatAppearance.BorderSize = 0;
            this.buttonLocationSessionConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocationSessionConsecutive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocationSessionConsecutive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.buttonLocationSessionConsecutive.Location = new System.Drawing.Point(0, 0);
            this.buttonLocationSessionConsecutive.Name = "buttonLocationSessionConsecutive";
            this.buttonLocationSessionConsecutive.Size = new System.Drawing.Size(200, 47);
            this.buttonLocationSessionConsecutive.TabIndex = 9;
            this.buttonLocationSessionConsecutive.Text = "Consecutive";
            this.buttonLocationSessionConsecutive.UseVisualStyleBackColor = false;
            // 
            // FormSessionExtendForLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.panelContentLocationSessionContent);
            this.Controls.Add(this.buttonLocationSessionNotAvailableTimes);
            this.Controls.Add(this.buttonLocationSessionConsecutive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSessionExtendForLocation";
            this.Text = "FormSessionExtendForLocation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContentLocationSessionContent;
        private System.Windows.Forms.Button buttonLocationSessionNotAvailableTimes;
        private System.Windows.Forms.Button buttonLocationSessionConsecutive;
    }
}
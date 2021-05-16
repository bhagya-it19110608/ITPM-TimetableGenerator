
namespace Member3
{
    partial class FormContentLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentLecturer));
            this.panelLecturerHeader = new System.Windows.Forms.Panel();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.buttonManageLecturer = new System.Windows.Forms.Button();
            this.buttonAddLecturer = new System.Windows.Forms.Button();
            this.panelLecturer = new System.Windows.Forms.Panel();
            this.panelContentLecturer = new System.Windows.Forms.Panel();
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.panelLecturerHeader.SuspendLayout();
            this.panelLecturer.SuspendLayout();
            this.panelLecturerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLecturerHeader
            // 
            this.panelLecturerHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerHeader.Controls.Add(this.buttonAddSession);
            this.panelLecturerHeader.Controls.Add(this.buttonManageLecturer);
            this.panelLecturerHeader.Controls.Add(this.buttonAddLecturer);
            this.panelLecturerHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLecturerHeader.Location = new System.Drawing.Point(0, 0);
            this.panelLecturerHeader.Name = "panelLecturerHeader";
            this.panelLecturerHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelLecturerHeader.TabIndex = 0;
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonAddSession.FlatAppearance.BorderSize = 0;
            this.buttonAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSession.Location = new System.Drawing.Point(523, 61);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(200, 47);
            this.buttonAddSession.TabIndex = 2;
            this.buttonAddSession.Text = "Add Session";
            this.buttonAddSession.UseVisualStyleBackColor = false;
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // buttonManageLecturer
            // 
            this.buttonManageLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonManageLecturer.FlatAppearance.BorderSize = 0;
            this.buttonManageLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageLecturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageLecturer.Location = new System.Drawing.Point(306, 61);
            this.buttonManageLecturer.Name = "buttonManageLecturer";
            this.buttonManageLecturer.Size = new System.Drawing.Size(200, 47);
            this.buttonManageLecturer.TabIndex = 1;
            this.buttonManageLecturer.Text = "Manage Lecturer";
            this.buttonManageLecturer.UseVisualStyleBackColor = false;
            // 
            // buttonAddLecturer
            // 
            this.buttonAddLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonAddLecturer.FlatAppearance.BorderSize = 0;
            this.buttonAddLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLecturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLecturer.Location = new System.Drawing.Point(89, 61);
            this.buttonAddLecturer.Name = "buttonAddLecturer";
            this.buttonAddLecturer.Size = new System.Drawing.Size(200, 47);
            this.buttonAddLecturer.TabIndex = 0;
            this.buttonAddLecturer.Text = "Add Lecturer";
            this.buttonAddLecturer.UseVisualStyleBackColor = false;
            // 
            // panelLecturer
            // 
            this.panelLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturer.Controls.Add(this.panelContentLecturer);
            this.panelLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturer.Location = new System.Drawing.Point(0, 0);
            this.panelLecturer.Name = "panelLecturer";
            this.panelLecturer.Size = new System.Drawing.Size(1509, 900);
            this.panelLecturer.TabIndex = 2;
            // 
            // panelContentLecturer
            // 
            this.panelContentLecturer.BackColor = System.Drawing.Color.White;
            this.panelContentLecturer.Location = new System.Drawing.Point(89, 0);
            this.panelContentLecturer.Name = "panelContentLecturer";
            this.panelContentLecturer.Size = new System.Drawing.Size(1286, 601);
            this.panelContentLecturer.TabIndex = 1;
            // 
            // panelLecturerContent
            // 
            this.panelLecturerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerContent.Controls.Add(this.panelLecturer);
            this.panelLecturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerContent.Location = new System.Drawing.Point(0, 108);
            this.panelLecturerContent.Name = "panelLecturerContent";
            this.panelLecturerContent.Size = new System.Drawing.Size(1509, 900);
            this.panelLecturerContent.TabIndex = 1;
            this.panelLecturerContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLecturerContent_Paint);
            // 
            // FormContentLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelLecturerContent);
            this.Controls.Add(this.panelLecturerHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContentLecturer";
            this.Text = "FormContentLecturer";
            this.panelLecturerHeader.ResumeLayout(false);
            this.panelLecturer.ResumeLayout(false);
            this.panelLecturerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLecturerHeader;
        private System.Windows.Forms.Button buttonAddLecturer;
        private System.Windows.Forms.Button buttonManageLecturer;
        private System.Windows.Forms.Button buttonAddSession;
        private System.Windows.Forms.Panel panelLecturer;
        private System.Windows.Forms.Panel panelContentLecturer;
        private System.Windows.Forms.Panel panelLecturerContent;
    }
}
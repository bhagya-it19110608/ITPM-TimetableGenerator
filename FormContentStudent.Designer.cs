
namespace Member3
{
    partial class FormContentStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentStudent));
            this.panelStudentHeader = new System.Windows.Forms.Panel();
            this.buttonStudentAddSession = new System.Windows.Forms.Button();
            this.buttonManageStudentGroup = new System.Windows.Forms.Button();
            this.buttonAddStudentGroup = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.panelContentStudent = new System.Windows.Forms.Panel();
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.panelStudentHeader.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelLecturerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStudentHeader
            // 
            this.panelStudentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelStudentHeader.Controls.Add(this.buttonStudentAddSession);
            this.panelStudentHeader.Controls.Add(this.buttonManageStudentGroup);
            this.panelStudentHeader.Controls.Add(this.buttonAddStudentGroup);
            this.panelStudentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentHeader.Location = new System.Drawing.Point(0, 0);
            this.panelStudentHeader.Name = "panelStudentHeader";
            this.panelStudentHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelStudentHeader.TabIndex = 2;
            // 
            // buttonStudentAddSession
            // 
            this.buttonStudentAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonStudentAddSession.FlatAppearance.BorderSize = 0;
            this.buttonStudentAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentAddSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentAddSession.Location = new System.Drawing.Point(523, 61);
            this.buttonStudentAddSession.Name = "buttonStudentAddSession";
            this.buttonStudentAddSession.Size = new System.Drawing.Size(200, 47);
            this.buttonStudentAddSession.TabIndex = 2;
            this.buttonStudentAddSession.Text = "Add Session";
            this.buttonStudentAddSession.UseVisualStyleBackColor = false;
            this.buttonStudentAddSession.Click += new System.EventHandler(this.buttonStudentAddSession_Click);
            // 
            // buttonManageStudentGroup
            // 
            this.buttonManageStudentGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonManageStudentGroup.FlatAppearance.BorderSize = 0;
            this.buttonManageStudentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageStudentGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageStudentGroup.Location = new System.Drawing.Point(306, 61);
            this.buttonManageStudentGroup.Name = "buttonManageStudentGroup";
            this.buttonManageStudentGroup.Size = new System.Drawing.Size(200, 47);
            this.buttonManageStudentGroup.TabIndex = 1;
            this.buttonManageStudentGroup.Text = "Manage Student Group";
            this.buttonManageStudentGroup.UseVisualStyleBackColor = false;
            // 
            // buttonAddStudentGroup
            // 
            this.buttonAddStudentGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonAddStudentGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddStudentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudentGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudentGroup.Location = new System.Drawing.Point(89, 61);
            this.buttonAddStudentGroup.Name = "buttonAddStudentGroup";
            this.buttonAddStudentGroup.Size = new System.Drawing.Size(200, 47);
            this.buttonAddStudentGroup.TabIndex = 0;
            this.buttonAddStudentGroup.Text = "Add Student Group";
            this.buttonAddStudentGroup.UseVisualStyleBackColor = false;
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelStudent.Controls.Add(this.panelContentStudent);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(1509, 1008);
            this.panelStudent.TabIndex = 2;
            // 
            // panelContentStudent
            // 
            this.panelContentStudent.BackColor = System.Drawing.Color.White;
            this.panelContentStudent.Location = new System.Drawing.Point(89, 107);
            this.panelContentStudent.Name = "panelContentStudent";
            this.panelContentStudent.Size = new System.Drawing.Size(1286, 601);
            this.panelContentStudent.TabIndex = 1;
            // 
            // panelLecturerContent
            // 
            this.panelLecturerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerContent.Controls.Add(this.panelStudent);
            this.panelLecturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerContent.Location = new System.Drawing.Point(0, 0);
            this.panelLecturerContent.Name = "panelLecturerContent";
            this.panelLecturerContent.Size = new System.Drawing.Size(1509, 1008);
            this.panelLecturerContent.TabIndex = 3;
            // 
            // FormContentStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelStudentHeader);
            this.Controls.Add(this.panelLecturerContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContentStudent";
            this.Text = "FormContentStudent";
            this.panelStudentHeader.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelLecturerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStudentHeader;
        private System.Windows.Forms.Button buttonStudentAddSession;
        private System.Windows.Forms.Button buttonManageStudentGroup;
        private System.Windows.Forms.Button buttonAddStudentGroup;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panelContentStudent;
        private System.Windows.Forms.Panel panelLecturerContent;
    }
}
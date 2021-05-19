
namespace Member3
{
    partial class FormContentSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentSubject));
            this.panelSubjectHeader = new System.Windows.Forms.Panel();
            this.buttonManageSubject = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.panelSubject = new System.Windows.Forms.Panel();
            this.panelContentSubject = new System.Windows.Forms.Panel();
            this.panelSubjectHeader.SuspendLayout();
            this.panelSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubjectHeader
            // 
            this.panelSubjectHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelSubjectHeader.Controls.Add(this.buttonManageSubject);
            this.panelSubjectHeader.Controls.Add(this.buttonAddSubject);
            this.panelSubjectHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjectHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSubjectHeader.Name = "panelSubjectHeader";
            this.panelSubjectHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelSubjectHeader.TabIndex = 3;
            // 
            // buttonManageSubject
            // 
            this.buttonManageSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonManageSubject.FlatAppearance.BorderSize = 0;
            this.buttonManageSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageSubject.Location = new System.Drawing.Point(306, 61);
            this.buttonManageSubject.Name = "buttonManageSubject";
            this.buttonManageSubject.Size = new System.Drawing.Size(200, 47);
            this.buttonManageSubject.TabIndex = 1;
            this.buttonManageSubject.Text = "Manage Subject";
            this.buttonManageSubject.UseVisualStyleBackColor = false;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonAddSubject.FlatAppearance.BorderSize = 0;
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(89, 61);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(200, 47);
            this.buttonAddSubject.TabIndex = 0;
            this.buttonAddSubject.Text = "Add Subject";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            // 
            // panelSubject
            // 
            this.panelSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelSubject.Controls.Add(this.panelContentSubject);
            this.panelSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubject.Location = new System.Drawing.Point(0, 0);
            this.panelSubject.Name = "panelSubject";
            this.panelSubject.Size = new System.Drawing.Size(1509, 1008);
            this.panelSubject.TabIndex = 4;
            // 
            // panelContentSubject
            // 
            this.panelContentSubject.BackColor = System.Drawing.Color.White;
            this.panelContentSubject.Location = new System.Drawing.Point(89, 105);
            this.panelContentSubject.Name = "panelContentSubject";
            this.panelContentSubject.Size = new System.Drawing.Size(1286, 601);
            this.panelContentSubject.TabIndex = 1;
            // 
            // FormContentSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelSubjectHeader);
            this.Controls.Add(this.panelSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContentSubject";
            this.Text = "FormContentSubject";
            this.panelSubjectHeader.ResumeLayout(false);
            this.panelSubject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubjectHeader;
        private System.Windows.Forms.Button buttonManageSubject;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Panel panelSubject;
        private System.Windows.Forms.Panel panelContentSubject;
    }
}

namespace Member3
{
    partial class FormContentSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentSession));
            this.panelSessionHeader = new System.Windows.Forms.Panel();
            this.buttonSession = new System.Windows.Forms.Button();
            this.buttonSessionManageSession = new System.Windows.Forms.Button();
            this.buttonSessionAddSession = new System.Windows.Forms.Button();
            this.panelSession = new System.Windows.Forms.Panel();
            this.panelContentSession = new System.Windows.Forms.Panel();
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.panelSessionHeader.SuspendLayout();
            this.panelSession.SuspendLayout();
            this.panelLecturerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSessionHeader
            // 
            this.panelSessionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelSessionHeader.Controls.Add(this.buttonSession);
            this.panelSessionHeader.Controls.Add(this.buttonSessionManageSession);
            this.panelSessionHeader.Controls.Add(this.buttonSessionAddSession);
            this.panelSessionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSessionHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSessionHeader.Name = "panelSessionHeader";
            this.panelSessionHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelSessionHeader.TabIndex = 2;
            // 
            // buttonSession
            // 
            this.buttonSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonSession.FlatAppearance.BorderSize = 0;
            this.buttonSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSession.Location = new System.Drawing.Point(523, 61);
            this.buttonSession.Name = "buttonSession";
            this.buttonSession.Size = new System.Drawing.Size(200, 47);
            this.buttonSession.TabIndex = 2;
            this.buttonSession.Text = "Session";
            this.buttonSession.UseVisualStyleBackColor = false;
            this.buttonSession.Click += new System.EventHandler(this.buttonSession_Click);
            // 
            // buttonSessionManageSession
            // 
            this.buttonSessionManageSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonSessionManageSession.FlatAppearance.BorderSize = 0;
            this.buttonSessionManageSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionManageSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionManageSession.Location = new System.Drawing.Point(306, 61);
            this.buttonSessionManageSession.Name = "buttonSessionManageSession";
            this.buttonSessionManageSession.Size = new System.Drawing.Size(200, 47);
            this.buttonSessionManageSession.TabIndex = 1;
            this.buttonSessionManageSession.Text = "Manage Session";
            this.buttonSessionManageSession.UseVisualStyleBackColor = false;
            this.buttonSessionManageSession.Click += new System.EventHandler(this.buttonSessionManageSession_Click);
            // 
            // buttonSessionAddSession
            // 
            this.buttonSessionAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonSessionAddSession.FlatAppearance.BorderSize = 0;
            this.buttonSessionAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionAddSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionAddSession.Location = new System.Drawing.Point(89, 61);
            this.buttonSessionAddSession.Name = "buttonSessionAddSession";
            this.buttonSessionAddSession.Size = new System.Drawing.Size(200, 47);
            this.buttonSessionAddSession.TabIndex = 0;
            this.buttonSessionAddSession.Text = "Add Session";
            this.buttonSessionAddSession.UseVisualStyleBackColor = false;
            this.buttonSessionAddSession.Click += new System.EventHandler(this.buttonSessionAddSession_Click);
            // 
            // panelSession
            // 
            this.panelSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelSession.Controls.Add(this.panelContentSession);
            this.panelSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSession.Location = new System.Drawing.Point(0, 0);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(1509, 1008);
            this.panelSession.TabIndex = 2;
            // 
            // panelContentSession
            // 
            this.panelContentSession.BackColor = System.Drawing.Color.White;
            this.panelContentSession.Location = new System.Drawing.Point(89, 107);
            this.panelContentSession.Name = "panelContentSession";
            this.panelContentSession.Size = new System.Drawing.Size(1286, 601);
            this.panelContentSession.TabIndex = 1;
            // 
            // panelLecturerContent
            // 
            this.panelLecturerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerContent.Controls.Add(this.panelSession);
            this.panelLecturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerContent.Location = new System.Drawing.Point(0, 0);
            this.panelLecturerContent.Name = "panelLecturerContent";
            this.panelLecturerContent.Size = new System.Drawing.Size(1509, 1008);
            this.panelLecturerContent.TabIndex = 3;
            // 
            // FormContentSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelSessionHeader);
            this.Controls.Add(this.panelLecturerContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContentSession";
            this.Text = "FormContentSession";
            this.panelSessionHeader.ResumeLayout(false);
            this.panelSession.ResumeLayout(false);
            this.panelLecturerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSessionHeader;
        private System.Windows.Forms.Button buttonSession;
        private System.Windows.Forms.Button buttonSessionManageSession;
        private System.Windows.Forms.Button buttonSessionAddSession;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.Panel panelLecturerContent;
        private System.Windows.Forms.Panel panelContentSession;
    }
}
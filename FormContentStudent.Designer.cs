
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGID2 = new System.Windows.Forms.TextBox();
            this.txtGID1 = new System.Windows.Forms.TextBox();
            this.ud12 = new System.Windows.Forms.NumericUpDown();
            this.ud11 = new System.Windows.Forms.NumericUpDown();
            this.comboP1 = new System.Windows.Forms.ComboBox();
            this.txtAYS1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.panelStudentHeader.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelContentStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud11)).BeginInit();
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
            this.buttonManageStudentGroup.Click += new System.EventHandler(this.buttonManageStudentGroup_Click);
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
            this.buttonAddStudentGroup.Click += new System.EventHandler(this.buttonAddStudentGroup_Click);
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
            this.panelContentStudent.Controls.Add(this.btnSave);
            this.panelContentStudent.Controls.Add(this.btnClear);
            this.panelContentStudent.Controls.Add(this.btnGenerate);
            this.panelContentStudent.Controls.Add(this.txtGID2);
            this.panelContentStudent.Controls.Add(this.txtGID1);
            this.panelContentStudent.Controls.Add(this.ud12);
            this.panelContentStudent.Controls.Add(this.ud11);
            this.panelContentStudent.Controls.Add(this.comboP1);
            this.panelContentStudent.Controls.Add(this.txtAYS1);
            this.panelContentStudent.Controls.Add(this.label6);
            this.panelContentStudent.Controls.Add(this.label5);
            this.panelContentStudent.Controls.Add(this.label4);
            this.panelContentStudent.Controls.Add(this.label3);
            this.panelContentStudent.Controls.Add(this.label2);
            this.panelContentStudent.Controls.Add(this.label1);
            this.panelContentStudent.Location = new System.Drawing.Point(89, 107);
            this.panelContentStudent.Name = "panelContentStudent";
            this.panelContentStudent.Size = new System.Drawing.Size(1286, 601);
            this.panelContentStudent.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(696, 458);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 50);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(377, 458);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 50);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(797, 261);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(319, 63);
            this.btnGenerate.TabIndex = 27;
            this.btnGenerate.Text = "GENERATE IDs";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtGID2
            // 
            this.txtGID2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtGID2.Location = new System.Drawing.Point(973, 183);
            this.txtGID2.Margin = new System.Windows.Forms.Padding(4);
            this.txtGID2.Name = "txtGID2";
            this.txtGID2.Size = new System.Drawing.Size(160, 22);
            this.txtGID2.TabIndex = 26;
            // 
            // txtGID1
            // 
            this.txtGID1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtGID1.Location = new System.Drawing.Point(973, 96);
            this.txtGID1.Margin = new System.Windows.Forms.Padding(4);
            this.txtGID1.Name = "txtGID1";
            this.txtGID1.Size = new System.Drawing.Size(160, 22);
            this.txtGID1.TabIndex = 25;
            // 
            // ud12
            // 
            this.ud12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ud12.Location = new System.Drawing.Point(460, 340);
            this.ud12.Margin = new System.Windows.Forms.Padding(4);
            this.ud12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud12.Name = "ud12";
            this.ud12.Size = new System.Drawing.Size(261, 22);
            this.ud12.TabIndex = 24;
            this.ud12.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ud11
            // 
            this.ud11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ud11.Location = new System.Drawing.Point(460, 255);
            this.ud11.Margin = new System.Windows.Forms.Padding(4);
            this.ud11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud11.Name = "ud11";
            this.ud11.Size = new System.Drawing.Size(261, 22);
            this.ud11.TabIndex = 23;
            this.ud11.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboP1
            // 
            this.comboP1.AutoCompleteCustomSource.AddRange(new string[] {
            "B.Sc (Hons) Information Technology",
            "B.Sc (Hons) Computer Systems & Network Engineering",
            "B.Sc (Hons) Cuber Security",
            "B.Sc (Hons) Data Science",
            "B.Sc (Hons) Information Systems Egineering",
            "B.Sc (Hons) Interactive Media",
            "B.Sc (Hons) Software Engineering"});
            this.comboP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboP1.FormattingEnabled = true;
            this.comboP1.Items.AddRange(new object[] {
            "B.Sc (Hons) Information Technology",
            "B.Sc (Hons) Network & Systems Engineering",
            "B.Sc (Hons) Cyber Security",
            "B.Sc (Hons) Information Systems Engineering",
            "B.Sc (Hons) Data Science",
            "B.Sc (Hons) Interactive Media",
            "B.Sc (Hons) Software Engineering"});
            this.comboP1.Location = new System.Drawing.Point(460, 177);
            this.comboP1.Margin = new System.Windows.Forms.Padding(4);
            this.comboP1.Name = "comboP1";
            this.comboP1.Size = new System.Drawing.Size(260, 28);
            this.comboP1.TabIndex = 22;
            // 
            // txtAYS1
            // 
            this.txtAYS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtAYS1.Location = new System.Drawing.Point(460, 93);
            this.txtAYS1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAYS1.Name = "txtAYS1";
            this.txtAYS1.Size = new System.Drawing.Size(260, 22);
            this.txtAYS1.TabIndex = 21;
            this.txtAYS1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sub Group ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sub Group Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Group Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Programme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Academic Year Semester";
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
            this.Load += new System.EventHandler(this.FormContentStudent_Load);
            this.panelStudentHeader.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelContentStudent.ResumeLayout(false);
            this.panelContentStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud11)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGID2;
        private System.Windows.Forms.TextBox txtGID1;
        private System.Windows.Forms.NumericUpDown ud12;
        private System.Windows.Forms.NumericUpDown ud11;
        private System.Windows.Forms.ComboBox comboP1;
        private System.Windows.Forms.TextBox txtAYS1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
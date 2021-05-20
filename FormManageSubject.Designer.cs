
namespace Member3
{
    partial class FormManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageSubject));
            this.cmscode = new System.Windows.Forms.TextBox();
            this.bmsupdate = new System.Windows.Forms.Button();
            this.bmsclear = new System.Windows.Forms.Button();
            this.upmsevaluationh = new System.Windows.Forms.DomainUpDown();
            this.upmslabh = new System.Windows.Forms.DomainUpDown();
            this.upmstuteh = new System.Windows.Forms.DomainUpDown();
            this.upmslectureh = new System.Windows.Forms.DomainUpDown();
            this.lmslabh = new System.Windows.Forms.Label();
            this.lmsavaluationh = new System.Windows.Forms.Label();
            this.lmslecturerh = new System.Windows.Forms.Label();
            this.lmstuteh = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cmsname = new System.Windows.Forms.ComboBox();
            this.lmssemester = new System.Windows.Forms.Label();
            this.lmsname = new System.Windows.Forms.Label();
            this.lmscode = new System.Windows.Forms.Label();
            this.cmsyear = new System.Windows.Forms.ComboBox();
            this.lmsyear = new System.Windows.Forms.Label();
            this.subjectdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.subjectdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmscode
            // 
            this.cmscode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmscode.Location = new System.Drawing.Point(262, 460);
            this.cmscode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmscode.Name = "cmscode";
            this.cmscode.Size = new System.Drawing.Size(187, 22);
            this.cmscode.TabIndex = 97;
            // 
            // bmsupdate
            // 
            this.bmsupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.bmsupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bmsupdate.Location = new System.Drawing.Point(778, 347);
            this.bmsupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmsupdate.Name = "bmsupdate";
            this.bmsupdate.Size = new System.Drawing.Size(120, 32);
            this.bmsupdate.TabIndex = 96;
            this.bmsupdate.Text = "UPDATE";
            this.bmsupdate.UseVisualStyleBackColor = false;
            this.bmsupdate.Click += new System.EventHandler(this.bmsupdate_Click);
            // 
            // bmsclear
            // 
            this.bmsclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.bmsclear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bmsclear.Location = new System.Drawing.Point(778, 405);
            this.bmsclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmsclear.Name = "bmsclear";
            this.bmsclear.Size = new System.Drawing.Size(120, 34);
            this.bmsclear.TabIndex = 95;
            this.bmsclear.Text = "CLEAR";
            this.bmsclear.UseVisualStyleBackColor = false;
            this.bmsclear.Click += new System.EventHandler(this.bmsclear_Click);
            // 
            // upmsevaluationh
            // 
            this.upmsevaluationh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.upmsevaluationh.Items.Add("0");
            this.upmsevaluationh.Items.Add("1");
            this.upmsevaluationh.Items.Add("2");
            this.upmsevaluationh.Items.Add("3");
            this.upmsevaluationh.Items.Add("4");
            this.upmsevaluationh.Location = new System.Drawing.Point(693, 459);
            this.upmsevaluationh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upmsevaluationh.Name = "upmsevaluationh";
            this.upmsevaluationh.Size = new System.Drawing.Size(56, 22);
            this.upmsevaluationh.TabIndex = 94;
            // 
            // upmslabh
            // 
            this.upmslabh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.upmslabh.Items.Add("0");
            this.upmslabh.Items.Add("1");
            this.upmslabh.Items.Add("2");
            this.upmslabh.Items.Add("3");
            this.upmslabh.Items.Add("4");
            this.upmslabh.Location = new System.Drawing.Point(693, 405);
            this.upmslabh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upmslabh.Name = "upmslabh";
            this.upmslabh.Size = new System.Drawing.Size(56, 22);
            this.upmslabh.TabIndex = 93;
            // 
            // upmstuteh
            // 
            this.upmstuteh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.upmstuteh.Items.Add("0");
            this.upmstuteh.Items.Add("1");
            this.upmstuteh.Items.Add("2");
            this.upmstuteh.Items.Add("3");
            this.upmstuteh.Items.Add("4");
            this.upmstuteh.Location = new System.Drawing.Point(693, 358);
            this.upmstuteh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upmstuteh.Name = "upmstuteh";
            this.upmstuteh.Size = new System.Drawing.Size(56, 22);
            this.upmstuteh.TabIndex = 92;
            // 
            // upmslectureh
            // 
            this.upmslectureh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.upmslectureh.Items.Add("0");
            this.upmslectureh.Items.Add("1");
            this.upmslectureh.Items.Add("2");
            this.upmslectureh.Items.Add("3");
            this.upmslectureh.Items.Add("4");
            this.upmslectureh.Location = new System.Drawing.Point(693, 298);
            this.upmslectureh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upmslectureh.Name = "upmslectureh";
            this.upmslectureh.Size = new System.Drawing.Size(56, 22);
            this.upmslectureh.TabIndex = 91;
            // 
            // lmslabh
            // 
            this.lmslabh.AutoSize = true;
            this.lmslabh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmslabh.Location = new System.Drawing.Point(523, 401);
            this.lmslabh.Name = "lmslabh";
            this.lmslabh.Size = new System.Drawing.Size(107, 28);
            this.lmslabh.TabIndex = 89;
            this.lmslabh.Text = "Lab Hours";
            // 
            // lmsavaluationh
            // 
            this.lmsavaluationh.AutoSize = true;
            this.lmsavaluationh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmsavaluationh.Location = new System.Drawing.Point(523, 455);
            this.lmsavaluationh.Name = "lmsavaluationh";
            this.lmsavaluationh.Size = new System.Drawing.Size(174, 28);
            this.lmsavaluationh.TabIndex = 90;
            this.lmsavaluationh.Text = "Evaluation Hours";
            // 
            // lmslecturerh
            // 
            this.lmslecturerh.AutoSize = true;
            this.lmslecturerh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmslecturerh.Location = new System.Drawing.Point(523, 294);
            this.lmslecturerh.Name = "lmslecturerh";
            this.lmslecturerh.Size = new System.Drawing.Size(152, 28);
            this.lmslecturerh.TabIndex = 87;
            this.lmslecturerh.Text = "Lecturer Hours";
            // 
            // lmstuteh
            // 
            this.lmstuteh.AutoSize = true;
            this.lmstuteh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmstuteh.Location = new System.Drawing.Point(523, 353);
            this.lmstuteh.Name = "lmstuteh";
            this.lmstuteh.Size = new System.Drawing.Size(148, 28);
            this.lmstuteh.TabIndex = 88;
            this.lmstuteh.Text = "Tuturial Hours";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(396, 357);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 86;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2nd Semester";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(279, 357);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 24);
            this.radioButton2.TabIndex = 85;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1st Semester";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cmsname
            // 
            this.cmsname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmsname.FormattingEnabled = true;
            this.cmsname.Items.AddRange(new object[] {
            "Communication Skills - IT1040",
            "Introduction to Computer Systems - IT1020",
            "Introduction to Programming - IT1010",
            "Mathematics for Computing - IT1030",
            "Engineering Mathematics - IE1010",
            "English for Academic Purpose - IT1080",
            "Infromation System & Data Modeling - IT1090",
            "Network Fundamentals - IE1020",
            "Object Oriented Concepts - IT1050",
            "Internet & Web Technology - IT1100",
            "Software Process Modeling - IT1060",
            "Computer Networks - IT2050",
            "Database Management Systems - IT2040",
            "Object Oriented Programming - IT2030",
            "Operating Systems and System Administration - IT2060",
            "Software Engineering - IT2020",
            "Data Structures & Algorithms - IT2070",
            "Employability Skills Development - IT2100",
            "Information Technology Project - IT2080",
            "Mobile Application Development - IT2010",
            "Probability & Statistics - IT2110",
            "Professional Skills - IT2090"});
            this.cmsname.Location = new System.Drawing.Point(262, 404);
            this.cmsname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmsname.Name = "cmsname";
            this.cmsname.Size = new System.Drawing.Size(187, 24);
            this.cmsname.TabIndex = 84;
            // 
            // lmssemester
            // 
            this.lmssemester.AutoSize = true;
            this.lmssemester.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmssemester.Location = new System.Drawing.Point(106, 354);
            this.lmssemester.Name = "lmssemester";
            this.lmssemester.Size = new System.Drawing.Size(178, 28);
            this.lmssemester.TabIndex = 83;
            this.lmssemester.Text = "Offered Semester";
            // 
            // lmsname
            // 
            this.lmsname.AutoSize = true;
            this.lmsname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmsname.Location = new System.Drawing.Point(106, 404);
            this.lmsname.Name = "lmsname";
            this.lmsname.Size = new System.Drawing.Size(144, 28);
            this.lmsname.TabIndex = 82;
            this.lmsname.Text = "Subject Name";
            // 
            // lmscode
            // 
            this.lmscode.AutoSize = true;
            this.lmscode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmscode.Location = new System.Drawing.Point(106, 455);
            this.lmscode.Name = "lmscode";
            this.lmscode.Size = new System.Drawing.Size(135, 28);
            this.lmscode.TabIndex = 81;
            this.lmscode.Text = "Subject Code";
            // 
            // cmsyear
            // 
            this.cmsyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmsyear.FormattingEnabled = true;
            this.cmsyear.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cmsyear.Location = new System.Drawing.Point(262, 294);
            this.cmsyear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmsyear.Name = "cmsyear";
            this.cmsyear.Size = new System.Drawing.Size(187, 24);
            this.cmsyear.TabIndex = 80;
            // 
            // lmsyear
            // 
            this.lmsyear.AutoSize = true;
            this.lmsyear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmsyear.Location = new System.Drawing.Point(106, 294);
            this.lmsyear.Name = "lmsyear";
            this.lmsyear.Size = new System.Drawing.Size(131, 28);
            this.lmsyear.TabIndex = 79;
            this.lmsyear.Text = "Offered Year";
            // 
            // subjectdataGridView1
            // 
            this.subjectdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectdataGridView1.Location = new System.Drawing.Point(106, 50);
            this.subjectdataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectdataGridView1.Name = "subjectdataGridView1";
            this.subjectdataGridView1.RowHeadersWidth = 51;
            this.subjectdataGridView1.RowTemplate.Height = 29;
            this.subjectdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectdataGridView1.Size = new System.Drawing.Size(792, 176);
            this.subjectdataGridView1.TabIndex = 78;
            this.subjectdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectdataGridView1_CellContentClick);
            // 
            // FormManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 579);
            this.Controls.Add(this.cmscode);
            this.Controls.Add(this.bmsupdate);
            this.Controls.Add(this.bmsclear);
            this.Controls.Add(this.upmsevaluationh);
            this.Controls.Add(this.upmslabh);
            this.Controls.Add(this.upmstuteh);
            this.Controls.Add(this.upmslectureh);
            this.Controls.Add(this.lmslabh);
            this.Controls.Add(this.lmsavaluationh);
            this.Controls.Add(this.lmslecturerh);
            this.Controls.Add(this.lmstuteh);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.cmsname);
            this.Controls.Add(this.lmssemester);
            this.Controls.Add(this.lmsname);
            this.Controls.Add(this.lmscode);
            this.Controls.Add(this.cmsyear);
            this.Controls.Add(this.lmsyear);
            this.Controls.Add(this.subjectdataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageSubject";
            this.Text = "FormManageSubject";
            this.Load += new System.EventHandler(this.FormManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmscode;
        private System.Windows.Forms.Button bmsupdate;
        private System.Windows.Forms.Button bmsclear;
        private System.Windows.Forms.DomainUpDown upmsevaluationh;
        private System.Windows.Forms.DomainUpDown upmslabh;
        private System.Windows.Forms.DomainUpDown upmstuteh;
        private System.Windows.Forms.DomainUpDown upmslectureh;
        private System.Windows.Forms.Label lmslabh;
        private System.Windows.Forms.Label lmsavaluationh;
        private System.Windows.Forms.Label lmslecturerh;
        private System.Windows.Forms.Label lmstuteh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cmsname;
        private System.Windows.Forms.Label lmssemester;
        private System.Windows.Forms.Label lmsname;
        private System.Windows.Forms.Label lmscode;
        private System.Windows.Forms.ComboBox cmsyear;
        private System.Windows.Forms.Label lmsyear;
        private System.Windows.Forms.DataGridView subjectdataGridView1;
    }
}
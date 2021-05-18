
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.comboLecCon = new System.Windows.Forms.ComboBox();
            this.comboTagCon = new System.Windows.Forms.ComboBox();
            this.comboSubjectCon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSessionNotAvailableTimes = new System.Windows.Forms.Button();
            this.buttonSessionNonOverlapping = new System.Windows.Forms.Button();
            this.buttonSessionConsecutive = new System.Windows.Forms.Button();
            this.panelContentSessionContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContentSessionContent
            // 
            this.panelContentSessionContent.BackColor = System.Drawing.Color.White;
            this.panelContentSessionContent.Controls.Add(this.btnView);
            this.panelContentSessionContent.Controls.Add(this.btnAddCon);
            this.panelContentSessionContent.Controls.Add(this.comboLecCon);
            this.panelContentSessionContent.Controls.Add(this.comboTagCon);
            this.panelContentSessionContent.Controls.Add(this.comboSubjectCon);
            this.panelContentSessionContent.Controls.Add(this.label3);
            this.panelContentSessionContent.Controls.Add(this.label2);
            this.panelContentSessionContent.Controls.Add(this.label1);
            this.panelContentSessionContent.Location = new System.Drawing.Point(40, 52);
            this.panelContentSessionContent.Name = "panelContentSessionContent";
            this.panelContentSessionContent.Size = new System.Drawing.Size(1142, 487);
            this.panelContentSessionContent.TabIndex = 8;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(568, 399);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 46);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnAddCon
            // 
            this.btnAddCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnAddCon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCon.Location = new System.Drawing.Point(234, 399);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(215, 46);
            this.btnAddCon.TabIndex = 14;
            this.btnAddCon.Text = "ADD SESSION";
            this.btnAddCon.UseVisualStyleBackColor = false;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // comboLecCon
            // 
            this.comboLecCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboLecCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLecCon.FormattingEnabled = true;
            this.comboLecCon.Items.AddRange(new object[] {
            "Perera A.B",
            "Gunasekara H.I",
            "Jayasooriya N.A",
            "Udawaththa A.K",
            "Wijerathne B.L",
            "Silva S.F"});
            this.comboLecCon.Location = new System.Drawing.Point(385, 258);
            this.comboLecCon.Margin = new System.Windows.Forms.Padding(4);
            this.comboLecCon.Name = "comboLecCon";
            this.comboLecCon.Size = new System.Drawing.Size(388, 28);
            this.comboLecCon.TabIndex = 13;
            // 
            // comboTagCon
            // 
            this.comboTagCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboTagCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTagCon.FormattingEnabled = true;
            this.comboTagCon.Items.AddRange(new object[] {
            "Lecture",
            "Lab",
            "Tutorial"});
            this.comboTagCon.Location = new System.Drawing.Point(385, 148);
            this.comboTagCon.Margin = new System.Windows.Forms.Padding(4);
            this.comboTagCon.Name = "comboTagCon";
            this.comboTagCon.Size = new System.Drawing.Size(388, 28);
            this.comboTagCon.TabIndex = 12;
            // 
            // comboSubjectCon
            // 
            this.comboSubjectCon.AutoCompleteCustomSource.AddRange(new string[] {
            "Communication Skills - IT1040",
            "Introduction to Computer Systems - IT1020",
            "Introduction to Programming - IT1010",
            "Mathematics for Computing - IT1030"});
            this.comboSubjectCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboSubjectCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSubjectCon.FormattingEnabled = true;
            this.comboSubjectCon.Items.AddRange(new object[] {
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
            this.comboSubjectCon.Location = new System.Drawing.Point(385, 42);
            this.comboSubjectCon.Margin = new System.Windows.Forms.Padding(4);
            this.comboSubjectCon.Name = "comboSubjectCon";
            this.comboSubjectCon.Size = new System.Drawing.Size(388, 28);
            this.comboSubjectCon.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Lecturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Subject";
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
            this.buttonSessionNonOverlapping.Click += new System.EventHandler(this.buttonSessionNonOverlapping_Click);
            // 
            // buttonSessionConsecutive
            // 
            this.buttonSessionConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.buttonSessionConsecutive.FlatAppearance.BorderSize = 0;
            this.buttonSessionConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionConsecutive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSessionConsecutive.ForeColor = System.Drawing.Color.Black;
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
            this.Load += new System.EventHandler(this.FormSessionExtend_Load);
            this.panelContentSessionContent.ResumeLayout(false);
            this.panelContentSessionContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContentSessionContent;
        private System.Windows.Forms.Button buttonSessionNotAvailableTimes;
        private System.Windows.Forms.Button buttonSessionNonOverlapping;
        private System.Windows.Forms.Button buttonSessionConsecutive;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.ComboBox comboLecCon;
        private System.Windows.Forms.ComboBox comboTagCon;
        private System.Windows.Forms.ComboBox comboSubjectCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
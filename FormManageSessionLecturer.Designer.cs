
namespace Member3
{
    partial class FormManageSessionLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageSessionLecturer));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpmsession = new System.Windows.Forms.TabPage();
            this.brefresh = new System.Windows.Forms.Button();
            this.searchdrop = new System.Windows.Forms.ComboBox();
            this.btnview = new System.Windows.Forms.Button();
            this.btnaddsession = new System.Windows.Forms.Button();
            this.dataaddmanage = new System.Windows.Forms.DataGridView();
            this.bsearch = new System.Windows.Forms.Button();
            this.tpupdates = new System.Windows.Forms.TabPage();
            this.btnuupdate = new System.Windows.Forms.Button();
            this.btnupdateclear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lupdated = new System.Windows.Forms.Label();
            this.nupdayenos = new System.Windows.Forms.NumericUpDown();
            this.texupdated = new System.Windows.Forms.TextBox();
            this.textupdatesl2 = new System.Windows.Forms.TextBox();
            this.lupdatenos = new System.Windows.Forms.Label();
            this.cupdatesubject = new System.Windows.Forms.ComboBox();
            this.lupdatescode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cupdatesub = new System.Windows.Forms.ComboBox();
            this.cupdatescode = new System.Windows.Forms.ComboBox();
            this.lupdatesubject = new System.Windows.Forms.Label();
            this.cupdatemain = new System.Windows.Forms.ComboBox();
            this.lupdategid = new System.Windows.Forms.Label();
            this.cupdatetag = new System.Windows.Forms.ComboBox();
            this.lupdatesl2 = new System.Windows.Forms.Label();
            this.lupdatetag = new System.Windows.Forms.Label();
            this.cupdatesl1 = new System.Windows.Forms.ComboBox();
            this.lupdatesl1 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tpmsession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaddmanage)).BeginInit();
            this.tpupdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdayenos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpmsession);
            this.tabControl2.Controls.Add(this.tpupdates);
            this.tabControl2.Location = new System.Drawing.Point(-1, -2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1142, 558);
            this.tabControl2.TabIndex = 1;
            // 
            // tpmsession
            // 
            this.tpmsession.Controls.Add(this.brefresh);
            this.tpmsession.Controls.Add(this.searchdrop);
            this.tpmsession.Controls.Add(this.btnview);
            this.tpmsession.Controls.Add(this.btnaddsession);
            this.tpmsession.Controls.Add(this.dataaddmanage);
            this.tpmsession.Controls.Add(this.bsearch);
            this.tpmsession.Location = new System.Drawing.Point(4, 25);
            this.tpmsession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpmsession.Name = "tpmsession";
            this.tpmsession.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpmsession.Size = new System.Drawing.Size(1134, 529);
            this.tpmsession.TabIndex = 0;
            this.tpmsession.Text = "Manage Session";
            this.tpmsession.UseVisualStyleBackColor = true;
            // 
            // brefresh
            // 
            this.brefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.brefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.brefresh.Image = global::Member3.Properties.Resources.refresh_btn;
            this.brefresh.Location = new System.Drawing.Point(651, 33);
            this.brefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(47, 34);
            this.brefresh.TabIndex = 74;
            this.brefresh.UseVisualStyleBackColor = false;
            this.brefresh.Click += new System.EventHandler(this.brefresh_Click);
            // 
            // searchdrop
            // 
            this.searchdrop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchdrop.FormattingEnabled = true;
            this.searchdrop.Items.AddRange(new object[] {
            "Mr.Pitigala",
            "Dr.Anuradha",
            "Mr.Kodagoda",
            "Miss.Weerasinghe",
            "Prof.Perera",
            "Dr.Ramanadan"});
            this.searchdrop.Location = new System.Drawing.Point(160, 40);
            this.searchdrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchdrop.Name = "searchdrop";
            this.searchdrop.Size = new System.Drawing.Size(321, 24);
            this.searchdrop.TabIndex = 73;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnview.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnview.Location = new System.Drawing.Point(459, 362);
            this.btnview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(139, 27);
            this.btnview.TabIndex = 72;
            this.btnview.Text = "VIEW";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnaddsession
            // 
            this.btnaddsession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnaddsession.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnaddsession.Location = new System.Drawing.Point(190, 362);
            this.btnaddsession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddsession.Name = "btnaddsession";
            this.btnaddsession.Size = new System.Drawing.Size(139, 27);
            this.btnaddsession.TabIndex = 71;
            this.btnaddsession.Text = "ADD SESSION";
            this.btnaddsession.UseVisualStyleBackColor = false;
            this.btnaddsession.Click += new System.EventHandler(this.btnaddsession_Click);
            // 
            // dataaddmanage
            // 
            this.dataaddmanage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataaddmanage.Location = new System.Drawing.Point(52, 119);
            this.dataaddmanage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataaddmanage.Name = "dataaddmanage";
            this.dataaddmanage.RowHeadersWidth = 51;
            this.dataaddmanage.RowTemplate.Height = 29;
            this.dataaddmanage.Size = new System.Drawing.Size(718, 197);
            this.dataaddmanage.TabIndex = 70;
            this.dataaddmanage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataaddmanage_CellContentClick);
            // 
            // bsearch
            // 
            this.bsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.bsearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bsearch.Location = new System.Drawing.Point(501, 37);
            this.bsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(139, 27);
            this.bsearch.TabIndex = 37;
            this.bsearch.Text = "SEARCH";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // tpupdates
            // 
            this.tpupdates.Controls.Add(this.btnuupdate);
            this.tpupdates.Controls.Add(this.btnupdateclear);
            this.tpupdates.Controls.Add(this.label11);
            this.tpupdates.Controls.Add(this.lupdated);
            this.tpupdates.Controls.Add(this.nupdayenos);
            this.tpupdates.Controls.Add(this.texupdated);
            this.tpupdates.Controls.Add(this.textupdatesl2);
            this.tpupdates.Controls.Add(this.lupdatenos);
            this.tpupdates.Controls.Add(this.cupdatesubject);
            this.tpupdates.Controls.Add(this.lupdatescode);
            this.tpupdates.Controls.Add(this.label5);
            this.tpupdates.Controls.Add(this.label6);
            this.tpupdates.Controls.Add(this.cupdatesub);
            this.tpupdates.Controls.Add(this.cupdatescode);
            this.tpupdates.Controls.Add(this.lupdatesubject);
            this.tpupdates.Controls.Add(this.cupdatemain);
            this.tpupdates.Controls.Add(this.lupdategid);
            this.tpupdates.Controls.Add(this.cupdatetag);
            this.tpupdates.Controls.Add(this.lupdatesl2);
            this.tpupdates.Controls.Add(this.lupdatetag);
            this.tpupdates.Controls.Add(this.cupdatesl1);
            this.tpupdates.Controls.Add(this.lupdatesl1);
            this.tpupdates.Location = new System.Drawing.Point(4, 25);
            this.tpupdates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpupdates.Name = "tpupdates";
            this.tpupdates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpupdates.Size = new System.Drawing.Size(1134, 529);
            this.tpupdates.TabIndex = 1;
            this.tpupdates.Text = "Update Session";
            this.tpupdates.UseVisualStyleBackColor = true;
            // 
            // btnuupdate
            // 
            this.btnuupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.btnuupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnuupdate.Location = new System.Drawing.Point(466, 363);
            this.btnuupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuupdate.Name = "btnuupdate";
            this.btnuupdate.Size = new System.Drawing.Size(139, 32);
            this.btnuupdate.TabIndex = 58;
            this.btnuupdate.Text = "UPDATE";
            this.btnuupdate.UseVisualStyleBackColor = false;
            this.btnuupdate.Click += new System.EventHandler(this.btnuupdate_Click);
            // 
            // btnupdateclear
            // 
            this.btnupdateclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.btnupdateclear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnupdateclear.Location = new System.Drawing.Point(256, 363);
            this.btnupdateclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdateclear.Name = "btnupdateclear";
            this.btnupdateclear.Size = new System.Drawing.Size(139, 32);
            this.btnupdateclear.TabIndex = 57;
            this.btnupdateclear.Text = "CLEAR";
            this.btnupdateclear.UseVisualStyleBackColor = false;
            this.btnupdateclear.Click += new System.EventHandler(this.btnupdateclear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(758, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Hrs";
            // 
            // lupdated
            // 
            this.lupdated.AutoSize = true;
            this.lupdated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdated.Location = new System.Drawing.Point(466, 274);
            this.lupdated.Name = "lupdated";
            this.lupdated.Size = new System.Drawing.Size(96, 28);
            this.lupdated.TabIndex = 55;
            this.lupdated.Text = "Duration";
            // 
            // nupdayenos
            // 
            this.nupdayenos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nupdayenos.Location = new System.Drawing.Point(667, 226);
            this.nupdayenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupdayenos.Name = "nupdayenos";
            this.nupdayenos.Size = new System.Drawing.Size(91, 22);
            this.nupdayenos.TabIndex = 54;
            // 
            // texupdated
            // 
            this.texupdated.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.texupdated.Location = new System.Drawing.Point(647, 274);
            this.texupdated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texupdated.Name = "texupdated";
            this.texupdated.Size = new System.Drawing.Size(91, 22);
            this.texupdated.TabIndex = 53;
            // 
            // textupdatesl2
            // 
            this.textupdatesl2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textupdatesl2.Location = new System.Drawing.Point(256, 114);
            this.textupdatesl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdatesl2.Name = "textupdatesl2";
            this.textupdatesl2.Size = new System.Drawing.Size(481, 22);
            this.textupdatesl2.TabIndex = 12;
            // 
            // lupdatenos
            // 
            this.lupdatenos.AutoSize = true;
            this.lupdatenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatenos.Location = new System.Drawing.Point(460, 222);
            this.lupdatenos.Name = "lupdatenos";
            this.lupdatenos.Size = new System.Drawing.Size(204, 28);
            this.lupdatenos.TabIndex = 52;
            this.lupdatenos.Text = "Number of Students";
            // 
            // cupdatesubject
            // 
            this.cupdatesubject.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatesubject.FormattingEnabled = true;
            this.cupdatesubject.Items.AddRange(new object[] {
            "Computer Network",
            "Database System",
            "IT Project",
            "Propobility & Stastics",
            "Software Engineering",
            "Object Oriented Programming"});
            this.cupdatesubject.Location = new System.Drawing.Point(256, 298);
            this.cupdatesubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatesubject.Name = "cupdatesubject";
            this.cupdatesubject.Size = new System.Drawing.Size(151, 24);
            this.cupdatesubject.TabIndex = 51;
            // 
            // lupdatescode
            // 
            this.lupdatescode.AutoSize = true;
            this.lupdatescode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatescode.Location = new System.Drawing.Point(57, 238);
            this.lupdatescode.Name = "lupdatescode";
            this.lupdatescode.Size = new System.Drawing.Size(198, 28);
            this.lupdatescode.TabIndex = 50;
            this.lupdatescode.Text = "Select Subject Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(386, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Sub";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(266, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Main";
            // 
            // cupdatesub
            // 
            this.cupdatesub.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatesub.FormattingEnabled = true;
            this.cupdatesub.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cupdatesub.Location = new System.Drawing.Point(368, 186);
            this.cupdatesub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatesub.Name = "cupdatesub";
            this.cupdatesub.Size = new System.Drawing.Size(77, 24);
            this.cupdatesub.TabIndex = 47;
            // 
            // cupdatescode
            // 
            this.cupdatescode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatescode.FormattingEnabled = true;
            this.cupdatescode.Items.AddRange(new object[] {
            "IT1020",
            "IT1030",
            "IT2020",
            "IT2060",
            "IT3020",
            "IT4050"});
            this.cupdatescode.Location = new System.Drawing.Point(256, 238);
            this.cupdatescode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatescode.Name = "cupdatescode";
            this.cupdatescode.Size = new System.Drawing.Size(151, 24);
            this.cupdatescode.TabIndex = 46;
            // 
            // lupdatesubject
            // 
            this.lupdatesubject.AutoSize = true;
            this.lupdatesubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatesubject.Location = new System.Drawing.Point(57, 295);
            this.lupdatesubject.Name = "lupdatesubject";
            this.lupdatesubject.Size = new System.Drawing.Size(145, 28);
            this.lupdatesubject.TabIndex = 45;
            this.lupdatesubject.Text = "Select Subject";
            // 
            // cupdatemain
            // 
            this.cupdatemain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatemain.FormattingEnabled = true;
            this.cupdatemain.Items.AddRange(new object[] {
            "Y1S1G1",
            "Y1S1G2",
            "Y1S1G3",
            "Y1S2G1",
            "Y1S2G2",
            "Y1S2G3",
            "Y2S1G1",
            "Y2S1G2",
            "Y2S2G1",
            "Y2S2G2",
            "Y2S1G1",
            "Y3S1G1",
            "Y3S1G2",
            "Y3S2G1",
            "Y3S2G2"});
            this.cupdatemain.Location = new System.Drawing.Point(256, 186);
            this.cupdatemain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatemain.Name = "cupdatemain";
            this.cupdatemain.Size = new System.Drawing.Size(77, 24);
            this.cupdatemain.TabIndex = 44;
            // 
            // lupdategid
            // 
            this.lupdategid.AutoSize = true;
            this.lupdategid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdategid.Location = new System.Drawing.Point(57, 182);
            this.lupdategid.Name = "lupdategid";
            this.lupdategid.Size = new System.Drawing.Size(160, 28);
            this.lupdategid.TabIndex = 43;
            this.lupdategid.Text = "Select Group ID";
            // 
            // cupdatetag
            // 
            this.cupdatetag.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatetag.FormattingEnabled = true;
            this.cupdatetag.Items.AddRange(new object[] {
            "",
            "Lecture",
            "Tutorial",
            "Lab",
            "Evaluation"});
            this.cupdatetag.Location = new System.Drawing.Point(586, 50);
            this.cupdatetag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatetag.Name = "cupdatetag";
            this.cupdatetag.Size = new System.Drawing.Size(151, 24);
            this.cupdatetag.TabIndex = 11;
            // 
            // lupdatesl2
            // 
            this.lupdatesl2.AutoSize = true;
            this.lupdatesl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatesl2.Location = new System.Drawing.Point(56, 114);
            this.lupdatesl2.Name = "lupdatesl2";
            this.lupdatesl2.Size = new System.Drawing.Size(199, 28);
            this.lupdatesl2.TabIndex = 10;
            this.lupdatesl2.Text = "Selected Lecturer(s)";
            // 
            // lupdatetag
            // 
            this.lupdatetag.AutoSize = true;
            this.lupdatetag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatetag.Location = new System.Drawing.Point(460, 46);
            this.lupdatetag.Name = "lupdatetag";
            this.lupdatetag.Size = new System.Drawing.Size(108, 28);
            this.lupdatetag.TabIndex = 9;
            this.lupdatetag.Text = "Select Tag";
            // 
            // cupdatesl1
            // 
            this.cupdatesl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cupdatesl1.FormattingEnabled = true;
            this.cupdatesl1.Items.AddRange(new object[] {
            "Mr.Pitigala",
            "Dr.Anuradha",
            "Mr.Kodagoda",
            "Miss.Weerasinghe",
            "Prof.Perera",
            "Dr.Ramanadan"});
            this.cupdatesl1.Location = new System.Drawing.Point(256, 46);
            this.cupdatesl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cupdatesl1.Name = "cupdatesl1";
            this.cupdatesl1.Size = new System.Drawing.Size(151, 24);
            this.cupdatesl1.TabIndex = 8;
            // 
            // lupdatesl1
            // 
            this.lupdatesl1.AutoSize = true;
            this.lupdatesl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lupdatesl1.Location = new System.Drawing.Point(57, 43);
            this.lupdatesl1.Name = "lupdatesl1";
            this.lupdatesl1.Size = new System.Drawing.Size(176, 28);
            this.lupdatesl1.TabIndex = 7;
            this.lupdatesl1.Text = "Select Lecturer(s)";
            // 
            // FormManageSessionLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 556);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageSessionLecturer";
            this.Text = "FormManageSessionLecturer";
            this.Load += new System.EventHandler(this.FormManageSessionLecturer_Load);
            this.tabControl2.ResumeLayout(false);
            this.tpmsession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataaddmanage)).EndInit();
            this.tpupdates.ResumeLayout(false);
            this.tpupdates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdayenos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpmsession;
        private System.Windows.Forms.Button brefresh;
        private System.Windows.Forms.ComboBox searchdrop;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnaddsession;
        private System.Windows.Forms.DataGridView dataaddmanage;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.TabPage tpupdates;
        private System.Windows.Forms.Button btnuupdate;
        private System.Windows.Forms.Button btnupdateclear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lupdated;
        private System.Windows.Forms.NumericUpDown nupdayenos;
        private System.Windows.Forms.TextBox texupdated;
        private System.Windows.Forms.TextBox textupdatesl2;
        private System.Windows.Forms.Label lupdatenos;
        private System.Windows.Forms.ComboBox cupdatesubject;
        private System.Windows.Forms.Label lupdatescode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cupdatesub;
        private System.Windows.Forms.ComboBox cupdatescode;
        private System.Windows.Forms.Label lupdatesubject;
        private System.Windows.Forms.ComboBox cupdatemain;
        private System.Windows.Forms.Label lupdategid;
        private System.Windows.Forms.ComboBox cupdatetag;
        private System.Windows.Forms.Label lupdatesl2;
        private System.Windows.Forms.Label lupdatetag;
        private System.Windows.Forms.ComboBox cupdatesl1;
        private System.Windows.Forms.Label lupdatesl1;
    }
}
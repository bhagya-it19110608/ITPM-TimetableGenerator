
namespace Member3
{
    partial class FormManageLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageLecturer));
            this.button9 = new System.Windows.Forms.Button();
            this.bmledithours = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmlto = new System.Windows.Forms.ComboBox();
            this.cmlfrom = new System.Windows.Forms.ComboBox();
            this.cmlday = new System.Windows.Forms.ComboBox();
            this.lmlday = new System.Windows.Forms.Label();
            this.lmlfrom = new System.Windows.Forms.Label();
            this.lmlto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bmlupdate = new System.Windows.Forms.Button();
            this.bmlclear = new System.Windows.Forms.Button();
            this.tmlrank = new System.Windows.Forms.TextBox();
            this.cmlbuilding = new System.Windows.Forms.ComboBox();
            this.cmllevel = new System.Windows.Forms.ComboBox();
            this.lmlrank = new System.Windows.Forms.Label();
            this.lmllevel = new System.Windows.Forms.Label();
            this.lmlbuilding = new System.Windows.Forms.Label();
            this.cmlcenter = new System.Windows.Forms.ComboBox();
            this.lmlcenter = new System.Windows.Forms.Label();
            this.cmldepartment = new System.Windows.Forms.ComboBox();
            this.cmlfaculty = new System.Windows.Forms.ComboBox();
            this.tmlid = new System.Windows.Forms.TextBox();
            this.lmldepartment = new System.Windows.Forms.Label();
            this.lmlfaculty = new System.Windows.Forms.Label();
            this.lmlid = new System.Windows.Forms.Label();
            this.tmlname = new System.Windows.Forms.TextBox();
            this.lmlname = new System.Windows.Forms.Label();
            this.gridmanagelectrer = new System.Windows.Forms.DataGridView();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmanagelectrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Location = new System.Drawing.Point(800, 329);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 25);
            this.button9.TabIndex = 97;
            this.button9.Text = "Genarate Rank";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bmledithours
            // 
            this.bmledithours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.bmledithours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bmledithours.Location = new System.Drawing.Point(748, 492);
            this.bmledithours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmledithours.Name = "bmledithours";
            this.bmledithours.Size = new System.Drawing.Size(139, 32);
            this.bmledithours.TabIndex = 96;
            this.bmledithours.Text = "Edit HOURS";
            this.bmledithours.UseVisualStyleBackColor = false;
            this.bmledithours.Click += new System.EventHandler(this.bmledithours_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(85, 412);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(461, 149);
            this.dataGridView2.TabIndex = 95;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cmlto
            // 
            this.cmlto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlto.FormattingEnabled = true;
            this.cmlto.Items.AddRange(new object[] {
            "1.00 p.m",
            "5.00 p.m ",
            "8.00 p.m"});
            this.cmlto.Location = new System.Drawing.Point(715, 465);
            this.cmlto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlto.Name = "cmlto";
            this.cmlto.Size = new System.Drawing.Size(187, 24);
            this.cmlto.TabIndex = 94;
            // 
            // cmlfrom
            // 
            this.cmlfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlfrom.FormattingEnabled = true;
            this.cmlfrom.Items.AddRange(new object[] {
            "8.00 a.m",
            "1.00 p.m",
            "5.00 p.m"});
            this.cmlfrom.Location = new System.Drawing.Point(715, 430);
            this.cmlfrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlfrom.Name = "cmlfrom";
            this.cmlfrom.Size = new System.Drawing.Size(187, 24);
            this.cmlfrom.TabIndex = 93;
            // 
            // cmlday
            // 
            this.cmlday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlday.FormattingEnabled = true;
            this.cmlday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmlday.Location = new System.Drawing.Point(715, 395);
            this.cmlday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlday.Name = "cmlday";
            this.cmlday.Size = new System.Drawing.Size(187, 24);
            this.cmlday.TabIndex = 92;
            // 
            // lmlday
            // 
            this.lmlday.AutoSize = true;
            this.lmlday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlday.Location = new System.Drawing.Point(564, 392);
            this.lmlday.Name = "lmlday";
            this.lmlday.Size = new System.Drawing.Size(112, 28);
            this.lmlday.TabIndex = 91;
            this.lmlday.Text = "Select Day";
            // 
            // lmlfrom
            // 
            this.lmlfrom.AutoSize = true;
            this.lmlfrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlfrom.Location = new System.Drawing.Point(564, 426);
            this.lmlfrom.Name = "lmlfrom";
            this.lmlfrom.Size = new System.Drawing.Size(122, 28);
            this.lmlfrom.TabIndex = 90;
            this.lmlfrom.Text = "Hours From";
            // 
            // lmlto
            // 
            this.lmlto.AutoSize = true;
            this.lmlto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlto.Location = new System.Drawing.Point(564, 462);
            this.lmlto.Name = "lmlto";
            this.lmlto.Size = new System.Drawing.Size(34, 28);
            this.lmlto.TabIndex = 89;
            this.lmlto.Text = "To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(85, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 28);
            this.label12.TabIndex = 88;
            this.label12.Text = "Available Hours";
            // 
            // bmlupdate
            // 
            this.bmlupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.bmlupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bmlupdate.Location = new System.Drawing.Point(800, 211);
            this.bmlupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmlupdate.Name = "bmlupdate";
            this.bmlupdate.Size = new System.Drawing.Size(120, 32);
            this.bmlupdate.TabIndex = 87;
            this.bmlupdate.Text = "UPDATE";
            this.bmlupdate.UseVisualStyleBackColor = false;
            this.bmlupdate.Click += new System.EventHandler(this.bmlupdate_Click);
            // 
            // bmlclear
            // 
            this.bmlclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.bmlclear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bmlclear.Location = new System.Drawing.Point(800, 269);
            this.bmlclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmlclear.Name = "bmlclear";
            this.bmlclear.Size = new System.Drawing.Size(120, 34);
            this.bmlclear.TabIndex = 86;
            this.bmlclear.Text = "CLEAR";
            this.bmlclear.UseVisualStyleBackColor = false;
            this.bmlclear.Click += new System.EventHandler(this.bmlclear_Click);
            // 
            // tmlrank
            // 
            this.tmlrank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tmlrank.Location = new System.Drawing.Point(564, 322);
            this.tmlrank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmlrank.Name = "tmlrank";
            this.tmlrank.Size = new System.Drawing.Size(164, 22);
            this.tmlrank.TabIndex = 85;
            // 
            // cmlbuilding
            // 
            this.cmlbuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlbuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlbuilding.FormattingEnabled = true;
            this.cmlbuilding.Items.AddRange(new object[] {
            "New Building",
            "Engineering Building",
            "Management Building",
            "Main Building"});
            this.cmlbuilding.Location = new System.Drawing.Point(564, 248);
            this.cmlbuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlbuilding.Name = "cmlbuilding";
            this.cmlbuilding.Size = new System.Drawing.Size(164, 24);
            this.cmlbuilding.TabIndex = 84;
            // 
            // cmllevel
            // 
            this.cmllevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmllevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmllevel.FormattingEnabled = true;
            this.cmllevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmllevel.Location = new System.Drawing.Point(564, 286);
            this.cmllevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmllevel.Name = "cmllevel";
            this.cmllevel.Size = new System.Drawing.Size(164, 24);
            this.cmllevel.TabIndex = 83;
            // 
            // lmlrank
            // 
            this.lmlrank.AutoSize = true;
            this.lmlrank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlrank.Location = new System.Drawing.Point(440, 318);
            this.lmlrank.Name = "lmlrank";
            this.lmlrank.Size = new System.Drawing.Size(59, 28);
            this.lmlrank.TabIndex = 82;
            this.lmlrank.Text = "Rank";
            // 
            // lmllevel
            // 
            this.lmllevel.AutoSize = true;
            this.lmllevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmllevel.Location = new System.Drawing.Point(440, 286);
            this.lmllevel.Name = "lmllevel";
            this.lmllevel.Size = new System.Drawing.Size(61, 28);
            this.lmllevel.TabIndex = 81;
            this.lmllevel.Text = "Level";
            // 
            // lmlbuilding
            // 
            this.lmlbuilding.AutoSize = true;
            this.lmlbuilding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlbuilding.Location = new System.Drawing.Point(440, 245);
            this.lmlbuilding.Name = "lmlbuilding";
            this.lmlbuilding.Size = new System.Drawing.Size(91, 28);
            this.lmlbuilding.TabIndex = 80;
            this.lmlbuilding.Text = "Building";
            // 
            // cmlcenter
            // 
            this.cmlcenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlcenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlcenter.FormattingEnabled = true;
            this.cmlcenter.Items.AddRange(new object[] {
            "Colombo",
            "Matara",
            "Kandy",
            "Jaffna"});
            this.cmlcenter.Location = new System.Drawing.Point(564, 211);
            this.cmlcenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlcenter.Name = "cmlcenter";
            this.cmlcenter.Size = new System.Drawing.Size(164, 24);
            this.cmlcenter.TabIndex = 79;
            // 
            // lmlcenter
            // 
            this.lmlcenter.AutoSize = true;
            this.lmlcenter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlcenter.Location = new System.Drawing.Point(440, 208);
            this.lmlcenter.Name = "lmlcenter";
            this.lmlcenter.Size = new System.Drawing.Size(74, 28);
            this.lmlcenter.TabIndex = 78;
            this.lmlcenter.Text = "Center";
            // 
            // cmldepartment
            // 
            this.cmldepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmldepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmldepartment.FormattingEnabled = true;
            this.cmldepartment.Items.AddRange(new object[] {
            "Software Engineering",
            "Information Thechnology",
            "Computer System Engineering",
            "Business Managment",
            "Quantity Surveying"});
            this.cmldepartment.Location = new System.Drawing.Point(255, 318);
            this.cmldepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmldepartment.Name = "cmldepartment";
            this.cmldepartment.Size = new System.Drawing.Size(161, 24);
            this.cmldepartment.TabIndex = 77;
            // 
            // cmlfaculty
            // 
            this.cmlfaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmlfaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlfaculty.FormattingEnabled = true;
            this.cmlfaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Management"});
            this.cmlfaculty.Location = new System.Drawing.Point(255, 286);
            this.cmlfaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmlfaculty.Name = "cmlfaculty";
            this.cmlfaculty.Size = new System.Drawing.Size(161, 24);
            this.cmlfaculty.TabIndex = 76;
            // 
            // tmlid
            // 
            this.tmlid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tmlid.Location = new System.Drawing.Point(255, 245);
            this.tmlid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmlid.Name = "tmlid";
            this.tmlid.Size = new System.Drawing.Size(161, 22);
            this.tmlid.TabIndex = 75;
            this.tmlid.TextChanged += new System.EventHandler(this.tmlid_TextChanged);
            // 
            // lmldepartment
            // 
            this.lmldepartment.AutoSize = true;
            this.lmldepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmldepartment.Location = new System.Drawing.Point(85, 318);
            this.lmldepartment.Name = "lmldepartment";
            this.lmldepartment.Size = new System.Drawing.Size(127, 28);
            this.lmldepartment.TabIndex = 74;
            this.lmldepartment.Text = "Department";
            // 
            // lmlfaculty
            // 
            this.lmlfaculty.AutoSize = true;
            this.lmlfaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlfaculty.Location = new System.Drawing.Point(85, 283);
            this.lmlfaculty.Name = "lmlfaculty";
            this.lmlfaculty.Size = new System.Drawing.Size(79, 28);
            this.lmlfaculty.TabIndex = 73;
            this.lmlfaculty.Text = "Faculty";
            // 
            // lmlid
            // 
            this.lmlid.AutoSize = true;
            this.lmlid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlid.Location = new System.Drawing.Point(85, 245);
            this.lmlid.Name = "lmlid";
            this.lmlid.Size = new System.Drawing.Size(131, 28);
            this.lmlid.TabIndex = 72;
            this.lmlid.Text = "Employee ID";
            // 
            // tmlname
            // 
            this.tmlname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tmlname.Location = new System.Drawing.Point(255, 208);
            this.tmlname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmlname.Name = "tmlname";
            this.tmlname.Size = new System.Drawing.Size(161, 22);
            this.tmlname.TabIndex = 71;
            // 
            // lmlname
            // 
            this.lmlname.AutoSize = true;
            this.lmlname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lmlname.Location = new System.Drawing.Point(85, 205);
            this.lmlname.Name = "lmlname";
            this.lmlname.Size = new System.Drawing.Size(152, 28);
            this.lmlname.TabIndex = 70;
            this.lmlname.Text = "Lecturer Name";
            // 
            // gridmanagelectrer
            // 
            this.gridmanagelectrer.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridmanagelectrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmanagelectrer.Location = new System.Drawing.Point(85, 17);
            this.gridmanagelectrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridmanagelectrer.Name = "gridmanagelectrer";
            this.gridmanagelectrer.RowHeadersWidth = 51;
            this.gridmanagelectrer.RowTemplate.Height = 29;
            this.gridmanagelectrer.Size = new System.Drawing.Size(853, 142);
            this.gridmanagelectrer.TabIndex = 69;
            this.gridmanagelectrer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmanagelectrer_CellContentClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Member3.Properties.Resources._01161aaa0b6d1345dd8fe4e481144d84;
            this.pictureBox11.Location = new System.Drawing.Point(760, 329);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 98;
            this.pictureBox11.TabStop = false;
            // 
            // FormManageLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 586);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.bmledithours);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmlto);
            this.Controls.Add(this.cmlfrom);
            this.Controls.Add(this.cmlday);
            this.Controls.Add(this.lmlday);
            this.Controls.Add(this.lmlfrom);
            this.Controls.Add(this.lmlto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bmlupdate);
            this.Controls.Add(this.bmlclear);
            this.Controls.Add(this.tmlrank);
            this.Controls.Add(this.cmlbuilding);
            this.Controls.Add(this.cmllevel);
            this.Controls.Add(this.lmlrank);
            this.Controls.Add(this.lmllevel);
            this.Controls.Add(this.lmlbuilding);
            this.Controls.Add(this.cmlcenter);
            this.Controls.Add(this.lmlcenter);
            this.Controls.Add(this.cmldepartment);
            this.Controls.Add(this.cmlfaculty);
            this.Controls.Add(this.tmlid);
            this.Controls.Add(this.lmldepartment);
            this.Controls.Add(this.lmlfaculty);
            this.Controls.Add(this.lmlid);
            this.Controls.Add(this.tmlname);
            this.Controls.Add(this.lmlname);
            this.Controls.Add(this.gridmanagelectrer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageLecturer";
            this.Text = "FormManageLecturer";
            this.Load += new System.EventHandler(this.FormManageLecturer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmanagelectrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bmledithours;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmlto;
        private System.Windows.Forms.ComboBox cmlfrom;
        private System.Windows.Forms.ComboBox cmlday;
        private System.Windows.Forms.Label lmlday;
        private System.Windows.Forms.Label lmlfrom;
        private System.Windows.Forms.Label lmlto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bmlupdate;
        private System.Windows.Forms.Button bmlclear;
        private System.Windows.Forms.TextBox tmlrank;
        private System.Windows.Forms.ComboBox cmlbuilding;
        private System.Windows.Forms.ComboBox cmllevel;
        private System.Windows.Forms.Label lmlrank;
        private System.Windows.Forms.Label lmllevel;
        private System.Windows.Forms.Label lmlbuilding;
        private System.Windows.Forms.ComboBox cmlcenter;
        private System.Windows.Forms.Label lmlcenter;
        private System.Windows.Forms.ComboBox cmldepartment;
        private System.Windows.Forms.ComboBox cmlfaculty;
        private System.Windows.Forms.TextBox tmlid;
        private System.Windows.Forms.Label lmldepartment;
        private System.Windows.Forms.Label lmlfaculty;
        private System.Windows.Forms.Label lmlid;
        private System.Windows.Forms.TextBox tmlname;
        private System.Windows.Forms.Label lmlname;
        private System.Windows.Forms.DataGridView gridmanagelectrer;
    }
}
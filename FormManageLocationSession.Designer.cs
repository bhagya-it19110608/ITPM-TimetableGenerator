
namespace Member3
{
    partial class FormManageLocationSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageLocationSession));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.comboBoxLec = new System.Windows.Forms.ComboBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelLec = new System.Windows.Forms.Label();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.labelSession = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(984, 183);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 42);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(984, 111);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 42);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(984, 256);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 42);
            this.buttonClear.TabIndex = 52;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Items.AddRange(new object[] {
            "Tag1",
            "Tag2",
            "Tag3"});
            this.comboBoxTag.Location = new System.Drawing.Point(698, 419);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(156, 24);
            this.comboBoxTag.TabIndex = 51;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "Room1",
            "Room2",
            "Room3"});
            this.comboBoxRoom.Location = new System.Drawing.Point(698, 388);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(156, 24);
            this.comboBoxRoom.TabIndex = 50;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Items.AddRange(new object[] {
            "Sub1",
            "Sub2",
            "Sub3"});
            this.comboBoxSub.Location = new System.Drawing.Point(310, 418);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(156, 24);
            this.comboBoxSub.TabIndex = 49;
            // 
            // comboBoxLec
            // 
            this.comboBoxLec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxLec.FormattingEnabled = true;
            this.comboBoxLec.Items.AddRange(new object[] {
            "Lec1",
            "Lec2",
            "Lec3"});
            this.comboBoxLec.Location = new System.Drawing.Point(310, 386);
            this.comboBoxLec.Name = "comboBoxLec";
            this.comboBoxLec.Size = new System.Drawing.Size(156, 24);
            this.comboBoxLec.TabIndex = 48;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(524, 419);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(32, 20);
            this.labelTag.TabIndex = 47;
            this.labelTag.Text = "Tag";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(524, 388);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(49, 20);
            this.labelRoom.TabIndex = 46;
            this.labelRoom.Text = "Room";
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(157, 418);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(102, 20);
            this.labelSub.TabIndex = 45;
            this.labelSub.Text = "Subject Name";
            // 
            // labelLec
            // 
            this.labelLec.AutoSize = true;
            this.labelLec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLec.Location = new System.Drawing.Point(174, 386);
            this.labelLec.Name = "labelLec";
            this.labelLec.Size = new System.Drawing.Size(106, 20);
            this.labelLec.TabIndex = 44;
            this.labelLec.Text = "Lecturer Name";
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonAddSession.FlatAppearance.BorderSize = 0;
            this.buttonAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSession.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddSession.ForeColor = System.Drawing.Color.White;
            this.buttonAddSession.Location = new System.Drawing.Point(465, 310);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(164, 42);
            this.buttonAddSession.TabIndex = 43;
            this.buttonAddSession.Text = "Add Session";
            this.buttonAddSession.UseVisualStyleBackColor = false;
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Location = new System.Drawing.Point(146, 111);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.RowHeadersWidth = 51;
            this.dataGridViewLocation.RowTemplate.Height = 24;
            this.dataGridViewLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocation.Size = new System.Drawing.Size(799, 187);
            this.dataGridViewLocation.TabIndex = 42;
            this.dataGridViewLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocation_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Image = global::Member3.Properties.Resources.refresh_btn;
            this.buttonRefresh.Location = new System.Drawing.Point(735, 65);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(31, 27);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(596, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 27);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(450, 68);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(140, 24);
            this.comboBoxSearch.TabIndex = 39;
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Items.AddRange(new object[] {
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
            this.comboBoxSession.Location = new System.Drawing.Point(310, 448);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(156, 24);
            this.comboBoxSession.TabIndex = 56;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.Location = new System.Drawing.Point(157, 448);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(77, 20);
            this.labelSession.TabIndex = 55;
            this.labelSession.Text = "Session ID";
            // 
            // FormManageLocationSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 540);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.comboBoxLec);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.labelLec);
            this.Controls.Add(this.buttonAddSession);
            this.Controls.Add(this.dataGridViewLocation);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageLocationSession";
            this.Text = "FormManageLocationSession";
            this.Load += new System.EventHandler(this.FormManageLocationSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.ComboBox comboBoxLec;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelLec;
        private System.Windows.Forms.Button buttonAddSession;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.Label labelSession;
    }
}
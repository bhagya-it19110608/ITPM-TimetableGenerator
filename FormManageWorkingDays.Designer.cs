
namespace Member3
{
    partial class FormManageWorkingDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageWorkingDays));
            this.dataGridViewManageWorkingDays = new System.Windows.Forms.DataGridView();
            this.labelManageWorkingDaysLecID = new System.Windows.Forms.Label();
            this.buttonManageWorkingDaysSearch = new System.Windows.Forms.Button();
            this.labelLecturerName = new System.Windows.Forms.Label();
            this.labelManageWorkingDaysNumber = new System.Windows.Forms.Label();
            this.labelManageWorkingDaysName = new System.Windows.Forms.Label();
            this.labelWeekTime = new System.Windows.Forms.Label();
            this.textBoxManageWorkingDaysLecID = new System.Windows.Forms.TextBox();
            this.textBoxManageWorkingDaysLecturerName = new System.Windows.Forms.TextBox();
            this.textBoxManageWorkingDaysWeekTime = new System.Windows.Forms.TextBox();
            this.numericUpDownManageWorkingDaysNumber = new System.Windows.Forms.NumericUpDown();
            this.domainUpDownManageWorkingDaysName = new System.Windows.Forms.DomainUpDown();
            this.buttonManageWorkingDaysClear = new System.Windows.Forms.Button();
            this.buttonManageWorkingDaysUpdate = new System.Windows.Forms.Button();
            this.buttonManageWorkingDaysDelete = new System.Windows.Forms.Button();
            this.comboBoxManageWorkingDaysSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageWorkingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManageWorkingDaysNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManageWorkingDays
            // 
            this.dataGridViewManageWorkingDays.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.dataGridViewManageWorkingDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageWorkingDays.Location = new System.Drawing.Point(217, 85);
            this.dataGridViewManageWorkingDays.Name = "dataGridViewManageWorkingDays";
            this.dataGridViewManageWorkingDays.RowHeadersWidth = 51;
            this.dataGridViewManageWorkingDays.RowTemplate.Height = 24;
            this.dataGridViewManageWorkingDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageWorkingDays.Size = new System.Drawing.Size(799, 187);
            this.dataGridViewManageWorkingDays.TabIndex = 0;
            this.dataGridViewManageWorkingDays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageWorkingDays_CellClick);
            this.dataGridViewManageWorkingDays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageWorkingDays_CellContentClick);
            // 
            // labelManageWorkingDaysLecID
            // 
            this.labelManageWorkingDaysLecID.AutoSize = true;
            this.labelManageWorkingDaysLecID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageWorkingDaysLecID.Location = new System.Drawing.Point(406, 297);
            this.labelManageWorkingDaysLecID.Name = "labelManageWorkingDaysLecID";
            this.labelManageWorkingDaysLecID.Size = new System.Drawing.Size(81, 20);
            this.labelManageWorkingDaysLecID.TabIndex = 3;
            this.labelManageWorkingDaysLecID.Text = "Lecturer ID";
            // 
            // buttonManageWorkingDaysSearch
            // 
            this.buttonManageWorkingDaysSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonManageWorkingDaysSearch.FlatAppearance.BorderSize = 0;
            this.buttonManageWorkingDaysSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageWorkingDaysSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonManageWorkingDaysSearch.ForeColor = System.Drawing.Color.White;
            this.buttonManageWorkingDaysSearch.Location = new System.Drawing.Point(664, 30);
            this.buttonManageWorkingDaysSearch.Name = "buttonManageWorkingDaysSearch";
            this.buttonManageWorkingDaysSearch.Size = new System.Drawing.Size(133, 27);
            this.buttonManageWorkingDaysSearch.TabIndex = 4;
            this.buttonManageWorkingDaysSearch.Text = "Search";
            this.buttonManageWorkingDaysSearch.UseVisualStyleBackColor = false;
            this.buttonManageWorkingDaysSearch.Click += new System.EventHandler(this.buttonManageWorkingDaysSearch_Click);
            // 
            // labelLecturerName
            // 
            this.labelLecturerName.AutoSize = true;
            this.labelLecturerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLecturerName.Location = new System.Drawing.Point(406, 343);
            this.labelLecturerName.Name = "labelLecturerName";
            this.labelLecturerName.Size = new System.Drawing.Size(106, 20);
            this.labelLecturerName.TabIndex = 5;
            this.labelLecturerName.Text = "Lecturer Name";
            // 
            // labelManageWorkingDaysNumber
            // 
            this.labelManageWorkingDaysNumber.AutoSize = true;
            this.labelManageWorkingDaysNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageWorkingDaysNumber.Location = new System.Drawing.Point(406, 386);
            this.labelManageWorkingDaysNumber.Name = "labelManageWorkingDaysNumber";
            this.labelManageWorkingDaysNumber.Size = new System.Drawing.Size(144, 20);
            this.labelManageWorkingDaysNumber.TabIndex = 6;
            this.labelManageWorkingDaysNumber.Text = "No Of Working Days";
            // 
            // labelManageWorkingDaysName
            // 
            this.labelManageWorkingDaysName.AutoSize = true;
            this.labelManageWorkingDaysName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageWorkingDaysName.Location = new System.Drawing.Point(406, 429);
            this.labelManageWorkingDaysName.Name = "labelManageWorkingDaysName";
            this.labelManageWorkingDaysName.Size = new System.Drawing.Size(100, 20);
            this.labelManageWorkingDaysName.TabIndex = 7;
            this.labelManageWorkingDaysName.Text = "Working Days";
            // 
            // labelWeekTime
            // 
            this.labelWeekTime.AutoSize = true;
            this.labelWeekTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeekTime.Location = new System.Drawing.Point(406, 472);
            this.labelWeekTime.Name = "labelWeekTime";
            this.labelWeekTime.Size = new System.Drawing.Size(106, 20);
            this.labelWeekTime.TabIndex = 8;
            this.labelWeekTime.Text = "Time Per Week";
            // 
            // textBoxManageWorkingDaysLecID
            // 
            this.textBoxManageWorkingDaysLecID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManageWorkingDaysLecID.Location = new System.Drawing.Point(622, 297);
            this.textBoxManageWorkingDaysLecID.Name = "textBoxManageWorkingDaysLecID";
            this.textBoxManageWorkingDaysLecID.Size = new System.Drawing.Size(175, 27);
            this.textBoxManageWorkingDaysLecID.TabIndex = 9;
            // 
            // textBoxManageWorkingDaysLecturerName
            // 
            this.textBoxManageWorkingDaysLecturerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManageWorkingDaysLecturerName.Location = new System.Drawing.Point(622, 339);
            this.textBoxManageWorkingDaysLecturerName.Name = "textBoxManageWorkingDaysLecturerName";
            this.textBoxManageWorkingDaysLecturerName.Size = new System.Drawing.Size(175, 27);
            this.textBoxManageWorkingDaysLecturerName.TabIndex = 10;
            // 
            // textBoxManageWorkingDaysWeekTime
            // 
            this.textBoxManageWorkingDaysWeekTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManageWorkingDaysWeekTime.Location = new System.Drawing.Point(622, 465);
            this.textBoxManageWorkingDaysWeekTime.Name = "textBoxManageWorkingDaysWeekTime";
            this.textBoxManageWorkingDaysWeekTime.Size = new System.Drawing.Size(175, 27);
            this.textBoxManageWorkingDaysWeekTime.TabIndex = 11;
            // 
            // numericUpDownManageWorkingDaysNumber
            // 
            this.numericUpDownManageWorkingDaysNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.numericUpDownManageWorkingDaysNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownManageWorkingDaysNumber.Location = new System.Drawing.Point(622, 381);
            this.numericUpDownManageWorkingDaysNumber.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownManageWorkingDaysNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownManageWorkingDaysNumber.Name = "numericUpDownManageWorkingDaysNumber";
            this.numericUpDownManageWorkingDaysNumber.Size = new System.Drawing.Size(175, 27);
            this.numericUpDownManageWorkingDaysNumber.TabIndex = 12;
            this.numericUpDownManageWorkingDaysNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // domainUpDownManageWorkingDaysName
            // 
            this.domainUpDownManageWorkingDaysName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.domainUpDownManageWorkingDaysName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownManageWorkingDaysName.Items.Add("Weekdays");
            this.domainUpDownManageWorkingDaysName.Items.Add("Weekend");
            this.domainUpDownManageWorkingDaysName.Items.Add("Both");
            this.domainUpDownManageWorkingDaysName.Location = new System.Drawing.Point(622, 423);
            this.domainUpDownManageWorkingDaysName.Name = "domainUpDownManageWorkingDaysName";
            this.domainUpDownManageWorkingDaysName.Size = new System.Drawing.Size(175, 27);
            this.domainUpDownManageWorkingDaysName.TabIndex = 13;
            this.domainUpDownManageWorkingDaysName.Text = "Week End";
            // 
            // buttonManageWorkingDaysClear
            // 
            this.buttonManageWorkingDaysClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonManageWorkingDaysClear.FlatAppearance.BorderSize = 0;
            this.buttonManageWorkingDaysClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageWorkingDaysClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonManageWorkingDaysClear.ForeColor = System.Drawing.Color.White;
            this.buttonManageWorkingDaysClear.Location = new System.Drawing.Point(891, 450);
            this.buttonManageWorkingDaysClear.Name = "buttonManageWorkingDaysClear";
            this.buttonManageWorkingDaysClear.Size = new System.Drawing.Size(125, 42);
            this.buttonManageWorkingDaysClear.TabIndex = 14;
            this.buttonManageWorkingDaysClear.Text = "Clear";
            this.buttonManageWorkingDaysClear.UseVisualStyleBackColor = false;
            this.buttonManageWorkingDaysClear.Click += new System.EventHandler(this.buttonManageWorkingDaysClear_Click);
            // 
            // buttonManageWorkingDaysUpdate
            // 
            this.buttonManageWorkingDaysUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonManageWorkingDaysUpdate.FlatAppearance.BorderSize = 0;
            this.buttonManageWorkingDaysUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageWorkingDaysUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonManageWorkingDaysUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonManageWorkingDaysUpdate.Location = new System.Drawing.Point(891, 297);
            this.buttonManageWorkingDaysUpdate.Name = "buttonManageWorkingDaysUpdate";
            this.buttonManageWorkingDaysUpdate.Size = new System.Drawing.Size(125, 42);
            this.buttonManageWorkingDaysUpdate.TabIndex = 15;
            this.buttonManageWorkingDaysUpdate.Text = "Update";
            this.buttonManageWorkingDaysUpdate.UseVisualStyleBackColor = false;
            this.buttonManageWorkingDaysUpdate.Click += new System.EventHandler(this.buttonManageWorkingDaysUpdate_Click);
            // 
            // buttonManageWorkingDaysDelete
            // 
            this.buttonManageWorkingDaysDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonManageWorkingDaysDelete.FlatAppearance.BorderSize = 0;
            this.buttonManageWorkingDaysDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageWorkingDaysDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonManageWorkingDaysDelete.ForeColor = System.Drawing.Color.White;
            this.buttonManageWorkingDaysDelete.Location = new System.Drawing.Point(891, 372);
            this.buttonManageWorkingDaysDelete.Name = "buttonManageWorkingDaysDelete";
            this.buttonManageWorkingDaysDelete.Size = new System.Drawing.Size(125, 42);
            this.buttonManageWorkingDaysDelete.TabIndex = 16;
            this.buttonManageWorkingDaysDelete.Text = "Delete";
            this.buttonManageWorkingDaysDelete.UseVisualStyleBackColor = false;
            this.buttonManageWorkingDaysDelete.Click += new System.EventHandler(this.buttonManageWorkingDaysDelete_Click);
            // 
            // comboBoxManageWorkingDaysSearch
            // 
            this.comboBoxManageWorkingDaysSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManageWorkingDaysSearch.FormattingEnabled = true;
            this.comboBoxManageWorkingDaysSearch.Location = new System.Drawing.Point(422, 29);
            this.comboBoxManageWorkingDaysSearch.Name = "comboBoxManageWorkingDaysSearch";
            this.comboBoxManageWorkingDaysSearch.Size = new System.Drawing.Size(236, 28);
            this.comboBoxManageWorkingDaysSearch.TabIndex = 17;
            // 
            // FormManageWorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.comboBoxManageWorkingDaysSearch);
            this.Controls.Add(this.buttonManageWorkingDaysDelete);
            this.Controls.Add(this.buttonManageWorkingDaysUpdate);
            this.Controls.Add(this.buttonManageWorkingDaysClear);
            this.Controls.Add(this.domainUpDownManageWorkingDaysName);
            this.Controls.Add(this.numericUpDownManageWorkingDaysNumber);
            this.Controls.Add(this.textBoxManageWorkingDaysWeekTime);
            this.Controls.Add(this.textBoxManageWorkingDaysLecturerName);
            this.Controls.Add(this.textBoxManageWorkingDaysLecID);
            this.Controls.Add(this.labelWeekTime);
            this.Controls.Add(this.labelManageWorkingDaysName);
            this.Controls.Add(this.labelManageWorkingDaysNumber);
            this.Controls.Add(this.labelLecturerName);
            this.Controls.Add(this.buttonManageWorkingDaysSearch);
            this.Controls.Add(this.labelManageWorkingDaysLecID);
            this.Controls.Add(this.dataGridViewManageWorkingDays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageWorkingDays";
            this.Text = "FormManageWorkingDays";
            this.Load += new System.EventHandler(this.FormManageWorkingDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageWorkingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManageWorkingDaysNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManageWorkingDays;
        private System.Windows.Forms.Label labelManageWorkingDaysLecID;
        private System.Windows.Forms.Button buttonManageWorkingDaysSearch;
        private System.Windows.Forms.Label labelLecturerName;
        private System.Windows.Forms.Label labelManageWorkingDaysNumber;
        private System.Windows.Forms.Label labelManageWorkingDaysName;
        private System.Windows.Forms.Label labelWeekTime;
        private System.Windows.Forms.TextBox textBoxManageWorkingDaysLecID;
        private System.Windows.Forms.TextBox textBoxManageWorkingDaysLecturerName;
        private System.Windows.Forms.TextBox textBoxManageWorkingDaysWeekTime;
        private System.Windows.Forms.NumericUpDown numericUpDownManageWorkingDaysNumber;
        private System.Windows.Forms.DomainUpDown domainUpDownManageWorkingDaysName;
        private System.Windows.Forms.Button buttonManageWorkingDaysClear;
        private System.Windows.Forms.Button buttonManageWorkingDaysUpdate;
        private System.Windows.Forms.Button buttonManageWorkingDaysDelete;
        private System.Windows.Forms.ComboBox comboBoxManageWorkingDaysSearch;
    }
}
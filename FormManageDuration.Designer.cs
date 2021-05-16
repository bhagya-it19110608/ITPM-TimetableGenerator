
namespace Member3
{
    partial class FormManageDuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageDuration));
            this.dataGridViewManageDuration = new System.Windows.Forms.DataGridView();
            this.labelManageDurationNoOfWorkingDays = new System.Windows.Forms.Label();
            this.labelManageDurationWorkingDays = new System.Windows.Forms.Label();
            this.numericUpDownManageDurationNumberOfWorkingDays = new System.Windows.Forms.NumericUpDown();
            this.checkBoxManageDurationMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxManageDurationSunday = new System.Windows.Forms.CheckBox();
            this.labelManageDurationWorkingTimePerDay = new System.Windows.Forms.Label();
            this.numericUpDownWorkingTimePerDayHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonManageDurationClear = new System.Windows.Forms.Button();
            this.buttonManageDurationDelete = new System.Windows.Forms.Button();
            this.buttonManageDurationUpdate = new System.Windows.Forms.Button();
            this.comboBoxManageDurationTimeSlots = new System.Windows.Forms.ComboBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.numericUpDownWorkingTimePerDayMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManageDurationNumberOfWorkingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingTimePerDayHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingTimePerDayMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManageDuration
            // 
            this.dataGridViewManageDuration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.dataGridViewManageDuration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageDuration.Location = new System.Drawing.Point(64, 33);
            this.dataGridViewManageDuration.Name = "dataGridViewManageDuration";
            this.dataGridViewManageDuration.RowHeadersWidth = 51;
            this.dataGridViewManageDuration.RowTemplate.Height = 24;
            this.dataGridViewManageDuration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageDuration.Size = new System.Drawing.Size(695, 162);
            this.dataGridViewManageDuration.TabIndex = 0;
            this.dataGridViewManageDuration.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageDuration_CellClick);
            // 
            // labelManageDurationNoOfWorkingDays
            // 
            this.labelManageDurationNoOfWorkingDays.AutoSize = true;
            this.labelManageDurationNoOfWorkingDays.Location = new System.Drawing.Point(205, 226);
            this.labelManageDurationNoOfWorkingDays.Name = "labelManageDurationNoOfWorkingDays";
            this.labelManageDurationNoOfWorkingDays.Size = new System.Drawing.Size(178, 20);
            this.labelManageDurationNoOfWorkingDays.TabIndex = 1;
            this.labelManageDurationNoOfWorkingDays.Text = "Number Of Working Days";
            // 
            // labelManageDurationWorkingDays
            // 
            this.labelManageDurationWorkingDays.AutoSize = true;
            this.labelManageDurationWorkingDays.Location = new System.Drawing.Point(205, 268);
            this.labelManageDurationWorkingDays.Name = "labelManageDurationWorkingDays";
            this.labelManageDurationWorkingDays.Size = new System.Drawing.Size(100, 20);
            this.labelManageDurationWorkingDays.TabIndex = 2;
            this.labelManageDurationWorkingDays.Text = "Working Days";
            // 
            // numericUpDownManageDurationNumberOfWorkingDays
            // 
            this.numericUpDownManageDurationNumberOfWorkingDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.numericUpDownManageDurationNumberOfWorkingDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownManageDurationNumberOfWorkingDays.Location = new System.Drawing.Point(472, 224);
            this.numericUpDownManageDurationNumberOfWorkingDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownManageDurationNumberOfWorkingDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownManageDurationNumberOfWorkingDays.Name = "numericUpDownManageDurationNumberOfWorkingDays";
            this.numericUpDownManageDurationNumberOfWorkingDays.Size = new System.Drawing.Size(228, 27);
            this.numericUpDownManageDurationNumberOfWorkingDays.TabIndex = 6;
            this.numericUpDownManageDurationNumberOfWorkingDays.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBoxManageDurationMonday
            // 
            this.checkBoxManageDurationMonday.AutoSize = true;
            this.checkBoxManageDurationMonday.Location = new System.Drawing.Point(472, 268);
            this.checkBoxManageDurationMonday.Name = "checkBoxManageDurationMonday";
            this.checkBoxManageDurationMonday.Size = new System.Drawing.Size(85, 24);
            this.checkBoxManageDurationMonday.TabIndex = 7;
            this.checkBoxManageDurationMonday.Text = "Monday";
            this.checkBoxManageDurationMonday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationTuesday
            // 
            this.checkBoxManageDurationTuesday.AutoSize = true;
            this.checkBoxManageDurationTuesday.Location = new System.Drawing.Point(563, 268);
            this.checkBoxManageDurationTuesday.Name = "checkBoxManageDurationTuesday";
            this.checkBoxManageDurationTuesday.Size = new System.Drawing.Size(85, 24);
            this.checkBoxManageDurationTuesday.TabIndex = 8;
            this.checkBoxManageDurationTuesday.Text = "Tuesday";
            this.checkBoxManageDurationTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationWednesday
            // 
            this.checkBoxManageDurationWednesday.AutoSize = true;
            this.checkBoxManageDurationWednesday.Location = new System.Drawing.Point(654, 268);
            this.checkBoxManageDurationWednesday.Name = "checkBoxManageDurationWednesday";
            this.checkBoxManageDurationWednesday.Size = new System.Drawing.Size(107, 24);
            this.checkBoxManageDurationWednesday.TabIndex = 9;
            this.checkBoxManageDurationWednesday.Text = "Wednesday";
            this.checkBoxManageDurationWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationThursday
            // 
            this.checkBoxManageDurationThursday.AutoSize = true;
            this.checkBoxManageDurationThursday.Location = new System.Drawing.Point(767, 268);
            this.checkBoxManageDurationThursday.Name = "checkBoxManageDurationThursday";
            this.checkBoxManageDurationThursday.Size = new System.Drawing.Size(90, 24);
            this.checkBoxManageDurationThursday.TabIndex = 10;
            this.checkBoxManageDurationThursday.Text = "Thursday";
            this.checkBoxManageDurationThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationFriday
            // 
            this.checkBoxManageDurationFriday.AutoSize = true;
            this.checkBoxManageDurationFriday.Location = new System.Drawing.Point(863, 268);
            this.checkBoxManageDurationFriday.Name = "checkBoxManageDurationFriday";
            this.checkBoxManageDurationFriday.Size = new System.Drawing.Size(71, 24);
            this.checkBoxManageDurationFriday.TabIndex = 11;
            this.checkBoxManageDurationFriday.Text = "Friday";
            this.checkBoxManageDurationFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationSaturday
            // 
            this.checkBoxManageDurationSaturday.AutoSize = true;
            this.checkBoxManageDurationSaturday.Location = new System.Drawing.Point(472, 309);
            this.checkBoxManageDurationSaturday.Name = "checkBoxManageDurationSaturday";
            this.checkBoxManageDurationSaturday.Size = new System.Drawing.Size(89, 24);
            this.checkBoxManageDurationSaturday.TabIndex = 12;
            this.checkBoxManageDurationSaturday.Text = "Saturday";
            this.checkBoxManageDurationSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxManageDurationSunday
            // 
            this.checkBoxManageDurationSunday.AutoSize = true;
            this.checkBoxManageDurationSunday.Location = new System.Drawing.Point(563, 309);
            this.checkBoxManageDurationSunday.Name = "checkBoxManageDurationSunday";
            this.checkBoxManageDurationSunday.Size = new System.Drawing.Size(79, 24);
            this.checkBoxManageDurationSunday.TabIndex = 13;
            this.checkBoxManageDurationSunday.Text = "Sunday";
            this.checkBoxManageDurationSunday.UseVisualStyleBackColor = true;
            // 
            // labelManageDurationWorkingTimePerDay
            // 
            this.labelManageDurationWorkingTimePerDay.AutoSize = true;
            this.labelManageDurationWorkingTimePerDay.Location = new System.Drawing.Point(205, 352);
            this.labelManageDurationWorkingTimePerDay.Name = "labelManageDurationWorkingTimePerDay";
            this.labelManageDurationWorkingTimePerDay.Size = new System.Drawing.Size(155, 20);
            this.labelManageDurationWorkingTimePerDay.TabIndex = 14;
            this.labelManageDurationWorkingTimePerDay.Text = "Working Time Per Day";
            // 
            // numericUpDownWorkingTimePerDayHours
            // 
            this.numericUpDownWorkingTimePerDayHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.numericUpDownWorkingTimePerDayHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWorkingTimePerDayHours.Location = new System.Drawing.Point(472, 350);
            this.numericUpDownWorkingTimePerDayHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownWorkingTimePerDayHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkingTimePerDayHours.Name = "numericUpDownWorkingTimePerDayHours";
            this.numericUpDownWorkingTimePerDayHours.Size = new System.Drawing.Size(106, 27);
            this.numericUpDownWorkingTimePerDayHours.TabIndex = 15;
            this.numericUpDownWorkingTimePerDayHours.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Time Slots For Table";
            // 
            // buttonManageDurationClear
            // 
            this.buttonManageDurationClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonManageDurationClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageDurationClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageDurationClear.ForeColor = System.Drawing.Color.White;
            this.buttonManageDurationClear.Location = new System.Drawing.Point(801, 150);
            this.buttonManageDurationClear.Name = "buttonManageDurationClear";
            this.buttonManageDurationClear.Size = new System.Drawing.Size(133, 45);
            this.buttonManageDurationClear.TabIndex = 20;
            this.buttonManageDurationClear.Text = "Clear";
            this.buttonManageDurationClear.UseVisualStyleBackColor = false;
            this.buttonManageDurationClear.Click += new System.EventHandler(this.buttonManageDurationClear_Click);
            // 
            // buttonManageDurationDelete
            // 
            this.buttonManageDurationDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonManageDurationDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageDurationDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageDurationDelete.ForeColor = System.Drawing.Color.White;
            this.buttonManageDurationDelete.Location = new System.Drawing.Point(801, 92);
            this.buttonManageDurationDelete.Name = "buttonManageDurationDelete";
            this.buttonManageDurationDelete.Size = new System.Drawing.Size(133, 45);
            this.buttonManageDurationDelete.TabIndex = 21;
            this.buttonManageDurationDelete.Text = "Delete";
            this.buttonManageDurationDelete.UseVisualStyleBackColor = false;
            this.buttonManageDurationDelete.Click += new System.EventHandler(this.buttonManageDurationDelete_Click);
            // 
            // buttonManageDurationUpdate
            // 
            this.buttonManageDurationUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonManageDurationUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageDurationUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageDurationUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonManageDurationUpdate.Location = new System.Drawing.Point(801, 33);
            this.buttonManageDurationUpdate.Name = "buttonManageDurationUpdate";
            this.buttonManageDurationUpdate.Size = new System.Drawing.Size(133, 45);
            this.buttonManageDurationUpdate.TabIndex = 22;
            this.buttonManageDurationUpdate.Text = "Update";
            this.buttonManageDurationUpdate.UseVisualStyleBackColor = false;
            this.buttonManageDurationUpdate.Click += new System.EventHandler(this.buttonManageDurationUpdate_Click);
            // 
            // comboBoxManageDurationTimeSlots
            // 
            this.comboBoxManageDurationTimeSlots.FormattingEnabled = true;
            this.comboBoxManageDurationTimeSlots.Items.AddRange(new object[] {
            "One Hour",
            "30 Minutes"});
            this.comboBoxManageDurationTimeSlots.Location = new System.Drawing.Point(472, 399);
            this.comboBoxManageDurationTimeSlots.Name = "comboBoxManageDurationTimeSlots";
            this.comboBoxManageDurationTimeSlots.Size = new System.Drawing.Size(228, 28);
            this.comboBoxManageDurationTimeSlots.TabIndex = 23;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(594, 352);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(48, 20);
            this.labelHours.TabIndex = 24;
            this.labelHours.Text = "Hours";
            // 
            // numericUpDownWorkingTimePerDayMinutes
            // 
            this.numericUpDownWorkingTimePerDayMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.numericUpDownWorkingTimePerDayMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWorkingTimePerDayMinutes.Location = new System.Drawing.Point(654, 350);
            this.numericUpDownWorkingTimePerDayMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownWorkingTimePerDayMinutes.Name = "numericUpDownWorkingTimePerDayMinutes";
            this.numericUpDownWorkingTimePerDayMinutes.Size = new System.Drawing.Size(106, 27);
            this.numericUpDownWorkingTimePerDayMinutes.TabIndex = 25;
            this.numericUpDownWorkingTimePerDayMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Minutes";
            // 
            // FormManageDuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownWorkingTimePerDayMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.comboBoxManageDurationTimeSlots);
            this.Controls.Add(this.buttonManageDurationUpdate);
            this.Controls.Add(this.buttonManageDurationDelete);
            this.Controls.Add(this.buttonManageDurationClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWorkingTimePerDayHours);
            this.Controls.Add(this.labelManageDurationWorkingTimePerDay);
            this.Controls.Add(this.checkBoxManageDurationSunday);
            this.Controls.Add(this.checkBoxManageDurationSaturday);
            this.Controls.Add(this.checkBoxManageDurationFriday);
            this.Controls.Add(this.checkBoxManageDurationThursday);
            this.Controls.Add(this.checkBoxManageDurationWednesday);
            this.Controls.Add(this.checkBoxManageDurationTuesday);
            this.Controls.Add(this.checkBoxManageDurationMonday);
            this.Controls.Add(this.numericUpDownManageDurationNumberOfWorkingDays);
            this.Controls.Add(this.labelManageDurationWorkingDays);
            this.Controls.Add(this.labelManageDurationNoOfWorkingDays);
            this.Controls.Add(this.dataGridViewManageDuration);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormManageDuration";
            this.Text = "FormManageDuration";
            this.Load += new System.EventHandler(this.FormManageDuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManageDurationNumberOfWorkingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingTimePerDayHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingTimePerDayMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManageDuration;
        private System.Windows.Forms.Label labelManageDurationNoOfWorkingDays;
        private System.Windows.Forms.Label labelManageDurationWorkingDays;
        private System.Windows.Forms.NumericUpDown numericUpDownManageDurationNumberOfWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxManageDurationMonday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationTuesday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationWednesday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationThursday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationFriday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationSaturday;
        private System.Windows.Forms.CheckBox checkBoxManageDurationSunday;
        private System.Windows.Forms.Label labelManageDurationWorkingTimePerDay;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkingTimePerDayHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonManageDurationClear;
        private System.Windows.Forms.Button buttonManageDurationDelete;
        private System.Windows.Forms.Button buttonManageDurationUpdate;
        private System.Windows.Forms.ComboBox comboBoxManageDurationTimeSlots;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkingTimePerDayMinutes;
        private System.Windows.Forms.Label label3;
    }
}
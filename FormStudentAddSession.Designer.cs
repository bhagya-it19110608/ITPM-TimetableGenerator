
namespace Member3
{
    partial class FormStudentAddSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentAddSession));
            this.buttonStudentTimeView = new System.Windows.Forms.Button();
            this.buttonStudentTimeSubmit = new System.Windows.Forms.Button();
            this.buttonStudentTimeClear = new System.Windows.Forms.Button();
            this.comboBoxStudentSelectTime = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentSelectSessionID = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentSelectSubGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentSelectGroup = new System.Windows.Forms.ComboBox();
            this.labelStudentSelectTime = new System.Windows.Forms.Label();
            this.labelStudentSelectSessionID = new System.Windows.Forms.Label();
            this.labelStudentSelectSubGroup = new System.Windows.Forms.Label();
            this.labelStudentSelectGroup = new System.Windows.Forms.Label();
            this.labelStudentNotAvailableTimeAllocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStudentTimeView
            // 
            this.buttonStudentTimeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonStudentTimeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentTimeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentTimeView.ForeColor = System.Drawing.Color.White;
            this.buttonStudentTimeView.Location = new System.Drawing.Point(809, 306);
            this.buttonStudentTimeView.Name = "buttonStudentTimeView";
            this.buttonStudentTimeView.Size = new System.Drawing.Size(133, 45);
            this.buttonStudentTimeView.TabIndex = 37;
            this.buttonStudentTimeView.Text = "View";
            this.buttonStudentTimeView.UseVisualStyleBackColor = false;
            // 
            // buttonStudentTimeSubmit
            // 
            this.buttonStudentTimeSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonStudentTimeSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentTimeSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentTimeSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonStudentTimeSubmit.Location = new System.Drawing.Point(809, 196);
            this.buttonStudentTimeSubmit.Name = "buttonStudentTimeSubmit";
            this.buttonStudentTimeSubmit.Size = new System.Drawing.Size(133, 45);
            this.buttonStudentTimeSubmit.TabIndex = 36;
            this.buttonStudentTimeSubmit.Text = "Submit";
            this.buttonStudentTimeSubmit.UseVisualStyleBackColor = false;
            this.buttonStudentTimeSubmit.Click += new System.EventHandler(this.buttonStudentTimeSubmit_Click);
            // 
            // buttonStudentTimeClear
            // 
            this.buttonStudentTimeClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.buttonStudentTimeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentTimeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentTimeClear.ForeColor = System.Drawing.Color.White;
            this.buttonStudentTimeClear.Location = new System.Drawing.Point(809, 251);
            this.buttonStudentTimeClear.Name = "buttonStudentTimeClear";
            this.buttonStudentTimeClear.Size = new System.Drawing.Size(133, 45);
            this.buttonStudentTimeClear.TabIndex = 35;
            this.buttonStudentTimeClear.Text = "Clear";
            this.buttonStudentTimeClear.UseVisualStyleBackColor = false;
            this.buttonStudentTimeClear.Click += new System.EventHandler(this.buttonStudentTimeClear_Click);
            // 
            // comboBoxStudentSelectTime
            // 
            this.comboBoxStudentSelectTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxStudentSelectTime.FormattingEnabled = true;
            this.comboBoxStudentSelectTime.Items.AddRange(new object[] {
            "Time1",
            "Time2",
            "Time3"});
            this.comboBoxStudentSelectTime.Location = new System.Drawing.Point(510, 327);
            this.comboBoxStudentSelectTime.Name = "comboBoxStudentSelectTime";
            this.comboBoxStudentSelectTime.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudentSelectTime.TabIndex = 34;
            // 
            // comboBoxStudentSelectSessionID
            // 
            this.comboBoxStudentSelectSessionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxStudentSelectSessionID.FormattingEnabled = true;
            this.comboBoxStudentSelectSessionID.Items.AddRange(new object[] {
            "Session1",
            "Session2",
            "Session3"});
            this.comboBoxStudentSelectSessionID.Location = new System.Drawing.Point(510, 274);
            this.comboBoxStudentSelectSessionID.Name = "comboBoxStudentSelectSessionID";
            this.comboBoxStudentSelectSessionID.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudentSelectSessionID.TabIndex = 33;
            // 
            // comboBoxStudentSelectSubGroup
            // 
            this.comboBoxStudentSelectSubGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxStudentSelectSubGroup.FormattingEnabled = true;
            this.comboBoxStudentSelectSubGroup.Items.AddRange(new object[] {
            "SubGroup1",
            "SubGroup2",
            "SubGroup3"});
            this.comboBoxStudentSelectSubGroup.Location = new System.Drawing.Point(510, 221);
            this.comboBoxStudentSelectSubGroup.Name = "comboBoxStudentSelectSubGroup";
            this.comboBoxStudentSelectSubGroup.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudentSelectSubGroup.TabIndex = 32;
            // 
            // comboBoxStudentSelectGroup
            // 
            this.comboBoxStudentSelectGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.comboBoxStudentSelectGroup.FormattingEnabled = true;
            this.comboBoxStudentSelectGroup.Items.AddRange(new object[] {
            "Group1",
            "Group2",
            "Group3"});
            this.comboBoxStudentSelectGroup.Location = new System.Drawing.Point(510, 168);
            this.comboBoxStudentSelectGroup.Name = "comboBoxStudentSelectGroup";
            this.comboBoxStudentSelectGroup.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudentSelectGroup.TabIndex = 31;
            // 
            // labelStudentSelectTime
            // 
            this.labelStudentSelectTime.AutoSize = true;
            this.labelStudentSelectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentSelectTime.Location = new System.Drawing.Point(316, 327);
            this.labelStudentSelectTime.Name = "labelStudentSelectTime";
            this.labelStudentSelectTime.Size = new System.Drawing.Size(42, 20);
            this.labelStudentSelectTime.TabIndex = 29;
            this.labelStudentSelectTime.Text = "Time";
            // 
            // labelStudentSelectSessionID
            // 
            this.labelStudentSelectSessionID.AutoSize = true;
            this.labelStudentSelectSessionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentSelectSessionID.Location = new System.Drawing.Point(314, 274);
            this.labelStudentSelectSessionID.Name = "labelStudentSelectSessionID";
            this.labelStudentSelectSessionID.Size = new System.Drawing.Size(121, 20);
            this.labelStudentSelectSessionID.TabIndex = 28;
            this.labelStudentSelectSessionID.Text = "Select Session ID";
            // 
            // labelStudentSelectSubGroup
            // 
            this.labelStudentSelectSubGroup.AutoSize = true;
            this.labelStudentSelectSubGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentSelectSubGroup.Location = new System.Drawing.Point(314, 221);
            this.labelStudentSelectSubGroup.Name = "labelStudentSelectSubGroup";
            this.labelStudentSelectSubGroup.Size = new System.Drawing.Size(123, 20);
            this.labelStudentSelectSubGroup.TabIndex = 27;
            this.labelStudentSelectSubGroup.Text = "Select Sub Group";
            // 
            // labelStudentSelectGroup
            // 
            this.labelStudentSelectGroup.AutoSize = true;
            this.labelStudentSelectGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentSelectGroup.Location = new System.Drawing.Point(314, 168);
            this.labelStudentSelectGroup.Name = "labelStudentSelectGroup";
            this.labelStudentSelectGroup.Size = new System.Drawing.Size(94, 20);
            this.labelStudentSelectGroup.TabIndex = 26;
            this.labelStudentSelectGroup.Text = "Select Group";
            // 
            // labelStudentNotAvailableTimeAllocation
            // 
            this.labelStudentNotAvailableTimeAllocation.AutoSize = true;
            this.labelStudentNotAvailableTimeAllocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentNotAvailableTimeAllocation.Location = new System.Drawing.Point(423, 54);
            this.labelStudentNotAvailableTimeAllocation.Name = "labelStudentNotAvailableTimeAllocation";
            this.labelStudentNotAvailableTimeAllocation.Size = new System.Drawing.Size(250, 23);
            this.labelStudentNotAvailableTimeAllocation.TabIndex = 38;
            this.labelStudentNotAvailableTimeAllocation.Text = "Not Available Time Allocation";
            // 
            // FormStudentAddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 586);
            this.Controls.Add(this.labelStudentNotAvailableTimeAllocation);
            this.Controls.Add(this.buttonStudentTimeView);
            this.Controls.Add(this.buttonStudentTimeSubmit);
            this.Controls.Add(this.buttonStudentTimeClear);
            this.Controls.Add(this.comboBoxStudentSelectTime);
            this.Controls.Add(this.comboBoxStudentSelectSessionID);
            this.Controls.Add(this.comboBoxStudentSelectSubGroup);
            this.Controls.Add(this.comboBoxStudentSelectGroup);
            this.Controls.Add(this.labelStudentSelectTime);
            this.Controls.Add(this.labelStudentSelectSessionID);
            this.Controls.Add(this.labelStudentSelectSubGroup);
            this.Controls.Add(this.labelStudentSelectGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudentAddSession";
            this.Text = "FormStudentAddSession";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStudentTimeView;
        private System.Windows.Forms.Button buttonStudentTimeSubmit;
        private System.Windows.Forms.Button buttonStudentTimeClear;
        private System.Windows.Forms.ComboBox comboBoxStudentSelectTime;
        private System.Windows.Forms.ComboBox comboBoxStudentSelectSessionID;
        private System.Windows.Forms.ComboBox comboBoxStudentSelectSubGroup;
        private System.Windows.Forms.ComboBox comboBoxStudentSelectGroup;
        private System.Windows.Forms.Label labelStudentSelectTime;
        private System.Windows.Forms.Label labelStudentSelectSessionID;
        private System.Windows.Forms.Label labelStudentSelectSubGroup;
        private System.Windows.Forms.Label labelStudentSelectGroup;
        private System.Windows.Forms.Label labelStudentNotAvailableTimeAllocation;
    }
}
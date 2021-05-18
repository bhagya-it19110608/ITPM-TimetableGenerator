
namespace Member3
{
    partial class FormManageTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageTags));
            this.comboTags2 = new System.Windows.Forms.ComboBox();
            this.TagsdataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearTag = new System.Windows.Forms.Button();
            this.updateTag = new System.Windows.Forms.Button();
            this.tagCode = new System.Windows.Forms.TextBox();
            this.tagName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TagsdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTags2
            // 
            this.comboTags2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTags2.FormattingEnabled = true;
            this.comboTags2.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.comboTags2.Location = new System.Drawing.Point(380, 438);
            this.comboTags2.Margin = new System.Windows.Forms.Padding(4);
            this.comboTags2.Name = "comboTags2";
            this.comboTags2.Size = new System.Drawing.Size(440, 24);
            this.comboTags2.TabIndex = 21;
            // 
            // TagsdataGridView1
            // 
            this.TagsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagsdataGridView1.Location = new System.Drawing.Point(227, 48);
            this.TagsdataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.TagsdataGridView1.Name = "TagsdataGridView1";
            this.TagsdataGridView1.RowHeadersWidth = 51;
            this.TagsdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TagsdataGridView1.Size = new System.Drawing.Size(593, 208);
            this.TagsdataGridView1.TabIndex = 20;
            this.TagsdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TagsdataGridView1_CellClick);
            // 
            // clearTag
            // 
            this.clearTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.clearTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearTag.Location = new System.Drawing.Point(916, 397);
            this.clearTag.Margin = new System.Windows.Forms.Padding(4);
            this.clearTag.Name = "clearTag";
            this.clearTag.Size = new System.Drawing.Size(121, 43);
            this.clearTag.TabIndex = 19;
            this.clearTag.Text = "CLEAR";
            this.clearTag.UseVisualStyleBackColor = false;
            this.clearTag.Click += new System.EventHandler(this.clearTag_Click);
            // 
            // updateTag
            // 
            this.updateTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.updateTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateTag.Location = new System.Drawing.Point(916, 315);
            this.updateTag.Margin = new System.Windows.Forms.Padding(4);
            this.updateTag.Name = "updateTag";
            this.updateTag.Size = new System.Drawing.Size(121, 43);
            this.updateTag.TabIndex = 18;
            this.updateTag.Text = "UPDATE";
            this.updateTag.UseVisualStyleBackColor = false;
            this.updateTag.Click += new System.EventHandler(this.updateTag_Click);
            // 
            // tagCode
            // 
            this.tagCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tagCode.Location = new System.Drawing.Point(382, 360);
            this.tagCode.Margin = new System.Windows.Forms.Padding(4);
            this.tagCode.Name = "tagCode";
            this.tagCode.Size = new System.Drawing.Size(439, 22);
            this.tagCode.TabIndex = 17;
            // 
            // tagName
            // 
            this.tagName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tagName.Location = new System.Drawing.Point(382, 288);
            this.tagName.Margin = new System.Windows.Forms.Padding(4);
            this.tagName.Name = "tagName";
            this.tagName.Size = new System.Drawing.Size(440, 22);
            this.tagName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Related Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tag Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tag Name";
            // 
            // FormManageTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 586);
            this.Controls.Add(this.comboTags2);
            this.Controls.Add(this.TagsdataGridView1);
            this.Controls.Add(this.clearTag);
            this.Controls.Add(this.updateTag);
            this.Controls.Add(this.tagCode);
            this.Controls.Add(this.tagName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageTags";
            this.Text = "FormManageTags";
            this.Load += new System.EventHandler(this.FormManageTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TagsdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboTags2;
        private System.Windows.Forms.DataGridView TagsdataGridView1;
        private System.Windows.Forms.Button clearTag;
        private System.Windows.Forms.Button updateTag;
        private System.Windows.Forms.TextBox tagCode;
        private System.Windows.Forms.TextBox tagName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

namespace Member3
{
    partial class FormTagContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTagContent));
            this.panelTagHeader = new System.Windows.Forms.Panel();
            this.buttonManageTag = new System.Windows.Forms.Button();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.panelTag = new System.Windows.Forms.Panel();
            this.panelContentTag = new System.Windows.Forms.Panel();
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.comboTags = new System.Windows.Forms.ComboBox();
            this.AddTagsSave = new System.Windows.Forms.Button();
            this.AddTagsClear = new System.Windows.Forms.Button();
            this.txtTagCode = new System.Windows.Forms.TextBox();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTagHeader.SuspendLayout();
            this.panelTag.SuspendLayout();
            this.panelContentTag.SuspendLayout();
            this.panelLecturerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTagHeader
            // 
            this.panelTagHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelTagHeader.Controls.Add(this.buttonManageTag);
            this.panelTagHeader.Controls.Add(this.buttonAddTag);
            this.panelTagHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTagHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTagHeader.Name = "panelTagHeader";
            this.panelTagHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelTagHeader.TabIndex = 2;
            // 
            // buttonManageTag
            // 
            this.buttonManageTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonManageTag.FlatAppearance.BorderSize = 0;
            this.buttonManageTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageTag.Location = new System.Drawing.Point(306, 61);
            this.buttonManageTag.Name = "buttonManageTag";
            this.buttonManageTag.Size = new System.Drawing.Size(200, 47);
            this.buttonManageTag.TabIndex = 1;
            this.buttonManageTag.Text = "Manage Tag";
            this.buttonManageTag.UseVisualStyleBackColor = false;
            this.buttonManageTag.Click += new System.EventHandler(this.buttonManageTag_Click);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.buttonAddTag.FlatAppearance.BorderSize = 0;
            this.buttonAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTag.Location = new System.Drawing.Point(89, 61);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(200, 47);
            this.buttonAddTag.TabIndex = 0;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = false;
            // 
            // panelTag
            // 
            this.panelTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelTag.Controls.Add(this.panelContentTag);
            this.panelTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTag.Location = new System.Drawing.Point(0, 0);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(1509, 1008);
            this.panelTag.TabIndex = 2;
            // 
            // panelContentTag
            // 
            this.panelContentTag.BackColor = System.Drawing.Color.White;
            this.panelContentTag.Controls.Add(this.comboTags);
            this.panelContentTag.Controls.Add(this.AddTagsSave);
            this.panelContentTag.Controls.Add(this.AddTagsClear);
            this.panelContentTag.Controls.Add(this.txtTagCode);
            this.panelContentTag.Controls.Add(this.txtTagName);
            this.panelContentTag.Controls.Add(this.label3);
            this.panelContentTag.Controls.Add(this.label2);
            this.panelContentTag.Controls.Add(this.label1);
            this.panelContentTag.Location = new System.Drawing.Point(89, 107);
            this.panelContentTag.Name = "panelContentTag";
            this.panelContentTag.Size = new System.Drawing.Size(1286, 601);
            this.panelContentTag.TabIndex = 1;
            // 
            // panelLecturerContent
            // 
            this.panelLecturerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerContent.Controls.Add(this.panelTag);
            this.panelLecturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerContent.Location = new System.Drawing.Point(0, 0);
            this.panelLecturerContent.Name = "panelLecturerContent";
            this.panelLecturerContent.Size = new System.Drawing.Size(1509, 1008);
            this.panelLecturerContent.TabIndex = 3;
            // 
            // comboTags
            // 
            this.comboTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTags.FormattingEnabled = true;
            this.comboTags.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.comboTags.Location = new System.Drawing.Point(433, 261);
            this.comboTags.Margin = new System.Windows.Forms.Padding(4);
            this.comboTags.Name = "comboTags";
            this.comboTags.Size = new System.Drawing.Size(531, 24);
            this.comboTags.TabIndex = 16;
            // 
            // AddTagsSave
            // 
            this.AddTagsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.AddTagsSave.ForeColor = System.Drawing.Color.MintCream;
            this.AddTagsSave.Location = new System.Drawing.Point(836, 425);
            this.AddTagsSave.Margin = new System.Windows.Forms.Padding(4);
            this.AddTagsSave.Name = "AddTagsSave";
            this.AddTagsSave.Size = new System.Drawing.Size(129, 46);
            this.AddTagsSave.TabIndex = 15;
            this.AddTagsSave.Text = "SAVE";
            this.AddTagsSave.UseVisualStyleBackColor = false;
            this.AddTagsSave.Click += new System.EventHandler(this.AddTagsSave_Click);
            // 
            // AddTagsClear
            // 
            this.AddTagsClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(7)))));
            this.AddTagsClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTagsClear.Location = new System.Drawing.Point(652, 425);
            this.AddTagsClear.Margin = new System.Windows.Forms.Padding(4);
            this.AddTagsClear.Name = "AddTagsClear";
            this.AddTagsClear.Size = new System.Drawing.Size(129, 46);
            this.AddTagsClear.TabIndex = 14;
            this.AddTagsClear.Text = "CLEAR";
            this.AddTagsClear.UseVisualStyleBackColor = false;
            this.AddTagsClear.Click += new System.EventHandler(this.AddTagsClear_Click);
            // 
            // txtTagCode
            // 
            this.txtTagCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtTagCode.Location = new System.Drawing.Point(433, 194);
            this.txtTagCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(531, 22);
            this.txtTagCode.TabIndex = 13;
            // 
            // txtTagName
            // 
            this.txtTagName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtTagName.Location = new System.Drawing.Point(433, 109);
            this.txtTagName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(531, 22);
            this.txtTagName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(233, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Related Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(233, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tag Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(233, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tag Name";
            // 
            // FormTagContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelTagHeader);
            this.Controls.Add(this.panelLecturerContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTagContent";
            this.Text = "FormTagContent";
            this.Load += new System.EventHandler(this.FormTagContent_Load);
            this.panelTagHeader.ResumeLayout(false);
            this.panelTag.ResumeLayout(false);
            this.panelContentTag.ResumeLayout(false);
            this.panelContentTag.PerformLayout();
            this.panelLecturerContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTagHeader;
        private System.Windows.Forms.Button buttonManageTag;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Panel panelContentTag;
        private System.Windows.Forms.Panel panelLecturerContent;
        private System.Windows.Forms.ComboBox comboTags;
        private System.Windows.Forms.Button AddTagsSave;
        private System.Windows.Forms.Button AddTagsClear;
        private System.Windows.Forms.TextBox txtTagCode;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
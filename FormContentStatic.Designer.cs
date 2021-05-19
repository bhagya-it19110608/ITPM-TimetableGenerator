
namespace Member3
{
    partial class FormContentStatic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContentStatic));
            this.panelLecturerContent = new System.Windows.Forms.Panel();
            this.panelLecturer = new System.Windows.Forms.Panel();
            this.panelContentLecturer = new System.Windows.Forms.Panel();
            this.panelLecturerHeader = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoad = new System.Windows.Forms.Button();
            this._automated_timetableDataSet = new Member3._automated_timetableDataSet();
            this.mydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter = new Member3._automated_timetableDataSetTableAdapters.mydbTableAdapter();
            this._automated_timetableDataSet1 = new Member3._automated_timetableDataSet1();
            this.mydbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter1 = new Member3._automated_timetableDataSet1TableAdapters.mydbTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._automated_timetableDataSet2 = new Member3._automated_timetableDataSet2();
            this.mydbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter2 = new Member3._automated_timetableDataSet2TableAdapters.mydbTableAdapter();
            this.lecturerHallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._automated_timetableDataSet3 = new Member3._automated_timetableDataSet3();
            this.mydbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter3 = new Member3._automated_timetableDataSet3TableAdapters.mydbTableAdapter();
            this.panelLecturerContent.SuspendLayout();
            this.panelLecturer.SuspendLayout();
            this.panelContentLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLecturerContent
            // 
            this.panelLecturerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerContent.Controls.Add(this.panelLecturer);
            this.panelLecturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturerContent.Location = new System.Drawing.Point(0, 108);
            this.panelLecturerContent.Name = "panelLecturerContent";
            this.panelLecturerContent.Size = new System.Drawing.Size(1509, 900);
            this.panelLecturerContent.TabIndex = 3;
            // 
            // panelLecturer
            // 
            this.panelLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturer.Controls.Add(this.panelContentLecturer);
            this.panelLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLecturer.Location = new System.Drawing.Point(0, 0);
            this.panelLecturer.Name = "panelLecturer";
            this.panelLecturer.Size = new System.Drawing.Size(1509, 900);
            this.panelLecturer.TabIndex = 2;
            // 
            // panelContentLecturer
            // 
            this.panelContentLecturer.BackColor = System.Drawing.Color.White;
            this.panelContentLecturer.Controls.Add(this.dataGridView1);
            this.panelContentLecturer.Controls.Add(this.buttonLoad);
            this.panelContentLecturer.Controls.Add(this.chart1);
            this.panelContentLecturer.Location = new System.Drawing.Point(89, 0);
            this.panelContentLecturer.Name = "panelContentLecturer";
            this.panelContentLecturer.Size = new System.Drawing.Size(1286, 601);
            this.panelContentLecturer.TabIndex = 1;
            // 
            // panelLecturerHeader
            // 
            this.panelLecturerHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(164)))));
            this.panelLecturerHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLecturerHeader.Location = new System.Drawing.Point(0, 0);
            this.panelLecturerHeader.Name = "panelLecturerHeader";
            this.panelLecturerHeader.Size = new System.Drawing.Size(1509, 108);
            this.panelLecturerHeader.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(341, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Lecturer halls";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Labs";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(740, 440);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(119)))));
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(676, 505);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(125, 42);
            this.buttonLoad.TabIndex = 32;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // _automated_timetableDataSet
            // 
            this._automated_timetableDataSet.DataSetName = "_automated_timetableDataSet";
            this._automated_timetableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource
            // 
            this.mydbBindingSource.DataMember = "mydb";
            this.mydbBindingSource.DataSource = this._automated_timetableDataSet;
            // 
            // mydbTableAdapter
            // 
            this.mydbTableAdapter.ClearBeforeFill = true;
            // 
            // _automated_timetableDataSet1
            // 
            this._automated_timetableDataSet1.DataSetName = "_automated_timetableDataSet1";
            this._automated_timetableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource1
            // 
            this.mydbBindingSource1.DataMember = "mydb";
            this.mydbBindingSource1.DataSource = this._automated_timetableDataSet1;
            // 
            // mydbTableAdapter1
            // 
            this.mydbTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturerHallDataGridViewTextBoxColumn,
            this.labsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mydbBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(43, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(255, 358);
            this.dataGridView1.TabIndex = 33;
            // 
            // _automated_timetableDataSet2
            // 
            this._automated_timetableDataSet2.DataSetName = "_automated_timetableDataSet2";
            this._automated_timetableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource2
            // 
            this.mydbBindingSource2.DataMember = "mydb";
            this.mydbBindingSource2.DataSource = this._automated_timetableDataSet2;
            // 
            // mydbTableAdapter2
            // 
            this.mydbTableAdapter2.ClearBeforeFill = true;
            // 
            // lecturerHallDataGridViewTextBoxColumn
            // 
            this.lecturerHallDataGridViewTextBoxColumn.DataPropertyName = "Lecturer hall";
            this.lecturerHallDataGridViewTextBoxColumn.HeaderText = "Lecturer hall";
            this.lecturerHallDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecturerHallDataGridViewTextBoxColumn.Name = "lecturerHallDataGridViewTextBoxColumn";
            this.lecturerHallDataGridViewTextBoxColumn.Width = 125;
            // 
            // labsDataGridViewTextBoxColumn
            // 
            this.labsDataGridViewTextBoxColumn.DataPropertyName = "Labs";
            this.labsDataGridViewTextBoxColumn.HeaderText = "Labs";
            this.labsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labsDataGridViewTextBoxColumn.Name = "labsDataGridViewTextBoxColumn";
            this.labsDataGridViewTextBoxColumn.Width = 125;
            // 
            // _automated_timetableDataSet3
            // 
            this._automated_timetableDataSet3.DataSetName = "_automated_timetableDataSet3";
            this._automated_timetableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource3
            // 
            this.mydbBindingSource3.DataMember = "mydb";
            this.mydbBindingSource3.DataSource = this._automated_timetableDataSet3;
            // 
            // mydbTableAdapter3
            // 
            this.mydbTableAdapter3.ClearBeforeFill = true;
            // 
            // FormContentStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 1008);
            this.Controls.Add(this.panelLecturerContent);
            this.Controls.Add(this.panelLecturerHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContentStatic";
            this.Text = "FormContentStatic";
            this.Load += new System.EventHandler(this.FormContentStatic_Load);
            this.panelLecturerContent.ResumeLayout(false);
            this.panelLecturer.ResumeLayout(false);
            this.panelContentLecturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._automated_timetableDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLecturerContent;
        private System.Windows.Forms.Panel panelLecturer;
        private System.Windows.Forms.Panel panelContentLecturer;
        private System.Windows.Forms.Panel panelLecturerHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonLoad;
        private _automated_timetableDataSet _automated_timetableDataSet;
        private System.Windows.Forms.BindingSource mydbBindingSource;
        private _automated_timetableDataSetTableAdapters.mydbTableAdapter mydbTableAdapter;
        private _automated_timetableDataSet1 _automated_timetableDataSet1;
        private System.Windows.Forms.BindingSource mydbBindingSource1;
        private _automated_timetableDataSet1TableAdapters.mydbTableAdapter mydbTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _automated_timetableDataSet2 _automated_timetableDataSet2;
        private System.Windows.Forms.BindingSource mydbBindingSource2;
        private _automated_timetableDataSet2TableAdapters.mydbTableAdapter mydbTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerHallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labsDataGridViewTextBoxColumn;
        private _automated_timetableDataSet3 _automated_timetableDataSet3;
        private System.Windows.Forms.BindingSource mydbBindingSource3;
        private _automated_timetableDataSet3TableAdapters.mydbTableAdapter mydbTableAdapter3;
    }
}
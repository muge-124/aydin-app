namespace AydınDinlenmeTesisleri
{
    partial class Şehirler
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Şehirler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.aydınDinlenmeTesisleriDataSet = new AydınDinlenmeTesisleri.AydınDinlenmeTesisleriDataSet();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerTableAdapter = new AydınDinlenmeTesisleri.AydınDinlenmeTesisleriDataSetTableAdapters.SehirlerTableAdapter();
            this.aydınDinlenmeTesisleriDataSet1 = new AydınDinlenmeTesisleri.AydınDinlenmeTesisleriDataSet1();
            this.sehirler5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirler5TableAdapter = new AydınDinlenmeTesisleri.AydınDinlenmeTesisleriDataSet1TableAdapters.Sehirler5TableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istanbulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karabükDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bursaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aydınDinlenmeTesisleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aydınDinlenmeTesisleriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirler5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.istanbulDataGridViewTextBoxColumn,
            this.karabükDataGridViewTextBoxColumn,
            this.bursaDataGridViewTextBoxColumn,
            this.ankaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sehirler5BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(272, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(427, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "?";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "İstanbul";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Karabük";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Bursa";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Ankara";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(598, 379);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aydınDinlenmeTesisleriDataSet
            // 
            this.aydınDinlenmeTesisleriDataSet.DataSetName = "AydınDinlenmeTesisleriDataSet";
            this.aydınDinlenmeTesisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.aydınDinlenmeTesisleriDataSet;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // aydınDinlenmeTesisleriDataSet1
            // 
            this.aydınDinlenmeTesisleriDataSet1.DataSetName = "AydınDinlenmeTesisleriDataSet1";
            this.aydınDinlenmeTesisleriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirler5BindingSource
            // 
            this.sehirler5BindingSource.DataMember = "Sehirler5";
            this.sehirler5BindingSource.DataSource = this.aydınDinlenmeTesisleriDataSet1;
            // 
            // sehirler5TableAdapter
            // 
            this.sehirler5TableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "?";
            this.dataGridViewTextBoxColumn1.HeaderText = "?";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // istanbulDataGridViewTextBoxColumn
            // 
            this.istanbulDataGridViewTextBoxColumn.DataPropertyName = "İstanbul";
            this.istanbulDataGridViewTextBoxColumn.HeaderText = "İstanbul";
            this.istanbulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istanbulDataGridViewTextBoxColumn.Name = "istanbulDataGridViewTextBoxColumn";
            this.istanbulDataGridViewTextBoxColumn.Width = 125;
            // 
            // karabükDataGridViewTextBoxColumn
            // 
            this.karabükDataGridViewTextBoxColumn.DataPropertyName = "Karabük";
            this.karabükDataGridViewTextBoxColumn.HeaderText = "Karabük";
            this.karabükDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.karabükDataGridViewTextBoxColumn.Name = "karabükDataGridViewTextBoxColumn";
            this.karabükDataGridViewTextBoxColumn.Width = 125;
            // 
            // bursaDataGridViewTextBoxColumn
            // 
            this.bursaDataGridViewTextBoxColumn.DataPropertyName = "Bursa";
            this.bursaDataGridViewTextBoxColumn.HeaderText = "Bursa";
            this.bursaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bursaDataGridViewTextBoxColumn.Name = "bursaDataGridViewTextBoxColumn";
            this.bursaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ankaraDataGridViewTextBoxColumn
            // 
            this.ankaraDataGridViewTextBoxColumn.DataPropertyName = "Ankara";
            this.ankaraDataGridViewTextBoxColumn.HeaderText = "Ankara";
            this.ankaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ankaraDataGridViewTextBoxColumn.Name = "ankaraDataGridViewTextBoxColumn";
            this.ankaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // Şehirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Şehirler";
            this.Text = "Şehirler";
            this.Load += new System.EventHandler(this.Şehirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aydınDinlenmeTesisleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aydınDinlenmeTesisleriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirler5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private AydınDinlenmeTesisleriDataSet aydınDinlenmeTesisleriDataSet;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private AydınDinlenmeTesisleriDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private AydınDinlenmeTesisleriDataSet1 aydınDinlenmeTesisleriDataSet1;
        private System.Windows.Forms.BindingSource sehirler5BindingSource;
        private AydınDinlenmeTesisleriDataSet1TableAdapters.Sehirler5TableAdapter sehirler5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn istanbulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karabükDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bursaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankaraDataGridViewTextBoxColumn;
    }
}
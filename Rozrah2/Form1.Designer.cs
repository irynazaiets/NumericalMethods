namespace Rozrah2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelA = new System.Windows.Forms.Label();
			this.labelN = new System.Windows.Forms.Label();
			this.Create = new System.Windows.Forms.Button();
			this.mnogochlen = new System.Windows.Forms.Label();
			this.x1 = new System.Windows.Forms.Label();
			this.labelFunction = new System.Windows.Forms.Label();
			this.DividedDifferences = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dvgInterpPolynom = new System.Windows.Forms.DataGridView();
			this.dvgInterpDeviation = new System.Windows.Forms.DataGridView();
			this.dgvTextX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvTextFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvTextLnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dvgInterpPolynom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dvgInterpDeviation)).BeginInit();
			this.SuspendLayout();
			// 
			// myChart
			// 
			chartArea1.Name = "ChartArea1";
			this.myChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.myChart.Legends.Add(legend1);
			this.myChart.Location = new System.Drawing.Point(862, 354);
			this.myChart.Margin = new System.Windows.Forms.Padding(4);
			this.myChart.Name = "myChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series2.Legend = "Legend1";
			series2.Name = "Series2";
			this.myChart.Series.Add(series1);
			this.myChart.Series.Add(series2);
			this.myChart.Size = new System.Drawing.Size(500, 318);
			this.myChart.TabIndex = 0;
			this.myChart.Text = "myChart";
			this.myChart.Click += new System.EventHandler(this.myChart_Click);
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("OpenSymbol", 14F, System.Drawing.FontStyle.Bold);
			this.labelA.Location = new System.Drawing.Point(27, 67);
			this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(66, 19);
			this.labelA.TabIndex = 1;
			this.labelA.Text = "A = 0";
			// 
			// labelN
			// 
			this.labelN.AutoSize = true;
			this.labelN.Font = new System.Drawing.Font("OpenSymbol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelN.Location = new System.Drawing.Point(28, 159);
			this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelN.Name = "labelN";
			this.labelN.Size = new System.Drawing.Size(110, 19);
			this.labelN.TabIndex = 3;
			this.labelN.Text = "Amount = 5";
			// 
			// Create
			// 
			this.Create.BackColor = System.Drawing.Color.Red;
			this.Create.Location = new System.Drawing.Point(30, 536);
			this.Create.Margin = new System.Windows.Forms.Padding(4);
			this.Create.Name = "Create";
			this.Create.Size = new System.Drawing.Size(249, 28);
			this.Create.TabIndex = 5;
			this.Create.Text = "Create";
			this.Create.UseVisualStyleBackColor = false;
			this.Create.Click += new System.EventHandler(this.button1_Click);
			// 
			// mnogochlen
			// 
			this.mnogochlen.AutoSize = true;
			this.mnogochlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mnogochlen.Location = new System.Drawing.Point(29, 262);
			this.mnogochlen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mnogochlen.Name = "mnogochlen";
			this.mnogochlen.Size = new System.Drawing.Size(125, 24);
			this.mnogochlen.TabIndex = 6;
			this.mnogochlen.Text = "Інтерполяційний многочлен Ньютона";
			// 
			// x1
			// 
			this.x1.AutoSize = true;
			this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.x1.Location = new System.Drawing.Point(29, 603);
			this.x1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.x1.Name = "x1";
			this.x1.Size = new System.Drawing.Size(0, 24);
			this.x1.TabIndex = 8;
			// 
			// labelFunction
			// 
			this.labelFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFunction.AutoSize = true;
			this.labelFunction.Font = new System.Drawing.Font("OpenSymbol", 14F, System.Drawing.FontStyle.Bold);
			this.labelFunction.Location = new System.Drawing.Point(28, 23);
			this.labelFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFunction.Name = "labelFunction";
			this.labelFunction.Size = new System.Drawing.Size(298, 19);
			this.labelFunction.TabIndex = 13;
			this.labelFunction.Text = "y(x) = (1/24)*sin(3*x)+(1/64)*(x^5)";
			// 
			// DividedDifferences
			// 
			this.DividedDifferences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DividedDifferences.AutoSize = true;
			this.DividedDifferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DividedDifferences.Location = new System.Drawing.Point(713, 23);
			this.DividedDifferences.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DividedDifferences.Name = "DividedDifferences";
			this.DividedDifferences.Size = new System.Drawing.Size(241, 24);
			this.DividedDifferences.TabIndex = 15;
			this.DividedDifferences.Text = "Таблиця розділених різниць";
			this.DividedDifferences.Click += new System.EventHandler(this.label5_Click);
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("OpenSymbol", 14F, System.Drawing.FontStyle.Bold);
			this.labelB.Location = new System.Drawing.Point(26, 112);
			this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(86, 19);
			this.labelB.TabIndex = 17;
			this.labelB.Text = "B = PI/8";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "f(x)";
			this.Column2.Name = "Column2";
			// 
			// x
			// 
			this.x.HeaderText = "x";
			this.x.Name = "x";
			// 
			// dvgInterpPolynom
			// 
			this.dvgInterpPolynom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgInterpPolynom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.Column2});
			this.dvgInterpPolynom.Location = new System.Drawing.Point(366, 23);
			this.dvgInterpPolynom.Margin = new System.Windows.Forms.Padding(4);
			this.dvgInterpPolynom.Name = "dvgInterpPolynom";
			this.dvgInterpPolynom.Size = new System.Drawing.Size(244, 181);
			this.dvgInterpPolynom.TabIndex = 4;
			this.dvgInterpPolynom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgInterpPolynom_CellContentClick);
			// 
			// dvgInterpDeviation
			// 
			this.dvgInterpDeviation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgInterpDeviation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextX,
            this.dgvTextFx,
            this.dgvTextLnX,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dvgInterpDeviation.Location = new System.Drawing.Point(30, 354);
			this.dvgInterpDeviation.Margin = new System.Windows.Forms.Padding(4);
			this.dvgInterpDeviation.Name = "dvgInterpDeviation";
			this.dvgInterpDeviation.Size = new System.Drawing.Size(794, 137);
			this.dvgInterpDeviation.TabIndex = 18;
			// 
			// dgvTextX
			// 
			this.dgvTextX.HeaderText = "x";
			this.dgvTextX.Name = "dgvTextX";
			this.dgvTextX.Width = 150;
			// 
			// dgvTextFx
			// 
			this.dgvTextFx.HeaderText = "Fx";
			this.dgvTextFx.Name = "dgvTextFx";
			this.dgvTextFx.Width = 150;
			// 
			// dgvTextLnX
			// 
			this.dgvTextLnX.HeaderText = "Ln(x)";
			this.dgvTextLnX.Name = "dgvTextLnX";
			this.dgvTextLnX.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "|y-Ln(x)|";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Rn(x)";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1400, 730);
			this.Controls.Add(this.dvgInterpDeviation);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.DividedDifferences);
			this.Controls.Add(this.labelFunction);
			this.Controls.Add(this.x1);
			this.Controls.Add(this.mnogochlen);
			this.Controls.Add(this.Create);
			this.Controls.Add(this.dvgInterpPolynom);
			this.Controls.Add(this.labelN);
			this.Controls.Add(this.labelA);
			this.Controls.Add(this.myChart);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Розрахункова робота №2 з Чисельних методів, ч.1. Виконала студентка групи ПМ-31 Заєць Ірина";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dvgInterpPolynom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dvgInterpDeviation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label mnogochlen;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label DividedDifferences;
        private System.Windows.Forms.DataGridView dvgInterpPolynom;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn fX;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridView dvgInterpDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgTextY_LnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextRnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextLnX;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}


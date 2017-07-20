namespace FRF_Form_test
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_mag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_phs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCreateFiittingCurve = new System.Windows.Forms.Button();
            this.buttonOptimizationOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_phs)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_mag
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_mag.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_mag.Legends.Add(legend7);
            this.chart_mag.Location = new System.Drawing.Point(2, 2);
            this.chart_mag.Margin = new System.Windows.Forms.Padding(2);
            this.chart_mag.Name = "chart_mag";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            this.chart_mag.Series.Add(series13);
            this.chart_mag.Series.Add(series14);
            this.chart_mag.Size = new System.Drawing.Size(697, 306);
            this.chart_mag.TabIndex = 0;
            this.chart_mag.Text = "11";
            this.chart_mag.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.InformationTipEvent);
            // 
            // chart_phs
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_phs.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart_phs.Legends.Add(legend8);
            this.chart_phs.Location = new System.Drawing.Point(2, 312);
            this.chart_phs.Margin = new System.Windows.Forms.Padding(2);
            this.chart_phs.Name = "chart_phs";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Series2";
            this.chart_phs.Series.Add(series15);
            this.chart_phs.Series.Add(series16);
            this.chart_phs.Size = new System.Drawing.Size(697, 306);
            this.chart_phs.TabIndex = 1;
            this.chart_phs.Text = "chart_phs";
            this.chart_phs.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.InformationTipEvent);
            // 
            // buttonCreateFiittingCurve
            // 
            this.buttonCreateFiittingCurve.Location = new System.Drawing.Point(60, 626);
            this.buttonCreateFiittingCurve.Name = "buttonCreateFiittingCurve";
            this.buttonCreateFiittingCurve.Size = new System.Drawing.Size(110, 23);
            this.buttonCreateFiittingCurve.TabIndex = 5;
            this.buttonCreateFiittingCurve.Text = "GeneticAlgorithm";
            this.buttonCreateFiittingCurve.UseVisualStyleBackColor = true;
            this.buttonCreateFiittingCurve.Click += new System.EventHandler(this.GeneticAlgorithmEvent);
            // 
            // buttonOptimizationOptions
            // 
            this.buttonOptimizationOptions.Enabled = false;
            this.buttonOptimizationOptions.Location = new System.Drawing.Point(465, 626);
            this.buttonOptimizationOptions.Name = "buttonOptimizationOptions";
            this.buttonOptimizationOptions.Size = new System.Drawing.Size(110, 23);
            this.buttonOptimizationOptions.TabIndex = 5;
            this.buttonOptimizationOptions.Text = "Gradient Descent";
            this.buttonOptimizationOptions.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 661);
            this.Controls.Add(this.buttonOptimizationOptions);
            this.Controls.Add(this.buttonCreateFiittingCurve);
            this.Controls.Add(this.chart_phs);
            this.Controls.Add(this.chart_mag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_mag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_phs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mag;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_phs;
        private System.Windows.Forms.Button buttonCreateFiittingCurve;
        private System.Windows.Forms.Button buttonOptimizationOptions;
    }
}


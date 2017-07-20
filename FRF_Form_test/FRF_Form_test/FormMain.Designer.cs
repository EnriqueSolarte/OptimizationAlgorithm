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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_mag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_phs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMag = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.textBoxFreqMin = new System.Windows.Forms.TextBox();
            this.textBoxFreqMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCreateFiittingCurve = new System.Windows.Forms.Button();
            this.buttonOptimizationOptions = new System.Windows.Forms.Button();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelZeta = new System.Windows.Forms.Label();
            this.textBoxOPMass = new System.Windows.Forms.TextBox();
            this.textBoxOPZeta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOPFreq = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxOPError = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonOPSetParameters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_phs)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_mag
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_mag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_mag.Legends.Add(legend1);
            this.chart_mag.Location = new System.Drawing.Point(2, 2);
            this.chart_mag.Margin = new System.Windows.Forms.Padding(2);
            this.chart_mag.Name = "chart_mag";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart_mag.Series.Add(series1);
            this.chart_mag.Series.Add(series2);
            this.chart_mag.Size = new System.Drawing.Size(697, 306);
            this.chart_mag.TabIndex = 0;
            this.chart_mag.Text = "11";
            this.chart_mag.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.InformationTipEvent);
            // 
            // chart_phs
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_phs.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_phs.Legends.Add(legend2);
            this.chart_phs.Location = new System.Drawing.Point(2, 312);
            this.chart_phs.Margin = new System.Windows.Forms.Padding(2);
            this.chart_phs.Name = "chart_phs";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart_phs.Series.Add(series3);
            this.chart_phs.Series.Add(series4);
            this.chart_phs.Size = new System.Drawing.Size(697, 306);
            this.chart_phs.TabIndex = 1;
            this.chart_phs.Text = "chart_phs";
            this.chart_phs.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.InformationTipEvent);
            // 
            // textBoxMag
            // 
            this.textBoxMag.Location = new System.Drawing.Point(33, 667);
            this.textBoxMag.Name = "textBoxMag";
            this.textBoxMag.Size = new System.Drawing.Size(73, 22);
            this.textBoxMag.TabIndex = 2;
            this.textBoxMag.Text = "-2";
            this.textBoxMag.TextChanged += new System.EventHandler(this.ChangedResonantPeakEvent);
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(116, 667);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(52, 22);
            this.textBoxFreq.TabIndex = 2;
            this.textBoxFreq.Text = "60";
            this.textBoxFreq.TextChanged += new System.EventHandler(this.ChangedResonantPeakEvent);
            // 
            // textBoxFreqMin
            // 
            this.textBoxFreqMin.Location = new System.Drawing.Point(195, 667);
            this.textBoxFreqMin.Name = "textBoxFreqMin";
            this.textBoxFreqMin.Size = new System.Drawing.Size(48, 22);
            this.textBoxFreqMin.TabIndex = 2;
            this.textBoxFreqMin.Text = "55";
            // 
            // textBoxFreqMax
            // 
            this.textBoxFreqMax.Location = new System.Drawing.Point(247, 667);
            this.textBoxFreqMax.Name = "textBoxFreqMax";
            this.textBoxFreqMax.Size = new System.Drawing.Size(49, 22);
            this.textBoxFreqMax.TabIndex = 2;
            this.textBoxFreqMax.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Magnitud (dB)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Frequency Range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resonant Peak";
            // 
            // buttonCreateFiittingCurve
            // 
            this.buttonCreateFiittingCurve.Location = new System.Drawing.Point(574, 665);
            this.buttonCreateFiittingCurve.Name = "buttonCreateFiittingCurve";
            this.buttonCreateFiittingCurve.Size = new System.Drawing.Size(110, 23);
            this.buttonCreateFiittingCurve.TabIndex = 5;
            this.buttonCreateFiittingCurve.Text = "GeneticAlgorithm ";
            this.buttonCreateFiittingCurve.UseVisualStyleBackColor = true;
            this.buttonCreateFiittingCurve.Click += new System.EventHandler(this.RunGeneticAlgorithm);
            // 
            // buttonOptimizationOptions
            // 
            this.buttonOptimizationOptions.Enabled = false;
            this.buttonOptimizationOptions.Location = new System.Drawing.Point(574, 694);
            this.buttonOptimizationOptions.Name = "buttonOptimizationOptions";
            this.buttonOptimizationOptions.Size = new System.Drawing.Size(110, 23);
            this.buttonOptimizationOptions.TabIndex = 5;
            this.buttonOptimizationOptions.Text = "Gradient Descent";
            this.buttonOptimizationOptions.UseVisualStyleBackColor = true;
            this.buttonOptimizationOptions.Click += new System.EventHandler(this.GeneticAlgorithmOptionsBntEvent);
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Location = new System.Drawing.Point(33, 697);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(28, 12);
            this.labelMass.TabIndex = 4;
            this.labelMass.Text = "Mass";
            // 
            // labelZeta
            // 
            this.labelZeta.AutoSize = true;
            this.labelZeta.Location = new System.Drawing.Point(36, 715);
            this.labelZeta.Name = "labelZeta";
            this.labelZeta.Size = new System.Drawing.Size(25, 12);
            this.labelZeta.TabIndex = 4;
            this.labelZeta.Text = "Zeta";
            // 
            // textBoxOPMass
            // 
            this.textBoxOPMass.Enabled = false;
            this.textBoxOPMass.Location = new System.Drawing.Point(350, 695);
            this.textBoxOPMass.Name = "textBoxOPMass";
            this.textBoxOPMass.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPMass.TabIndex = 2;
            this.textBoxOPMass.Text = "-2";
            // 
            // textBoxOPZeta
            // 
            this.textBoxOPZeta.Enabled = false;
            this.textBoxOPZeta.Location = new System.Drawing.Point(350, 723);
            this.textBoxOPZeta.Name = "textBoxOPZeta";
            this.textBoxOPZeta.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPZeta.TabIndex = 2;
            this.textBoxOPZeta.Text = "-2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 700);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mass";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 728);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "Zeta";
            // 
            // textBoxOPFreq
            // 
            this.textBoxOPFreq.Enabled = false;
            this.textBoxOPFreq.Location = new System.Drawing.Point(350, 667);
            this.textBoxOPFreq.Name = "textBoxOPFreq";
            this.textBoxOPFreq.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPFreq.TabIndex = 2;
            this.textBoxOPFreq.Text = "-2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 672);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Freq";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Optimal Values";
            // 
            // textBoxOPError
            // 
            this.textBoxOPError.Enabled = false;
            this.textBoxOPError.Location = new System.Drawing.Point(349, 749);
            this.textBoxOPError.Name = "textBoxOPError";
            this.textBoxOPError.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPError.TabIndex = 2;
            this.textBoxOPError.Text = "-2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 754);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "Error";
            // 
            // buttonOPSetParameters
            // 
            this.buttonOPSetParameters.Location = new System.Drawing.Point(456, 749);
            this.buttonOPSetParameters.Name = "buttonOPSetParameters";
            this.buttonOPSetParameters.Size = new System.Drawing.Size(95, 23);
            this.buttonOPSetParameters.TabIndex = 6;
            this.buttonOPSetParameters.Text = "Set Parameters";
            this.buttonOPSetParameters.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 782);
            this.Controls.Add(this.buttonOPSetParameters);
            this.Controls.Add(this.buttonOptimizationOptions);
            this.Controls.Add(this.buttonCreateFiittingCurve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelZeta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFreqMax);
            this.Controls.Add(this.textBoxFreqMin);
            this.Controls.Add(this.textBoxOPError);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.textBoxOPZeta);
            this.Controls.Add(this.textBoxOPFreq);
            this.Controls.Add(this.textBoxOPMass);
            this.Controls.Add(this.textBoxMag);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mag;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_phs;
        private System.Windows.Forms.TextBox textBoxMag;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.TextBox textBoxFreqMin;
        private System.Windows.Forms.TextBox textBoxFreqMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCreateFiittingCurve;
        private System.Windows.Forms.Button buttonOptimizationOptions;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelZeta;
        private System.Windows.Forms.TextBox textBoxOPMass;
        private System.Windows.Forms.TextBox textBoxOPZeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOPFreq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxOPError;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonOPSetParameters;
    }
}


namespace FRF_Form_test
{
    partial class FormGAOptions
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFitness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartParameters = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMassMax = new System.Windows.Forms.TextBox();
            this.textBoxZetaMax = new System.Windows.Forms.TextBox();
            this.textBoxMassMin = new System.Windows.Forms.TextBox();
            this.textBoxZetaMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPCross = new System.Windows.Forms.TextBox();
            this.textBoxPMutation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonRunGA = new System.Windows.Forms.Button();
            this.radioButtonMass = new System.Windows.Forms.RadioButton();
            this.radioButtonZeta = new System.Windows.Forms.RadioButton();
            this.radioButtonFreq = new System.Windows.Forms.RadioButton();
            this.textBoxFreqMax = new System.Windows.Forms.TextBox();
            this.textBoxFreqMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSensibility = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxOPError = new System.Windows.Forms.TextBox();
            this.textBoxOPZeta = new System.Windows.Forms.TextBox();
            this.textBoxOPFreq = new System.Windows.Forms.TextBox();
            this.textBoxOPMass = new System.Windows.Forms.TextBox();
            this.textBoxNFREQ_Order = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFitness
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFitness.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFitness.Legends.Add(legend3);
            this.chartFitness.Location = new System.Drawing.Point(-1, -2);
            this.chartFitness.Margin = new System.Windows.Forms.Padding(2);
            this.chartFitness.Name = "chartFitness";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            this.chartFitness.Series.Add(series6);
            this.chartFitness.Series.Add(series7);
            this.chartFitness.Size = new System.Drawing.Size(742, 306);
            this.chartFitness.TabIndex = 2;
            this.chartFitness.Text = "11";
            this.chartFitness.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart_mag_GetToolTipText);
            // 
            // chartParameters
            // 
            chartArea4.Name = "ChartArea1";
            this.chartParameters.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartParameters.Legends.Add(legend4);
            this.chartParameters.Location = new System.Drawing.Point(-1, 308);
            this.chartParameters.Margin = new System.Windows.Forms.Padding(2);
            this.chartParameters.Name = "chartParameters";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series3";
            this.chartParameters.Series.Add(series8);
            this.chartParameters.Series.Add(series9);
            this.chartParameters.Series.Add(series10);
            this.chartParameters.Size = new System.Drawing.Size(742, 306);
            this.chartParameters.TabIndex = 2;
            this.chartParameters.Text = "11";
            this.chartParameters.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart_mag_GetToolTipText);
            // 
            // textBoxMassMax
            // 
            this.textBoxMassMax.Location = new System.Drawing.Point(188, 646);
            this.textBoxMassMax.Name = "textBoxMassMax";
            this.textBoxMassMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxMassMax.TabIndex = 6;
            this.textBoxMassMax.Tag = "";
            this.textBoxMassMax.Text = "1";
            // 
            // textBoxZetaMax
            // 
            this.textBoxZetaMax.Location = new System.Drawing.Point(335, 646);
            this.textBoxZetaMax.Name = "textBoxZetaMax";
            this.textBoxZetaMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxZetaMax.TabIndex = 7;
            this.textBoxZetaMax.Text = "0.5";
            // 
            // textBoxMassMin
            // 
            this.textBoxMassMin.Location = new System.Drawing.Point(188, 674);
            this.textBoxMassMin.Name = "textBoxMassMin";
            this.textBoxMassMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMassMin.TabIndex = 10;
            this.textBoxMassMin.Text = "0.01";
            // 
            // textBoxZetaMin
            // 
            this.textBoxZetaMin.Location = new System.Drawing.Point(335, 674);
            this.textBoxZetaMin.Name = "textBoxZetaMin";
            this.textBoxZetaMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxZetaMin.TabIndex = 11;
            this.textBoxZetaMin.Text = "0.001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mass";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 653);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 653);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 678);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "Min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 631);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "Zeta";
            // 
            // textBoxPCross
            // 
            this.textBoxPCross.Location = new System.Drawing.Point(61, 770);
            this.textBoxPCross.Name = "textBoxPCross";
            this.textBoxPCross.Size = new System.Drawing.Size(45, 22);
            this.textBoxPCross.TabIndex = 7;
            this.textBoxPCross.Text = "0.9";
            // 
            // textBoxPMutation
            // 
            this.textBoxPMutation.Location = new System.Drawing.Point(124, 770);
            this.textBoxPMutation.Name = "textBoxPMutation";
            this.textBoxPMutation.Size = new System.Drawing.Size(45, 22);
            this.textBoxPMutation.TabIndex = 11;
            this.textBoxPMutation.Text = "0.1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 755);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "P Mut";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 755);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "P Cross";
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(192, 770);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(61, 22);
            this.textBoxPop.TabIndex = 7;
            this.textBoxPop.Text = "100";
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(274, 770);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(61, 22);
            this.textBoxGen.TabIndex = 11;
            this.textBoxGen.Text = "100";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 755);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "Gen";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(214, 755);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "Pop";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(164, 736);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 12);
            this.label19.TabIndex = 20;
            this.label19.Text = "Genenticn Algorithm parameters";
            // 
            // buttonRunGA
            // 
            this.buttonRunGA.Location = new System.Drawing.Point(656, 672);
            this.buttonRunGA.Name = "buttonRunGA";
            this.buttonRunGA.Size = new System.Drawing.Size(75, 23);
            this.buttonRunGA.TabIndex = 23;
            this.buttonRunGA.Text = "Run GA";
            this.buttonRunGA.UseVisualStyleBackColor = true;
            this.buttonRunGA.Click += new System.EventHandler(this.RunGAEnvent);
            // 
            // radioButtonMass
            // 
            this.radioButtonMass.AutoSize = true;
            this.radioButtonMass.Location = new System.Drawing.Point(651, 435);
            this.radioButtonMass.Name = "radioButtonMass";
            this.radioButtonMass.Size = new System.Drawing.Size(46, 16);
            this.radioButtonMass.TabIndex = 28;
            this.radioButtonMass.TabStop = true;
            this.radioButtonMass.Text = "Mass";
            this.radioButtonMass.UseVisualStyleBackColor = true;
            this.radioButtonMass.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonZeta
            // 
            this.radioButtonZeta.AutoSize = true;
            this.radioButtonZeta.Location = new System.Drawing.Point(651, 457);
            this.radioButtonZeta.Name = "radioButtonZeta";
            this.radioButtonZeta.Size = new System.Drawing.Size(43, 16);
            this.radioButtonZeta.TabIndex = 28;
            this.radioButtonZeta.TabStop = true;
            this.radioButtonZeta.Text = "Zeta";
            this.radioButtonZeta.UseVisualStyleBackColor = true;
            this.radioButtonZeta.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonFreq
            // 
            this.radioButtonFreq.AutoSize = true;
            this.radioButtonFreq.Location = new System.Drawing.Point(651, 479);
            this.radioButtonFreq.Name = "radioButtonFreq";
            this.radioButtonFreq.Size = new System.Drawing.Size(44, 16);
            this.radioButtonFreq.TabIndex = 28;
            this.radioButtonFreq.TabStop = true;
            this.radioButtonFreq.Text = "Freq";
            this.radioButtonFreq.UseVisualStyleBackColor = true;
            this.radioButtonFreq.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxFreqMax
            // 
            this.textBoxFreqMax.Location = new System.Drawing.Point(48, 646);
            this.textBoxFreqMax.Name = "textBoxFreqMax";
            this.textBoxFreqMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxFreqMax.TabIndex = 6;
            this.textBoxFreqMax.Tag = "";
            this.textBoxFreqMax.Text = "65";
            // 
            // textBoxFreqMin
            // 
            this.textBoxFreqMin.Location = new System.Drawing.Point(48, 674);
            this.textBoxFreqMin.Name = "textBoxFreqMin";
            this.textBoxFreqMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxFreqMin.TabIndex = 10;
            this.textBoxFreqMin.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "Freq";
            // 
            // textBoxSensibility
            // 
            this.textBoxSensibility.Location = new System.Drawing.Point(362, 773);
            this.textBoxSensibility.Name = "textBoxSensibility";
            this.textBoxSensibility.Size = new System.Drawing.Size(61, 22);
            this.textBoxSensibility.TabIndex = 7;
            this.textBoxSensibility.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 758);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fitness Scale";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 731);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "Zeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mass";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(533, 629);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "Optimal Values";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(489, 649);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 12);
            this.label20.TabIndex = 37;
            this.label20.Text = "Freq";
            // 
            // textBoxOPError
            // 
            this.textBoxOPError.Enabled = false;
            this.textBoxOPError.Location = new System.Drawing.Point(520, 726);
            this.textBoxOPError.Name = "textBoxOPError";
            this.textBoxOPError.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPError.TabIndex = 29;
            this.textBoxOPError.Text = "-2";
            // 
            // textBoxOPZeta
            // 
            this.textBoxOPZeta.Enabled = false;
            this.textBoxOPZeta.Location = new System.Drawing.Point(521, 700);
            this.textBoxOPZeta.Name = "textBoxOPZeta";
            this.textBoxOPZeta.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPZeta.TabIndex = 30;
            this.textBoxOPZeta.Text = "-2";
            // 
            // textBoxOPFreq
            // 
            this.textBoxOPFreq.Enabled = false;
            this.textBoxOPFreq.Location = new System.Drawing.Point(521, 644);
            this.textBoxOPFreq.Name = "textBoxOPFreq";
            this.textBoxOPFreq.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPFreq.TabIndex = 31;
            this.textBoxOPFreq.Text = "-2";
            // 
            // textBoxOPMass
            // 
            this.textBoxOPMass.Enabled = false;
            this.textBoxOPMass.Location = new System.Drawing.Point(521, 672);
            this.textBoxOPMass.Name = "textBoxOPMass";
            this.textBoxOPMass.Size = new System.Drawing.Size(101, 22);
            this.textBoxOPMass.TabIndex = 32;
            this.textBoxOPMass.Text = "-2";
            // 
            // textBoxNFREQ_Order
            // 
            this.textBoxNFREQ_Order.Location = new System.Drawing.Point(335, 705);
            this.textBoxNFREQ_Order.Name = "textBoxNFREQ_Order";
            this.textBoxNFREQ_Order.Size = new System.Drawing.Size(22, 22);
            this.textBoxNFREQ_Order.TabIndex = 10;
            this.textBoxNFREQ_Order.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(151, 710);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 12);
            this.label21.TabIndex = 20;
            this.label21.Text = "NATURAL FRQUENCY ORDER";
            // 
            // FormGAOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 818);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxOPError);
            this.Controls.Add(this.textBoxOPZeta);
            this.Controls.Add(this.textBoxOPFreq);
            this.Controls.Add(this.textBoxOPMass);
            this.Controls.Add(this.radioButtonMass);
            this.Controls.Add(this.radioButtonFreq);
            this.Controls.Add(this.radioButtonZeta);
            this.Controls.Add(this.buttonRunGA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxGen);
            this.Controls.Add(this.textBoxPMutation);
            this.Controls.Add(this.textBoxZetaMin);
            this.Controls.Add(this.textBoxNFREQ_Order);
            this.Controls.Add(this.textBoxFreqMin);
            this.Controls.Add(this.textBoxMassMin);
            this.Controls.Add(this.textBoxSensibility);
            this.Controls.Add(this.textBoxPop);
            this.Controls.Add(this.textBoxPCross);
            this.Controls.Add(this.textBoxZetaMax);
            this.Controls.Add(this.textBoxFreqMax);
            this.Controls.Add(this.textBoxMassMax);
            this.Controls.Add(this.chartParameters);
            this.Controls.Add(this.chartFitness);
            this.MaximizeBox = false;
            this.Name = "FormGAOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGAOptions";
            ((System.ComponentModel.ISupportInitialize)(this.chartFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFitness;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParameters;
        private System.Windows.Forms.TextBox textBoxMassMax;
        private System.Windows.Forms.TextBox textBoxZetaMax;
        private System.Windows.Forms.TextBox textBoxMassMin;
        private System.Windows.Forms.TextBox textBoxZetaMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPCross;
        private System.Windows.Forms.TextBox textBoxPMutation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonRunGA;
        private System.Windows.Forms.RadioButton radioButtonMass;
        private System.Windows.Forms.RadioButton radioButtonZeta;
        private System.Windows.Forms.RadioButton radioButtonFreq;
        private System.Windows.Forms.TextBox textBoxFreqMax;
        private System.Windows.Forms.TextBox textBoxFreqMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSensibility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxOPError;
        private System.Windows.Forms.TextBox textBoxOPZeta;
        private System.Windows.Forms.TextBox textBoxOPFreq;
        private System.Windows.Forms.TextBox textBoxOPMass;
        private System.Windows.Forms.TextBox textBoxNFREQ_Order;
        private System.Windows.Forms.Label label21;
    }
}
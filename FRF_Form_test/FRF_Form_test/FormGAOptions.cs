using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mechatronics.Analysis;
using Mechatronics.MathToolBox;
using Optimization;
using System.Windows.Forms.DataVisualization.Charting;

namespace FRF_Form_test
{
    public partial class FormGAOptions : Form
    {
        //Obj FormMain came by parameter
        public FormMain FormMain;
        //

        List<Mode> ReachedVLoopModes;

        private GAOptimization GAOPT;

        public bool IsThereDataAvailable { get; private set; }

        public FormGAOptions(FormMain formMain) 
        {
            InitializeComponent();
            ReachedVLoopModes = new List<Mode>();
            FormMain.CreateModes(ReachedVLoopModes);
            FormMain = formMain;
        }

        private void RunGAEnvent(object sender, EventArgs e)
        {
            buttonRunGA.Enabled = false;
            GeneticAlgorithmOptimization();
            buttonRunGA.Enabled = true;
        } //Checked

        public void GeneticAlgorithmOptimization()
        {
            List<Mode> NewVLoopModes = new List<Mode>();

            NewVLoopModes = ReachedVLoopModes;

            #region Setting up Ranges
            GeneticAlgorithm.Range Mass_range = new GeneticAlgorithm.Range { MinValue = FormMain.TryToDouble(textBoxMassMin.Text), MaxValue = FormMain.TryToDouble(textBoxMassMax.Text) };
            GeneticAlgorithm.Range Zeta_range = new GeneticAlgorithm.Range { MinValue = FormMain.TryToDouble(textBoxZetaMin.Text), MaxValue = FormMain.TryToDouble(textBoxZetaMax.Text) };

            #region Range frequencies: Peak Freq + range & Peak Freq - range
            GeneticAlgorithm.Range Freq1_rage = new GeneticAlgorithm.Range
            {
                MinValue = FormMain.TryToDouble(textBoxFreq1.Text) - FormMain.TryToDouble(textBoxFreqRange1.Text),
                MaxValue = FormMain.TryToDouble(textBoxFreq1.Text) + FormMain.TryToDouble(textBoxFreqRange1.Text)
            };

            GeneticAlgorithm.Range Freq2_rage = new GeneticAlgorithm.Range
            {
                MinValue = FormMain.TryToDouble(textBoxFreq2.Text) - FormMain.TryToDouble(textBoxFreqRange2.Text),
                MaxValue = FormMain.TryToDouble(textBoxFreq2.Text) + FormMain.TryToDouble(textBoxFreqRange2.Text)
            };

            GeneticAlgorithm.Range Freq3_rage = new GeneticAlgorithm.Range
            {
                MinValue = FormMain.TryToDouble(textBoxFreq3.Text) - FormMain.TryToDouble(textBoxFreqRange3.Text),
                MaxValue = FormMain.TryToDouble(textBoxFreq3.Text) + FormMain.TryToDouble(textBoxFreqRange3.Text)
            };
            #endregion

            GAOPT = new GAOptimization(Mass_range, Zeta_range, Freq1_rage, Freq2_rage, Freq3_rage);
            #endregion

            //GAOPT.SetOptimizationParameters(pop,pcross,pmutation,generations,sensibitily)
            #region Setting GA
            GAOPT.SetOptimizationParameters((int)FormMain.TryToDouble(textBoxPop.Text),
                                              FormMain.TryToDouble(textBoxPCross.Text),
                                              FormMain.TryToDouble(textBoxPMutation.Text),
                                              (int)FormMain.TryToDouble(textBoxGen.Text),
                                              FormMain.TryToDouble(textBoxSensibility.Text),
                                              checkBoxInitialValues.Checked
                                              );
            #endregion

            GAOPT.SettingReference(FormMain.VClose_ref, FormMain.VR);

            List<Mode> newModes = new List<Mode>();
            newModes = GAOPT.Solve();

            #region Writting Results
            textBoxOPFreq.Text = newModes[0].Freq.ToString("0.000") + "-" + newModes[1].Freq.ToString("0.000") + "-" + newModes[2].Freq.ToString("0.000");
            textBoxOPMass.Text = newModes[0].Mass.ToString("0.000") + "-" + newModes[1].Mass.ToString("0.000") + "-" + newModes[2].Mass.ToString("0.000");
            textBoxOPZeta.Text = newModes[0].Zeta.ToString("0.000") + "-" + newModes[1].Zeta.ToString("0.000") + "-" + newModes[2].Zeta.ToString("0.000");
            textBoxOPError.Text = (GAOPT.Sensibility/GAOPT.GA.OPTResult.target[0]).ToString();
            #endregion

            IsThereDataAvailable = true;
            PlottingGAData();

            NewVLoopModes = newModes;

            FormMain.VR.VLoopModes = NewVLoopModes;

            //Evaluation
            GAOPT.ResultOPT = FormMain.VR.SolveCloseLoopResponse();

            // draw simulated FRF chart in FormMain

            FormMain.DrawResult(GAOPT.ResultOPT);

        }

        public class GAOptimization
        {
            public GeneticAlgorithm GA;
            public double Sensibility { get; set; }
            public FRF[] Target { get; set; }
            public FRF[] ResultOPT { get; set; }
            private VelocityResponse VR;

            private List<GeneticAlgorithm.Range> Features;// internal Varaiable to GA

            //Constructure: Create det OBJ and define "Features" to GA
            public GAOptimization(GeneticAlgorithm.Range mass_range, GeneticAlgorithm.Range zeta_range, GeneticAlgorithm.Range freq1_rage, GeneticAlgorithm.Range freq2_rage, GeneticAlgorithm.Range freq3_rage) 
            {
              
                Features = new List<GeneticAlgorithm.Range>();
                Features.Add(mass_range);
                Features.Add(zeta_range);
                Features.Add(freq1_rage);

                Features.Add(mass_range);
                Features.Add(zeta_range);
                Features.Add(freq2_rage);

                Features.Add(mass_range);
                Features.Add(zeta_range);
                Features.Add(freq3_rage);
            }

            public void SetOptimizationParameters(int population, double pcross, double pmutation, int generations, double sensibility, bool initialValues)
            {
                Sensibility = sensibility;
                GA = new GeneticAlgorithm(population, Features, pcross, pmutation, generations);

                GA.IsPatternAvailable = initialValues; // Setting Initial Values
                List<Mode> initialModes = new List<Mode>();
                FormMain.CreateModes(initialModes);

                double[] aux = new double[Features.Count];
                for(int i =0; i < initialModes.Count; i++)
                {
                    aux[0 + i*3] = initialModes[i].Mass;
                    aux[1 + i*3] = initialModes[i].Zeta;
                    aux[2 + i*3] = initialModes[i].Freq;
                }

                GA.PatternFeature = (double[])aux.Clone();

            }

            private double ObjFunction(double[] parameters)
            {

                List<Mode> VLoopModes = new List<Mode>();

                for(int i =0; i<3; i++)
                {
                    Mode mode = new Mode();
                    //It shoud be in this order
                    mode.Freq = parameters[2 + 3 * i];
                    mode.Mass = parameters[0 + 3 * i];
                    mode.Zeta = parameters[1 + 3 * i];
                    VLoopModes.Add(mode);
                }
  
                VR.VLoopModes = VLoopModes;

                FRF[] Eval = VR.SolveCloseLoopResponse();
                
                double LocalErrorMag = 0;
                double LocalErrorPha = 0;
                for (int i = 0; i < Target.Length; i++)
                {
                    LocalErrorMag = Math.Abs(Target[i].Mag - Eval[i].Mag) + LocalErrorMag;
                    LocalErrorPha = Math.Abs(Target[i].Phs - Eval[i].Phs) + LocalErrorPha;
                }

                return (Sensibility / LocalErrorMag) + (Sensibility / LocalErrorPha);
            }

            public List<Mode> Solve()
            {


                List<Mode> result = new List<Mode>();

                GA.Solve(ObjFunction);
                double[] BestParameters = GA.OPTResult.Parameters;
                //Should be in this oreder 2 - 0 - 1       
                for (int i = 0; i < 3; i++)
                {
                    Mode aux = new Mode();
                    aux.Freq = BestParameters[2 + i * 3];
                    aux.Mass = BestParameters[0 + i * 3];
                    aux.Zeta = BestParameters[1 + i * 3];                  
                    result.Add(aux);
                }

               return result;
            }

            internal void SettingReference(FRF[] vClose_ref, VelocityResponse vR)
            {
                Target = vClose_ref;
                VR = vR;
            }
        }


        #region Fix Code
        private void chart_mag_GetToolTipText(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint myPoint = (DataPoint)(e.HitTestResult.Object);
                e.Text = "X value: " + myPoint.XValue + Environment.NewLine;
                e.Text += "Y value: " + myPoint.YValues[0] + Environment.NewLine;
            }
        }

        void DrawLine(double[] Data, int Channel, Chart chart)
        {

            //reset
            chart.Series[Channel].Points.Clear();

            for (int i = 0; i < Data.Length; i++)
            {
                chart.Series[Channel].Points.AddXY(i, Data[i]);
            }

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlottingGAData();
        }

        private void PlottingGAData()
        {
            if (IsThereDataAvailable)
            {
                DrawLine(GAOPT.GA.GetMaxFitnessHistory(), 0, chartFitness);
                DrawLine(GAOPT.GA.GetMeanFitnessHistory(), 1, chartFitness);

                if (radioButtonMass.Checked)
                {
                    DrawLine(GAOPT.GA.GetFeatureHistory(0), 0, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(3), 1, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(6), 2, chartParameters);
                }
                if (radioButtonZeta.Checked)
                {
                    DrawLine(GAOPT.GA.GetFeatureHistory(1), 0, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(4), 1, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(7), 2, chartParameters);
                }
                if (radioButtonFreq.Checked)
                {
                    DrawLine(GAOPT.GA.GetFeatureHistory(2), 0, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(5), 1, chartParameters);
                    DrawLine(GAOPT.GA.GetFeatureHistory(8), 2, chartParameters);
                }
            }
           
        }

        #endregion

      
    }
}


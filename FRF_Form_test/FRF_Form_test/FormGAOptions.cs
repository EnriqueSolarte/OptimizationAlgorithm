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
        //Comming from Main
        private static FRF[] VClose_ref;
        private static VelocityResponse VR;
        //
        List<Mode> ReachedVLoopModes;

        private GAOptimization GAOPT;
        public FormMain FormMain;

        public FormGAOptions(FRF[] vClose_ref, VelocityResponse vR, FormMain formMain) 
        {
            VClose_ref = vClose_ref;
            VR = new VelocityResponse();
            VR = vR;
            InitializeComponent();
            ReachedVLoopModes = new List<Mode>();
            FormMain.CreateModes(ReachedVLoopModes);
            FormMain = formMain;
        }

        private void RunGAEnvent(object sender, EventArgs e)
        {
            GeneticAlgorithmOptimization();
        } //Checked

        public void GeneticAlgorithmOptimization()
        {
            List<Mode> NewVLoopModes = new List<Mode>();

            NewVLoopModes = ReachedVLoopModes;

            GeneticAlgorithm.Range Mass_range = new GeneticAlgorithm.Range { MinValue = FormMain.TryToDouble(textBoxMassMin.Text), MaxValue = FormMain.TryToDouble(textBoxMassMax.Text) };
            GeneticAlgorithm.Range Zeta_range = new GeneticAlgorithm.Range { MinValue = FormMain.TryToDouble(textBoxZetaMin.Text), MaxValue = FormMain.TryToDouble(textBoxZetaMax.Text) };
            GeneticAlgorithm.Range FrequencyRange = new GeneticAlgorithm.Range { MinValue = FormMain.TryToDouble(textBoxFreqMin.Text), MaxValue = FormMain.TryToDouble(textBoxFreqMax.Text) };

            GAOPT = new GAOptimization(Mass_range, Zeta_range, FrequencyRange);

            //GAOPT.SetOptimizationParameters(pop,pcross,pmutation,generations,sensibitily)
            GAOPT.SetOptimizationParameters((int)FormMain.TryToDouble(textBoxPop.Text),
                                              FormMain.TryToDouble(textBoxPCross.Text),
                                              FormMain.TryToDouble(textBoxPMutation.Text),
                                              (int)FormMain.TryToDouble(textBoxGen.Text),
                                              FormMain.TryToDouble(textBoxSensibility.Text));

            GAOPT.SetReference(VClose_ref, VR, NewVLoopModes, (int)FormMain.TryToDouble(textBoxNFREQ_Order.Text)-1);

            Mode newMode = new Mode();
            newMode = GAOPT.Solve();

            textBoxOPFreq.Text = newMode.Freq.ToString();
            textBoxOPMass.Text = newMode.Mass.ToString();
            textBoxOPZeta.Text = newMode.Zeta.ToString();
            textBoxOPError.Text = (GAOPT.Sensibility/GAOPT.GA.OPTResult.target[0]).ToString();

            PlottingGAData();

            NewVLoopModes[(int)FormMain.TryToDouble(textBoxNFREQ_Order.Text)-1] = newMode;

            VR.VLoopModes = NewVLoopModes;

            //Evaluation
            GAOPT.ResultOPT = VR.SolveCloseLoopResponse();

            // draw simulated FRF chart in FormMain

            FormMain.DrawResult(GAOPT.ResultOPT);

        }

        public class GAOptimization
        {
            public GeneticAlgorithm GA;

            public GeneticAlgorithm.Range FrequencyRange { get; set; }
            public GeneticAlgorithm.Range Mass_range { get; set; }
            public GeneticAlgorithm.Range Zeta_range { get; set; }

            public double Sensibility { get; set; }
            public int IndexMode { get; set; }
            public FRF[] Target { get; set; }
            public FRF[] ResultOPT { get; set; }

            private List<GeneticAlgorithm.Range> Features;// internal Varaiable to GA

            private List<Mode> InitialModes;

            public GAOptimization(GeneticAlgorithm.Range mass_range, GeneticAlgorithm.Range zeta_range, GeneticAlgorithm.Range frequencyRange)
            {
                Mass_range = mass_range;
                Zeta_range = zeta_range;
                FrequencyRange = frequencyRange;

            }

            public void SetOptimizationParameters(int population, double pcross, double pmutation, int generations, double sensibility)
            {

                Sensibility = sensibility;
                Features = new List<GeneticAlgorithm.Range>();
                Features.Add(Mass_range);
                Features.Add(Zeta_range);
                Features.Add(FrequencyRange);

                GA = new GeneticAlgorithm(population, Features, pcross, pmutation, generations);
            }

            public Mode Solve()
            {

                SetReference(VClose_ref, VR, InitialModes, IndexMode);
                Mode result = new Mode();

                GA.Solve(ObjFunction);
                double[] BestParameters = GA.OPTResult.Parameters;
                //Should be in this oreder 2 0 1
                result.Freq = BestParameters[2];
                result.Mass = BestParameters[0];
                result.Zeta = BestParameters[1];
                
                return result;
            }

            private double ObjFunction(double[] parameters)
            {

                List<Mode> VLoopModes = new List<Mode>();

                Mode mode = new Mode();
                //It shoud be in this order
                mode.Freq = parameters[2];
                mode.Mass = parameters[0];
                mode.Zeta = parameters[1];
                

                VLoopModes = InitialModes;
                VLoopModes[IndexMode] = mode;

                VR.VLoopModes = VLoopModes;
                FRF[] Eval = VR.SolveCloseLoopResponse();

                FRF[] Target = GettingRegionReference(VClose_ref);
                FRF[] RegionEval = GettingRegionReference(Eval);


                double LocalError = 0;
                for (int i = 0; i < RegionEval.Length; i++)
                {
                    LocalError = Math.Abs(Target[i].Mag - RegionEval[i].Mag) + LocalError;
                }

                return Sensibility / LocalError;
            }

            public void SetReference(FRF[] vClose_ref, VelocityResponse vR, List<Mode> initialModes, int indexMode)
            {
                VClose_ref = vClose_ref;
                VR = vR;
                IndexMode = indexMode;
                Target = GettingRegionReference(vClose_ref);
                InitialModes = initialModes;

            }

            private FRF[] GettingRegionReference(FRF[] vRef)
            {
                List<FRF> target = new List<FRF>();

                for (int data = 0; data < vRef.Length; data++)
                {
                    if (vRef[data].Freq >= FrequencyRange.MinValue && vRef[data].Freq <= FrequencyRange.MaxValue)
                    {
                        FRF _target = new FRF();
                        _target = vRef[data];
                        target.Add(_target);
                    }
                }
                return (FRF[])target.ToArray().Clone();
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
            DrawLine(GAOPT.GA.GetMaxFitnessHistory(), 0, chartFitness);
            DrawLine(GAOPT.GA.GetMeanFitnessHistory(), 1, chartFitness);

            if (radioButtonMass.Checked) { DrawLine(GAOPT.GA.GetFeatureHistory(0), 0, chartParameters); chartParameters.Series[1].Points.Clear(); chartParameters.Series[2].Points.Clear(); }
            if (radioButtonZeta.Checked) { DrawLine(GAOPT.GA.GetFeatureHistory(1), 1, chartParameters); chartParameters.Series[0].Points.Clear(); chartParameters.Series[2].Points.Clear(); }
            if (radioButtonFreq.Checked) { DrawLine(GAOPT.GA.GetFeatureHistory(2), 2, chartParameters); chartParameters.Series[1].Points.Clear(); chartParameters.Series[0].Points.Clear(); }

        }

        #endregion

      
    }
}


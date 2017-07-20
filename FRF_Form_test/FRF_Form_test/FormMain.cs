using System.Collections.Generic;
using System.Windows.Forms;
using Mechatronics.MathToolBox;
using Mechatronics.MSMObject;
using Mechatronics.Analysis;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace FRF_Form_test
{
    public partial class FormMain : Form
    {
        FRF[] VClose_ref;
        VelocityResponse VR;
       

        public FormMain()
        {
            InitializeComponent();

            //Function object
            VR = new VelocityResponse();

            //Set experiment Control Parameters (C controller)
            Parameters P = new Parameters();
            SetParameters(P);
            VR.P = P;

            //Defining target, read FRF file from csv file, which is created by servoguide
            VClose_ref = VR.ReadServoGuide_FRFdata_csv("Frequency_Response_Axis-1_1_-_1000Hz.csv");
            VR.IsFreqDataSameAsRef = true;

            DrawLine(VClose_ref, 0,chart_mag,chart_phs);

        }
       
        #region Fixed Code

        public static void CreateModes(List<Mode> VLoopModes)
        {

            Mode mode;

            mode = new Mode();
            mode.Freq = 55;
            mode.Zeta = 0.1;
            mode.Mass = 0.3;
            VLoopModes.Add(mode);


            mode = new Mode();
            mode.Freq = 120;
            mode.Zeta = 0.07;
            mode.Mass = 0.1;
            VLoopModes.Add(mode);

            mode = new Mode();
            mode.Freq = 315;
            mode.Zeta = 0.1;
            mode.Mass = 0.05;
            VLoopModes.Add(mode);

        }
        void SetParameters(Parameters P)
        {//value is from *.prm file (ServoGuide Parameter file)
            P.FANUCs.HRVGain = 300;
            P.FANUCs.VelocityLoopGain = 100;
            P.FANUCs.No2043_KVI_Standard = 198;
            P.FANUCs.No2044_KVP_Standard = -1775;
            P.FANUCs.No2043_KVI_Setting = 198;
            P.FANUCs.No2044_KVP_Setting = -1775;




            P.Jm = 0.012;
            P.Kt = 1.2;
            P.dTzoh = 0.001m;
            P.Tc = 0;
            P.JL = 0.00546;
            P.IsHighCycle = true;
            P.IsFullCloseLoop = true;

            P.ConvertFUNUCParamters();


           
        }

        private void DrawLine(FRF[] FRFData, int Channel)
        {

            //X AXIS in log scale
            chart_mag.ChartAreas[0].AxisX.IsLogarithmic = true;
            chart_phs.ChartAreas[0].AxisX.IsLogarithmic = true;

            //reset
            chart_mag.Series[Channel].Points.Clear();
            chart_phs.Series[Channel].Points.Clear();

            for (int i = 0; i < FRFData.Length; i++)
            {
                chart_mag.Series[Channel].Points.AddXY(FRFData[i].Freq, Mechatronics.MathToolBox.TL.DB(FRFData[i].Mag));
                chart_phs.Series[Channel].Points.AddXY(FRFData[i].Freq, FRFData[i].Phs);

            }
        }
        internal static void DrawLine(FRF[] FRFData, int Channel, Chart Chart_mag, Chart Chart_phs)
        {
            //X AXIS in log scale
            Chart_mag.ChartAreas[0].AxisX.IsLogarithmic = true;
            Chart_phs.ChartAreas[0].AxisX.IsLogarithmic = true;

            //reset
            Chart_mag.Series[Channel].Points.Clear();
            Chart_phs.Series[Channel].Points.Clear();

            for (int i = 0; i < FRFData.Length; i++)
            {
                Chart_mag.Series[Channel].Points.AddXY(FRFData[i].Freq, Mechatronics.MathToolBox.TL.DB(FRFData[i].Mag));
                Chart_phs.Series[Channel].Points.AddXY(FRFData[i].Freq, FRFData[i].Phs);
            }
        }

        internal void DrawResult(FRF[] resultOPT)
        {
            DrawLine(resultOPT, 1, chart_mag, chart_phs);
        }

        private void InformationTipEvent(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint myPoint = (DataPoint)(e.HitTestResult.Object);
                e.Text = "X value: " + myPoint.XValue + Environment.NewLine;
                e.Text += "Y value: " + myPoint.YValues[0] + Environment.NewLine;
            }
        }

       
        #endregion

        #region MyRegion

        #region Fix Code
        public class InitialResonatPeak
        {
            public double ResonantMagPeak;
            public double ResonantFreqPeak;       
        }

        private InitialResonatPeak GetInitialValues()
        {
            InitialResonatPeak _InitialValues = new InitialResonatPeak();



            return _InitialValues;
        }

        private void ChangedResonantPeakEvent(object sender, EventArgs e)
        {

        }

        public static double TryToDouble(string stringValue)
        {
            double auxOut;
            double.TryParse(stringValue, out auxOut);
            return auxOut;
        }

        #endregion


        private void GeneticAlgorithmEvent(object sender, EventArgs e)
        {           
            FormGAOptions GAForm = new FormGAOptions((FRF[])VClose_ref.Clone(), VR, this);
            GAForm.Show();
        
            
        }

        
        #endregion

        
    }





}
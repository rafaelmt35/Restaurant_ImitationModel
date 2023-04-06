using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restaurant_imitationmodel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        double NBEval, NGCval, NBFval, ACval, SCval, NGEval;
        double COMval;
        double REV =0.0;
        double TBE,GQE, FQC, GQF,IC,Q,SATC;
        double CPL = 5.0;
        int hours = 0;
        Random rnd = new Random();

        private void btRun_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                hours = 0;
                timer1.Stop();
            }
            else
            {
                chart1.Series[0].Points.Clear();          
                timer1.Start();
                NBEval = (double)NBE.Value;
                NGCval = (double)NGC.Value;
                NBFval = (double)NBF.Value;
                ACval = (double)AC.Value;
                COMval = (double)COM.Value;
                SCval = (double)SC.Value;
                NGEval = (double)NGE.Value;          
                chart1.Series[0].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.None;
                chart1.Series[0].Points.AddXY(0, REV);
               
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hours++;
          
            if(NBEval - TBE > 0)
            {
                TBE += hours * (NBEval - TBE);
            }
            GQE = TBE + NGEval;
            if (NBFval - FQC > 0 )
            {
                FQC += NBFval - FQC;
            }

            GQF = FQC + Math.Round(NGCval / 3);
            IC = ACval * COMval;
            if (IC < 100)
            {
                Q = 0;
            }
            else
            {
                Q = 20-IC - SCval + CPL;
            }
            SCval -= 5;

            SATC = (GQE / 30 + GQF / 100) / 2 - (Q / 20) * 5 + (SCval / 100) * 5;
            REV = (REV + SATC) / 2;
       
            Console.WriteLine("DOUBLE : " + rnd.NextDouble());
            Console.WriteLine("TBE : " +TBE); 
            Console.WriteLine("FQC : " + FQC); 
            Console.WriteLine("GQE : " + GQE); 
            Console.WriteLine("GQF : " + GQF);
            Console.WriteLine("IC : " + IC);
            Console.WriteLine("Q : " + Q);
            Console.WriteLine("SATC : " + SATC);
            Console.WriteLine("REV : " + REV);
            chart1.Series[0].Points.AddXY(hours, REV);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4
{
    public partial class frmMain : Form
    {
        
        Random rand = new Random();
        int numIterations, numBins, nMin_mean, nMax_stddev, Pvmean_min, Pvstddev_max;



        public frmMain()
        {
            InitializeComponent();
        }

        
        //Part B
        public int GetRandomUniform(int min, int max)
        {
            int uniform;
            uniform = rand.Next(min, max + 1);
            return uniform;

        }
        public double GetRandomNormal(double mean, double stddev)
        {
            // Box-Muller Transformation 
            double r, phi, z, x;
            r = rand.NextDouble();
            phi = rand.NextDouble();
            z = (Math.Cos(2 * Math.PI * r)) * (Math.Sqrt(-2 * Math.Log(phi)));
            // z is normal with mean = 0 and stddev = 1.  
            // We use our values of mean and stddev to   // scale z, giving us x.    
            x = (z * stddev) + mean;
            return x;
        }
        public int GetBinIndex(double mini, double maxi, int numbins, double valuetobin)
        {
            int binIndex;
            binIndex = (int)Math.Ceiling((valuetobin - mini) * (numbins / (maxi - mini)));
            return binIndex;
            //valuetobin is Pt to be assigned to a bin  
            //mini is Ptmin  
            //maxi is Ptmax  
            //numbins is number of bins 
        }

        //Part C
        private void btnRun_Click(object sender, EventArgs e)
        {

           

            double total_profit = 0;
            double n = 0;
            double Pv = 0;

            

            if (
                    int.TryParse(txtNumBins.Text, out numBins) == true
                    && int.TryParse(txtNumIterations.Text, out numIterations) == true
                    && int.TryParse(txtNmean_minimum.Text, out nMin_mean) == true
                    && int.TryParse(txtNstddev_maximum.Text, out nMax_stddev) == true
                    && int.TryParse(txtPVmean_minimum.Text, out Pvmean_min) == true
                    && int.TryParse(txtPVstddev_maximum.Text, out Pvstddev_max) == true
               )
            {
                // Create an Array to stor number of bins
                int[] ArrBins = new int[numBins];
                double nMin=0, nMax=0, pvMin=0, pvMax=0, Pt, PtMin=0, PtMax=0;

                for (int i = 0; i < numIterations; i++)
                {
                    if (rdoPVNormal.Checked == true)
                    {
                        Pv = GetRandomNormal(Pvmean_min, Pvstddev_max);
                        //Pv Standard Dev included
                        pvMin = Pvmean_min - 3 * Pvstddev_max;
                        pvMax = Pvmean_min + 3 * Pvstddev_max;
                    }
                    else if (rdoPVuniform.Checked == true)
                    {
                        Pv = GetRandomUniform(Pvmean_min, Pvstddev_max);
                        //Directly from txtbox
                        pvMin = Pvmean_min;
                        pvMax = Pvstddev_max;
                    }





                    if (rdoNormal.Checked == true)
                    {
                        n = GetRandomNormal(nMin_mean, nMax_stddev);
                        //Pv Standard Dev included
                        nMin = nMin_mean - 3 * nMax_stddev;
                        nMax = nMin_mean + 3 * nMax_stddev;
                    }
                    else if (rdoNuniform.Checked == true)
                    {
                        n = GetRandomUniform(nMin_mean, nMax_stddev);
                        //Directly from txtbox
                        nMin = nMin_mean;
                        nMax = nMax_stddev;
                    }
                    //Calculating the average
                    PtMax = nMax * pvMax;
                    PtMin = nMin * pvMin;
                    Pt = n * Pv;
                    total_profit = total_profit + Pt;
                    //Getting bin index
                    if (Pt > PtMin && Pt <PtMax)
                    {
                        int Bin_Index = GetBinIndex(PtMin, PtMax, numBins, Pt) - 1;

                        ArrBins[Bin_Index]++;

                    }
                    
                }
                double avg_profit = total_profit / numIterations;
                //Start drawing the chart
                Chart.Series[0].Points.Clear();
                //Calculate the increment for the x - axis
                int x;
                int inc =  ((int)PtMax - (int)PtMin) / numBins;

                x = (int) (PtMin + 0.5 * inc);



                //Creating a loop to assagn values for the x and y axis
                for (int i =0 ; i < numBins; i++)
                {
                    Chart.Series[0].Points.AddXY(i, ArrBins[i]);
                    Chart.Series[0].Points[i].AxisLabel = (x).ToString();
                    x += inc;

                }


            }

            
        }
        
        


        //Changing the labels to match the radio buttons
        private void rdoPVuniform_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPVuniform.Checked==true)
            {
                lblPVmean_minimum.Text = "Minimum";
                lblPVstddev_maximum.Text = "Maximum";
            }else
            {
                lblPVmean_minimum.Text = "Mean";
                lblPVstddev_maximum.Text = "Standard Deviation";
            }
        }
        private void rdoNuniform_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNuniform.Checked == true)
            {
                lblNmean_minimum.Text = "Minimum";
                lblNstddev_maximum.Text = "Maximum";
            }
            else
            {
                lblNmean_minimum.Text = "Mean";
                lblNstddev_maximum.Text = "Standard Deviation";
            }

        }
    }
    
}

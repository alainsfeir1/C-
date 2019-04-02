/* Lab 6
 SEMESTER Winter 2019 
 Alain, Sfeir 
 I fully understand the following statement. 
 OU PLAGIARISM POLICY 
 ‘All members of the academic community at Oakland are expected to practice and 
 uphold ‘standards of academic integrity and honesty. An instructor is expected to 
 inform and instruct students about the procedures and standards of research and 
 documentation required of students ‘in fulfilling course work. A student is expected 
 to follow such instructions and be sure the rules ‘and procedures are understood in 
 order to avoid inadvertent misrepresentation of his/her work. ‘Students must assume that 
 individual (unaided) work on exams and lab reports and documentation ‘of sources is 
 expected unless the instructor specifically says that is not necessary. 
 
‘The following definitions are some examples of academic dishonesty:  
‘Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without ‘giving the 
other person credit; by doing this, a student is, in effect, claiming credit for 
‘someone else's thinking. Whether the student has read or heard the information she/he 
uses, ‘the student must document the source of information. When dealing with written sources,
‘a clear distinction would be made between quotations (which reproduce information 
from ‘the source word-for-word within quotation marks) and paraphrases (which digest 
the ‘source information and produce it in the student's own words). Both direct quotations
and  ‘paraphrases must be documented. Just because a student rephrases, 
condenses or selects ‘from another person's work, the ideas are still the other person's,
and failure to give ‘credit constitutes misrepresentation of the student's actual work 
and plagiarism of ‘another's ideas. Naturally, buying a paper and handing it in as one's
own work is ‘plagiarism. 
‘Cheating on lab reports falsifying data or submitting data not based on student's own work. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Alain_Sfeir
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void Grapher()
        {
            //clear the graph
            chtMain.Series[0].Points.Clear();

            //initialize the variables
            double xmin, xmax, ymin, ymax, numb_points;
            double a, b, c;

            //Convert the string to double
            double.TryParse(txtXmin.Text, out xmin);
            double.TryParse(txtXmax.Text, out xmax);
            double.TryParse(txtYmin.Text, out ymin);
            double.TryParse(txtYmax.Text, out ymax);
            double.TryParse(txtnumPoints.Text, out numb_points);

            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            double.TryParse(txtC.Text, out c);

            //x-axis
            chtMain.ChartAreas[0].Axes[0].Minimum = xmin;
            chtMain.ChartAreas[0].Axes[0].Maximum = xmax;

            //y-axis
            chtMain.ChartAreas[0].Axes[1].Minimum = ymin;
            chtMain.ChartAreas[0].Axes[1].Maximum = ymax;

            double x;
            double y;
            // for loop the graph the function
            for (double i = xmin; i <= numb_points ; i += 0.05)
            {
                x = i;
                y = (a * Math.Pow(x, 2) + b * x + c);
                chtMain.Series[0].Points.AddXY(x, y);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtXmax_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtXmin_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtYmin_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtYmax_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }

        private void txtnumPoints_TextChanged(object sender, EventArgs e)
        {
            Grapher();
        }
    }
}


/* Lab 7
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
using System.IO;

namespace Lab7_Alain_Sfeir
{
    public partial class frmMain : Form
    {   //create a structure
        public struct Numbers
        {
            //first complex number
            public int numX;
            public int numY;
            
        }
        //create a list
        Numbers[] mylist = new Numbers[100];
        public frmMain()
        {
            string temp;
            string[] detail;
            int idx = 0;
            InitializeComponent();
            StreamReader myFile;
            myFile = File.OpenText("Input.txt");

            while (!myFile.EndOfStream)
            {
                temp = myFile.ReadLine();
    
                detail = temp.Split(',');
                //put the split 
                int.TryParse(detail[0], out mylist[idx].numX);
                int.TryParse(detail[1], out mylist[idx].numY);
                

                idx++;
            }
        }
   
        
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Method to calculate the addition
        public string Addition(int real1, int imaginary1, int real2, int imaginary2 )
        {
            string result;
            result = ComplexMath.MathFunctions.Add(real1, imaginary1, real2, imaginary2);
            return result;
        }
        // Method to calculate the subtraction
        public string Subtraction(int real1, int imaginary1, int real2, int imaginary2)
        {
            string result;
            result = ComplexMath.MathFunctions.Subtract(real1, imaginary1, real2, imaginary2);
            return result;
        }
        // Method to calculate the multiplication
        public string Multiply(int real1, int imaginary1, int real2, int imaginary2)
        {
            string result;
            result = ComplexMath.MathFunctions.Multiply(real1, imaginary1, real2, imaginary2);
            return result;
        }
        // Method to calculate the division
        public string Divide(int real1, int imaginary1, int real2, int imaginary2)
        {
            string result;
            result = ComplexMath.MathFunctions.Divide(real1, imaginary1, real2, imaginary2);
            return result;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///// Function for calculating the user input 
        private void btnAdduser_Click(object sender, EventArgs e)
        {
            string solution;
            int real1=0, imaginary1=0, real2=0, imaginary2=0;
            int.TryParse(txtnum1X.Text, out real1);
            int.TryParse(txtnum1y.Text, out imaginary1);
            int.TryParse(txtnum2x.Text, out real2);
            int.TryParse(txtnum2y.Text, out imaginary2);
            solution = Addition(real1, imaginary1, real2, imaginary2);
            lblAnswer.Text = solution.ToString();
        }

        private void btnSubtractuser_Click(object sender, EventArgs e)
        {
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            int.TryParse(txtnum1X.Text, out real1);
            int.TryParse(txtnum1y.Text, out imaginary1);
            int.TryParse(txtnum2x.Text, out real2);
            int.TryParse(txtnum2y.Text, out imaginary2);
            solution = Subtraction(real1, imaginary1, real2, imaginary2);
            lblAnswer.Text = solution.ToString();

        }

        private void btnMultiplyuser_Click(object sender, EventArgs e)
        {
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            int.TryParse(txtnum1X.Text, out real1);
            int.TryParse(txtnum1y.Text, out imaginary1);
            int.TryParse(txtnum2x.Text, out real2);
            int.TryParse(txtnum2y.Text, out imaginary2);
            solution = Multiply(real1, imaginary1, real2, imaginary2);
            lblAnswer.Text = solution.ToString();
        }

        private void btnDivideuser_Click(object sender, EventArgs e)
        {
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            int.TryParse(txtnum1X.Text, out real1);
            int.TryParse(txtnum1y.Text, out imaginary1);
            int.TryParse(txtnum2x.Text, out real2);
            int.TryParse(txtnum2y.Text, out imaginary2);
            solution = Divide(real1, imaginary1, real2, imaginary2);
            lblAnswer.Text = solution.ToString();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///Add the list
        private void btnAddtxt_Click(object sender, EventArgs e)
        {
            //clear the list
            lstAnswertxt.Items.Clear();
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            //loop through the list
            for (int i = 0; i<=14; i+=2)
            {
                //first number
                real1 = mylist[i].numX;
                imaginary1 = mylist[i].numY;
                //second number
                real2 = mylist[i+1].numX;
                imaginary2 = mylist[i+1].numY;
                // add extra 2 to i so that we go to next 2 numbers
                
                solution = Addition(real1, imaginary1, real2, imaginary2);
                lstAnswertxt.Items.Add(solution);
                

            }
        }

        private void btnSubtracttxt_Click(object sender, EventArgs e)
        {
            //clear the list
            lstAnswertxt.Items.Clear();
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            //loop through the list
            for (int i = 0; i <= 14; i += 2)
            {
                //first number
                real1 = mylist[i].numX;
                imaginary1 = mylist[i].numY;
                //second number
                real2 = mylist[i + 1].numX;
                imaginary2 = mylist[i + 1].numY;
                // add extra 2 to i so that we go to next 2 numbers

                solution = Subtraction(real1, imaginary1, real2, imaginary2);
                lstAnswertxt.Items.Add(solution);


            }

        }

        private void btnMultiplytxt_Click(object sender, EventArgs e)
        {
            //clear the list
            lstAnswertxt.Items.Clear();
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            //loop through the list
            for (int i = 0; i <= 14; i += 2)
            {
                //first number
                real1 = mylist[i].numX;
                imaginary1 = mylist[i].numY;
                //second number
                real2 = mylist[i + 1].numX;
                imaginary2 = mylist[i + 1].numY;
                // add extra 2 to i so that we go to next 2 numbers

                solution = Multiply(real1, imaginary1, real2, imaginary2);
                lstAnswertxt.Items.Add(solution);

            }
        }

        private void btnDividetxt_Click(object sender, EventArgs e)
        {
            //clear the list
            lstAnswertxt.Items.Clear();
            string solution;
            int real1 = 0, imaginary1 = 0, real2 = 0, imaginary2 = 0;
            //loop through the list
            for (int i = 0; i <= 14; i += 2)
            {
                //first number
                real1 = mylist[i].numX;
                imaginary1 = mylist[i].numY;
                //second number
                real2 = mylist[i + 1].numX;
                imaginary2 = mylist[i + 1].numY;
                // add extra 2 to i so that we go to next 2 numbers

                solution = Divide(real1, imaginary1, real2, imaginary2);
                lstAnswertxt.Items.Add(solution);

            }
        }
    }

}

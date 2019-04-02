/* Lab 9
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
using System.Xml.Linq;

namespace Lab9_Alain_Sfeir
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void medicalRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicalRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalRecordsDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordsDataSet.MedicalRecords' table. You can move, or remove it, as needed.
            this.medicalRecordsTableAdapter.Fill(this.medicalRecordsDataSet.MedicalRecords);
            

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            XElement BloodTests = XElement.Load("BloodTests.xml");
            double Bilirubin_died_sum=0,
                        Bilirubin_died_square_sum=0,
                            Bilirubin_died_record_count=0,
                                Bilirubin_survive_sum=0,
                                     Bilirubin_survive_square_sum=0,
                                         Bilirubin_survive_record_count=0;
                                     
            var ID_Bilirubin_query = from items in BloodTests.Descendants("BloodTests")
                                    let ID = items.Element("PatientID").Value
                                    let Bilirubin= items.Element("Bilirubin").Value
                                    select new { ID , Bilirubin };

            foreach (var items in ID_Bilirubin_query)
            {
                if (items.Bilirubin != "-99")
                {
                    var Hostpital_query =   from ID_State in medicalRecordsDataSet.MedicalRecords
                                            let ID = ID_State.PatientID
                                            let State = ID_State.Alive
                                            select new { ID, State };

                    foreach (var stat in Hostpital_query)
                    {
                        if (stat.State == 2)
                        {
                            Bilirubin_died_sum = Bilirubin_died_sum + Convert.ToDouble(items.Bilirubin);

                            Bilirubin_died_square_sum = Bilirubin_died_square_sum
                                                        + Math.Pow(Convert.ToDouble(items.Bilirubin), 2);

                            Bilirubin_died_record_count += 1;

                        }else if (stat.State == 1)
                        {
                            Bilirubin_survive_sum = Bilirubin_survive_sum + Convert.ToDouble(items.Bilirubin);

                            Bilirubin_survive_square_sum = Bilirubin_survive_square_sum
                                                            + Math.Pow(Convert.ToDouble(items.Bilirubin), 2);

                            Bilirubin_survive_record_count += 1;

                        }
                    }
                }
            
            }

            double Bilirubin_died_Average, 
                        Bilirubin_died_Std_Dev,
                            Bilirubin_survive_Average,
                                 Bilirubin_survive_Std_Dev;


            Bilirubin_died_Average = Bilirubin_died_sum / Bilirubin_died_record_count;
            double calc = (Bilirubin_died_square_sum / Bilirubin_died_record_count) 
                           - Math.Pow(Bilirubin_died_Average,2);

            Bilirubin_died_Std_Dev = Math.Pow(calc,1/2);
            /////////////////////////////////////////////////////////////////////////////////
            Bilirubin_survive_Average = Bilirubin_survive_sum / Bilirubin_survive_record_count;
            double calc2= (Bilirubin_survive_square_sum / Bilirubin_survive_record_count)
                           - Math.Pow(Bilirubin_survive_Average, 2);

            Bilirubin_survive_Std_Dev = Math.Pow(calc2, 1 / 2);



            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////

            double AlkPhosphate_died_sum = 0,
                        AlkPhosphate_died_square_sum = 0,
                            AlkPhosphate_died_record_count = 0,
                                AlkPhosphate_survive_sum = 0,
                                     AlkPhosphate_survive_square_sum = 0,
                                         AlkPhosphate_survive_record_count = 0;

            var ID_AlkPhosphate_query = from items in BloodTests.Descendants("BloodTests")
                                     let ID = items.Element("PatientID").Value
                                     let AlkPhosphate = items.Element("AlkPhosphate").Value
                                     select new { ID, AlkPhosphate };

            foreach (var items in ID_AlkPhosphate_query)
            {
                if (items.AlkPhosphate != "-99")
                {
                    var Hostpital_query = from ID_State in medicalRecordsDataSet.MedicalRecords
                                          let ID = ID_State.PatientID
                                          let State = ID_State.Alive
                                          select new { ID, State };

                    foreach (var stat in Hostpital_query)
                    {
                        if (stat.State == 2)
                        {
                            AlkPhosphate_died_sum = AlkPhosphate_died_sum + Convert.ToDouble(items.AlkPhosphate);

                            AlkPhosphate_died_square_sum = AlkPhosphate_died_square_sum
                                                        + Math.Pow(Convert.ToDouble(items.AlkPhosphate), 2);

                            AlkPhosphate_died_record_count += 1;

                        }
                        else if (stat.State == 1)
                        {
                            AlkPhosphate_survive_sum = Bilirubin_survive_sum + Convert.ToDouble(items.AlkPhosphate);

                            AlkPhosphate_survive_square_sum = AlkPhosphate_survive_square_sum
                                                            + Math.Pow(Convert.ToDouble(items.AlkPhosphate), 2);

                            AlkPhosphate_survive_record_count += 1;

                        }
                    }
                }

            }

            double AlkPhosphate_died_Average,
                        AlkPhosphate_died_Std_Dev,
                            AlkPhosphate_survive_Average,
                                 AlkPhosphate_survive_Std_Dev;


            AlkPhosphate_died_Average = AlkPhosphate_died_sum / AlkPhosphate_died_record_count;
            double calc3 = (AlkPhosphate_died_square_sum / AlkPhosphate_died_record_count)
                           - Math.Pow(AlkPhosphate_died_Average, 2);

            AlkPhosphate_died_Std_Dev = Math.Pow(calc3, 1 / 2);
            /////////////////////////////////////////////////////////////////////////////////
            AlkPhosphate_survive_Average = AlkPhosphate_survive_sum / AlkPhosphate_survive_record_count;
            double calc4 = (AlkPhosphate_survive_square_sum / AlkPhosphate_survive_record_count)
                           - Math.Pow(AlkPhosphate_survive_Average, 2);

            AlkPhosphate_survive_Std_Dev = Math.Pow(calc4, 1 / 2);


            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////


            double SGot_died_sum = 0,
                        SGot_died_square_sum = 0,
                            SGot_died_record_count = 0,
                                SGot_survive_sum = 0,
                                     SGot_survive_square_sum = 0,
                                         SGot_survive_record_count = 0;

            var ID_SGot_query = from items in BloodTests.Descendants("BloodTests")
                                        let ID = items.Element("PatientID").Value
                                        let SGot = items.Element("SGot").Value
                                        select new { ID, SGot };

            foreach (var items in ID_SGot_query)
            {
                if (items.SGot != "-99")
                {
                    var Hostpital_query = from ID_State in medicalRecordsDataSet.MedicalRecords
                                          let ID = ID_State.PatientID
                                          let State = ID_State.Alive
                                          select new { ID, State };

                    foreach (var stat in Hostpital_query)
                    {
                        if (stat.State == 2)
                        {
                            SGot_died_sum = SGot_died_sum + Convert.ToDouble(items.SGot);

                            SGot_died_square_sum = SGot_died_square_sum
                                                        + Math.Pow(Convert.ToDouble(items.SGot), 2);

                            SGot_died_record_count += 1;

                        }
                        else if (stat.State == 1)
                        {
                            SGot_survive_sum = SGot_survive_sum + Convert.ToDouble(items.SGot);

                            SGot_survive_square_sum = SGot_survive_square_sum
                                                            + Math.Pow(Convert.ToDouble(items.SGot), 2);

                            SGot_survive_record_count += 1;

                        }
                    }
                }

            }

            double SGot_died_Average,
                        SGot_died_Std_Dev,
                            SGot_survive_Average,
                                 SGot_survive_Std_Dev;


            SGot_died_Average = SGot_died_sum / SGot_died_record_count;
            double calc5 = (SGot_died_square_sum / SGot_died_record_count)
                           - Math.Pow(SGot_died_Average, 2);

            SGot_died_Std_Dev = Math.Pow(calc5, 1 / 2);
            /////////////////////////////////////////////////////////////////////////////////
            SGot_survive_Average = SGot_survive_sum / SGot_survive_record_count;
            double calc6 = (SGot_survive_square_sum / SGot_survive_record_count)
                           - Math.Pow(SGot_survive_Average, 2);

            SGot_survive_Std_Dev = Math.Pow(calc6, 1 / 2);




            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            double Albumin_died_sum = 0,
                       Albumin_died_square_sum = 0,
                            Albumin_died_record_count = 0,
                                Albumin_survive_sum = 0,
                                     Albumin_survive_square_sum = 0,
                                         Albumin_survive_record_count = 0;

            var ID_Albumin_query = from items in BloodTests.Descendants("BloodTests")
                                let ID = items.Element("PatientID").Value
                                let Albumin = items.Element("Albumin").Value
                                select new { ID, Albumin };

            foreach (var items in ID_Albumin_query)
            {
                if (items.Albumin != "-99")
                {
                    var Hostpital_query = from ID_State in medicalRecordsDataSet.MedicalRecords
                                          let ID = ID_State.PatientID
                                          let State = ID_State.Alive
                                          select new { ID, State };

                    foreach (var stat in Hostpital_query)
                    {
                        if (stat.State == 2)
                        {
                            Albumin_died_sum = Albumin_died_sum + Convert.ToDouble(items.Albumin);

                            Albumin_died_square_sum = Albumin_died_square_sum
                                                        + Math.Pow(Convert.ToDouble(items.Albumin), 2);

                            Albumin_died_record_count += 1;

                        }
                        else if (stat.State == 1)
                        {
                            Albumin_survive_sum = Albumin_survive_sum + Convert.ToDouble(items.Albumin);

                            Albumin_survive_square_sum = Albumin_survive_square_sum
                                                            + Math.Pow(Convert.ToDouble(items.Albumin), 2);

                            Albumin_survive_record_count += 1;

                        }
                    }
                }

            }

            double Albumin_died_Average,
                        Albumin_died_Std_Dev,
                            Albumin_survive_Average,
                                 Albumin_survive_Std_Dev;


            Albumin_died_Average = Albumin_died_sum / Albumin_died_record_count;
            double calc7 = (Albumin_died_square_sum / Albumin_died_record_count)
                           - Math.Pow(Albumin_died_Average, 2);

            Albumin_died_Std_Dev = Math.Pow(calc7, 1 / 2);
            /////////////////////////////////////////////////////////////////////////////////
            Albumin_survive_Average = Albumin_survive_sum / Albumin_survive_record_count;
            double calc8 = (Albumin_survive_square_sum / Albumin_survive_record_count)
                           - Math.Pow(Albumin_survive_Average, 2);

            Albumin_survive_Std_Dev = Math.Pow(calc8, 1 / 2);


            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            lblavgBil_L.Text = Bilirubin_survive_Average.ToString("0.00");
            lblstdBill_L.Text = Bilirubin_survive_Std_Dev.ToString("0.00");
            lblavgBil_D.Text = Bilirubin_died_Average.ToString("0.00");
            lblstdBill_D.Text = Bilirubin_died_Std_Dev.ToString("0.00");


            lblavgAl_L.Text = Albumin_survive_Average.ToString("0.00");
            lblstdAL_L.Text = Albumin_survive_Std_Dev.ToString("0.00");
            lblavgAL_D.Text = Albumin_died_Average.ToString("0.00");
            lblstdAL_D.Text = Albumin_died_Std_Dev.ToString("0.00");

            lblavgSGot_L.Text = SGot_survive_Average.ToString("0.00");
            lblstdSGot_L.Text = SGot_survive_Std_Dev.ToString("0.00");
            lblavgSGot_D.Text = SGot_died_Average.ToString("0.00");
            lblstdSGot_D.Text = SGot_died_Std_Dev.ToString("0.00");

            lblavgAlk_L.Text = AlkPhosphate_survive_Average.ToString("0.00");
            lblstdAlk_L.Text = AlkPhosphate_survive_Std_Dev.ToString("0.00");
            lblavgAlk_D.Text = AlkPhosphate_died_Average.ToString("0.00");
            lblstdAlk_D.Text = AlkPhosphate_died_Std_Dev.ToString("0.00");






        }
    }
}

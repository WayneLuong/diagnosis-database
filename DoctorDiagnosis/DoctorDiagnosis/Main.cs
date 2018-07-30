using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syn.Bot;  //Import of Syn.Bot package
using System.IO;

namespace DoctorDiagnosis
{
    public partial class Main : Form
    {
        //Declaration of variables
        int count = 0;
        public SynBot Chatbot;
        private string gender;
        public Main()
        {
            InitializeComponent();
            gender = "";
        }

        //Method for saving an SQL data entry
        private void symptomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.symptomsBindingSource.EndEdit();
            //Update the edited data entry
            this.tableAdapterManager.UpdateAll(this.diagnosisDataSet1);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Loads data into the 'diagnosisDataSet1.Symptoms' table.
            this.symptomsTableAdapter.Fill(this.diagnosisDataSet1.Symptoms);
            //Starts timer to record number of results returned
            timer1.Start();
        }

        //Initiates the searching of database
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //If Male was selected, sort database by Gender male
            if (gender == "Male")
            {
            try
            {
                this.symptomsTableAdapter.searchMaleSymptoms(this.diagnosisDataSet1.Symptoms, symptomsTxt.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            }
            //If Male was selected, sort database by Gender female
            else if (gender == "Female")
            {
                try
                {
                    this.symptomsTableAdapter.searchFemaleSymptoms(this.diagnosisDataSet1.Symptoms, symptomsTxt.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        //Navigates to admin form
        private void adminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin adminForm = new Admin();

            adminForm.Show();
        }

        //Each tick in the timer represents 1 result returned
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count = symptomsBindingSource.Count;
            statuslbl.Text = "There are " + count.ToString() + " result(s) found in this database";

            //If results are less than 2 then hide the data navigation buttons
            if (count < 2)
            {
                nextBtn.Visible = false;
                previousBtn.Visible = false;
            }
            else
            {
                nextBtn.Visible = true;
                previousBtn.Visible = true;
            }
        }

        //Navigation to move between each result
        private void nextBtn_Click(object sender, EventArgs e)
        {
            symptomsBindingSource.MoveNext();
        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            symptomsBindingSource.MovePrevious();
        }

        //Sets the variable 'gender' to male of female depending on user selection
        private void maleBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            Chatbot = new SynBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
        }

        private void femaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            Chatbot = new SynBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText("FemaleKnowledge.simlpk"));
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //Data is sorted when a gender option is checked on the Chatbot tab page
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            try
            {
                this.symptomsTableAdapter.sortMale(this.diagnosisDataSet1.Symptoms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            try
            {
                this.symptomsTableAdapter.sortFemale(this.diagnosisDataSet1.Symptoms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Validates the gender of the user through variable 'gender'
        //Then loads the chatbot knowledge base depending on user gender
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gender == "")
            {
                MessageBox.Show("Please select a gender", "Warning!");
            }
            else
            {
                if (gender == "Male")
                {
                    Chatbot = new SynBot();
                    Chatbot.PackageManager.LoadFromString(File.ReadAllText("Knowledge.simlpk"));
                }
                else if (gender == "Female")
                {
                    Chatbot = new SynBot();
                    Chatbot.PackageManager.LoadFromString(File.ReadAllText("FemaleKnowledge.simlpk"));
                }

                //Outputs the reply from the chatbot into textbot
                var result = Chatbot.Chat(InputBox.Text);
                OutputBox.Multiline = true;
                OutputBox.Text = string.Format("User: {0} \r\nBot: {1}\r\n{2}", InputBox.Text, result.BotMessage, OutputBox.Text);
                InputBox.Text = string.Empty;
            }
        }
    
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }
}

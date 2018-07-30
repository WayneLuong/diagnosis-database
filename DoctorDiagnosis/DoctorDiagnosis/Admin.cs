using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorDiagnosis
{
    public partial class Admin : Form
    {
        //Declaration of variables
        int count = 0;

        public Admin()
        {
            InitializeComponent();
        }

        //Method for saving an SQL data entry
        private void symptomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.symptomsBindingSource.EndEdit();

            //Update the edited data entry
            this.tableAdapterManager.UpdateAll(this.diagnosisDataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosisDataSet1.Symptoms' table. You can move, or remove it, as needed.
            this.symptomsTableAdapter.Fill(this.diagnosisDataSet1.Symptoms);
            timer1.Start();
        }

        //Method for adding a new data entry
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.symptomsBindingSource.AddNew();
            addBtn.Enabled = false;
        }

        //Method for saving a new data entry and notifying the usre via message box
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.symptomsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.diagnosisDataSet1);
                addBtn.Enabled = true;
                MessageBox.Show("Record saved!","Notification");
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("ID must not be null!","Warning!");
            }
        }

        //Method for removing a data entry with confirmation box to confirm the deletion
        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this record?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Remove Record
                this.symptomsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.diagnosisDataSet1);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            
        }

        //Timer count to return the number of results from the database
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = symptomsBindingSource.Count;
            statuslbl.Text = "There are "+count.ToString() +" result(s) found in this database";

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
        private void button2_Click(object sender, EventArgs e)
        {
            symptomsBindingSource.MovePrevious();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            symptomsBindingSource.MoveNext();
        }

        //Searchbar for searching the field diagnosis
        private void searchDiagnosisToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.symptomsTableAdapter.searchDiagnosis(this.diagnosisDataSet1.Symptoms, diagnosisToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //Cliking the search button initiates the query to search keywords in the field symptoms
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.symptomsTableAdapter.searchSymptoms(this.diagnosisDataSet1.Symptoms, symptomsTxt.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchDiagnosisToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.symptomsTableAdapter.searchDiagnosis(this.diagnosisDataSet1.Symptoms, diagnosisToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void symptomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void searchKeywordsToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.symptomsTableAdapter.searchKeywords(this.diagnosisDataSet1.Symptoms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      
    }
}

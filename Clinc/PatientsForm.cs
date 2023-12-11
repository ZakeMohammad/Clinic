using Clinc_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccc
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPatients.GittAllPatients();           
        }
     
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Form New = new AddNewPatientForm();
            New.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form New = new AddNewPatientForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPatients.DeletePatient((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Patient Sucssfilly Deleted");
            }
            else
            {
                MessageBox.Show("The Patient Does Not Deleted");
            }
        }

        private void showPatientDeteilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form New = new PatientDetelisForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void CheakIsVisibaleForTextSearch(bool Visibel)
        {
            if (Visibel)
            {
                TxtSearchFilter.Visible = true;
            }
            else
            {
                TxtSearchFilter.Visible = false;
            }
        }
   
        private void TxtSearchFilter_TextChanged_1(object sender, EventArgs e)
        {
            if (ComboForFillter.SelectedIndex == 0)
            {
                dataGridView1.DataSource = clsPatients.GittAllPatients();

                CheakIsVisibaleForTextSearch(false);
            }
            if (ComboForFillter.SelectedIndex == 1)
            {
                CheakIsVisibaleForTextSearch(true);

                if (TxtSearchFilter.Text == string.Empty)
                    dataGridView1.DataSource = clsPatients.GittAllPatients();
                else
                    dataGridView1.DataSource = clsPatients.GittAllPatientsByFillter(int.Parse(TxtSearchFilter.Text));
                return;
            }

            if (ComboForFillter.SelectedIndex == 2)
            {

                dataGridView1.DataSource = clsPatients.GittAllPatientsByFillter(0, TxtSearchFilter.Text.ToString());
                return;
            }

            if (ComboForFillter.SelectedIndex == 3)
            {

                dataGridView1.DataSource = clsPatients.GittAllPatientsByFillter(0, null, Convert.ToChar(TxtSearchFilter.Text));
                return;
            }

            if (ComboForFillter.SelectedIndex == 4)
            {
                dataGridView1.DataSource = clsPatients.GittAllPatientsByFillter(0, null, ' ', TxtSearchFilter.Text.ToString());
                return;
            }
            if (ComboForFillter.SelectedIndex == 5)
            {
                dataGridView1.DataSource = clsPatients.GittAllPatientsByFillter(0, null, ' ', null, TxtSearchFilter.Text.ToString());
                return;
            }
        }
    }
}

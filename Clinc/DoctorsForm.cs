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
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsDoctor.GittAllDoctorss();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Add_Edit_DoctorsForm New =new Add_Edit_DoctorsForm();
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsDoctor.DeleteDoctor((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Doctor Sucssfilly Deleted");
            }
            else
            {
                MessageBox.Show("The Doctor Does Not Deleted");
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Edit_DoctorsForm New = new Add_Edit_DoctorsForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void showDoctorDeteliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorDetelisForm New = new DoctorDetelisForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void TxtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            if (ComboForFillter.SelectedIndex == 0)
            {
                dataGridView1.DataSource = clsDoctor.GittAllDoctorss();
                return;
            }
            if (ComboForFillter.SelectedIndex == 1)
            {               
                if (TxtSearchFilter.Text == string.Empty)
                    dataGridView1.DataSource = clsDoctor.GittAllDoctorss();
                else
                    dataGridView1.DataSource = clsDoctor.GittAllDoctorsByFillter(int.Parse(TxtSearchFilter.Text));
                return;
            }
            if (ComboForFillter.SelectedIndex == 2)
            {
                dataGridView1.DataSource = clsDoctor.GittAllDoctorsByFillter(0,TxtSearchFilter.Text);
                return;
            }

        }
    }
}

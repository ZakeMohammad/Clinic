using Clinc_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccc
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsUser.GittAllUserss();
        }

        private void TxtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            if (ComboForFillter.SelectedIndex == 0)
            {
                dataGridView1.DataSource = clsUser.GittAllUserss();
                return;
            }
            if (ComboForFillter.SelectedIndex == 1)
            {
                if (TxtSearchFilter.Text == string.Empty)
                    dataGridView1.DataSource = clsUser.GittAllUserss();
                else
                    dataGridView1.DataSource = clsUser.GittAllUsersByFillter(int.Parse(TxtSearchFilter.Text));
                return;
            }
            if (ComboForFillter.SelectedIndex == 2)
            {
                dataGridView1.DataSource = clsUser.GittAllUsersByFillter(0,TxtSearchFilter.Text);
                return;
            }
            if (ComboForFillter.SelectedIndex == 3)
            {
                dataGridView1.DataSource = clsUser.GittAllUsersByFillter(0,null,TxtSearchFilter.Text);
                return;
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Form New = new AddNewUserForm();
            New.ShowDialog();
        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form New = new UserDetelisForm((string)dataGridView1.CurrentRow.Cells[1].Value);
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Username=(string)dataGridView1.CurrentRow.Cells[1].Value;

            if (clsUser.DeleteUser(Username))
            {

                MessageBox.Show("User Deleted Succssfilly  ", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Does Not Deleted ", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm New = new EditUserForm((string)dataGridView1.CurrentRow.Cells[1].Value);
            New.ShowDialog();
        }
    }
}

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
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        public int  PersonID;
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            FindPersonForm New= new FindPersonForm();

            New.BackData += FillData;

            New.ShowDialog();

        }

        public void FillData(object sender,int persionid)
        {
            PersonID= persionid;
            ctrlPersonInfo1.FIllDataPersonToControl(PersonID);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            DataTable dt = clsUser.GittAllUserss();

           
            foreach(DataRow row in dt.Rows)
            {
                if (row["Username"].ToString()==txtUsername.Text)
                {
                    e.Cancel= true;
                    txtUsername.Focus();
                    errorProvider1.SetError(txtUsername, "There Are Another User like this");
                }
                else
                {
                    e.Cancel= false;
                    errorProvider1.SetError(txtUsername,(string)null);
                }
            }

           
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtPassword.Text==string.Empty)
            {
                e.Cancel= true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Plese Enter Passwrod");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtPassword,(string)null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text!=txtPassword.Text)
            {
                e.Cancel= true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password is reqaierd");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtConfirmPassword,(string)null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser User=new clsUser();

            User.PersonID =PersonID;
            
            User.Username=txtUsername.Text;
            
            if(CHisActive.Checked)
            {
                User.IsActive = "Yes";
            }
            else
            {
                User.IsActive = "No";
            }
           
            if(User.Save())
            {
                MessageBox.Show("User Succssfilly Added","Add New User",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Does Not Added", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

using cccc.Properties;
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
    public partial class EditUserForm : Form
    {
        public EditUserForm(string username)
        {
            InitializeComponent();
            Username = username;
        }

        string Username;
       
        clsUser _User;

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(Username);
            _User.UserID = _User.UserID;
            TxtAddress.Text = _User.Address;
            TxtEmail.Text = _User.Email;
            TxtPassword.Text = _User.Password;
    
            TxtName.Text = _User.Name;
            TxtPhone.Text = _User.PhoneNumber;
            DatePicker.Value = _User.DateOfBirth;
            if(_User.Gender=='M')
            {
                RDMale.Checked=true;
            }
            if(_User.Gender=='F')
            {
                RDFemale.Checked=true;
            }
            lblUserD.Text = _User.UserID.ToString();
            TxtUsername.Text = _User.Username;
   
            if(_User.IsActive=="Yes")
            {
                CHIsActive.Checked=true;
            }
            if(_User.IsActive=="No")
            {
                CHIsActive.Checked = false;
            }

            if(_User.ImagePath!="")
            {
                PictreForUser.Image=Image.FromFile(_User.ImagePath);
            }
            else
            {
                PictreForUser.Image = Resources.man__1_;
            }

        }

        private void btnSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                PictreForUser.Image = new Bitmap(openFileDialog1.FileName);
                _User.ImagePath = openFileDialog1.FileName;
            }
        }


        void UpdateUser()
        {
            _User.ImagePath = _User.ImagePath;
            _User.Address = TxtAddress.Text;
            _User.Name = TxtName.Text;
            _User.PhoneNumber = TxtPhone.Text;
            _User.DateOfBirth = DatePicker.Value;
            _User.Email = TxtEmail.Text;
            _User.Password= TxtPassword.Text;
            if (RDFemale.Checked)
            {
                _User.Gender = 'F';
            }
            if (RDMale.Checked)
            {
                _User.Gender = 'M';
            } 
            
            if(CHIsActive.Checked)
            {
                _User.IsActive = "Yes";
            }
            else
            {
                _User.IsActive = "No";
            }

            _User.PersonID = _User.PersonID;
            _User.UserID = _User.UserID;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUser();

            if(_User.Save())
            {
                MessageBox.Show("The User was Update Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("The User Not Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

}

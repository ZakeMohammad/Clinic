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
    public partial class Add_Edit_DoctorsForm : Form
    {
        public Add_Edit_DoctorsForm(int DoctorID = -1)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            _Doctor = clsDoctor.Find(_DoctorID);
        }

        private string _ImagePath;
        int _DoctorID;
        private clsDoctor _Doctor;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                PictreForPatient.Image = new Bitmap(openFileDialog1.FileName);
                _ImagePath = openFileDialog1.FileName;
            }
        }


        void FillFormDataToNewDoctor()
        {
            clsDoctor Doctor= new clsDoctor();
            Doctor.Name = TxtName.Text;

            Doctor.Address = TxtAddress.Text;

            Doctor.PhoneNumber = TxtPhone.Text;
            Doctor.Email = TxtEmail.Text;

            if (RDMale.Checked)
            {
                Doctor.Gender = 'M';
            }
            if (RDFemale.Checked)
            {
                Doctor.Gender = 'F';
            }
            Doctor.DateOfBirth = DatePicker.Value;

            Doctor.ImagePath = _ImagePath;

            Doctor.Specialization=ComboForDoctorSpesh.SelectedItem.ToString();  

            if (Doctor.Save())
            {
                MessageBox.Show("The Doctor was added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("The Doctor Not Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_DoctorID != -1)
            {
                UpdateDoctor(_Doctor);

                if (_Doctor.Save())
                {
                    MessageBox.Show("The Doctor was Update Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("The Doctor Not Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                FillFormDataToNewDoctor();
            }
        }

        void UpdateDoctor(clsDoctor doctor)
        {
            doctor.ImagePath = _ImagePath;
            doctor.Address = TxtAddress.Text;
            doctor.Name = TxtName.Text;
            doctor.PhoneNumber = TxtPhone.Text;
            doctor.DateOfBirth = DatePicker.Value;
            doctor.Email = TxtEmail.Text;
            doctor.Specialization=ComboForDoctorSpesh.SelectedItem.ToString();
            if (RDFemale.Checked)
            {
                doctor.Gender = 'F';
            }
            if (RDMale.Checked)
            {
                doctor.Gender = 'M';
            }
            doctor.DoctorID = _DoctorID;
            doctor.PersonID = doctor.PersonID;
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Doctor Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtEmail, "Plese Enter Doctor Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtEmail, "");
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtPhone, "Plese Enter Doctor Phone");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPhone, "");
            }
        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAddress.Text))
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtAddress, "Plese Enter Doctor Address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtAddress, "");
            }

        }

        void FillDoctorDataToFormForUpdate(clsDoctor Doctor)
        {

            lblDoctorID.Text = _DoctorID.ToString();
            TxtAddress.Text = Doctor.Address;
            TxtEmail.Text = Doctor.Email;
            TxtName.Text = Doctor.Name;
            TxtPhone.Text = Doctor.PhoneNumber;
            DatePicker.Value = Doctor.DateOfBirth;

            if (Doctor.Gender == 'M')
            {
                RDMale.Checked = true;
            }
            if (Doctor.Gender == 'F')
            {
                RDFemale.Checked = true;
            }

            if (Doctor.ImagePath == null && Doctor.Gender == 'M')
            {
                PictreForPatient.Image = Resources.man__1_;
            }
            if (Doctor.ImagePath == null && Doctor.Gender == 'F')
            {
                PictreForPatient.Image = Resources.woman;

            }

            ComboForDoctorSpesh.SelectedItem = Doctor.Specialization;

            if (Doctor.ImagePath != "")
            {
                PictreForPatient.Image = Image.FromFile(Doctor.ImagePath);
                _ImagePath = Doctor.ImagePath;
            }

            lblEditOrAd.Text = "Update Doctor";
        }

        private void Add_Edit_DoctorsForm_Load(object sender, EventArgs e)
        {
            if (_DoctorID == -1)
            {
                return;
            }

            if (_Doctor.Mode == clsDoctor.enMode.Update)
            {
                FillDoctorDataToFormForUpdate(_Doctor);
            }
        }
    }
}

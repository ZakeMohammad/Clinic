using cccc.Properties;
using Clinc_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccc
{
    public partial class AddNewPatientForm : Form
    {
        public AddNewPatientForm(int PatientID = -1)
        {
            InitializeComponent();
            _PatientID = PatientID;
            _Patient = clsPatients.Find(PatientID);
        }


        private string _ImagePath;
        int _PatientID;
        private clsPatients _Patient;
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

        void FillFormDataToNewPatient()
        {
            clsPatients Patient = new clsPatients();
            Patient.Name = TxtName.Text;

            Patient.Address = TxtAddress.Text;

            Patient.PhoneNumber = TxtPhone.Text;
            Patient.Email = TxtEmail.Text;

            if (RDMale.Checked)
            {
                Patient.Gender = 'M';
            }
            if (RDFemale.Checked)
            {
                Patient.Gender = 'F';
            }
            Patient.DateOfBirth = DatePicker.Value;

            Patient.ImagePath = _ImagePath;

            if (Patient.Save())
            {
                MessageBox.Show("The Patient was added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("The Patient Not Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PatientID != -1)
            {
                UpdatePatinat(_Patient);

                if (_Patient.Save())
                {
                    MessageBox.Show("The Patient was Update Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("The Patient Not Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                FillFormDataToNewPatient();
            }
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Patient Name");
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
                errorProvider1.SetError(TxtEmail, "Plese Enter Patient Email");
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
                errorProvider1.SetError(TxtPhone, "Plese Enter Patient Phone");
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
                errorProvider1.SetError(TxtAddress, "Plese Enter Patient Address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtAddress, "");
            }
        }


        void FillPatientDataToFormForUpdate(clsPatients Patient)
        {

            lblPatientID.Text = _PatientID.ToString();
            TxtAddress.Text = Patient.Address;
            TxtEmail.Text = Patient.Email;
            TxtName.Text = Patient.Name;
            TxtPhone.Text = Patient.PhoneNumber;
            DatePicker.Value = Patient.DateOfBirth;

            if (Patient.Gender == 'M')
            {
                RDMale.Checked = true;
            }
            if (Patient.Gender == 'F')
            {
                RDFemale.Checked = true;
            }

            if (Patient.ImagePath == null && Patient.Gender == 'M')
            {
                PictreForPatient.Image = Resources.man__1_;
            }
            if (Patient.ImagePath == null && Patient.Gender == 'F')
            {
                PictreForPatient.Image = Resources.woman;

            }

            if (Patient.ImagePath != "")
            {
                PictreForPatient.Image = Image.FromFile(Patient.ImagePath);
                _ImagePath = Patient.ImagePath;
            }

            lblEditOrAdd.Text = "Update Patient";
        } 



        void UpdatePatinat(clsPatients patient)
        {
            patient.ImagePath = _ImagePath;
            patient.Address = TxtAddress.Text;
            patient.Name = TxtName.Text;
            patient.PhoneNumber = TxtPhone.Text;
            patient.DateOfBirth = DatePicker.Value;
            patient.Email = TxtEmail.Text;

            if (RDFemale.Checked)
            {
                patient.Gender = 'F';
            }
            if (RDMale.Checked)
            {
                patient.Gender = 'M';
            }
            patient.PatientID = _PatientID;
            patient.PersonID = _Patient.PersonID;
        }

        private void AddNewPatientForm_Load(object sender, EventArgs e)
        {
            if (_PatientID == -1)
            {
                return;
            }

            if (_Patient.Mode == clsPatients.enMode.Update)
            {
                FillPatientDataToFormForUpdate(_Patient);
            }

        }




    }
}

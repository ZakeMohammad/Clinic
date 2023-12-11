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
    public partial class EditPrescriptoinForm : Form
    {
        public EditPrescriptoinForm(int prescripitnID)
        {
            InitializeComponent();
            PrescripitnID = prescripitnID;
        }


        int PrescripitnID;
        clsPrescription _Prescription;

        private void EditPrescriptoinForm_Load(object sender, EventArgs e)
        {
            clsPrescription Prescription = clsPrescription.Find(PrescripitnID);


            TxtMedicationName.Text = Prescription.MedicationName;
            TxtSpecila.Text = Prescription.SpecialInstructions;
            NumberOFFrequency.Value = Prescription.Frequance;
            DatePickerStart.Value = Prescription.StartDate;
            DatePickerEnd.Value = Prescription.EndDate;

            lblMedicalRecordID.Text = Prescription.MedecalRecordID.ToString();
            lblPersciptoinID.Text=Prescription.PrescriptionID.ToString();
            _Prescription= Prescription;

        }


        void UpdatePrescription()
        {
            _Prescription.EndDate = DatePickerEnd.Value;
            _Prescription.StartDate= DatePickerStart.Value;
            _Prescription.MedecalRecordID =Convert.ToInt32(lblMedicalRecordID.Text);
            _Prescription.PrescriptionID =  Convert.ToInt32(lblPersciptoinID.Text);

            _Prescription.Frequance = (int)NumberOFFrequency.Value;
            _Prescription.MedicationName= TxtMedicationName.Text;
            _Prescription.SpecialInstructions= TxtSpecila.Text;
            _Prescription.PrescriptionID = PrescripitnID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePrescription();

            if(_Prescription.Save())
            {
                MessageBox.Show("Prescrption Succssfilly Updaed","Prescriptions",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Prescrption Does Not Updaed", "Prescriptions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}

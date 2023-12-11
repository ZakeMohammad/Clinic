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
    public partial class PrespictoinDetelisForm : Form
    {
        public PrespictoinDetelisForm(int prescriptionID)
        {
            InitializeComponent();
            PrescriptionID = prescriptionID;
        }


        int PrescriptionID;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrespictoinDetelisForm_Load(object sender, EventArgs e)
        {
            clsPrescription Prescriptoin = clsPrescription.Find(PrescriptionID);

            lblMedicalRecordID.Text=Prescriptoin.MedecalRecordID.ToString();
            lblMedicationName.Text = Prescriptoin.MedicationName;
            lblPersciptoinID.Text=Prescriptoin.PrescriptionID.ToString();
            lblSpecial.Text = Prescriptoin.SpecialInstructions;
            NumberOFFrequency.Value = Prescriptoin.Frequance;
            DatePickerStart.Value = Prescriptoin.StartDate;
            DatePickerEnd.Value= Prescriptoin.EndDate;

        }
    }
}

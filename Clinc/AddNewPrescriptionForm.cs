using Clinc_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccc
{
    public partial class AddNewPrescriptionForm : Form
    {
        public AddNewPrescriptionForm(int medicalrecord)
        {
            InitializeComponent();
            MedicalRecord= medicalrecord;
        }



        public int MedicalRecord;

        private void btnSave_Click(object sender, EventArgs e)
        {
           clsPrescription Presecription=new clsPrescription();

            Presecription.SpecialInstructions = TxtSpecial.Text;
            Presecription.MedecalRecordID = MedicalRecord;
            Presecription.StartDate= DatePikerStart.Value;
            Presecription.EndDate= DatePikerEnd.Value;
            Presecription.Frequance=Convert.ToInt32(TxtFrequance.Text);
            Presecription.MedicationName= TxtMedecationName.Text;


            if(Presecription.Save())
            {
                MessageBox.Show("Prescription Has Been Added", "Prescriptions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Prescription  Does Not Added", "Prescriptions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddNewPrescriptionForm_Load(object sender, EventArgs e)
        {
            lblMedicalRecord.Text=MedicalRecord.ToString();
        }




    }
}

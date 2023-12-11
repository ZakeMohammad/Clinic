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
    public partial class ctrlPatientInfo : UserControl
    {
        public ctrlPatientInfo()
        {
            InitializeComponent();
        }


       private int PatientID { get; set; }   

        public void FillDataPateintToControl(int patientID)
        {
            PatientID= patientID;
            clsPatients Patient = clsPatients.Find(PatientID);
             lblPateintID.Text = Patient.PatientID.ToString();           
        }

        private void LinkLaberForEditPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form New = new AddNewPatientForm(PatientID);
            New.ShowDialog();
        }
    }
}

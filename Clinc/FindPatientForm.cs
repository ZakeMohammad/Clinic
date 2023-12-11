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
    public partial class FindPatientForm : Form
    {
        public FindPatientForm()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventhandler(object sender, int patientid);

        public event DataBackEventhandler BackData;

        public int PatientID;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPatients Patient = clsPatients.Find(Convert.ToInt32(TxtPatientDSearch.Text));

            if(Patient!= null)
            {
                PatientID=Patient.PatientID;
                ctrlPersonInfo1.FIllDataPersonToControl(Patient.PersonID);
                ctrlPatientInfo1.FillDataPateintToControl(Patient.PatientID);
            }
            else
            {
                MessageBox.Show("The Patient Does Not Exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackData?.Invoke(this, PatientID);
            this.Close();
        }




    }
}

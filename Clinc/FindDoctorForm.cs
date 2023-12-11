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
    public partial class FindDoctorForm : Form
    {
        public FindDoctorForm()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventhandler(object sender, int doctorid);

        public event DataBackEventhandler BackData;


        public int DoctorID;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = clsDoctor.Find(Convert.ToInt32(TxtDoctorIDSearch.Text));


            if (Doctor != null)
            {
                DoctorID=Doctor.DoctorID;
                ctrlPersonInfo1.FIllDataPersonToControl(Doctor.PersonID);
                ctrlDoctorInfo1.FillDataDoctorToControl(DoctorID);
            }
            else
            {
                MessageBox.Show("The Doctor Does Not Exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackData.Invoke(this, DoctorID);
            this.Close();   
        }
    }
}

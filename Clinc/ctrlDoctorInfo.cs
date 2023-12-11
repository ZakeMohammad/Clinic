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
    public partial class ctrlDoctorInfo : UserControl
    {
        public ctrlDoctorInfo()
        {
            InitializeComponent();
        }

        int DoctorID;


      public void FillDataDoctorToControl(int doctorID)
      {
            DoctorID= doctorID;

            clsDoctor Doctor = clsDoctor.Find(DoctorID);

            lblDoctorID.Text=Doctor.DoctorID.ToString();
            lblDoctorSbeh.Text=Doctor.Specialization.ToString();
      }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Edit_DoctorsForm New=new Add_Edit_DoctorsForm(DoctorID);
            New.ShowDialog();
        }
    }
}

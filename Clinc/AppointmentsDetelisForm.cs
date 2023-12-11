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
    public partial class AppointmentsDetelisForm : Form
    {
        public AppointmentsDetelisForm(int appointmentID)
        {
            InitializeComponent();
            AppointmentID= appointmentID;
        }

        int AppointmentID;
        int PaitentID;
        int DoctorID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentsDetelisForm_Load(object sender, EventArgs e)
        {
            clsAppointments Approintment = clsAppointments.Find(AppointmentID);

            PaitentID = Approintment.PatientID;
            DoctorID= Approintment.DoctorID;
            ctrlPatientInfo1.FillDataPateintToControl(PaitentID);
            ctrlDoctorInfo1.FillDataDoctorToControl(DoctorID);

            DatePickerForAppointment.Value = Approintment.AppointmentDateTime;
            lblMedicalRecordID.Text=Approintment.MedecailRecordID.ToString();
            lblPaymentID.Text=Approintment.PaymetnID.ToString();
            lblStatues.Text=Approintment.AppointmetnStatues.ToString();
        }



    }
}

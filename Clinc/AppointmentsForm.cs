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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        public int PatientID;
        public int DoctorID;
        public int PaymentID;

        private void btnNextForPatient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnNextForDoctor_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            FindPatientForm frm= new FindPatientForm();
            frm.BackData += FillPatientData;
            frm.ShowDialog();
        }

        void FillPatientData(object sender,int patientid)
        {
            PatientID = patientid;
            clsPatients Patient = clsPatients.Find(PatientID);

            ctrlPersonInfo1.FIllDataPersonToControl(Patient.PersonID);
            ctrlPatientInfo1.FillDataPateintToControl(PatientID);
        }
        void FillDoctorData(object sender, int doctorid)
        {
            DoctorID= doctorid;
            clsDoctor Doctor = clsDoctor.Find(DoctorID);
            ctrlPersonInfo2.FIllDataPersonToControl(Doctor.PersonID);
            ctrlDoctorInfo1.FillDataDoctorToControl(DoctorID);
        }

        private void btnSelectForDoctor_Click(object sender, EventArgs e)
        {
            FindDoctorForm frm= new FindDoctorForm();
            frm.BackData += FillDoctorData;
            frm.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            AddNewPaymentForm frm= new AddNewPaymentForm();
            frm.BackData += FillPaymetnData;
            frm.ShowDialog();
        }

        void FillPaymetnData(object sender, int paymetnid)
        {
            PaymentID= paymetnid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAppointments appointment= new clsAppointments();

            appointment.PatientID= PatientID;
            appointment.DoctorID= DoctorID;
            appointment.PaymetnID = PaymentID;           
            appointment.AppointmentDateTime =DatePickerForAppoinments.Value;
            appointment.AppointmetnStatues=ComboBoxForStatus.SelectedItem.ToString();
            
            
            if(appointment.Save())
            {
                MessageBox.Show("The Appointment Added Succssfilly","Appointments",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("The Appointment Does Not Added", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}

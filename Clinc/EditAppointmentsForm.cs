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
    public partial class EditAppointmentsForm : Form
    {
        public EditAppointmentsForm(int appointmentID)
        {
            InitializeComponent();
            AppointmentID = appointmentID;
        }
        clsAppointments _Appointent;
        public int AppointmentID;
        public int RecordID;
        int PaymentID;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void EditAppointmentsForm_Load(object sender, EventArgs e)
        {
            btnAddMedecalRecord.Enabled = false;
            clsAppointments Appointent = clsAppointments.Find(AppointmentID);

            lblDoctorID.Text = Appointent.DoctorID.ToString();
            lblPatientID.Text = Appointent.PatientID.ToString();
            lblPaymentID.Text = Appointent.PaymetnID.ToString();
            lblMedicalRecordID.Text = Appointent.MedecailRecordID.ToString();
            ComboForStates.SelectedItem = Appointent.AppointmetnStatues;
            DatePaickerForAppointments.Value = Appointent.AppointmentDateTime;
            _Appointent = Appointent;
        }




        private void ComboForStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboForStates.SelectedIndex == 2)
            {
                btnAddMedecalRecord.Enabled = true;
            }
        }

        void FillDataFromMedecialRecord(object sender,int rercordid)
        {
            RecordID= rercordid;
        }


        void UpdateAppoiment(clsAppointments Appointment)
        {
            lblMedicalRecordID.Text = RecordID.ToString();
            lblPaymentID.Text =PaymentID.ToString();
            Appointment.DoctorID=Convert.ToInt32( lblDoctorID.Text);
            Appointment.PatientID=Convert.ToInt32(lblPatientID.Text);
            Appointment.PaymetnID=Convert.ToInt32(lblPaymentID.Text);
            Appointment.AppointmetnStatues=ComboForStates.SelectedItem.ToString();
            Appointment.AppointmentDateTime = DatePaickerForAppointments.Value;
            Appointment.MedecailRecordID = Convert.ToInt32(lblMedicalRecordID.Text);          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateAppoiment(_Appointent);
            if(_Appointent.Save())
            {
                MessageBox.Show("The Appoinment Succssfilly Updated","Appoinments",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("The Appoinment Does Not Updated", "Appoinments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        private void btnAddMedecalRecord_Click(object sender, EventArgs e)
        {
            AddNewMedicalRecrodForm frm=new AddNewMedicalRecrodForm();
            frm.BackData += FillDataFromMedecialRecord;
            frm.ShowDialog();
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            AddNewPaymentForm frm=new AddNewPaymentForm();
            frm.BackData += FillNewPaymetnToAppointemnts;
            frm.ShowDialog();
        }
        void FillNewPaymetnToAppointemnts(object sender,int pyamentID)
        {
            PaymentID= pyamentID;           
        }



    }
}

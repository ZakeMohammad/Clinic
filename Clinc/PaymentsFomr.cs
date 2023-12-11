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
    public partial class PaymentsFomr : Form
    {
        public PaymentsFomr()
        {
            InitializeComponent();
        }

        private void PaymentsFomr_Load(object sender, EventArgs e)
        {
            DataViewForAppointments.DataSource = clsAppointments.GitALlAppintmetns();
            DataViewForMedicalRecord.DataSource=clsMedecalRecords.GitAllRecords();
            DataViewForPayments.DataSource=clsPayments.GittAllPayments();
            DataViewForPrescriptions.DataSource = clsPrescription.GitAllPrescription();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(2);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(2);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Page3_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearchPrescriptoins_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxForPrescriptoins.SelectedIndex == 0)
            {
                DataViewForPrescriptions.DataSource = clsPrescription.GitAllPrescription();
            }

            if (ComboBoxForPrescriptoins.SelectedIndex == 1)
            {
                if (Convert.ToInt32(TxtSearchPrescriptoins.Text) == 0)
                {
                    DataViewForPrescriptions.DataSource = clsPrescription.GitAllPrescription();
                }

                DataViewForPrescriptions.DataSource = clsPrescription.Fillter(Convert.ToInt32(TxtSearchPrescriptoins.Text));
                return;
            }

            if (ComboBoxForPrescriptoins.SelectedIndex == 2)
            {
                if (Convert.ToInt32(TxtSearchPrescriptoins.Text) == 0)
                {
                    DataViewForPrescriptions.DataSource = clsPrescription.GitAllPrescription();
                }
                DataViewForPrescriptions.DataSource = clsPrescription.Fillter(0,Convert.ToInt32( TxtSearchPrescriptoins.Text), null, 0);
                return;
            }
            if (ComboBoxForPrescriptoins.SelectedIndex == 3)
            {
                DataViewForPrescriptions.DataSource = clsPrescription.Fillter(0, 0, TxtSearchPrescriptoins.Text, 0);
                return;
            }
            if (ComboBoxForPrescriptoins.SelectedIndex == 4)
            {
                if (Convert.ToInt32(TxtSearchPrescriptoins.Text) == 0)
                {
                    DataViewForPrescriptions.DataSource = clsPrescription.GitAllPrescription();
                }
                DataViewForPrescriptions.DataSource = clsPrescription.Fillter(0, 0, null,Convert.ToInt32(TxtSearchPrescriptoins.Text));
                return;
            }

        }

        private void TxtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            if(ComboBoxForAppointments.SelectedIndex == 0)
            {
                DataViewForAppointments.DataSource = clsAppointments.GitALlAppintmetns();
            }
            if (ComboBoxForAppointments.SelectedIndex == 1)
            {
                if(Convert.ToInt32(TxtSearchFilterForApp.Text)==0)
                {
                    DataViewForAppointments.DataSource = clsAppointments.GitALlAppintmetns();
                }

                DataViewForAppointments.DataSource = clsAppointments.Fillter(Convert.ToInt32(TxtSearchFilterForApp.Text));
                return;
            }
            if (ComboBoxForAppointments.SelectedIndex == 2)
            {
                DataViewForAppointments.DataSource = clsAppointments.Fillter(0,TxtSearchFilterForApp.Text,null,null);
                return;
            }
            if (ComboBoxForAppointments.SelectedIndex == 3)
            {
                DataViewForAppointments.DataSource = clsAppointments.Fillter(0,null,TxtSearchFilterForApp.Text,null);
                return;
            }
            if (ComboBoxForAppointments.SelectedIndex == 4)
            {
                DataViewForAppointments.DataSource = clsAppointments.Fillter(0,null,null,TxtSearchFilterForApp.Text);
                return;
            }

        }

        private void TxtSearchForPayment_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxForPayments.SelectedIndex == 0)
            {
                DataViewForPayments.DataSource = clsPayments.GittAllPayments();
            }
            if (ComboBoxForPayments.SelectedIndex == 1)
            {
                if (Convert.ToInt32(TxtSearchForPayment.Text) == 0)
                {
                    DataViewForPayments.DataSource = clsPayments.GittAllPayments();
                }

                DataViewForPayments.DataSource = clsPayments.Fillter(Convert.ToInt32(TxtSearchForPayment.Text),0,null);
                return;
            }
            if (ComboBoxForPayments.SelectedIndex == 2)
            {
                DataViewForPayments.DataSource = clsPayments.Fillter(0,0 , TxtSearchForPayment.Text);
                return;
            }
            if (ComboBoxForPayments.SelectedIndex == 3)
            {
                DataViewForPayments.DataSource = clsPayments.Fillter(0,Convert.ToInt32(TxtSearchForPayment.Text), null );
                return;
            }         
        }

        private void TxtSearchForMedical_TextChanged(object sender, EventArgs e)
        {
            if (ComboForMedicalRecords.SelectedIndex == 0)
            {
                DataViewForMedicalRecord.DataSource = clsMedecalRecords.GitAllRecords();
            }
            if (ComboForMedicalRecords.SelectedIndex == 1)
            {
                if (Convert.ToInt32(TxtSearchForMedical.Text) == 0)
                {
                    DataViewForMedicalRecord.DataSource = clsMedecalRecords.GitAllRecords();
                }

                DataViewForMedicalRecord.DataSource = clsMedecalRecords.Fillter(Convert.ToInt32(TxtSearchForMedical.Text));
                return;
            }
        }


        private void showAppointmentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentsDetelisForm New = new AppointmentsDetelisForm((int)DataViewForAppointments.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAppointmentsForm New = new EditAppointmentsForm((int)DataViewForAppointments.CurrentRow.Cells[0].Value);
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int MedicalRecordID= (int)(DataViewForAppointments.CurrentRow.Cells[5].Value);
            int PaymentID= (int)(DataViewForAppointments.CurrentRow.Cells[6].Value);
            int PrescriptionID=clsPrescription.GitPerscripionosByMedicalID(MedicalRecordID);


            if(clsAppointments.DeleteAppintment((int)(DataViewForAppointments.CurrentRow.Cells[0].Value)))
            {
                if(clsPrescription.DeletePrescriptions(PrescriptionID))
                {
                    if (clsMedecalRecords.DeleteMedicalRecord(MedicalRecordID))
                    {
                        if (clsPayments.DeletePayment(PaymentID))
                        {
                            MessageBox.Show("Appointment Succssfilly Deleted", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Payment Does Not Deleted", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medical Record Does Not Deleted", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Prescription Does Not Deleted", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
            }
            else
            {
                MessageBox.Show("Appointment Does Not Deleted", "Appointments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void showMedicalRecordInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalRecordInfoForm New = new MedicalRecordInfoForm((int)(DataViewForMedicalRecord.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditMedicalRecordForm New = new EditMedicalRecordForm((int)(DataViewForMedicalRecord.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void showPaymentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDetelisForm New = new PaymentDetelisForm((int)(DataViewForPayments.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditPaymentForm New = new EditPaymentForm((int)(DataViewForPayments.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(clsPayments.DeletePayment((int)(DataViewForPayments.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Payment Succssfilly Deleted", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Payment Does Not Deleted", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showPrescriptionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrespictoinDetelisForm New = new PrespictoinDetelisForm((int)(DataViewForPrescriptions.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditPrescriptoinForm New = new EditPrescriptoinForm((int)(DataViewForPrescriptions.CurrentRow.Cells[0].Value));
            New.ShowDialog();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int MedecalRecord= (int)DataViewForPrescriptions.CurrentRow.Cells[1].Value;

            if (clsPrescription.DeletePrescriptions(((int)DataViewForPrescriptions.CurrentRow.Cells[0].Value)))
            {
                if (clsMedecalRecords.DeleteMedicalRecord(MedecalRecord))
                {
                    MessageBox.Show("Perscriptoin Succssfilly Deleted", "Perscriptoins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Perscriptoin Does Not Deleted", "Perscriptoins", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsMedecalRecords.DeleteMedicalRecord((int)DataViewForMedicalRecord.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Record Succssfilly Deleted", "Medical Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Record Does Not Deleted", "Medical Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}

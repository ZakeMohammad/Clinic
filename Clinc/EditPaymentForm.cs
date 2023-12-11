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
    public partial class EditPaymentForm : Form
    {
        public EditPaymentForm(int paymentID)
        {
            InitializeComponent();
            PaymentID = paymentID;
        }

        int PaymentID;

        clsPayments _Payment;


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePayment();

            if(_Payment.Save())
            {
                MessageBox.Show("Payment Succssfilly Updated","Paymetns",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Payment Does Not Updated", "Paymetns", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void EditPaymentForm_Load(object sender, EventArgs e)
        {
            clsPayments Payment = clsPayments.Find(PaymentID);
            lblPaymentID.Text=PaymentID.ToString();
            NumberOFMoney.Value = Payment.AmountPaid;
            DatePickerForPayment.Value = Payment.DatePayed;
            TxtMethod.Text = Payment.PaymentMethod;
            TxtNotes.Text = Payment.Notes;
            _Payment= Payment;
        }

        void UpdatePayment()
        {
            _Payment.DatePayed= DatePickerForPayment.Value;
            _Payment.PaymentMethod= TxtMethod.Text;
            _Payment.Notes= TxtNotes.Text;
            _Payment.AmountPaid=(int)NumberOFMoney.Value;
            _Payment.PaymentID= PaymentID;
        }



    }
}

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
    public partial class PaymentDetelisForm : Form
    {
        public PaymentDetelisForm(int paymentID)
        {
            InitializeComponent();
            PaymentID = paymentID;
        }

        int PaymentID;


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentDetelisForm_Load(object sender, EventArgs e)
        {
            clsPayments Payment = clsPayments.Find(PaymentID);

            lblNotes.Text = Payment.Notes;
            lblPaymentAmount.Text=Payment.AmountPaid.ToString();
            lblPaymentID.Text=PaymentID.ToString();
            lblPaymentMethod.Text=Payment.PaymentMethod.ToString();
        }


    }
}

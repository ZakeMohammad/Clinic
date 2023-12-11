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
    public partial class AddNewPaymentForm : Form
    {
        public AddNewPaymentForm()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventhandler(object sender, int paymentid);

        public event DataBackEventhandler BackData;


        public int PaymentID;


        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPayments payments= new clsPayments();
            payments.AmountPaid = (int)NumberOfAmountPaid.Value;
            payments.Notes=TxtNotes.Text;
            payments.PaymentMethod=ComboForPaymentMethod.SelectedItem.ToString();
            payments.DatePayed = DatePickerForPayment.Value;

            if(payments.Save())
            {
                PaymentID= payments.PaymentID;
                MessageBox.Show("Payment Succssfilly Added", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show("Payment Does Not Added", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BackData.Invoke(this,PaymentID);
            this.Close();

        }





    }
}

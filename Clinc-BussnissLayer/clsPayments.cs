using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public  class clsPayments
    {

        public enum enMode { Add,Update}

        public enMode Mode;

        public int PaymentID { get; set; }

        public int AmountPaid { get; set; }

        public DateTime DatePayed { get; set; }

        public string PaymentMethod { get; set; }

        public string Notes { get; set; }


        private clsPayments(int paymentID,DateTime date,string method,int amount,string notes)
        {
            this.PaymentID = paymentID;
            this.DatePayed = date;
            this.PaymentMethod = method;
            this.AmountPaid = amount;
            this.Notes = notes;
            this.Mode = enMode.Update;
        }


        public clsPayments()
        {
            this.PaymentID = -1;
            this.DatePayed = DateTime.Now;
            this.PaymentMethod = "";
            this.AmountPaid = -1;
            this.Notes = "";
            this.Mode = enMode.Add;
        }



        bool _AddPayment()
        {
            this.PaymentID=clsPayments_Data.AddNewPayment(this.DatePayed,this.PaymentMethod,this.AmountPaid,this.Notes);
            return (this.PaymentID!=1);
        }

        bool _UpdatePayment()
        {
            return clsPayments_Data.UpdatePayment(this.PaymentID, this.DatePayed,this.PaymentMethod, this.AmountPaid, this.Notes);
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Update:
                    {
                        return _UpdatePayment();
                    }
                    case enMode.Add:
                    {
                        if(_AddPayment())
                        {
                            this.Mode=enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    default:
                    {
                        return false;
                    }
            }
        }


        public static bool DeletePayment(int paymentID)
        {
            return clsPayments_Data.DeletePayment(paymentID);
        }


        public static clsPayments Find(int paymentID)
        {
            DateTime date= DateTime.Now;
            int amount = 0;
            string method = "", notes = "";

            if (clsPayments_Data.Find(paymentID, ref date, ref method, ref amount, ref notes))
            {
                return new clsPayments(paymentID, date, method, amount, notes);
            }
            else
                return null;
        }


        public static DataTable GittAllPayments()
        {
            return clsPayments_Data.GitAllPayment();
        }

        public static DataTable Fillter(int PaymentID = 0, int AmountPaid = 0, string Method = null)
        {
            return clsPayments_Data.Fillter(PaymentID, AmountPaid, Method);
        }


        public static int NumberOfPayments()
        {
            return clsPayments_Data.GitNumberOfPayments();
        }

    }
}

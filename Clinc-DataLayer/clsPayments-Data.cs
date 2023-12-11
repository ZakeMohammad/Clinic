using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_DataLayer
{
    public class clsPayments_Data
    {
        public static int AddNewPayment(DateTime PaymetnDate, string PaymentMethod, int AmountPaid, string Notes)
        {
            int PaymentID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "insert into Payments (PaymentDate,PaymentMethod,AmountPaid,AdditionalNotes) values(@date,@mothod,@amount,@notes); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@date", PaymetnDate);
            Command.Parameters.AddWithValue("@mothod", PaymentMethod);
            Command.Parameters.AddWithValue("@amount", AmountPaid);
            Command.Parameters.AddWithValue("@notes", Notes);
         

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    PaymentID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID, DateTime PaymetnDate, string PaymentMethod, int AmountPaid, string Notes)
        {
            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "update Payments set  PaymentDate=@date ,PaymentMethod=@method ,AmountPaid=@amount ,  AdditionalNotes=@notes   where PaymentID=@paymentid  ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@date", PaymetnDate);
            Command.Parameters.AddWithValue("@method", PaymentMethod);
            Command.Parameters.AddWithValue("@amount", AmountPaid);
            Command.Parameters.AddWithValue("@notes", Notes);
            Command.Parameters.AddWithValue("@paymentid", PaymentID);


            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {
                    IsUpdate = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return IsUpdate;
        }

        public static bool DeletePayment(int PaymentID)
        {
            bool IsDeleted = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "delete Payments where PaymentID=@paymentid ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@paymentid", PaymentID);

            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {
                    IsDeleted = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return IsDeleted;
        }


        public static DataTable GitAllPayment()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Payments";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }

            return dt;
        }

        public static bool Find(int PaymentID,ref DateTime PaymetnDate,ref string PaymentMethod,ref int AmountPaid,ref string Notes)
        {
            bool IsFound = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "select * from Payments where PaymentID=@paymentid  ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@paymentid", PaymentID);

            try
            {
                Conniction.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PaymentID = Convert.ToInt32(Reader[0]);
                   PaymetnDate = Convert.ToDateTime(Reader[1]);
                    PaymentMethod= Convert.ToString(Reader[2]);
                    AmountPaid= Convert.ToInt32(Reader[3]);
                    Notes = Convert.ToString(Reader[4]);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return IsFound;
        }


        public static DataTable Fillter(int PaymentID = 0, int AmountPaid = 0, string Method = null)
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "";

            if ( PaymentID!= 0)
            {
                Querey = "select * from Payments where PaymentID like '" + PaymentID + "%'";
            }
            if ( AmountPaid!= 0)
            {
                Querey = "select * from Payments where AmountPaid like '" + AmountPaid + "%'";
            }
            if ( Method!= null)
            {
                Querey = "select * from Payments where PaymentMethod like '" + Method + "%'";
            }
            
            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }




        public static int GitNumberOfPayments()
        {
            int NumberOfPayments = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select NumberOfPayments=Count(*) from Payments";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    NumberOfPayments = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return NumberOfPayments;
        }


    }
}

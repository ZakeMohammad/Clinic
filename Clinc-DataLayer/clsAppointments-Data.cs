using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_DataLayer
{
    public class clsAppointments_Data
    {

         public static int AddNewAppiontment(int PatientID,int DoctroID,DateTime AppointmetnDate,string AppointmentStatues,int MedecalRecordID,int PaymetnID)
        {
            int AppiontmentID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "insert into Appointments (PatientID,DoctorID,AppointmentDateTime,AppointmentStatus,MedicalRecordID,PaymentID) values(@patientid,@doctorid,@date,@statues,@medecalrecordid,@paymentid); SELECT SCOPE_IDENTITY();";

            SqlCommand Command=new SqlCommand(Querey,Conniction);
           
            Command.Parameters.AddWithValue("@patientid", PatientID);
            Command.Parameters.AddWithValue("@doctorid", DoctroID);
            Command.Parameters.AddWithValue("@date", AppointmetnDate);
            Command.Parameters.AddWithValue("@statues", AppointmentStatues);

            if(MedecalRecordID ==-1)
            {
                Command.Parameters.AddWithValue("@medecalrecordid", DBNull.Value);
            }
            else
            Command.Parameters.AddWithValue("@medecalrecordid", MedecalRecordID);


            if (PaymetnID == -1)
            {
                Command.Parameters.AddWithValue("@paymentid", DBNull.Value);
            }
            else
                Command.Parameters.AddWithValue("@paymentid", PaymetnID);

           

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    AppiontmentID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return AppiontmentID;
        }

        public static bool UpdateAppiontment(int AppiontmentID, int PatientID, int DoctroID, DateTime AppointmetnDate, string AppointmentStatues, int MedecalRecordID, int PaymetnID)
        {
            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "update Appointments set PatientID=@patientid , DoctorID=@doctorid ,AppointmentDateTime=@date ,AppointmentStatus=@statues ,  MedicalRecordID=@medecalrecordid , PaymentID=@paymentid  where AppointmentID=@appiontemntID  ";

            SqlCommand Command=new SqlCommand(Querey,Conniction);
          
            Command.Parameters.AddWithValue("@date", AppointmetnDate);
            Command.Parameters.AddWithValue("@statues", AppointmentStatues);


            if (DoctroID == -1)
            {
                Command.Parameters.AddWithValue("@doctorid", DBNull.Value);
            }
            else
                Command.Parameters.AddWithValue("@doctorid", DoctroID);


            if (PatientID == -1)
            {
                Command.Parameters.AddWithValue("@patientid", DBNull.Value);
            }
            else
                Command.Parameters.AddWithValue("@patientid", PatientID);



            if (MedecalRecordID == -1)
            {
                Command.Parameters.AddWithValue("@medecalrecordid", DBNull.Value);
            }
            else
                Command.Parameters.AddWithValue("@medecalrecordid", MedecalRecordID);


            if (PaymetnID == -1)
            {
                Command.Parameters.AddWithValue("@paymentid", DBNull.Value);
            }
            else
                Command.Parameters.AddWithValue("@paymentid", PaymetnID);


            Command.Parameters.AddWithValue("@appiontemntID", AppiontmentID);

            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {
                    IsUpdate= true;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return IsUpdate;
        }

        public static bool DeleteAppiontment(int AppiontmentID)
        {
            bool IsDeleted = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "delete Appointments where AppointmentID=@appiontemntID ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);
          
            Command.Parameters.AddWithValue("@appiontemntID", AppiontmentID);

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


        public static DataTable GitAllAppiontment()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from AppointmentsData";

            SqlCommand Command= new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                SqlDataReader Reader= Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch(Exception ex) 
            { 

            }
            finally
            {
                Conniction.Close();
            }

            return dt;
        }

        public static bool Find(int AppiontmentID,ref int PatientID,ref int DoctroID,ref DateTime AppointmetnDate,ref string AppointmentStatues,ref int MedecalRecordID,ref int PaymetnID)
        {
            bool IsFound=false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "select * from Appointments where AppointmentID=@appointmentid  ";

            SqlCommand Command=new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@appointmentid", AppiontmentID);

            try
            {
                Conniction.Open();
                SqlDataReader Reader= Command.ExecuteReader();

                if(Reader.Read())
                {
                    IsFound=true;
                    AppiontmentID = Convert.ToInt32(Reader[0]);
                    PatientID = Convert.ToInt32(Reader[1]);
                    DoctroID = Convert.ToInt32(Reader[2]);
                    AppointmetnDate= Convert.ToDateTime(Reader[3]);
                    AppointmentStatues = Convert.ToString(Reader[4]);

                    if (Reader[5]==DBNull.Value)
                    {
                        MedecalRecordID = 0;
                    }
                    else
                    MedecalRecordID = Convert.ToInt32(Reader[5]);

                    if (Reader[6] == DBNull.Value)
                    {
                        PaymetnID = 0;
                    }
                    else
                    PaymetnID = Convert.ToInt32(Reader[6]);

                }
            }
            catch(Exception ex)
            {

            }
            finally 
            {
                Conniction.Close();
            }
            return IsFound;
        }

        public static DataTable Fillter(int AppointmentID = 0, string AppointmentStatus=null, string PaitntName = null, string DoctorName = null)
        {
            DataTable dt = new DataTable();


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "";

            if (AppointmentID != 0)
            {
                Querey = "select * from AppointmentsData where AppointmentID like '" + AppointmentID+"%'";
            }
            if (AppointmentStatus != null)
            {
                Querey = "select * from AppointmentsData where AppointmentStatus like '"+AppointmentStatus+"%'";
            }
            if (PaitntName != null)
            {
                Querey = "select * from AppointmentsData where Patient like '" + PaitntName + "%'";
            }
            if (DoctorName != null)
            {
                Querey = "select * from AppointmentsData where Doctor like '" + DoctorName + "%'";
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

        public static DataTable GitAllAppointmentFormOrignalTable()
        {
            DataTable dt = new DataTable();
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Appointments";

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



        public static int GitNumberOfAppointments()
        {
            int NumberOfAppointments = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select NumberOfAppointments=Count(*) from Appointments";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    NumberOfAppointments = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return NumberOfAppointments;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace Clinc_DataLayer
{
    public class clsPrescription_Data
    {
        public static int AddNewPrescription(int MedecalRecordID, string MedicationName, int Frequance,DateTime StartDate,DateTime EndDate,string SpicealInstruction)
        {
            int PrescriptionsID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "insert into Prescriptions (MedicalRecordID,MedicationName,Frequency,StartDate,EndDate,SpecialInstructions) values(@medecalrecordid,@medeshonname,@frequance,@startdate,@enddate,@specialinsturctoin); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);
          
            Command.Parameters.AddWithValue("@medecalrecordid", MedecalRecordID );
            Command.Parameters.AddWithValue("@medeshonname", MedicationName);
            Command.Parameters.AddWithValue("@frequance", Frequance);
            Command.Parameters.AddWithValue("@startdate", StartDate);
            Command.Parameters.AddWithValue("@enddate", EndDate);
            Command.Parameters.AddWithValue("@specialinsturctoin",SpicealInstruction);
 


            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    PrescriptionsID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return PrescriptionsID;
        }

        public static bool UpdatePrescriptions(int PrescriptionID, int MedecalRecordID, string MedicationName, int Frequance, DateTime StartDate, DateTime EndDate, string SpicealInstruction)
        {
            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "update Prescriptions set MedicalRecordID=@medecalrecordid , MedicationName=@medeshonname ,Frequency=@frequance ,StartDate=@startdate ,EndDate=@enddate ,SpecialInstructions=@specialinsturctoin   where PrescriptionID=@percscripotnid  ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@medecalrecordid", MedecalRecordID);
            Command.Parameters.AddWithValue("@medeshonname", MedicationName);
            Command.Parameters.AddWithValue("@frequance", Frequance);
            Command.Parameters.AddWithValue("@startdate", StartDate);
            Command.Parameters.AddWithValue("@enddate", EndDate);
            Command.Parameters.AddWithValue("@specialinsturctoin", SpicealInstruction);
            Command.Parameters.AddWithValue("@percscripotnid", PrescriptionID);

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

        public static bool DeletePrescriptions(int PrescriptionID)
        {
            bool IsDeleted = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "delete Prescriptions where PrescriptionID=@presctionid ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@presctionid", PrescriptionID);

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


        public static DataTable GitAllPrescriptions()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Prescriptions";

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

        public static bool Find(int PrescriptionID,ref int MedecalRecordID,ref string MedicationName,ref int Frequance,ref DateTime StartDate,ref DateTime EndDate,ref string SpicealInstruction)
        {
            bool IsFound = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "select * from Prescriptions where PrescriptionID=@presctionid ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@presctionid", PrescriptionID);

            try
            {
                Conniction.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PrescriptionID = Convert.ToInt32(Reader[0]);
                    MedecalRecordID = Convert.ToInt32(Reader[1]);
                    MedicationName = Convert.ToString(Reader[2]);
                    Frequance = Convert.ToInt32(Reader[3]);
                    StartDate = Convert.ToDateTime(Reader[4]);
                    EndDate = Convert.ToDateTime(Reader[5]);
                    SpicealInstruction = Convert.ToString(Reader[6]);
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

        public static DataTable Fillter(int PrescriptionID=0,int MedicalRecordID=0,string MedichinName=null,int Frequance=0)
        {
            DataTable dt = new DataTable();


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey ="";

            if (PrescriptionID != 0)
            {
                Querey = "select * from Prescriptions where PrescriptionID like '" + PrescriptionID + "%'";
            }
            if (MedicalRecordID != 0)
            {
                Querey = "select * from Prescriptions where MedicalRecordID like '" + MedicalRecordID + "%'";
            }
            if (MedichinName != null)
            {
                Querey = "select * from Prescriptions where MedicationName like '" + MedichinName + "%'";
            }
            if (Frequance != 0)
            {
                Querey = "select * from Prescriptions where Frequency like '" + Frequance + "%'";
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

        public static int GitPerscripionosByMedicalID(int MedicalRecordID)
        {
            int medicalrecordid = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "Select PrescriptionID from Prescriptions where MedicalRecordID=@medicalrecordid";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@medicalrecordid", MedicalRecordID);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    medicalrecordid = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }


            return medicalrecordid;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_DataLayer
{
    public class clsMedicalRecords_Data
    {
        public static int AddNewMedicalRecord(string VisitDescription,string Diognas,string Notes)
        {
            int MedicalRecordID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "insert into MedicalRecords (VisitDescription,Diagnosis,AdditionalNotes) values(@discription,@diagnosis,@notes); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@discription",VisitDescription );
            Command.Parameters.AddWithValue("@diagnosis", Diognas);
            Command.Parameters.AddWithValue("@notes", Notes);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    MedicalRecordID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return MedicalRecordID;
        }

        public static bool UpdateMedicalRecord( int RecordID, string VisitDescription, string Diognas, string Notes)
        {
            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "update MedicalRecords set VisitDescription=@descriptoin , Diagnosis=@diagnosis ,AdditionalNotes=@notes   where MedicalRecordID=@recordid  ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@descriptoin",VisitDescription );
            Command.Parameters.AddWithValue("@diagnosis", Diognas);
            Command.Parameters.AddWithValue("@notes", Notes);
            Command.Parameters.AddWithValue("@recordid", RecordID);

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

        public static bool DeleteMedicalRecord(int RecordID)
        {
            bool IsDeleted = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "delete MedicalRecords where MedicalRecordID=@recordid ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@recordid", RecordID);

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


        public static DataTable GitAllMedicalRecord()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from MedicalRecords";

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

        public static bool Find(int RecordID,ref string VisitDescription,ref string Diognas,ref string Notes)
        {
            bool IsFound = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);


            string Querey = "select * from MedicalRecords where MedicalRecordID=@recordid  ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@recordid", RecordID);

            try
            {
                Conniction.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    RecordID = Convert.ToInt32(Reader[0]);                  
                    VisitDescription = Convert.ToString(Reader[1]);
                    Diognas = Convert.ToString(Reader[2]);
                    Notes = Convert.ToString(Reader[3]);
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

        public static DataTable Fillter(int RecordID = 0)
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

           string Querey = "select * from MedicalRecords where MedicalRecordID like '" + RecordID + "%'";

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





    }
}

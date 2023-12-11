using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_DataLayer
{
    public class clsPatient_Data
    {
        public static bool Find(int PatientID, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Patients where PatientID=@Patientid";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@Patientid", PatientID);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PatientID = Convert.ToInt32(Reader["PatientID"]);                 
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                }
                Reader.Close();


            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }

            return IsFound;
        }

        public static int AddNewPatient(int PersoID)
        {
            int PatientID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "INSERT INTO Patients (PersonID) VALUES (@personid); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@personid", PersoID);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    PatientID = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }


            return PatientID;
        }

        public static bool UpdatePatient(int PatientID, int PersonID)
        {
            bool IsUpdated = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "UPDATE Patients SET PersonID=@personid  WHERE PatientID=@Patientid";


            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@personid", PersonID);
            Command.Parameters.AddWithValue("@Patientid", PatientID);

            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return IsUpdated;
        }

        public static bool DeletePatient(int PatientID)
        {
            bool IsDeleted = false;

            int patienID = 0;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "DELETE Patients WHERE PatientID=@Patientid";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            Command.Parameters.AddWithValue("@Patientid", PatientID);
           

            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {
                    IsDeleted = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }

            return IsDeleted;
        }

        public static DataTable GittAllPatients()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "SELECT * FROM PatientsData";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }

       public static int GitPersonID(int PatainID)
        {
            int PersonID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "Select PersonID from Patients where PatientID=@patin";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@patin", PatainID);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }


            return PersonID;

        }

        public static DataTable GittAllPatientsByFillter(int PatientID = 0, string Name = null, char Gender = ' ', string Phone = null, string Address = null)
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "";

            if(PatientID != 0 )
            {
                Query = "select * from PatientsData where PatientID like '"+PatientID+"%'";
            }
            if (Name !=null)
            {
                Query = "select * from PatientsData where Name like '"+Name+"%'";
            }
            if (Gender != ' ')
            {
                Query = "select * from PatientsData where Gender like '"+Gender+"%'";
            }
            if (Phone != null)
            {
                Query = "select * from PatientsData where PhoneNumber like '"+Phone+"%'";
            }
            if (Address != null)
            {
                Query = "select * from PatientsData where Address like '"+Address+"%'";
            }

            SqlCommand Command=new SqlCommand(Query,Conniction);
            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }


        public static int GitNumberOfPatents()
        {
            int NumberOfPatents = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select NumberOfPatents=Count(*) from Patients";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    NumberOfPatents = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return NumberOfPatents;
        }


    }
}

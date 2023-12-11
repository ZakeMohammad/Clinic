using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_DataLayer
{
    public class clsDoctor_Data
    {
        public static bool Find(int DoctorID, ref int PersonID,ref string Specialization)
        {
            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Doctors where DoctorID=@doctorid";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@doctorid", DoctorID);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DoctorID = Convert.ToInt32(Reader["DoctorID"]);
                    Specialization = Convert.ToString(Reader["Specialization"]);
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

        public static int AddNewDoctor(int PersoID, string Specialization)
        {
            int DoctorID =-1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "INSERT INTO Doctors (PersonID,Specialization) VALUES (@personid,@specil); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@specil", Specialization);
            Command.Parameters.AddWithValue("@personid", PersoID);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    DoctorID = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }


            return DoctorID;
        }

        public static bool UpdateDoctor(int DoctorID, int PersonID, string Specialization)
        {
            bool IsUpdated = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "UPDATE Doctors SET PersonID=@personid, Specialization=@special WHERE DoctorID=@doctorid";


            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@special", Specialization);
            Command.Parameters.AddWithValue("@personid", PersonID);
            Command.Parameters.AddWithValue("@doctorid", DoctorID);

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

        public static bool DeleteDoctor(int DoctorID)
        {
            bool IsDeleted = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "DELETE Doctors WHERE DoctorID=@doctorid";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            Command.Parameters.AddWithValue("@doctorid", DoctorID);


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

        public static DataTable GittAllDoctors()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "SELECT * FROM DoctorsData";

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

        public static int GitPersonID(int DocctorID)
        {
            int PersonID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "Select PersonID from Doctors  where DocctorID=@doctorid";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@doctorid", DocctorID);

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

        public static DataTable GittAllDoctorsByFillter(int DoctorID = 0, string Subspecialties = null)
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "";

            if (DoctorID != 0)
            {
                Query = "select * from DoctorsData where DoctorID like '" + DoctorID + "%'";
            }
            if (Subspecialties != null)
            {
                Query = "select * from DoctorsData where Specialization like '" + Subspecialties + "%'";
            }          
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



        public static int GitNumberOfDoctors()
        {
            int NumberOfDoctors = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select NumberOfDoctors=Count(*) from Doctors";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    NumberOfDoctors = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return NumberOfDoctors;
        }


    }



}

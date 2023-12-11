using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Clinc_DataLayer
{
    public class clsUser_Data
    {
        public static bool Find(ref int UserID, string Username, ref string Password, ref int PersonID, ref string IsActive)
        {
            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Users where Username=@username";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@username", Username);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = Convert.ToInt32(Reader["UserID"]);
                    Username = Convert.ToString(Reader["Username"]);
                    Password = Convert.ToString(Reader["Password"]);
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    IsActive = Convert.ToString(Reader["IsActive"]);
             
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

        public static int AddNewUser(string Username, string Password, int PersoID, string IsActive)
        {
            int UserID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "INSERT INTO Users (Username,Password,PersonID,IsActive) VALUES (@username,@password,@personid,@isActive); SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@username", Username);
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@personid", PersoID);
            Command.Parameters.AddWithValue("@isActive", IsActive);
     
            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }


            return UserID;
        }

        public static bool UpdateUser( int UserID, string Username, string Password,  int PersonID, string IsActive)
        {
            bool IsUpdated = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);
       
            string Querey = "UPDATE Users SET Username=@username,Password=@password,  PersonID=@personid,IsActive=@isActive WHERE UserID=@UserID";


            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@username", Username);
            Command.Parameters.AddWithValue("@password", Password);
            Command.Parameters.AddWithValue("@personid", PersonID);          
            Command.Parameters.AddWithValue("@isActive", IsActive);
            Command.Parameters.AddWithValue("@UserID", UserID);         

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

        public static bool DeleteUser(string Username)
        {
            bool IsDeleted = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "DELETE Users WHERE Username=@username";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            Command.Parameters.AddWithValue("@username", Username);


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

        public static DataTable GittAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "SELECT * FROM UsersData";

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
     
        public static int GitPersonID(string Username)
        {
            int PersonID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "Select PersonID from Users  where Username=@username";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@username", Username);

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

        public static DataTable GittAllUsersByFillter(int UserID = 0, string UserName = null,string IsActive=null)
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "";

            if (UserID != 0)
            {
                Query = "select * from UsersData where UserID like '" + UserID + "%'";
            }
            if (UserName != null)
            {
                Query = "select * from UsersData where Username like '" + UserName + "%'";
            }
            if (IsActive != null)
            {
                Query = "select * from UsersData where IsActive like '" + IsActive + "%'";
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


        public static int GitNumberOfUsers()
        {
            int NumberOfUsers = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select NumberOfUsers=Count(*) from Users";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {
                    NumberOfUsers = InsertedID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Conniction.Close();
            }
            return NumberOfUsers;
        }


    }
}

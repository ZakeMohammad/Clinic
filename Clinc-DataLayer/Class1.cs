using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Clinc_DataLayer
{

    public class clsPerson_Data
    {


        public static bool Find(int PersonID, ref string Name, ref DateTime DateOfBirth, ref char Gender, ref string PhoneNumber, ref string Email, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "select * from Persons where PersonID=@personId";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@personId", PersonID);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    Name = Convert.ToString(Reader["Name"]);
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToChar(Reader["Gender"]);
                    PhoneNumber = Convert.ToString(Reader["PhoneNumber"]);
                    Email = Convert.ToString(Reader["Email"]);
                    Address = Convert.ToString(Reader["Address"]);

                    if (Reader["ImagePath"] != DBNull.Value)
                        ImagePath = Convert.ToString(Reader["ImagePath"]);
                    else
                        ImagePath = "";
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

        public static int AddNewPerson( string Name,  DateTime DateOfBirth,  char Gender,  string PhoneNumber,  string Email,  string Address,  string ImagePath)
        {
            int PersonID = -1;
            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Querey = "INSERT INTO Persons (Name,DateOfBirth,Gender,PhoneNumber,Email,Address,ImagePath) VALUES (@name,@date,@gender,@phone,@email,@address,@imagepath); SELECT SCOPE_IDENTITY();";

            SqlCommand Command=new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@date", DateOfBirth);
            Command.Parameters.AddWithValue("@gender", Gender);
            Command.Parameters.AddWithValue("@phone", PhoneNumber);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@address", Address);

            if(ImagePath!="")
                 Command.Parameters.AddWithValue("@imagepath", ImagePath);
            else
                Command.Parameters.AddWithValue("@imagepath", System.DBNull.Value);

            try
            {
                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(),out int InsertedID)) 
                {
                    PersonID=InsertedID;
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

        public static bool UpdatePerson(int PersonID,  string Name,  DateTime DateOfBirth,  char Gender,  string PhoneNumber,  string Email,  string Address,  string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);
         
            string Querey = "UPDATE Persons SET Name=@name, DateOfBirth=@date,Gender=@gender,PhoneNumber=@phone,Email=@email,Address=@address,ImagePath=@imgapath WHERE PersonID=@personid ;";


            SqlCommand Command= new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@date", DateOfBirth);
            Command.Parameters.AddWithValue("@gender", Gender);
            Command.Parameters.AddWithValue("@phone", PhoneNumber);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@personid", PersonID);

            if (ImagePath != "")
                Command.Parameters.AddWithValue("@imgapath", ImagePath);
            else
                Command.Parameters.AddWithValue("@imgapath", System.DBNull.Value);

            try
            {
                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected>0)
                {
                    IsUpdated= true;
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

        public static bool DeletePerosn(int PersonID)
        {
            bool IsDeleted = false;


            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "DELETE Persons WHERE PersonID=@personid";

            SqlCommand Command=new SqlCommand(Query,Conniction);

            Command.Parameters.AddWithValue("@personid", PersonID);


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

        public static DataTable GittAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection(clsConnictionString.ConnictionString);

            string Query = "SELECT * FROM Persons";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            try
            {
                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
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



    }






}

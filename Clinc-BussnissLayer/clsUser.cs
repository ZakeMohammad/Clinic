using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsUser : clsPerson
    {
      

        private clsUser(int userID, string username, string Password, int personID, string name, DateTime dateOfBirth, char gender, string phoneNumber, string email, string address, string imagePath, string IsActive)
        {
            base.PersonID = personID;
            base.Name = name;
            base.DateOfBirth = dateOfBirth;
            base.Gender = gender;
            base.PhoneNumber = phoneNumber;
            base.Email = email;
            base.Address = address;
            base.ImagePath = imagePath;

            this.Password = Password;
            this.UserID = userID;          
            this.IsActive = IsActive;
            this.Username = username;
            Mode = enMode.Update;
        }
        public clsUser ()
        {
            UserID = 0;
            PersonID = 0;
            IsActive ="" ;
            Password = "";
            Username = "";
            Mode = enMode.AddNew;
        }

        public int UserID { get; set; }

     
       public string Password { get; set; }
        public string IsActive { get; set; }

        public string Username { get; set; }
       
        public static clsUser Find(string Username)
        {
            int UserID = -1, PersonID = -1;
            string IsActive = "",password="";

            if (clsUser_Data.Find(ref UserID, Username,ref password, ref PersonID, ref IsActive))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsUser(UserID,Username,password, Person.PersonID, Person.Name, Person.DateOfBirth, Person.Gender, Person.PhoneNumber, Person.Email, Person.Address, Person.ImagePath, IsActive);
            }
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUser_Data.AddNewUser(this.Username,this.Password, this.PersonID, this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUser_Data.UpdateUser(this.UserID, this.Username,this.Password, this.PersonID, this.IsActive);
        }


        public bool Save()
        {
            base.Mode = (clsPerson.enMode)Mode;


            if(this.Mode==enMode.Update)
            {
                if (!base.Save())
                {
                    return false;
                }
            }
            else
            {

            }


            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }
                default:
                    return false;
            }
        }

        public static bool DeleteUser(string Username)
        {
            int PersonID = GitPersonID(Username);

            if (clsUser_Data.DeleteUser(Username))
            {
                if(clsPerson.DeletePerson(PersonID))
                {
                    return true;
                }
                else 
                { 
                    return false;
                }
            }
          else
            {
                return false;
            }
        }

        public static DataTable GittAllUserss()
        {
            return clsUser_Data.GittAllUsers();
        }
        private static int GitPersonID(string Username)
        {
            return clsUser_Data.GitPersonID(Username);
        }
    
        public static DataTable GittAllUsersByFillter(int UserID = 0, string UserName = null, string IsActive = null)
        {
            return clsUser_Data.GittAllUsersByFillter(UserID, UserName, IsActive);
        }

        public static int NumberOfUsers()
        {
            return clsUser_Data.GitNumberOfUsers();
        }


    }
}

using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clinc_BussnissLayer
{

    public class clsPerson
    {
   
        public enum enMode { AddNew, Update}

        public enMode Mode = enMode.AddNew;

        private clsPerson(int personID, string name, DateTime dateOfBirth, char gender, string phoneNumber, string email, string address, string imagePath)
        {
            this.PersonID = personID;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
            this.ImagePath = imagePath;
            this.Mode = enMode.Update;
        }
        public clsPerson()
        {

            this.PersonID = 0;
            this.Name = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender =' ' ;
            this.PhoneNumber = "";
            this.Email = "";
            this.Address = "";
            this.ImagePath = "";
           
            this.Mode = enMode.AddNew;
        }


        public int PersonID { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public char Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ImagePath { get; set; }


        public static clsPerson Find(int PersonID)
        {
            string name = "", phonenumber = "",email="", address = "", imagepath = "";
            char gender = ' ';
            DateTime dateofbirth = DateTime.Now;

            if (clsPerson_Data.Find(PersonID, ref name, ref dateofbirth, ref gender, ref phonenumber, ref email, ref address, ref imagepath))
            {
                return new clsPerson(PersonID, name, dateofbirth, gender, phonenumber, email, address, imagepath);
            }
            else
                return null;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPerson_Data.AddNewPerson(this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address, this.ImagePath);

           return (this.PersonID != 0);
        }

        private bool _UpdatePerson()
        {
            return clsPerson_Data.UpdatePerson(this.PersonID,this.Name,this.DateOfBirth,this.Gender,this.PhoneNumber,this.Email,this.Address,this.ImagePath) ;
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewPerson())
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
                        return _UpdatePerson();
                    }
                default:
                    return false;
            }
                

            
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPerson_Data.DeletePerosn(PersonID);
        }

        public static DataTable GittAllPersonss()
        {
            return clsPerson_Data.GittAllPersons();
        }






    }
}

using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsDoctor : clsPerson
    {
        public int DoctorID { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode = enMode.AddNew;

        public string Specialization { get; set; }

        private clsDoctor(int doctorID, int personID, string name, DateTime dateOfBirth, char gender, string phoneNumber, string email, string address, string imagePath, string specialization)
        {
            base.PersonID= personID;
            base.Name= name;
            base.DateOfBirth= dateOfBirth;
            base.Gender=gender;
            base.PhoneNumber= phoneNumber;
            base.Email= email;
            base.Address= address;
            base.ImagePath= imagePath;

            this.DoctorID = doctorID;
           
            this.Specialization = specialization;


            Mode = enMode.Update;
        }


        public clsDoctor ()
        {
            this.DoctorID =-1;
           
            this.Specialization ="";
            Mode = enMode.AddNew;
        }


        public static clsDoctor Find(int DoctorID)
        {
            int  PersonID = -1;
            string Specialization = "";



            if (clsDoctor_Data.Find(DoctorID, ref PersonID, ref Specialization))
            {
                clsPerson Person=clsPerson.Find(PersonID);

                return new clsDoctor(DoctorID,Person.PersonID,Person.Name,Person.DateOfBirth,Person.Gender,Person.PhoneNumber,Person.Email,Person.Address,Person.ImagePath, Specialization);
            }
            else
                return null;
        }

        private bool _AddNewDoctor()
        {
            this.DoctorID = clsDoctor_Data.AddNewDoctor(this.PersonID, this.Specialization);

            return (this.DoctorID != -1);
        }

        private bool _UpdateDoctor()
        {
            return clsDoctor_Data.UpdateDoctor(this.DoctorID, this.PersonID, this.Specialization);
        }

        private static int GitPersonID(int DoctorID)
        {
            return clsDoctor_Data.GitPersonID(DoctorID);
        }

        public bool Save()
        {
            base.Mode = (clsPerson.enMode)Mode;

            if (!base.Save())
            {
                return false;
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewDoctor())
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
                        return _UpdateDoctor();
                    }
                default:
                    return false;
            }



        }

        public static bool DeleteDoctor(int DoctorID)
        {
            if(clsDoctor_Data.DeleteDoctor(DoctorID))
            {
                if(clsPerson.DeletePerson(GitPersonID(DoctorID)))
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public static DataTable GittAllDoctorss()
        {
            return clsDoctor_Data.GittAllDoctors();
        }


        public static DataTable GittAllDoctorsByFillter(int DoctorID=0,string Subspecialties=null)
        {
            return clsDoctor_Data.GittAllDoctorsByFillter(DoctorID, Subspecialties);
        }

        public static int NumberOfDoctors()
        {
            return clsDoctor_Data.GitNumberOfDoctors();
        }

    }
}

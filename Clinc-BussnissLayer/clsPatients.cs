using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsPatients : clsPerson
    {
        public enum enMode { AddNew, Update }

        public enMode Mode;

        public int PatientID { get; set; }
    

        private clsPatients(int patientID, int personID, string name, DateTime dateOfBirth, char gender, string phoneNumber, string email, string address, string imagePath)
        {
            base.PersonID= personID;
           base.Name= name;
            base.DateOfBirth= dateOfBirth;
            base.Gender= gender;
            base.PhoneNumber= phoneNumber;
            base.Email= email;
            base.Address= address;
            base.ImagePath = imagePath;

            this.PatientID= patientID;
            Mode = enMode.Update;
        }

        public clsPatients ()
        {
            PatientID = -1;          
            Mode = enMode.AddNew;
        }

        public static clsPatients Find(int PatientID)
        {
            int PersonID = -1;         

            if (clsPatient_Data.Find(PatientID, ref PersonID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsPatients(PatientID,Person.PersonID,Person.Name,Person.DateOfBirth,Person.Gender, Person.PhoneNumber,Person.Email,Person.Address,Person.ImagePath);
            }
            else
                return null;
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatient_Data.AddNewPatient(this.PersonID);

            return (this.PatientID != -1);
        }

        private bool _UpdatePatient()
        {
            return clsPatient_Data.UpdatePatient(this.PatientID, this.PersonID);
        }


        public bool Save()
        {
            base.Mode= (clsPerson.enMode)Mode;

            if(!base.Save()) 
            {
                return false;
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPatient())
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
                        return _UpdatePatient();
                    }
                default:
                    return false;
            }



        }

        private static int GitPersonID(int PatientID)
        {
            return clsPatient_Data.GitPersonID(PatientID);
        }


        public static bool DeletePatient(int PatientID)
        {
            int PersonID = GitPersonID(PatientID);

            if (clsPatient_Data.DeletePatient(PatientID))
            {
                if (clsPerson.DeletePerson(PersonID))
                {
                    return true;
                }
                return false;
            }
            else
                return false;

        }

        public static DataTable GittAllPatients()
        {
            return clsPatient_Data.GittAllPatients();
        }

        public static DataTable GittAllPatientsByFillter(int PatientsID=0,string Name=null,char Gender=' ',string Phone= null,string Address=null)
        {
            return clsPatient_Data.GittAllPatientsByFillter(PatientsID,Name,Gender,Phone,Address);
        }


        public static int NumberOfPatients()
        {
            return clsPatient_Data.GitNumberOfPatents();
        }

    }
}

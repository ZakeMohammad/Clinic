using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsPrescription
    {

        public enum enMode { Add,Update}

        public enMode Mode;

        public int PrescriptionID { get; set; }

        public int MedecalRecordID { get; set; }

        public string MedicationName { get; set; }

        public int Frequance { get; set; }

       public string SpecialInstructions { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        private clsPrescription (int prescriptionID, int medecalRecordID, string medicationName  , int frequance,DateTime startdate,DateTime enddate,string spicealinstruction)
        {
            this.PrescriptionID = prescriptionID;
            this.MedecalRecordID = medecalRecordID;
            this.Frequance = frequance;
            this.SpecialInstructions = spicealinstruction;
            this.MedicationName= medicationName;
            this.StartDate= startdate;
            this.EndDate= enddate;
            this.Mode = enMode.Update;
        }

        public clsPrescription ()
        {
            this.PrescriptionID =-1 ;
            this.MedecalRecordID =-1 ;
            this.Frequance =-1 ;
            this.SpecialInstructions ="" ;
            this.MedicationName = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.Mode = enMode.Add;
        }



        private bool _AddPrescriptions()
        {
            this.PrescriptionID = clsPrescription_Data.AddNewPrescription(this.MedecalRecordID, this.MedicationName, this.Frequance, this.StartDate, this.EndDate, this.SpecialInstructions);
            return (this.PrescriptionID != -1);
        }

        private bool _UpdatePrescriptions()
        {
            return clsPrescription_Data.UpdatePrescriptions(this.PrescriptionID,this.MedecalRecordID, this.MedicationName, this.Frequance, this.StartDate, this.EndDate, this.SpecialInstructions);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_AddPrescriptions())
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
                        return _UpdatePrescriptions();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


       public static bool DeletePrescriptions(int PrescriptoinID)
        {
            return clsPrescription_Data.DeletePrescriptions(PrescriptoinID);
        }


        public static clsPrescription Find(int PrescriptoinID)
        {
            int medecalrocord = 0, frequance = 0;
            DateTime startdate=DateTime.Now,enddate=DateTime.Now;
            string medecalname = "", spechialinstruction = "";



            if (clsPrescription_Data.Find(PrescriptoinID,ref medecalrocord,ref medecalname,ref frequance,ref startdate,ref enddate,ref spechialinstruction))
            {
                return new clsPrescription(PrescriptoinID, medecalrocord, medecalname, frequance, startdate, enddate, spechialinstruction);
            }
            else
                return null;
        }

        public static DataTable GitAllPrescription()
        {
            return clsPrescription_Data.GitAllPrescriptions();
        }

        public static DataTable Fillter(int PrescriptionID = 0, int MedicalRecordID = 0, string MedichinName = null, int Frequance = 0)
        {
            return clsPrescription_Data.Fillter(PrescriptionID,MedicalRecordID,MedichinName,Frequance); 
        }
        public static int GitPerscripionosByMedicalID(int MedicalRecordID)
        {
            return clsPrescription_Data.GitPerscripionosByMedicalID(MedicalRecordID);
        }


    }
}

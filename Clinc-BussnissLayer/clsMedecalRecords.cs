using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsMedecalRecords
    {

        public enum enMode { Add,Update}

        public enMode Mode;

        public int RecordID { get; set; }

        public string VisitDescrition { get; set; }

        public string Diognas { get; set; }

        public string Notes { get; set; }


         private clsMedecalRecords(int recordID,string visitDescrition,string diognas,string notes) 
         {
 
           this.RecordID = recordID;
            this.VisitDescrition = visitDescrition;
            this.Diognas = diognas;
            this.Notes = notes;
            this.Mode = enMode.Update;
         }
        public clsMedecalRecords ()
        {
            this.RecordID = -1;
            this.VisitDescrition = "";
            this.Diognas = "";
            this.Notes = "";
            this.Mode = enMode.Add;
        }



        private bool _AddMedicalRecord()
        {
            this.RecordID = clsMedicalRecords_Data.AddNewMedicalRecord(this.VisitDescrition,this.Diognas,this.Notes);
            return (this.RecordID != -1);
        }

        private bool _UpdateMedicalRecord()
        {
            return clsMedicalRecords_Data.UpdateMedicalRecord(this.RecordID, this.VisitDescrition, this.Diognas, this.Notes);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_AddMedicalRecord())
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
                        return _UpdateMedicalRecord();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


       public static bool DeleteMedicalRecord(int RecrodID)
        {
            return clsMedicalRecords_Data.DeleteMedicalRecord(RecrodID);
        }


        public static clsMedecalRecords Find(int RecrodID)
        {
            string visitDescrition = "", diognas = "", notes = "";



            if (clsMedicalRecords_Data.Find(RecrodID,ref visitDescrition, ref diognas, ref notes))
            {
                return new clsMedecalRecords(RecrodID,visitDescrition,diognas,notes);
            }
            else
                return null;
        }

        public static DataTable GitAllRecords()
        {
            return clsMedicalRecords_Data.GitAllMedicalRecord();
        }




        public static DataTable Fillter(int RecordID = 0)
        {
            return clsMedicalRecords_Data.Fillter(RecordID);
        }




    }
}

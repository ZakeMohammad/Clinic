using Clinc_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinc_BussnissLayer
{
    public class clsAppointments
    {

        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string AppointmetnStatues { get; set; }

        public  int MedecailRecordID { get; set;}

        public int PaymetnID { get; set; }


        public enum enMode { Add,Update}

        public enMode Mode;

        private clsAppointments(int appointmentID, int patientID, int doctorID, DateTime appointmentDateTime, string appointmetnStatues, int medecailRecordID , int paymetnID)
        {
            this.AppointmentID = appointmentID;
            this.PatientID = patientID;
            this.DoctorID = doctorID;
            this.AppointmentDateTime = appointmentDateTime;
            this.AppointmetnStatues = appointmetnStatues;
            this.MedecailRecordID =medecailRecordID;
            this.PaymetnID = paymetnID;
            this.Mode = enMode.Update;
        }

        public clsAppointments()
        {
            this.Mode = enMode.Add;
            this.AppointmentID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.AppointmentDateTime = DateTime.Now;
            this.AppointmetnStatues = "";
            this.MedecailRecordID = -1;
            this.PaymetnID = -1;
        }


        private bool _AddAppintment()
        {
            this.AppointmentID = clsAppointments_Data.AddNewAppiontment(this.PatientID, this.DoctorID, this.AppointmentDateTime, this.AppointmetnStatues, this.MedecailRecordID, this.PaymetnID);
            return (this.AppointmentID != -1);
        }

        private bool _UpdateAppintment()
        {
            return clsAppointments_Data.UpdateAppiontment(this.AppointmentID, this.PatientID, this.DoctorID, this.AppointmentDateTime, this.AppointmetnStatues, this.MedecailRecordID, this.PaymetnID);
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if(_AddAppintment())
                        {
                            Mode= enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false; 
                        }
                    }
                    case enMode.Update:
                    {
                        return _UpdateAppintment();
                    }
                    default:
                    {
                        return false;
                    }
            }
        }


       public static bool DeleteAppintment(int AppintmetnID)
        {
            return clsAppointments_Data.DeleteAppiontment(AppintmetnID);
        }


        public static clsAppointments Find(int AppintmetnID)
        {
            int patientid = 0, doctorid = 0, medecalrecordid = 0, paymetnid = 0;
            string statues = "";
            DateTime date= DateTime.Now;

            if (clsAppointments_Data.Find(AppintmetnID,ref patientid,ref doctorid,ref date,ref statues,ref medecalrecordid,ref paymetnid))
            {
                return new clsAppointments(AppintmetnID, patientid, doctorid, date, statues, medecalrecordid, paymetnid);
            }
            else
                return null;
        }

        public static DataTable GitALlAppintmetns()
        {
            return clsAppointments_Data.GitAllAppiontment();
        }


        public static DataTable Fillter(int AppointmentID = 0, string AppointmentStatus = null, string PaitntName = null, string DoctorName = null)
        {
            return clsAppointments_Data.Fillter(AppointmentID,AppointmentStatus,PaitntName,DoctorName);
        }


        public static DataTable GitAllAppointmentFormOrignalTable()
        {
            return clsAppointments_Data.GitAllAppointmentFormOrignalTable();
        }


        public static int NumberOfAppointments()
        {
            return clsAppointments_Data.GitNumberOfAppointments();
        }


    }
}

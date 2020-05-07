using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        // DELETE IF NOT NEEDEDDDDDDDDDDDDDDDDDDDDDD
        public int CheckPassword_Basic(string username, string password)
        {
            string query = "SELECT priv from Users_basic where username = '" + username + "' and password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectMedications()
        {
            string query = "select * from Medication";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPatients()
        {
            string query = "select * from Patient";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectScans()
        {
            string query = "select * from Scan";
            return dbMan.ExecuteReader(query);
        }

        public int DAssignMedications(long DoctorID,String PatientName, String MedicationName, decimal Dosage=0)
        {
            string query;
            if (Dosage == 0)
            {
                 query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time) "
                           + " select RegID, MID, GETDATE() "
                           + "From Registration as R, Medication as M"
                           + "where M.MID = (select MID from Medication where Name = ' " + MedicationName + " ') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc )";
            }
            else
            {
                 query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time) "
                           + " select RegID, MID, GETDATE(), "+Dosage+" "
                           + "From Registration as R, Medication as M"
                           + "where M.MID = (select MID from Medication where Name = ' " + MedicationName + " ') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc )";
            }
           
            return dbMan.ExecuteNonQuery(query);        
        }

        public int DRequestScans(long DoctorID, String PatientName, String ScanName)
        {
           string query = "Insert into Ordered_Scans(Scan_ID, Registration_ID, Scan_Start_Time, Scan_End_Time) "
           + " select RegID, SID,GETDATE(),dateadd(hh,+1,R.Reserved_Time_Slot)"
           + "From Registration as R, Scan as S"
           + "where S.SID = (select SID from Scan where Name ='"+ScanName+"') AND R.RegID =(select Top 1 RegID from Registration where (Patient_ID = (select PID from Patient where Name='"+PatientName+"')) AND (Doctor_ID ="+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query);
        }

        public String GetScanEndTime(long DoctorID, String PatientName,String ScanName)
        {

            string query = "Select Scan_End_Time from Ordered_Scans as O, Registration as R, Scan as S"
                        +"where O.Registration_ID = R.RegID And O.Scan_ID = S.SID AND S.SID = (select SID from Scan where Name = '"+ScanName+"') AND R.RegID = (select top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '"+PatientName+"')) AND(Doctor_ID = "+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query).ToString();
        }
    }
}

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

        // Checks the patient username/password and returns the patient id
        // Returns -1 in patient is not found
        public int PatientPasswordCheck(string username, string password)
        {
            string query = "SELECT PID FROM Patient where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the doctor username/password and returns the doctor id
        // Returns -1 in doctor is not found
        public int DoctorPasswordCheck(string username, string password)
        {
            string query = "SELECT DID FROM Doctor where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the receptionist username/password and returns the receptionist id
        // Returns -1 in receptionist is not found
        public int ReceptionistPasswordCheck(string username, string password)
        {
            string query = "SELECT RecID FROM Receptionist where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        // Checks the admin username/password and returns the admin id
        // Returns -1 in admin is not found
        public int AdminPasswordCheck(string username, string password)
        {
            string query = "SELECT AID FROM Admin where Username = '" + username + "' and Password = '" + password + "';";
            object p = dbMan.ExecuteScalar(query);

            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)((long)p);
            }
        }

        /////////////////     DOCTOR FORMS     /////////////////

        public DataTable SelectDoctorIDsNames()
        {
            string query = "SELECT DID, Name FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAvgDrsRatings()
        {
            string query = "SELECT Name as 'Doctor Name', Avg_Rating as 'Average Rating' FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewDrRatings(int did)
        {
            string query = "SELECT DR.Date as 'Date', P.Name as 'Patient Name', DR.Rate as 'Rating' FROM Doctor_Ratings as DR, Patient as P, Doctor as D WHERE DR.Doctor_ID = " + did + " AND DR.Doctor_ID = D.DID AND DR.Patient_ID = P.PID ORDER BY DR.Date;";
            return dbMan.ExecuteReader(query);
        }


        ////////////////////////////////////////////////////////

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

        public DataTable SelectNonReleasedPatients(long Doctor_ID)
        {
            string query = "select distinct Name from patient where PID in  (select TOP 100 PERCENT Patient_ID from Registration where State!='Released' AND (Doctor_ID =" + Doctor_ID+") Order By Date Desc )";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectScans()
        {
            string query = "select * from Scan";
            return dbMan.ExecuteReader(query);
        }

        public int DAssignMedications(long DoctorID,string PatientName, string MedicationName, string Dosage="")
        {
            string query;
            if (Dosage.Length == 0)
            {

                query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time)" +
                  " select MID, RegID, GETDATE()" +
                  " From Registration as R, Medication as M" +
                   " where M.MID = (select MID from Medication where Name = '" + MedicationName + "') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc );";
            }
            else
            {
                query = "Insert into Prescribed_Medications(Medication_ID, Registration_ID, Prescription_Time, Dosage) "
                          + " select RegID, MID, GETDATE(), '" + Dosage + "'"
                          + " From Registration as R, Medication as M"
                          + " where M.MID = (select MID from Medication where Name = '" + MedicationName + "') AND R.RegID = (select Top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID =" + DoctorID + ") Order By Date Desc )";
            }
           
            return dbMan.ExecuteNonQuery(query);        
        }

        public int DRequestScans(long DoctorID, String PatientName, String ScanName)
        {
           string query = "Insert into Ordered_Scans(Scan_ID, Registration_ID, Scan_Start_Time, Scan_End_Time) "
           + " select SID, RegID,GETDATE(),dateadd(hh,+1,R.Reserved_Time_Slot)"
           + " From Registration as R, Scan as S"
           + " where S.SID = (select SID from Scan where Name ='"+ScanName+"') AND R.RegID =(select Top 1 RegID from Registration where (Patient_ID = (select PID from Patient where Name='"+PatientName+"')) AND (Doctor_ID ="+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query);
        }

        public string GetScanEndTime(long DoctorID, string PatientName,string ScanName)
        {

            string query = "Select Scan_End_Time from Ordered_Scans as O, Registration as R, Scan as S"
                        +" where O.Registration_ID = R.RegID And O.Scan_ID = S.SID AND S.SID = (select SID from Scan where Name = '"+ScanName+"') AND R.RegID = (select top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '"+PatientName+"')) AND(Doctor_ID = "+DoctorID+") Order By Date Desc )";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string GetDoctorNameFromPatientID(long patientID)
        {
            string query = "select Name from Doctor" +
                        " where DID = (select Doctor_ID from Registration where RegID = (select top 1 RegID from Registration where Patient_ID ="+ patientID +"Order By Date Desc))";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public long GetDoctorIDFromName(string DoctorName)
        {
            string query = "select DID from Doctor where Name = '" + DoctorName + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int InsertDoctorRate(long patientID,long DoctorID,int Rate)
        {
            string query = "insert into Doctor_Ratings" +
                                                " Values" +
                                    "("+patientID+", "+DoctorID+", GETDATE(), "+Rate+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatientState(string PatientNAme, long DoctorID, string state)
        {
            string query = "Update Registration" +
                          " set State =  '" + state + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatientDiagnosis(string PatientNAme, long DoctorID, string Diagnosis)
        {
            string query = "Update Registration" +
                          " set Diagnosis =  '" + Diagnosis + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePatientComments(string PatientNAme, long DoctorID, string Comments)
        {
            string query = "Update Registration" +
                          " set Comments =  '" + Comments + "'" +
                          " where RegID = (select top 1 RegID from Registration where Patient_ID = (select PID from Patient where Name = '" + PatientNAme + "') AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public long GetReceptionistIDFromName(string Name)
        {
            string query = "select RecID from Receptionist where Name = '" + Name + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public long GetPatientIDFromName(string Name)
        {
            string query = "select PID from Patient where Name='"+Name+"'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public long DoctorFreeCheck(long DoctorID,int Date,DataTable table)
        {

            string query1 = "select Doctor_ID, Reserved_Time_Slot,Date from Registration where Doctor_ID =" + DoctorID + "and Reserved_Time_Slot = '" + Date + ":00' AND Date= CAST(getdate() AS date)";
            DataTable result1 = dbMan.ExecuteReader(query1);
            if(result1 != null)
            {
                return 0;
            }
            if (table == null)
            {
                return 0;
            }
            for (int i =0; i< table.Rows.Count; i++)
            {
                string query = "select Doctor_ID, Reserved_Time_Slot,Date,Room_ID from Registration where Doctor_ID =" + DoctorID + "and Reserved_Time_Slot = '" + Date + ":00' AND Date= CAST(getdate() AS date) AND Room_ID="+ (int)table.Rows[i]["RID"] + "";
                DataTable result = dbMan.ExecuteReader(query);
                if (result == null)
                {
                    return (int)table.Rows[i]["RID"];
                }
            }
            return 0;
            
        }

        public DataTable SelectAllDoctors()
        {
            string query = "select * from Doctor";
            return dbMan.ExecuteReader(query);   
        }

        public DataTable SelectAllUnRelievedPatients()
        {
            string query = "select distinct Name from patient where PID in  (select TOP 100 PERCENT Patient_ID from Registration where State!='Released' Order By Date Desc )";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllReciptionists()
        {
            string query = "select * from Receptionist";
            return dbMan.ExecuteReader(query);
        }

        public long GetRoomIDFromType( string type)
        {
            string query = "select top 1 RID from Room where Room_Availability=1 AND Type='" + type + "'";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int setRoomUnavailable(long RoomID)
        {
            string query = "Update Room" +
                           "set Room_Availability = 0" +
                            "where RID = " + RoomID + "";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public int insertRegisteration(long recID, long DocID, long PID, long RoomID, int Date)
        {
            string query = " Insert into Registration(Reciptionist_ID, Doctor_ID, Patient_ID, Room_ID, Date, Reserved_Time_Slot)" +
                           "values(" + recID + "," + DocID + "," + PID + "," + RoomID + ",CAST(getdate() AS date),'" + Date + ":00')";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetRoomsIDsOfCertainType(string type)
        {
            string query = "select RID from Room where Type='" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public string GetRoomTypeFromPatientID(long patientID)
        {
            string query = "select type" +
                            " from Room" +
                            " where RID = (select Top 1 Room_ID from Registration where Patient_ID = "+patientID+"  Order By Date Desc )";
            return dbMan.ExecuteScalar(query).ToString();        
        }

        public string GetReservedTimeSlotFromRegisterationByPatientID(long patientID)
        {
            string query = "select Top 1 Reserved_Time_Slot from Registration where Patient_ID = "+patientID+ " Order By Date Desc";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string GetDateFromRegisterationByPatientID(long patientID)
        {
            string query = "select Top 1 Date from Registration where Patient_ID = " + patientID + " Order By Date Desc";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public int CheckRoomChangeAbility(DataTable table,string date)
        {
            if (table == null)
            {
                return 0;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //string query = "select  Reserved_Time_Slot,Date,Room_ID from Registration where  Reserved_Time_Slot = '" + date[0]+date[1] + ":00' AND Date= CAST(getdate() AS date) AND Room_ID=" + (int)table.Rows[i]["RID"] + "";
                string query = "select Room_ID, Reserved_Time_Slot, Date from Registration where Room_ID =" + (int)table.Rows[i]["RID"] + " and Reserved_Time_Slot='" + date[0] + date[1] + ":00' AND Date=CAST(getdate() AS date)";
               // MessageBox.Show(query);
                DataTable result = dbMan.ExecuteReader(query);
                //MessageBox.Show(result.Rows.Count.ToString());
                if (result == null)
                {
                    return (int)table.Rows[i]["RID"];
                }
            }
            return 0;
        }

        public long selectRegistrationIDFromPatientID(long pid)
        {
            string query = " select Top 1 RegID from Registration where Patient_ID ="+ pid + " Order By Date Desc";
            return (long)dbMan.ExecuteScalar(query);
        }

        public int ChangeRoom(long RoomID, long RegID)
        {
            string query = "Update Registration" +
                           " set Room_ID = "+RoomID+"" +
                            " where regID = "+RegID+"";

            return (int)dbMan.ExecuteNonQuery(query);
        }
    }
}

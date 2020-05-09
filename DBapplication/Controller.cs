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

        public DataTable SelectScans()
        {
            string query = "select * from Scan";
            return dbMan.ExecuteReader(query);
        }

        public int DAssignMedications(long DoctorID, String PatientName, String MedicationName, decimal Dosage = 0)
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
                          + " select RegID, MID, GETDATE(), " + Dosage + " "
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
            + "where S.SID = (select SID from Scan where Name ='" + ScanName + "') AND R.RegID =(select Top 1 RegID from Registration where (Patient_ID = (select PID from Patient where Name='" + PatientName + "')) AND (Doctor_ID =" + DoctorID + ") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query);
        }

        public String GetScanEndTime(long DoctorID, String PatientName, String ScanName)
        {

            string query = "Select Scan_End_Time from Ordered_Scans as O, Registration as R, Scan as S"
                        + "where O.Registration_ID = R.RegID And O.Scan_ID = S.SID AND S.SID = (select SID from Scan where Name = '" + ScanName + "') AND R.RegID = (select top 1 RegID from Registration where(Patient_ID = (select PID from Patient where Name= '" + PatientName + "')) AND(Doctor_ID = " + DoctorID + ") Order By Date Desc )";
            return dbMan.ExecuteNonQuery(query).ToString();
        }


        //A_AddUpdateAdmin
        public int A_AddAdmin(string name, string username, string password)
        {
            string query = "INSERT INTO Admin (Name, Username, Password) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "')";

            return dbMan.ExecuteNonQuery(query);

        }
        public int A_UpdateAdmin(string name, string username, string password, int selectedAdmin)
        {
            string query = "update Admin set " +
               "Name='" + name + "'," +
               "Username='" + username + "'," +
               "Password='" + password + "'" +
               "where AID = " + selectedAdmin + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable SelectAdmin_name_id()
        {
            string query = "SELECT Name, AID FROM Admin;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAdmin(string name)
        {
            string query = "SELECT Name, Username, Password FROM Admin where Name=' " + name + "'";
            return dbMan.ExecuteReader(query);
        }

        //A_AddDoctor
        public int A_AddDoctor(string name, string username, string password, string gender, int age, int mobile, string address, int deptID, string startWH, string endWH, int salary, double avgRate)
        {
            string query = "INSERT INTO Doctor (Name, Username, Password, Gender, Age, Mobile_Number, Address, Department_ID, Start_of_Working_Hours,End_of_Working_Hours,Salary, Avg_Rating) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + "," +
               "" + mobile + "," +
               "'" + address + "'," +
               "" + deptID + "," +
               "'" + startWH + "'," +
               "'" + endWH + "'," +
               "" + salary + "," +
               "" + avgRate + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateDoctor(string name, string username, string password, string gender, int age, int mobile, string address, int deptID, string startWH, string endWH, int salary, double avgRate, int selectedDrID)
        {
            string query = "update Doctor set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'," +
               "Department_ID=" + deptID + "," +
               "Start_of_Working_Hours='" + startWH + "'," +
               "End_of_Working_Hours='" + endWH + "'," +
               "Salary=" + salary + "," +
               "Avg_Rating=" + avgRate +
               "where DID = " + selectedDrID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*------------------------A_AddUpdateReceptionist-----------------------*/

        public int A_AddRecep(string name, string username, string password, string gender, int age, int mobile, string address, int salary)
        {
            string query = "INSERT INTO Receptionist (Name, Username, Password, Gender, Age, Mobile_Number, Address, Salary) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + "," +
               "" + mobile + "," +
               "'" + address + "'," +
               "" + salary +")";

            return dbMan.ExecuteNonQuery(query);

        }
        
        public int A_UpdateRecep(string name, string username, string password, string gender, int age, int mobile, string address,int salary, int selectedRecepID)
        {
            string query = "update Receptionist set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'," +
               "Salary=" + salary +
               "where RecID = " + selectedRecepID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*----------------------------R_AddUpdatePatient------------------------*/
      
        public int R_AddPatient(string name, string username, string password, string gender, int age, int mobile, string address)
        {
            string query = "INSERT INTO Patient (Name, Username, Password, Gender, Age, Mobile_Number, Address) VALUES (" +
               "'" + name + "'," +
               "'" + username + "'," +
               "'" + password + "'," +
               "'" + gender + "'," +
               "" + age + "," +
               "" + mobile + "," +
               "'" + address + "'" + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int R_UpdatePatient(string name, string username, string password, string gender, int age, int mobile, string address, int selectedPatientID)
        {
            string query = "update Patient set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'" +
               "where PID = " + selectedPatientID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*-----------------------P_UpdateInfo-----------------*/
        public int P_UpdateInfo(string name, string username, string password, string gender, int age, int mobile, string address, int loggedOnPatientID)
        {
            string query = "update Patient set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'" +
               "where PID = " + loggedOnPatientID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*------------------D_UpdateInfo----------------------*/
 
        public int D_UpdateInfo(string name, string username, string password, string gender, int age, int mobile, string address, int deptID, string startWH, string endWH, int salary, double avgRate, int loggedONDrID)
        {
            string query = "update Doctor set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'," +
               "Department_ID=" + deptID + "," +
               "Start_of_Working_Hours='" + startWH + "'," +
               "End_of_Working_Hours='" + endWH + "'," +
               "Salary=" + salary + "," +
               "Avg_Rating=" + avgRate +
               "where DID = " + loggedONDrID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*----------------R_UpdateInfo--------------------*/
        public int R_UpdateInfo(string name, string username, string password, string gender, int age, int mobile, string address, int salary, int loggedOnRecepID)
        {
            string query = "update Receptionist set " +
               "Name ='" + name + "'," +
               "Username = '" + username + "'," +
               "Password ='" + password + "'," +
               "Gender='" + gender + "'," +
               "Age=" + age + "," +
               "Mobile_Number=" + mobile + "," +
               "Address='" + address + "'," +
               "Salary=" + salary +
               "where RecID = " + loggedOnRecepID;

            return dbMan.ExecuteNonQuery(query);

        }

        /*------------------A_UpdateInfo---------------------*/
        public int A_UpdateInfo(string name, string username, string password, int loggedOnAdmin)
        {
            string query = "update Admin set " +
               "Name='" + name + "'," +
               "Username='" + username + "'," +
               "Password='" + password + "'" +
               "where AID = " + loggedOnAdmin + ";";

            return dbMan.ExecuteNonQuery(query);

        }

                                                            /*-----------------------------------------*/
                                                            /*-------------------GROUP D---------------*/
                                                            /*-----------------------------------------*/

        /*-------------A_AddUpdateDepartment--------------*/

        public int A_AddDepartment(string name)
        {
            string query = "INSERT INTO Department (Name) VALUES (" +
               "'" + name + "'" +")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateDepartment(string name, int selectedDeptID)
        {
            string query = "update Department set " +
               "Name='" + name + "'" +
               "where DepID = " + selectedDeptID + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        /*----------------A_AddUpdateRoom----------------*/
        
        public int A_AddRoom(string type, int size, int price, int deptID, bool availability)
        {
            string query = "INSERT INTO Room (Type,Size,Price,Department_ID,Room_Availability) VALUES (" +
               "'" + type + "'," +
               "" + size + "," +
               "" + price + "," +
               "" + deptID + "," +
               "" + availability + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateRoom(string type, int size, int price, int deptID, bool availability, int selectedRoomID )
        {
            string query = "update Room set " +
               "Type='" + type + "'," +
               "Size=" + size + "," +
               "Price=" + price + "," +
               "Department_ID=" + deptID + "," +
               "Room_Availability=" + availability  +
               "where RID = " + selectedRoomID + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        /*--------------A_AddUpdateMedication--------------*/
        public int A_AddMedication(string name, int price, string exp_date)
        {
            string query = "INSERT INTO Medication (Name,Price,Exp_Date)  VALUES (" +
               "'" + name + "'," +
               "" + price + "," +
               "'" + exp_date + "'" +")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateMedication(string name, int price, string exp_date, int selectedMedicationID)
        {
            string query = "update Medication set " +
               "Name='" + name + "'," +
               "Price=" + price + "," +
               "Exp_Date = '" + exp_date + "'" +
               "where RID = " + selectedMedicationID + ";";

            return dbMan.ExecuteNonQuery(query);

        }

        /*-------------A_AddUpdateScan-----------*/
       
        public int A_AddScan(string name, int price)
        {
            string query = "INSERT INTO Scan (Name,Price)  VALUES (" +
               "'" + name + "'," +
               "" + price  + ")";

            return dbMan.ExecuteNonQuery(query);

        }

        public int A_UpdateScan(string name, double price, int selectedMedicationID)
        {
            string query = "update Medication set " +
               "Name='" + name + "'," +
               "Price=" + price +
               "where SID = " + selectedMedicationID + ";";

            return dbMan.ExecuteNonQuery(query);

        }














    }
}

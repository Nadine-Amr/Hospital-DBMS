-------------Database creation-------------
--create database hospital
Create database Hospital
GO
use Hospital
------------Table Creation-----------------
Create Table Patient
(
PID bigint NOT NULL,
Name VARCHAR(30) NOT NULL, 
Username VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F'),
Age INTEGER CHECK (Age > 0),
Mobile_Number  CHAR(11),
Address VARCHAR(30),
PRIMARY KEY (PID),
UNIQUE (Name),
UNIQUE (Username)
);

Create Table Admin
(
 AID bigint NOT NULL,
 Name VARCHAR(30) NOT NULL,
 Username VARCHAR(15) NOT NULL, 
 Password VARCHAR(15) NOT NULL,
 PRIMARY KEY (AID),
 UNIQUE (Username),
 UNIQUE (Name)
);

Create Table Receptionist
(
RecID bigint NOT NULL,
Name VARCHAR(30) NOT NULL, 
Username VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F'),
Age INTEGER CHECK (Age > 0),
Mobile_Number  CHAR(11),
Address VARCHAR(30),
Salary int CHECK (Salary > 0),
PRIMARY KEY (RecID),
UNIQUE (Name),
UNIQUE (Username)
);

Create Table Department
(
 DepID int NOT NULL CHECK (DepID >= 1 AND DepID <= 100),
 Name VARCHAR(30) NOT NULL,
 PRIMARY KEY (DepID),
 UNIQUE (Name)
);

Create Table Doctor
(
DID bigint NOT NULL,
Name VARCHAR(30) NOT NULL,
Username VARCHAR(15) NOT NULL, 
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F'),
Age INTEGER CHECK (Age > 0),
Mobile_Number  CHAR(11),
Address VARCHAR(30),
Department_ID int,
Start_of_Working_Hours TIME CHECK (Start_of_Working_Hours >= '08:00:00:0000000' AND Start_of_Working_Hours <= '18:00:00:0000000') DEFAULT '08:00:00:0000000', 
End_of_Working_Hours TIME CHECK (End_of_Working_Hours >= '08:00:00:0000000' AND End_of_Working_Hours <= '18:00:00:0000000') DEFAULT '18:00:00:0000000', 
Salary int NOT NULL CHECK (Salary > 0),
Avg_Rating float CHECK (Avg_Rating >= 0 AND Avg_Rating <= 10) DEFAULT 0,
PRIMARY KEY (DID), 
UNIQUE (Username),
UNIQUE (Name),
FOREIGN KEY (Department_ID) REFERENCES Department
);

Create Table Scan
(
 SID int NOT NULL CHECK (SID >= 1 AND SID <= 100),
 Name VARCHAR(30),
 Price float NOT NULL CHECK (Price >= 100 AND Price <= 1000),
 PRIMARY KEY (SID)
);

Create Table Medication
(
 MID int NOT NULL CHECK (MID >= 1 AND MID <= 500),
 Name VARCHAR(30),
 Price float NOT NULL CHECK (Price >= 20 AND Price <= 1000),
 Exp_Date DATETIME CHECK (Exp_Date > GETDATE()), 
 PRIMARY KEY (MID)
);


Create Table Room
(
 RID int NOT NULL CHECK (RID >= 1 AND RID <= 500),
 Type VARCHAR(16) CHECK (Type = 'Examination Room' OR Type = 'Surgery Room' OR Type = 'ICU'),
 Size FLOAT  CHECK (Size >= 30 AND Size <= 60),
 Price FLOAT NOT NULL CHECK (Price >= 100 AND Price <= 1000),
 Department_ID int,
 Room_Availability Binary DEFAULT 0,
 PRIMARY KEY (RID),
 FOREIGN KEY (Department_ID) REFERENCES Department,
);

Create Table Registration 
(
RegID bigint NOT NULL,
Reciptionist_ID bigint NOT NULL, 
Doctor_ID bigint NOT NULL,
Patient_ID bigint NOT NULL,
Room_ID int NOT NULL,
Date DATETIME CHECK (Date = GETDATE()) DEFAULT GETDATE(), 
Reserved_Time_Slot TIME NOT NULL CHECK (Reserved_Time_Slot >= '08:00:00:0000000' AND Reserved_Time_Slot <= '18:00:00:0000000'),
State VARCHAR(18) CHECK (State = 'Waiting' OR State = 'Being Examined' OR State = 'Getting Scans' OR State = 'Buying Medications' OR State = 'Released') DEFAULT 'Waiting',
Diagnosis VARCHAR(1000), 
Comments VARCHAR(100),
PRIMARY KEY (RegID), 
FOREIGN KEY (Reciptionist_ID) REFERENCES Receptionist,
FOREIGN KEY (Doctor_ID) REFERENCES Doctor,
FOREIGN KEY (Patient_ID) REFERENCES Patient,
FOREIGN KEY (Room_ID) REFERENCES Room,
);

Create Table Ordered_Scans
(
Registration_ID bigint NOT NULL, 
Scan_ID int NOT NULL, 
Scan_Start_Time TIME CHECK (Scan_Start_Time >= '08:00:00:0000000' AND Scan_Start_Time <= '18:00:00:0000000'),
Scan_End_Time TIME CHECK (Scan_End_Time >= '08:00:00:0000000' AND Scan_End_Time <= '18:00:00:0000000'),
PRIMARY KEY (Registration_ID,Scan_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Scan_ID) REFERENCES Scan
)

Create Table Prescribed_Medications
(
Registration_ID bigint NOT NULL, 
Medication_ID int NOT NULL, 
Prescription_Time TIME CHECK (Prescription_Time >= '08:00:00:0000000' AND Prescription_Time <= '18:00:00:0000000'),
Dosage VARCHAR(30), 
PRIMARY KEY (Registration_ID,Medication_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Medication_ID) REFERENCES Medication
);

Create Table Doctor_Ratings
(
Patient_ID bigint NOT NULL, 
Doctor_ID bigint NOT NUll, 
Date DATETIME NOT NULL CHECK (Date = GETDATE()),
Rate FLOAT NOT NULL CHECK (Rate >= 0 AND Rate <= 10),
PRIMARY KEY (Patient_ID,Doctor_ID,Date),
FOREIGN KEY (Patient_ID) REFERENCES Patient,
FOREIGN KEY (Doctor_ID) REFERENCES Doctor
);
-------------Database creation-------------
--create database hospital
Create database Hospital
GO
use Hospital
------------Table Creation-----------------
Create Table Patient
(
PID bigint identity NOT NULL,
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
 AID int identity (10,10) NOT NULL,
 Name VARCHAR(30) NOT NULL,
 Username VARCHAR(15) NOT NULL, 
 Password VARCHAR(15) NOT NULL,
 PRIMARY KEY (AID),
 UNIQUE (Username),
 UNIQUE (Name)
);

Create Table Receptionist
(
RecID bigint identity NOT NULL,
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
 DepID int identity NOT NULL CHECK (DepID >= 1 AND DepID <= 100),
 Name VARCHAR(30) NOT NULL,
 PRIMARY KEY (DepID),
 UNIQUE (Name)
);

Create Table Doctor
(
DID bigint identity NOT NULL,
Name VARCHAR(30) NOT NULL,
Username VARCHAR(15) NOT NULL, 
Password VARCHAR(15) NOT NULL,
Gender CHAR(1) CHECK (Gender = 'M' OR Gender = 'F'),
Age INTEGER CHECK (Age > 0),
Mobile_Number  CHAR(11),
Address VARCHAR(30),
Department_ID int,
Start_of_Working_Hours TIME CHECK (Start_of_Working_Hours >= '08 AM' AND Start_of_Working_Hours <= '06 PM') DEFAULT '08 AM', 
End_of_Working_Hours TIME CHECK (End_of_Working_Hours >= '08 AM' AND End_of_Working_Hours <= '06 PM') DEFAULT '06 PM', 
Salary int NOT NULL CHECK (Salary > 0),
Avg_Rating float CHECK (Avg_Rating >= 0 AND Avg_Rating <= 10) DEFAULT 0,
PRIMARY KEY (DID), 
UNIQUE (Username),
UNIQUE (Name),
FOREIGN KEY (Department_ID) REFERENCES Department
);

Create Table Scan
(
 SID int identity NOT NULL CHECK (SID >= 1 AND SID <= 100),
 Name VARCHAR(30),
 Price float NOT NULL CHECK (Price >= 100 AND Price <= 1000),
 PRIMARY KEY (SID)
);

Create Table Medication
(
 MID int identity NOT NULL CHECK (MID >= 1 AND MID <= 500),
 Name VARCHAR(30),
 Price float NOT NULL CHECK (Price >= 20 AND Price <= 1000),
 Exp_Date DATETIME CHECK (Exp_Date > GETDATE()), 
 PRIMARY KEY (MID)
);


Create Table Room
(
 RID int identity NOT NULL CHECK (RID >= 1 AND RID <= 500),
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
RegID bigint identity NOT NULL,
Reciptionist_ID bigint NOT NULL, 
Doctor_ID bigint NOT NULL,
Patient_ID bigint NOT NULL,
Room_ID int NOT NULL,
Date DATETIME CHECK (Date = GETDATE()) DEFAULT GETDATE(), 
Reserved_Time_Slot TIME NOT NULL CHECK (Reserved_Time_Slot >= '08 AM' AND Reserved_Time_Slot <= '06 PM'),
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
Scan_Start_Time TIME CHECK (Scan_Start_Time >= '08 AM' AND Scan_Start_Time <= '06 PM'),
Scan_End_Time TIME CHECK (Scan_End_Time >= '08 AM' AND Scan_End_Time <= '06 PM'),
PRIMARY KEY (Registration_ID,Scan_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Scan_ID) REFERENCES Scan
)

Create Table Prescribed_Medications
(
Registration_ID bigint NOT NULL, 
Medication_ID int NOT NULL, 
Prescription_Time TIME CHECK (Prescription_Time >= '08 AM' AND Prescription_Time <= '06 PM'),
Dosage VARCHAR(30), 
PRIMARY KEY (Registration_ID,Medication_ID),
FOREIGN KEY (Registration_ID) REFERENCES Registration,
FOREIGN KEY (Medication_ID) REFERENCES Medication
);

Create Table Doctor_Ratings
(
Patient_ID bigint NOT NULL, 
Doctor_ID bigint NOT NUll, 
Date DATE NOT NULL CHECK (Date = CAST(getdate() AS date)),
Rate FLOAT NOT NULL CHECK (Rate >= 0 AND Rate <= 10),
PRIMARY KEY (Patient_ID,Doctor_ID,Date),
FOREIGN KEY (Patient_ID) REFERENCES Patient,
FOREIGN KEY (Doctor_ID) REFERENCES Doctor
);

SET IDENTITY_INSERT Patient ON
insert into Patient(PID,Name,Username,Password,Gender,Age,Mobile_Number,Address)
values
(1,'Mohamad', 'M16','1234', 'M',5,'01145585123','doky'),
(2,'Ibrahim', 'I20','1234', 'M',20,'01145585193','October'),
(3,'Fatma', 'F90','1234', 'F',7,'01245585193','Giza')
SET IDENTITY_INSERT Patient OFF

SET IDENTITY_INSERT Admin ON
insert into Admin (AID,Name,Username,Password)
Values
(10, 'Ali','A91','1234'),
(20, 'Hesham','H11','1234'),
(30, 'Samir','S61','1234')
SET IDENTITY_INSERT Admin OFF

SET IDENTITY_INSERT Receptionist ON
insert into Receptionist(RecID,Name,Username,Password,Gender,Age,Mobile_Number,Address,Salary)
Values
(26, 'Ahmed','A50','1234','M',26,'01247585193','Cairo',5000),
(30, 'hamad','H90','1234','M',45,'01347585193','Mansora',7000),
(40, 'Remas','HM15','1234','F',27,'01247595193','Fayoom',9000)
SET IDENTITY_INSERT Receptionist OFF

SET IDENTITY_INSERT Department ON
insert into Department(DepID,Name)
Values
(1,'Brain'),
(2, 'heart'),
(3, 'Eyes')
SET IDENTITY_INSERT Department OFF

SET IDENTITY_INSERT Doctor ON
insert into Doctor(DID,Name,Username,Password,Gender,Age,Mobile_Number,Address,Department_ID,Start_of_Working_Hours,End_of_Working_Hours,Salary,Avg_Rating)
values
(1,'Diaa','D76','1234','M',25,'01247599193','Dubi',1,'08 AM' ,'06 PM' ,10000,10),
(2,'Nour','N78','1234','F',29,'01747599193','Germany',2,'08 AM','06 PM',30000,10),
(3,'Nesreen','N59','1234','F',31,'01247599190','Italy',3,'08 AM','06 PM',80000,10)
SET IDENTITY_INSERT Doctor Off

SET IDENTITY_INSERT Scan ON
insert into Scan(SID,Name,Price)
Values
(1,'MRI', 200),
(2,'Blood',300),
(3, 'XRay',400)
SET IDENTITY_INSERT Scan OFF

SET IDENTITY_INSERT Medication ON
insert into Medication(MID,Name,Price,Exp_Date)
Values
(1,'koha',100,'2030-05-10'),
(2, 'Soda3',50,'2050-09-16'),
(3, 'vitamins',90,'2090-04-19')
SET IDENTITY_INSERT Medication OFF

SET IDENTITY_INSERT Room  ON
insert into Room(RID,Type,Size,Price,Department_ID,Room_Availability) 
Values
(1,'Examination Room',40,900,1,0),
(2,'Examination Room',50,800,2,1),
(3,'Examination Room',35,950,3,0)
SET IDENTITY_INSERT Room  OFF

SET IDENTITY_INSERT Registration ON
insert into Registration(RegID,Reciptionist_ID,Doctor_ID,Patient_ID,Room_ID,Date,Reserved_Time_Slot,State,Diagnosis,Comments)
Values
(1,26, 1, 1, 1, GETDATE(), '08 AM', 'Waiting', NULL, NULL),
(2,30, 2, 2, 2, GETDATE(), '09 AM', 'Waiting', NULL, NULL),
(3,40, 3, 3, 3, GETDATE(), '10 AM', 'Waiting', NULL, NULL)
SET IDENTITY_INSERT Registration OFF

insert into Ordered_Scans
Values
(1, 1, '08:30 AM', '09 AM'),
(2, 2, '09:30 AM', '10 AM'),
(3, 3, '10:30 AM', '11 AM')


insert into Prescribed_Medications
Values
(1, 1, '08:30 AM', '2ml'),
(2, 2, '09:30 AM', '1 table-spoon'),
(3, 3, '10:30 AM', 'once a day')

insert into Doctor_Ratings
Values
(1, 1, GETDATE(), 10),
(2, 2, GETDATE(), 10),
(3, 3, GETDATE(), 10)
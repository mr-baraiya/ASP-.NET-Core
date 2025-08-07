create database HospitalManagement
use HospitalManagement

create table HospitalMaster(
	HospitalID			int primary key identity(1,1)
	,HospitalName		nvarchar(150) Not null
	,HospitalAddress	nvarchar(250) Not null
	,ContactNumber		nvarchar(10) Not null
	,EmailAddress		nvarchar(250) Not null
	,OwnerName			nvarchar(250) Not null
	,OpeningDate		datetime Not null
	,TotalStaffs		int Not null
	,SundayOpen			bit Not null
);

INSERT INTO HospitalMaster (
    HospitalName, HospitalAddress, ContactNumber,
    EmailAddress, OwnerName, OpeningDate, TotalStaffs, SundayOpen
)
VALUES
('Hospital_1', 'Address_1, City, State', '9000000001', 'hospital1@example.com', 'Owner_1', '2020-01-01', 50, 1),
('Hospital_2', 'Address_2, City, State', '9000000002', 'hospital2@example.com', 'Owner_2', '2020-01-02', 60, 0),
('Hospital_3', 'Address_3, City, State', '9000000003', 'hospital3@example.com', 'Owner_3', '2020-01-03', 55, 1),
('Hospital_4', 'Address_4, City, State', '9000000004', 'hospital4@example.com', 'Owner_4', '2020-01-04', 40, 0),
('Hospital_5', 'Address_5, City, State', '9000000005', 'hospital5@example.com', 'Owner_5', '2020-01-05', 45, 1),
('Hospital_6', 'Address_6, City, State', '9000000006', 'hospital6@example.com', 'Owner_6', '2020-01-06', 70, 1),
('Hospital_7', 'Address_7, City, State', '9000000007', 'hospital7@example.com', 'Owner_7', '2020-01-07', 65, 0),
('Hospital_8', 'Address_8, City, State', '9000000008', 'hospital8@example.com', 'Owner_8', '2020-01-08', 80, 1),
('Hospital_9', 'Address_9, City, State', '9000000009', 'hospital9@example.com', 'Owner_9', '2020-01-09', 90, 0),
('Hospital_10', 'Address_10, City, State', '9000000010', 'hospital10@example.com', 'Owner_10', '2020-01-10', 100, 1);


create table Patients(
	PatientID			int primary key identity(1,1)
	,PatientName		nvarchar(150) Not Null
	,Contact			nvarchar(10) Not Null
	,Age				int Not Null
	,EarlierOperation	bit Not Null	
	,BloodGroup			nvarchar(10) Not Null
);

INSERT INTO Patients (PatientName, Contact, Age, EarlierOperation, BloodGroup)
VALUES
('Ankit Sharma', '9876543210', 28, 0, 'O+'),
('Sneha Verma', '9123456789', 34, 1, 'A+'),
('Ravi Kumar', '9001234567', 41, 0, 'B+'),
('Priya Singh', '9765432109', 25, 1, 'AB+'),
('Amit Joshi', '9012345678', 52, 1, 'O-'),
('Tanya Gupta', '9988776655', 19, 0, 'B-'),
('Sachin Mehta', '9873216540', 37, 1, 'A-'),
('Neha Rajput', '9955667788', 31, 0, 'O+'),
('Manoj Tiwari', '9090909090', 45, 1, 'AB-'),
(N'अनुज शर्मा', '9111222333', 23, 0, 'B+');  -- Unicode name (Hindi)


create table Doctors(
	DoctorID			int primary key identity(1,1)
	,DoctorName			nvarchar(150) Not Null
	,Degree				nvarchar(50) Not Null
	,Experience			int Not Null
	,Specification		nvarchar(50)
	,Age				int Not Null
	,DOB				datetime Not Null
)

INSERT INTO Doctors (DoctorName, Degree, Experience, Specification, Age, DOB)
VALUES
('Dr. Anjali Mehra', 'MBBS', 8, 'Cardiologist', 35, '1989-04-12'),
('Dr. Rajeev Sinha', 'MD', 15, 'Neurologist', 45, '1980-09-30'),
('Dr. Meena Shah', 'BDS', 5, 'Dentist', 30, '1994-02-18'),
('Dr. Varun Patel', 'MBBS', 12, 'Orthopedic', 40, '1984-11-05'),
('Dr. Sneha Gupta', 'MD', 10, 'Gynecologist', 38, '1986-06-25'),
('Dr. Sameer Khan', 'MBBS', 6, 'Dermatologist', 33, '1991-08-10'),
('Dr. Neha Bhatt', 'MS', 9, 'ENT Specialist', 36, '1988-01-22'),
('Dr. Arjun Yadav', 'MBBS', 7, 'Pediatrician', 32, '1992-07-15'),
('Dr. Kavita Rao', 'BAMS', 14, 'Ayurveda', 44, '1981-12-01'),
(N'डॉ. अमन सिंह', 'MBBS', 4, 'General Physician', 29, '1995-03-09'); -- Unicode name (Hindi)

select  * from HospitalMaster;
select  * from Patients;
select  * from Doctors;
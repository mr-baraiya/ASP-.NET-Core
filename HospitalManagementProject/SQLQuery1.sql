create database HospitalManagement
use HospitalManagement

create table HospitalMaster(
	HospitalID			int primary key
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
    HospitalID, HospitalName, HospitalAddress, ContactNumber,
    EmailAddress, OwnerName, OpeningDate, TotalStaffs, SundayOpen
)
VALUES
(1, 'Hospital_1', 'Address_1, City, State', '9000000001', 'hospital1@example.com', 'Owner_1', '2020-01-01', 50, 1),
(2, 'Hospital_2', 'Address_2, City, State', '9000000002', 'hospital2@example.com', 'Owner_2', '2020-01-02', 60, 0),
(3, 'Hospital_3', 'Address_3, City, State', '9000000003', 'hospital3@example.com', 'Owner_3', '2020-01-03', 55, 1),
(4, 'Hospital_4', 'Address_4, City, State', '9000000004', 'hospital4@example.com', 'Owner_4', '2020-01-04', 40, 0),
(5, 'Hospital_5', 'Address_5, City, State', '9000000005', 'hospital5@example.com', 'Owner_5', '2020-01-05', 45, 1),
(6, 'Hospital_6', 'Address_6, City, State', '9000000006', 'hospital6@example.com', 'Owner_6', '2020-01-06', 70, 1),
(7, 'Hospital_7', 'Address_7, City, State', '9000000007', 'hospital7@example.com', 'Owner_7', '2020-01-07', 65, 0),
(8, 'Hospital_8', 'Address_8, City, State', '9000000008', 'hospital8@example.com', 'Owner_8', '2020-01-08', 80, 1),
(9, 'Hospital_9', 'Address_9, City, State', '9000000009', 'hospital9@example.com', 'Owner_9', '2020-01-09', 90, 0),
(10, 'Hospital_10', 'Address_10, City, State', '9000000010', 'hospital10@example.com', 'Owner_10', '2020-01-10', 100, 1);

select  * from HospitalMaster;

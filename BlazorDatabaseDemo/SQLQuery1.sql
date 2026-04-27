create database SchoolDB;

create table STUDENTS(
	Id		int PRIMARY KEY Identity,
	Name	Nvarchar(100),
	AGE		INT,
	CITY	NVARCHAR(100)
);

INSERT INTO STUDENTS VALUES
('Prem',12,'Amd'),
('Kumar',20,'Bombay'),
('Badnaam',34,'Goa');

SELECT *  FROM STUDENTS;
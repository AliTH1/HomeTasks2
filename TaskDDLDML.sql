CREATE DATABASE SQLTASKS

USE SQLTASKS

CREATE TABLE regions(
Region_Id INT PRIMARY KEY IDENTITY,
Region_Name NVARCHAR(25)
)

CREATE TABLE countries(
Country_Id CHAR(2) PRIMARY KEY,
Country_Name NVARCHAR(40),
Region_Id INT
)

CREATE TABLE locations(
Location_Id INT PRIMARY KEY IDENTITY,
Street_Address NVARCHAR(25),
Postal_Code VARCHAR(12),
City NVARCHAR(30),
State_Province VARCHAR(12),
Country_Id CHAR(2)
)

CREATE TABLE departments(
Department_Id INT PRIMARY KEY IDENTITY,
Department_Name NVARCHAR(30),
Manager_Id INT,
Location_Id INT
)

CREATE TABLE employees(
Employee_Id INT PRIMARY KEY IDENTITY,
First_Name NVARCHAR(20),
Last_Name NVARCHAR(25),
Email VARCHAR(25),
Phone_Number VARCHAR(20),
Hire_Date DATE,
Job_Id VARCHAR(10),
Salary INT,
Commision_Pct INT,
Manager_Id INT,
Department_Id INT
)

CREATE TABLE jobs(
Job_Id VARCHAR(10) PRIMARY KEY,
Job_Title VARCHAR(35),
Min_Salary INT,
Max_Salary INT
)

CREATE TABLE job_history(
Employee_Id INT PRIMARY KEY IDENTITY,
[Start_Date] DATE,
End_Date DATE,
Job_Id VARCHAR(10),
Department_Id INT
)

CREATE TABLE job_grades(
Grade_Level VARCHAR(2) PRIMARY KEY,
Lowest_Sal INT,
Highest_Sal INT
)
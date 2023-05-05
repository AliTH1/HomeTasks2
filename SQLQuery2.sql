CREATE DATABASE SQLTASKS2
USE SQLTASKS2



--Self Join
CREATE TABLE SelfJoinTable(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20),
ManagerId INT
)


INSERT INTO SelfJoinTable(Name, ManagerId)
VALUES
('Ali', NULL),
('Akbar', 1),
('Hasan', 1),
('Reshad', 3),
('Mahir', 2)


SELECT sjt.Name, sjt2.Name FROM SelfJoinTable AS sjt
INNER JOIN SelfJoinTable AS sjt2
ON sjt.Id = sjt2.ManagerId
--------------------------------



--Cross Join
CREATE TABLE Smartphones(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20),
)

CREATE TABLE Color_Name(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20)
)

INSERT INTO Smartphones(Name)
VALUES('Iphone'), ('Samsung'), ('Huawei')

INSERT INTO Color_Name(Name)
VALUES
('Red'), ('Black'), ('White')


SELECT * FROM Smartphones
CROSS JOIN Color_Name
--------------------------------



--CREATE TABLE Products(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(20),
--Price FLOAT CHECK(Price >= 0 AND Price <= 100)
--)

--CREATE TABLE CategoriesProduct(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(20),
--PriceCategories INT CHECK(PriceCategories >= 0 AND PriceCategories <= 100)
--)


--INSERT INTO Products(Name, Price)
--VALUES('Eggs', 1.5), ('Lays', 5), ('Bread', 3)

--INSERT INTO CategoriesProduct(Name, PriceCategories)
--VALUES('MilkProd', ),



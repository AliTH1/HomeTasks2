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



CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20),
Price FLOAT CHECK(Price >= 0 AND Price <= 100)
)

CREATE TABLE CategoriesProduct(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20),
MinPriceCategories INT CHECK(MinPriceCategories >= 0 AND MinPriceCategories <= 100),
MaxPriceCategories INT CHECK(MaxPriceCategories >= 0 AND MaxPriceCategories <= 100)
)

INSERT INTO Products(Name, Price)
VALUES ('Eggs', 1), ('Yogurt', 3), ('Apple', 6), ('Cherry', 8)

INSERT INTO CategoriesProduct(Name, MinPriceCategories, MaxPriceCategories)
VALUES('MilkProd', 1, 5), ('FruitsProd', 5, 10)


SELECT * FROM Products AS p
INNER JOIN CategoriesProduct AS cp
ON p.price BETWEEN cp.MinPriceCategories AND cp.MaxPriceCategories



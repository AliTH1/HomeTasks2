CREATE DATABASE Library
USE Library

CREATE TABLE Authors(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(20) NOT NULL,
Surname NVARCHAR(20) NOT NULL
)

CREATE TABLE Books(
Id INT PRIMARY KEY IDENTITY,
AuthorId INT FOREIGN KEY REFERENCES Authors(Id),
[Name] NVARCHAR(100) CHECK(LEN([Name]) > 2) NOT NULL,
PageCount INT CHECK(PageCount >= 10) NOT NULL
)


INSERT INTO Authors([Name], Surname)
VALUES ('Grant', 'Cardone'),
('Robert', 'Kiyosaki'),
('Ahmed', 'Gazzali')

INSERT INTO Books(AuthorId, Name, PageCount)
VALUES
(1, 'The 10X Rule', 300),
(2, 'Rich Dad Poor Dad', 500),
(3, 'The Alchemy of Happiness', 650)



CREATE VIEW BooksInfo AS
SELECT bk.Id, bk.Name, bk.PageCount,
CONCAT(ath.Name, ' ' , ath.Surname) AS AuthorFullName
FROM Books AS bk
INNER JOIN Authors AS ath
ON bk.AuthorId = ath.Id


--Procedure
CREATE PROCEDURE usp_GetBookNameOrAuthorName @bookName NVARCHAR(20), @authorName NVARCHAR(20)
AS
SELECT bk.Id, bk.Name, bk.PageCount,
CONCAT(ath.Name, ' ' , ath.Surname) AS AuthorFullName
FROM Books AS bk
INNER JOIN Authors AS ath
ON bk.AuthorId = ath.Id
WHERE bk.Name = @bookName OR ath.Name = @authorName

EXEC usp_GetBookNameOrAuthorName @bookName = 'The  Rule', @authorName = 'Robert'



--Function
CREATE FUNCTION GetBookWithPageCount (@minPageCount INT)
RETURNS INT
AS
BEGIN
	DECLARE @Count INT
	SELECT @Count = COUNT(*) FROM Books WHERE PageCount >= @minPageCount
	RETURN @Count
END


SELECT dbo.GetBookWithPageCount(500)

--Trigger
CREATE TABLE DeletedBooks(
Id INT PRIMARY KEY IDENTITY,
AuthorId INT,
Name NVARCHAR(20),
PageCount INT
)

CREATE TRIGGER WriteDeletedBooks
ON Books
AFTER DELETE
AS
BEGIN
	DECLARE @AuthorId INT
	DECLARE @Name NVARCHAR(20)
	DECLARE @PageCount INT
	SELECT @AuthorId = BookList.AuthorId, @Name = BookList.Name,
	@PageCount = BookList.PageCount FROM DELETED BookList
	INSERT INTO DeletedBooks VALUES(@AuthorId, @Name, @PageCount)
END

DELETE FROM Books WHERE ID = 6
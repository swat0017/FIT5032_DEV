CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [userId] NCHAR(10) NULL
)
GO
CREATE TABLE [dbo].[Units]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Description] NCHAR(10) NULL, 
    [StudentId] int NOT NULL
	FOREIGN KEY (StudentId) references Students(Id)
);
GO

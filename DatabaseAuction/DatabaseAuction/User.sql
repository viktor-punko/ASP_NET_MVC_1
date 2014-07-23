CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(20) NULL, 
    [LastName] NCHAR(20) NULL, 
    [Email] NCHAR(255) NULL, 
    [Phone] NCHAR(20) NULL, 
    [UniqId] NCHAR(32) NULL
)

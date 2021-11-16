CREATE TABLE [dbo].[students]
(
	[Rnumber] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [names] VARCHAR(250) NULL, 
    [dob] DATE NULL, 
    [age] NCHAR(10) NULL, 
    [gender] CHAR(10) NULL, 
    [contactNumber] VARCHAR(10) NULL, 
    [courses] VARCHAR(250) NULL, 
    [fee] NCHAR(20) NULL
)

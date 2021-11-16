CREATE TABLE [dbo].[login] (
	[userID]   VARCHAR (150) NOT NULL,
    [username] VARCHAR (150) NOT NULL,
    [password] VARCHAR (200) NOT NULL, 
    CONSTRAINT [PK_login] PRIMARY KEY ([userID])
);


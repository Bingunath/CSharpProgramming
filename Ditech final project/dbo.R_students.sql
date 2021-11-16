CREATE TABLE [dbo].[R_students] (
    [Registration_Number] VARCHAR (50) NOT NULL,
    [Student_Name]        VARCHAR (50) NULL,
    [Date_of_birth]       DATE         NULL,
    [Gender]              CHAR (1)     NULL,
    [Contact_Number]      VARCHAR (10) NULL,
    [Enrolled_courses]    VARCHAR (20) NULL,
    [age]                 NCHAR (10)   NULL,
    CONSTRAINT [PK_R_students] PRIMARY KEY CLUSTERED ([Registration_Number] ASC)
);


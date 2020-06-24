
	CREATE TABLE [dbo].[Employees] (
    [ID]           INT        IDENTITY (1, 1) NOT NULL,
    [Name]         NCHAR (10) NOT NULL,
    [Surname]      NCHAR (10) NOT NULL,
    [Age]          TINYINT    DEFAULT ((22)) NULL,
    [Salary]       MONEY      DEFAULT ((50000)) NULL,
    [DepartmentID] INT        DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DepartmentID] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Departments] ([ID])
);




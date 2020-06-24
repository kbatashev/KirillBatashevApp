CREATE TABLE [dbo].[Departments] (
    [ID]   INT        IDENTITY (1, 1) NOT NULL,
    [dName] NCHAR (20) DEFAULT (N'Отдел_1') NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

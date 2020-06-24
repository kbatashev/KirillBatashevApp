Создать таблицу "Сотрудники"

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

Создать таблицу "Отделы"

CREATE TABLE [dbo].[Departments] (
    [ID]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (20) DEFAULT (N'Крутой_отдел_1') NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


Заполнить таблицы данными

INSERT INTO Departments (Name) VALUES (N'Отдел_1')
INSERT INTO Departments (Name) VALUES (N'Отдел_2')
INSERT INTO Departments (Name) VALUES (N'Отдел_3')
INSERT INTO Departments (Name) VALUES (N'Отдел_4')


INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_0', N'Фамилия_0', 18, 35000, 4)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_1', N'Фамилия_1', 19, 38000, 1)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_2', N'Фамилия_2', 20, 40000, 2)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_3', N'Фамилия_3', 21, 45000, 3)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_4', N'Фамилия_4', 25, 80000, 4)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_5', N'Фамилия_5', 30, 100000, 1)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_6', N'Фамилия_6', 45, 150000, 4)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_7', N'Фамилия_7', 37, 120000, 3)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_8', N'Фамилия_8', 24, 101000, 2)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_9', N'Фамилия_9', 36, 113000, 1)
INSERT INTO Employees (Name, Surname, Age, Salary, DepartmentID) VALUES (N'Имя_10', N'Фамилия_10', 33, 133000, 4)


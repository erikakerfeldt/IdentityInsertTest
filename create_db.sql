CREATE DATABASE [EFCoreTest];
GO

USE [EFCoreTest];

CREATE TABLE [Company] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	CONSTRAINT [PK_Company] PRIMARY KEY ([Id] ASC)
);

CREATE TABLE [Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[CompanyId] [int] NULL,
	CONSTRAINT [PK_Employee] PRIMARY KEY ([Id] ASC)
);

GO

ALTER TABLE [Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Company] FOREIGN KEY([CompanyId]) REFERENCES [Company] ([Id]);
ALTER TABLE [Employee] CHECK CONSTRAINT [FK_Employee_Company];


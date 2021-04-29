
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2021 11:19:49
-- Generated from EDMX file: C:\Users\konra\OneDrive - Institute of Technology Sligo\Modules\Year 2\Semester 2\Object Oriented Development ye2 sem2\Sligo University Project\sligoUniversityProject\sligoUniversityProject\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [People];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [MiddleName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [IdNumber] nvarchar(max)  NULL,
    [DateOfBirth] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [PersonType] nvarchar(max)  NULL,
    [test] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2018 22:03:42
-- Generated from EDMX file: f:\Users\Administrator\source\repos\SCB\SCB\Models\ScriptsControlBackground.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SCB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_GameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_GameSet];
GO
IF OBJECT_ID(N'[dbo].[tb_UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_UserSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tb_GameSet'
CREATE TABLE [dbo].[tb_GameSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [OSType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tb_UserSet'
CREATE TABLE [dbo].[tb_UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [Six] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'tb_GameSet'
ALTER TABLE [dbo].[tb_GameSet]
ADD CONSTRAINT [PK_tb_GameSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tb_UserSet'
ALTER TABLE [dbo].[tb_UserSet]
ADD CONSTRAINT [PK_tb_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2018 22:32:23
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

IF OBJECT_ID(N'[dbo].[FK_tb_Plantb_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_PlanSet] DROP CONSTRAINT [FK_tb_Plantb_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_Plantb_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_PlanSet] DROP CONSTRAINT [FK_tb_Plantb_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_GameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_GameSet];
GO
IF OBJECT_ID(N'[dbo].[tb_UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_UserSet];
GO
IF OBJECT_ID(N'[dbo].[tb_PlanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_PlanSet];
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

-- Creating table 'tb_PlanSet'
CREATE TABLE [dbo].[tb_PlanSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [ModHard] bit  NOT NULL,
    [ModVpn] bit  NOT NULL,
    [TaskNewArr] nvarchar(max)  NOT NULL,
    [TaskKeepArr] nvarchar(max)  NOT NULL,
    [tb_Game_Id] int  NOT NULL,
    [tb_User_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'tb_PlanSet'
ALTER TABLE [dbo].[tb_PlanSet]
ADD CONSTRAINT [PK_tb_PlanSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [tb_Game_Id] in table 'tb_PlanSet'
ALTER TABLE [dbo].[tb_PlanSet]
ADD CONSTRAINT [FK_tb_Plantb_Game]
    FOREIGN KEY ([tb_Game_Id])
    REFERENCES [dbo].[tb_GameSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_Plantb_Game'
CREATE INDEX [IX_FK_tb_Plantb_Game]
ON [dbo].[tb_PlanSet]
    ([tb_Game_Id]);
GO

-- Creating foreign key on [tb_User_Id] in table 'tb_PlanSet'
ALTER TABLE [dbo].[tb_PlanSet]
ADD CONSTRAINT [FK_tb_Plantb_User]
    FOREIGN KEY ([tb_User_Id])
    REFERENCES [dbo].[tb_UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_Plantb_User'
CREATE INDEX [IX_FK_tb_Plantb_User]
ON [dbo].[tb_PlanSet]
    ([tb_User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
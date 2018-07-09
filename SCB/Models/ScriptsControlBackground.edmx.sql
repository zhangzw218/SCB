
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/09/2018 23:03:20
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

IF OBJECT_ID(N'[dbo].[FK_PlannedTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TaskSet] DROP CONSTRAINT [FK_PlannedTask];
GO
IF OBJECT_ID(N'[dbo].[FK_PriorityPlanned]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlannedSet] DROP CONSTRAINT [FK_PriorityPlanned];
GO
IF OBJECT_ID(N'[dbo].[FK_PriorityTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TaskSet] DROP CONSTRAINT [FK_PriorityTask];
GO
IF OBJECT_ID(N'[dbo].[FK_GamePlanned]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlannedSet] DROP CONSTRAINT [FK_GamePlanned];
GO
IF OBJECT_ID(N'[dbo].[FK_GameTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TaskSet] DROP CONSTRAINT [FK_GameTask];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPlanned]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlannedSet] DROP CONSTRAINT [FK_UserPlanned];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PlannedSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlannedSet];
GO
IF OBJECT_ID(N'[dbo].[TaskSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaskSet];
GO
IF OBJECT_ID(N'[dbo].[PrioritySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PrioritySet];
GO
IF OBJECT_ID(N'[dbo].[GameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PlannedTbSet'
CREATE TABLE [dbo].[PlannedTbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [GameServer] nvarchar(max)  NOT NULL,
    [State] int  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [TaskSum] int  NOT NULL,
    [TaskImmVpn] int  NOT NULL,
    [TaskWideVpn] int  NOT NULL,
    [RegisterArr] nvarchar(max)  NOT NULL,
    [RemainArr] nvarchar(max)  NOT NULL,
    [PriorityId] int  NOT NULL,
    [GameId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [ModHard] bit  NOT NULL,
    [ModVPN] bit  NOT NULL
);
GO

-- Creating table 'TaskTbSet'
CREATE TABLE [dbo].[TaskTbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlannedId] int  NOT NULL,
    [PriorityId] int  NOT NULL,
    [ExecutingNum] int  NOT NULL,
    [CancelNum] int  NOT NULL,
    [ErrorNum] int  NOT NULL,
    [TaskSum] int  NOT NULL,
    [ExecutionDate] datetime  NOT NULL,
    [State] int  NOT NULL,
    [GameId] int  NOT NULL
);
GO

-- Creating table 'PriorityTbSet'
CREATE TABLE [dbo].[PriorityTbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassName] nvarchar(max)  NOT NULL,
    [ClassRank] int  NOT NULL
);
GO

-- Creating table 'GameTbSet'
CREATE TABLE [dbo].[GameTbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [OSType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserTbSet'
CREATE TABLE [dbo].[UserTbSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PlannedTbSet'
ALTER TABLE [dbo].[PlannedTbSet]
ADD CONSTRAINT [PK_PlannedTbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TaskTbSet'
ALTER TABLE [dbo].[TaskTbSet]
ADD CONSTRAINT [PK_TaskTbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriorityTbSet'
ALTER TABLE [dbo].[PriorityTbSet]
ADD CONSTRAINT [PK_PriorityTbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameTbSet'
ALTER TABLE [dbo].[GameTbSet]
ADD CONSTRAINT [PK_GameTbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserTbSet'
ALTER TABLE [dbo].[UserTbSet]
ADD CONSTRAINT [PK_UserTbSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PlannedId] in table 'TaskTbSet'
ALTER TABLE [dbo].[TaskTbSet]
ADD CONSTRAINT [FK_PlannedTask]
    FOREIGN KEY ([PlannedId])
    REFERENCES [dbo].[PlannedTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlannedTask'
CREATE INDEX [IX_FK_PlannedTask]
ON [dbo].[TaskTbSet]
    ([PlannedId]);
GO

-- Creating foreign key on [PriorityId] in table 'PlannedTbSet'
ALTER TABLE [dbo].[PlannedTbSet]
ADD CONSTRAINT [FK_PriorityPlanned]
    FOREIGN KEY ([PriorityId])
    REFERENCES [dbo].[PriorityTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PriorityPlanned'
CREATE INDEX [IX_FK_PriorityPlanned]
ON [dbo].[PlannedTbSet]
    ([PriorityId]);
GO

-- Creating foreign key on [PriorityId] in table 'TaskTbSet'
ALTER TABLE [dbo].[TaskTbSet]
ADD CONSTRAINT [FK_PriorityTask]
    FOREIGN KEY ([PriorityId])
    REFERENCES [dbo].[PriorityTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PriorityTask'
CREATE INDEX [IX_FK_PriorityTask]
ON [dbo].[TaskTbSet]
    ([PriorityId]);
GO

-- Creating foreign key on [GameId] in table 'PlannedTbSet'
ALTER TABLE [dbo].[PlannedTbSet]
ADD CONSTRAINT [FK_GamePlanned]
    FOREIGN KEY ([GameId])
    REFERENCES [dbo].[GameTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GamePlanned'
CREATE INDEX [IX_FK_GamePlanned]
ON [dbo].[PlannedTbSet]
    ([GameId]);
GO

-- Creating foreign key on [GameId] in table 'TaskTbSet'
ALTER TABLE [dbo].[TaskTbSet]
ADD CONSTRAINT [FK_GameTask]
    FOREIGN KEY ([GameId])
    REFERENCES [dbo].[GameTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameTask'
CREATE INDEX [IX_FK_GameTask]
ON [dbo].[TaskTbSet]
    ([GameId]);
GO

-- Creating foreign key on [UserId] in table 'PlannedTbSet'
ALTER TABLE [dbo].[PlannedTbSet]
ADD CONSTRAINT [FK_UserPlanned]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserTbSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPlanned'
CREATE INDEX [IX_FK_UserPlanned]
ON [dbo].[PlannedTbSet]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
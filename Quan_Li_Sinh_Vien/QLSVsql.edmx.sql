
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2022 07:39:29
-- Generated from EDMX file: D:\New folder\Lập trình W\Quan_Li_Sinh_Vien\Quan_Li_Sinh_Vien\Quan_Li_Sinh_Vien\QLSVsql.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QLSV];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__MyContact__group__30F848ED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MyContact] DROP CONSTRAINT [FK__MyContact__group__30F848ED];
GO
IF OBJECT_ID(N'[dbo].[FK__MyContact__uid__300424B4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MyContact] DROP CONSTRAINT [FK__MyContact__uid__300424B4];
GO
IF OBJECT_ID(N'[dbo].[FK__score__c_id__2E1BDC42]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[score] DROP CONSTRAINT [FK__score__c_id__2E1BDC42];
GO
IF OBJECT_ID(N'[dbo].[FK__score__sv_id__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[score] DROP CONSTRAINT [FK__score__sv_id__2F10007B];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[login]', 'U') IS NOT NULL
    DROP TABLE [dbo].[login];
GO
IF OBJECT_ID(N'[dbo].[MyContact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MyContact];
GO
IF OBJECT_ID(N'[dbo].[MyGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MyGroup];
GO
IF OBJECT_ID(N'[dbo].[score]', 'U') IS NOT NULL
    DROP TABLE [dbo].[score];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [id] int  NOT NULL,
    [label] nvarchar(10)  NULL,
    [period] int  NULL,
    [semester] int  NULL
);
GO

-- Creating table 'logins'
CREATE TABLE [dbo].[logins] (
    [id] int  IDENTITY(1,1) NOT NULL,
    [username] nchar(10)  NULL,
    [password] nchar(10)  NULL
);
GO

-- Creating table 'MyContacts'
CREATE TABLE [dbo].[MyContacts] (
    [id] int IDENTITY(1,1) NOT NULL,
    [fname] nchar(50)  NULL,
    [lname] nchar(20)  NULL,
    [group_id] int  NULL,
    [phone] int  NULL,
    [email] nchar(50)  NULL,
    [address] varchar(max)  NULL,
    [pic] varbinary(max)  NULL,
    [uid] int  NULL
);
GO

-- Creating table 'MyGroups'
CREATE TABLE [dbo].[MyGroups] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(10)  NULL,
    [group_id] int  NULL
);
GO

-- Creating table 'scores'
CREATE TABLE [dbo].[scores] (
    [sv_id] int  NOT NULL,
    [c_id] int  NOT NULL,
    [gk] float  NULL,
    [ck] float  NULL,
    [des] nchar(10)  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [id] int  NOT NULL,
    [fname] nchar(10)  NULL,
    [lname] nvarchar(50)  NULL,
    [bdate] datetime  NULL,
    [gender] nchar(10)  NULL,
    [phone] nchar(10)  NULL,
    [address] nchar(10)  NULL,
    [picture] varbinary(max)  NULL,
    [group_id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'logins'
ALTER TABLE [dbo].[logins]
ADD CONSTRAINT [PK_logins]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'MyContacts'
ALTER TABLE [dbo].[MyContacts]
ADD CONSTRAINT [PK_MyContacts]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'MyGroups'
ALTER TABLE [dbo].[MyGroups]
ADD CONSTRAINT [PK_MyGroups]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [sv_id], [c_id] in table 'scores'
ALTER TABLE [dbo].[scores]
ADD CONSTRAINT [PK_scores]
    PRIMARY KEY CLUSTERED ([sv_id], [c_id] ASC);
GO

-- Creating primary key on [id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [c_id] in table 'scores'
ALTER TABLE [dbo].[scores]
ADD CONSTRAINT [FK__score__c_id__2E1BDC42]
    FOREIGN KEY ([c_id])
    REFERENCES [dbo].[Courses]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__score__c_id__2E1BDC42'
CREATE INDEX [IX_FK__score__c_id__2E1BDC42]
ON [dbo].[scores]
    ([c_id]);
GO

-- Creating foreign key on [uid] in table 'MyContacts'
ALTER TABLE [dbo].[MyContacts]
ADD CONSTRAINT [FK__MyContact__uid__300424B4]
    FOREIGN KEY ([uid])
    REFERENCES [dbo].[logins]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MyContact__uid__300424B4'
CREATE INDEX [IX_FK__MyContact__uid__300424B4]
ON [dbo].[MyContacts]
    ([uid]);
GO

-- Creating foreign key on [group_id] in table 'MyContacts'
ALTER TABLE [dbo].[MyContacts]
ADD CONSTRAINT [FK__MyContact__group__30F848ED]
    FOREIGN KEY ([group_id])
    REFERENCES [dbo].[MyGroups]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__MyContact__group__30F848ED'
CREATE INDEX [IX_FK__MyContact__group__30F848ED]
ON [dbo].[MyContacts]
    ([group_id]);
GO

-- Creating foreign key on [sv_id] in table 'scores'
ALTER TABLE [dbo].[scores]
ADD CONSTRAINT [FK__score__sv_id__2F10007B]
    FOREIGN KEY ([sv_id])
    REFERENCES [dbo].[Students]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
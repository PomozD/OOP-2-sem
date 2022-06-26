
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2022 21:38:20
-- Generated from EDMX file: D:\Лабы\ООП второй сем\labi\OOP-2\Lab09\Lab09\Model2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Met_MyBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ПОКУПКИ_ТОВАР]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ПОКУПКИ] DROP CONSTRAINT [FK_ПОКУПКИ_ТОВАР];
GO
IF OBJECT_ID(N'[dbo].[FK_ПОКУПКИ_ФИРМА]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ПОКУПКИ] DROP CONSTRAINT [FK_ПОКУПКИ_ФИРМА];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ПОКУПКИ]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ПОКУПКИ];
GO
IF OBJECT_ID(N'[dbo].[ТОВАР]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ТОВАР];
GO
IF OBJECT_ID(N'[dbo].[ФИРМА]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ФИРМА];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ПОКУПКИ'
CREATE TABLE [dbo].[ПОКУПКИ] (
    [Номер] int  NOT NULL,
    [Название_товара] nvarchar(10)  NULL,
    [Количество_купленных_товаров] int  NULL,
    [Дата_покупки] datetime  NULL,
    [Покупатель] nvarchar(20)  NULL
);
GO

-- Creating table 'ТОВАР'
CREATE TABLE [dbo].[ТОВАР] (
    [Название] nvarchar(10)  NOT NULL,
    [Описание] nvarchar(50)  NULL,
    [Цена] real  NULL
);
GO

-- Creating table 'ФИРМА'
CREATE TABLE [dbo].[ФИРМА] (
    [Название_отдела] nvarchar(20)  NOT NULL,
    [Количество_сотрудников] int  NULL,
    [Предельная_норма_расхода] real  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Номер] in table 'ПОКУПКИ'
ALTER TABLE [dbo].[ПОКУПКИ]
ADD CONSTRAINT [PK_ПОКУПКИ]
    PRIMARY KEY CLUSTERED ([Номер] ASC);
GO

-- Creating primary key on [Название] in table 'ТОВАР'
ALTER TABLE [dbo].[ТОВАР]
ADD CONSTRAINT [PK_ТОВАР]
    PRIMARY KEY CLUSTERED ([Название] ASC);
GO

-- Creating primary key on [Название_отдела] in table 'ФИРМА'
ALTER TABLE [dbo].[ФИРМА]
ADD CONSTRAINT [PK_ФИРМА]
    PRIMARY KEY CLUSTERED ([Название_отдела] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Название_товара] in table 'ПОКУПКИ'
ALTER TABLE [dbo].[ПОКУПКИ]
ADD CONSTRAINT [FK_ПОКУПКИ_ТОВАР]
    FOREIGN KEY ([Название_товара])
    REFERENCES [dbo].[ТОВАР]
        ([Название])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ПОКУПКИ_ТОВАР'
CREATE INDEX [IX_FK_ПОКУПКИ_ТОВАР]
ON [dbo].[ПОКУПКИ]
    ([Название_товара]);
GO

-- Creating foreign key on [Покупатель] in table 'ПОКУПКИ'
ALTER TABLE [dbo].[ПОКУПКИ]
ADD CONSTRAINT [FK_ПОКУПКИ_ФИРМА]
    FOREIGN KEY ([Покупатель])
    REFERENCES [dbo].[ФИРМА]
        ([Название_отдела])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ПОКУПКИ_ФИРМА'
CREATE INDEX [IX_FK_ПОКУПКИ_ФИРМА]
ON [dbo].[ПОКУПКИ]
    ([Покупатель]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
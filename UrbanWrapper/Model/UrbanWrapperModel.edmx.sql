
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/14/2021 09:58:44
-- Generated from EDMX file: C:\Users\Ben\Desktop\UrbanWrapper\UrbanWrapper\Model\UrbanWrapperModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UrbanWrapper];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerFeedback_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerFeedback] DROP CONSTRAINT [FK_CustomerFeedback_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerOrder_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerOrder] DROP CONSTRAINT [FK_CustomerOrder_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Invoice_CustomerOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoice] DROP CONSTRAINT [FK_Invoice_CustomerOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[CustomerFeedback]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerFeedback];
GO
IF OBJECT_ID(N'[dbo].[CustomerOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerOrder];
GO
IF OBJECT_ID(N'[dbo].[Invoice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoice];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(50)  NULL,
    [LastName] varchar(50)  NULL,
    [Phone] varchar(50)  NULL,
    [Address] varchar(50)  NULL,
    [Email] varchar(50)  NULL
);
GO

-- Creating table 'CustomerFeedbacks'
CREATE TABLE [dbo].[CustomerFeedbacks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NULL,
    [Feedback] varchar(max)  NULL,
    [FDate] datetime  NULL,
    [CustomerName] varchar(50)  NULL,
    [InvoiceId] int  NULL,
    [Rating] int  NULL
);
GO

-- Creating table 'CustomerOrders'
CREATE TABLE [dbo].[CustomerOrders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NULL,
    [OrderTotal] decimal(18,0)  NULL,
    [NumberOfProducts] int  NULL,
    [OrderDate] datetime  NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderId] int  NULL,
    [InvoiceAmount] decimal(18,0)  NULL,
    [InvoiceDate] datetime  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductName] varchar(50)  NULL,
    [Price] decimal(18,0)  NULL,
    [StockQuantity] int  NULL,
    [Description] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerFeedbacks'
ALTER TABLE [dbo].[CustomerFeedbacks]
ADD CONSTRAINT [PK_CustomerFeedbacks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerOrders'
ALTER TABLE [dbo].[CustomerOrders]
ADD CONSTRAINT [PK_CustomerOrders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'CustomerFeedbacks'
ALTER TABLE [dbo].[CustomerFeedbacks]
ADD CONSTRAINT [FK_CustomerFeedback_Customer]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerFeedback_Customer'
CREATE INDEX [IX_FK_CustomerFeedback_Customer]
ON [dbo].[CustomerFeedbacks]
    ([CustomerId]);
GO

-- Creating foreign key on [CustomerId] in table 'CustomerOrders'
ALTER TABLE [dbo].[CustomerOrders]
ADD CONSTRAINT [FK_CustomerOrder_Customer]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder_Customer'
CREATE INDEX [IX_FK_CustomerOrder_Customer]
ON [dbo].[CustomerOrders]
    ([CustomerId]);
GO

-- Creating foreign key on [OrderId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_Invoice_CustomerOrder]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[CustomerOrders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Invoice_CustomerOrder'
CREATE INDEX [IX_FK_Invoice_CustomerOrder]
ON [dbo].[Invoices]
    ([OrderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [UnitPrice]   MONEY        NULL,
    [StockAmount] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


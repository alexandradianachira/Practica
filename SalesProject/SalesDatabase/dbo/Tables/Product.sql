CREATE TABLE [dbo].[Product] (
    [Id]       INT            NOT NULL,
    [Name]     NVARCHAR (100) NOT NULL,
    [Quantity] INT            NOT NULL,
    [Price]    FLOAT (53)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


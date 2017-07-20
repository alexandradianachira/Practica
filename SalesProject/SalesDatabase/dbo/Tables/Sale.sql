CREATE TABLE [dbo].[Sale] (
    [Id]              INT  NOT NULL,
    [ProductId]       INT  NOT NULL,
    [CustomerId]      INT  NOT NULL,
    [StoreLocationId] INT  NOT NULL,
    [Date]            DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sale_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Sale_ToProduct] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]),
    CONSTRAINT [FK_Sale_ToStoreLocation] FOREIGN KEY ([StoreLocationId]) REFERENCES [dbo].[StoreLocation] ([Id])
);


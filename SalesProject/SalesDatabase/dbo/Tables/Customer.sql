CREATE TABLE [dbo].[Customer] (
    [Id]               INT            NOT NULL,
    [Name]             NVARCHAR (100) NOT NULL,
    [Email]            NVARCHAR (100) NOT NULL,
    [CreditCardNumber] NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


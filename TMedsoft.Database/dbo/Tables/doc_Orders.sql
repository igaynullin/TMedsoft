CREATE TABLE [dbo].[doc_Orders] (
    [ID]          BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (200)  NULL,
    [Quantity]    BIGINT          NOT NULL,
    [Cost]        DECIMAL (18, 2) NOT NULL,
    [DiscountSum] DECIMAL (18, 2) CONSTRAINT [DF_doc_Orders_DiscountSum] DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);




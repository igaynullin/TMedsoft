CREATE TABLE [dbo].[doc_OrderBooks] (
    [OrderID]     BIGINT          NOT NULL,
    [BookID]      BIGINT          NOT NULL,
    [Cost]        DECIMAL (18, 2) NOT NULL,
    [Quantity]    BIGINT          NOT NULL,
    [DiscountSum] DECIMAL (18, 2) CONSTRAINT [DF_doc_OrderBooks_DiscountSum] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [FK_doc_OrderBooks_doc_Orders] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[doc_Orders] ([ID]),
    CONSTRAINT [FK_doc_OrderBooks_ref_Books] FOREIGN KEY ([BookID]) REFERENCES [dbo].[ref_Books] ([ID])
);






CREATE TABLE [dbo].[ref_DiscountBooks] (
    [DiscountID] BIGINT NOT NULL,
    [BookID]     BIGINT NOT NULL,
    CONSTRAINT [FK_ref_DiscountBooks_ref_Books] FOREIGN KEY ([BookID]) REFERENCES [dbo].[ref_Books] ([ID]),
    CONSTRAINT [FK_ref_DiscountBooks_ref_Discounts] FOREIGN KEY ([DiscountID]) REFERENCES [dbo].[ref_Discounts] ([ID])
);




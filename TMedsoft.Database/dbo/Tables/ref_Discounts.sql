CREATE TABLE [dbo].[ref_Discounts] (
    [ID]           BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (200)  NULL,
    [Percentage]   DECIMAL (18, 2) NOT NULL,
    [CouponCode]   NVARCHAR (100)  NULL,
    [BookRequired] INT             NOT NULL,
    [DiscountType] INT             NULL,
    CONSTRAINT [PK__ref_Disc__3214EC272D14A20E] PRIMARY KEY CLUSTERED ([ID] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ref_Discounts]
    ON [dbo].[ref_Discounts]([CouponCode] ASC);


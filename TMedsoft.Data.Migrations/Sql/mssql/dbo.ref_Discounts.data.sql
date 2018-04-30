SET IDENTITY_INSERT [dbo].[ref_Discounts] ON
INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode], [BookRequired], [DiscountType]) VALUES (1, N'10% скидки на жанр1', CAST(10.00 AS Decimal(18, 2)), N'G43L6E', 2, 0)
INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode], [BookRequired], [DiscountType]) VALUES (2, N'1% на книгу1', CAST(1.00 AS Decimal(18, 2)), N'B3741N', 0, 1)
INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode], [BookRequired], [DiscountType]) VALUES (3, N'5% скидки на жанр2', CAST(5.00 AS Decimal(18, 2)), N'GYEDA1', 4, 0)
INSERT INTO [dbo].[ref_Discounts] ([ID], [Name], [Percentage], [CouponCode], [BookRequired], [DiscountType]) VALUES (4, N'5% на книгу1', CAST(5.00 AS Decimal(18, 2)), N'B6Q7B1', 0, 1)
SET IDENTITY_INSERT [dbo].[ref_Discounts] OFF

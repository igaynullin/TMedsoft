IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'ref_DiscountRules'))

				 Begin 
				 IF (NOT EXISTS (SELECT count(b.ID) 
                 FROM ref_DiscountRules b ))
				 begin 
SET IDENTITY_INSERT [dbo].[ref_DiscountRules] ON
INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (1, N'Jeanine25', 6, 3)
INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (2, N'Valerie', 7, 1)
INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (3, N'Roy5', 10, 1)
INSERT INTO [dbo].[ref_DiscountRules] ([ID], [Name], [BookRequired], [DiscountID]) VALUES (4, N'Ron506', 8, 3)
SET IDENTITY_INSERT [dbo].[ref_DiscountRules] OFF
		 end
				 END
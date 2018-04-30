CREATE TABLE [dbo].[ref_DiscountGenres] (
	[DiscountID] BIGINT NOT NULL,
	[GenreID]    BIGINT NOT NULL,
	CONSTRAINT [FK_ref_DiscountGenres_ref_Genres] FOREIGN KEY ([GenreID]) REFERENCES [dbo].[ref_Genres] ([ID]),
	CONSTRAINT [FK_ref_DiscountGenres_ref_Discounts] FOREIGN KEY ([DiscountID]) REFERENCES [dbo].[ref_Discounts] ([ID])
);


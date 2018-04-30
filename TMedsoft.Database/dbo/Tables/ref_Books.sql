CREATE TABLE [dbo].[ref_Books] (
    [ID]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (200)  NULL,
    [GenreID]  BIGINT          NOT NULL,
    [Quantity] BIGINT          DEFAULT ((0)) NOT NULL,
    [Cost]     DECIMAL (18, 2) DEFAULT ((0.0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ref_Books_ref_Genres] FOREIGN KEY ([GenreID]) REFERENCES [dbo].[ref_Genres] ([ID])
);




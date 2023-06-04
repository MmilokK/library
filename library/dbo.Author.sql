CREATE TABLE [dbo].[Author] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      VARCHAR (50)     NULL,
    [Surname]   VARCHAR (50)     NULL,
    [BirthYear] INT              NULL,
    [BookId] UNIQUEIDENTIFIER NULL, 
	CONSTRAINT [FK_Author_Books] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


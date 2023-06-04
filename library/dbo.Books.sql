CREATE TABLE [dbo].[Books] (
    [Id]              UNIQUEIDENTIFIER              NOT NULL,
    [BookName]        VARCHAR (50)     NULL,
    [PublicationsId]  UNIQUEIDENTIFIER NULL,
    [NumberInstances] INT              NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    
    CONSTRAINT [FK_Books_Publications] FOREIGN KEY ([PublicationsId]) REFERENCES [dbo].[Publications] ([Id])
);


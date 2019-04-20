CREATE TABLE [dbo].[Human] (
    [Id]              INT            NOT NULL,
    [Sex]             NVARCHAR (MAX) NULL,
    [Profession]      NVARCHAR (MAX) NULL,
    [SubProperty]     NVARCHAR (MAX) NULL,
    [RelationsWithId] INT            NULL,
    CONSTRAINT [PK_Human] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Human_Human1] FOREIGN KEY ([RelationsWithId]) REFERENCES [dbo].[Human] ([Id])
);


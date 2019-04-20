CREATE TABLE [dbo].[Message] (
    [Id]    INT            NOT NULL,
    [ActId] INT            NULL,
    [Text]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Message_Act] FOREIGN KEY ([ActId]) REFERENCES [dbo].[Act] ([Id])
);


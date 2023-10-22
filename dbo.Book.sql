CREATE TABLE [dbo].[Book] (
    [ID]     INT             IDENTITY (1, 1) NOT NULL,
    [Title]  NVARCHAR (MAX)  NOT NULL,
    [Author] NVARCHAR (MAX)  NOT NULL,
    [Price]  DECIMAL (18, 2) NOT NULL,
    [PublishingDate] DATETIME NOT NULL, 
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([ID] ASC)
);


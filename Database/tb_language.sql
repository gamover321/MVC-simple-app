CREATE TABLE [dbo].[tb_language]
(
	[id] INT IDENTITY (1, 1) NOT NULL,
	[name] NVARCHAR(150) NOT NULL

	CONSTRAINT [PK_tb_language] 
		PRIMARY KEY ([id])
)

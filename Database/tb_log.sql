CREATE TABLE [dbo].[tb_log]
(
	[id] INT IDENTITY (1, 1) NOT NULL,
	[date]      DATETIME       NOT NULL,
	[result]    NVARCHAR (MAX) NULL,

	CONSTRAINT [PK_tb_log] 
		PRIMARY KEY CLUSTERED ([id] ASC),
)

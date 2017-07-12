CREATE TABLE [dbo].[tb_user]
(
	[id] INT IDENTITY (1, 1) NOT NULL,
	[name] NVARCHAR(150) NOT NULL,
	[creation_date] DATETIME NOT NULL,
	[language_id] INT NOT NULL,

	CONSTRAINT PK_tb_user
	PRIMARY KEY ([id]), 

	CONSTRAINT FK_tb_user_tb_language
	FOREIGN KEY ([language_id])
	REFERENCES [dbo].[tb_language] ([id])
)

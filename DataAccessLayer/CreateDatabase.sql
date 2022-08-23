CREATE TABLE [dbo].[ErrorLog]
(
	[ErrorLogID] [uniqueidentifier] primary key NOT NULL,
	[ApplicationName] [varchar](255) NOT NULL,
	[Message] [text] NULL,
	[StackTrace] [text] NULL,
	[Source] [varchar](255) NULL,
	[ErrorLogUrl] [text] NULL,
	[ErrorLogTime] [datetime] NOT NULL
)

CREATE TABLE MessageLog
(
	MessageLogID [uniqueidentifier] primary key NOT NULL,
	[ApplicationName] [varchar](255) NOT NULL,
	[Message] [text] NOT NULL,
	[MessageTime] [datetime] NOT NULL
)
CREATE DATABASE BankDb;

USE [BankDb ]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/20/2020 12:18:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[IBAN] [nvarchar](30) NOT NULL,
	[AccountTypeCode] [nvarchar](1) NULL,
	[Firstname] [nvarchar](50) NULL,
	[Lastname] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Balance] [money] NOT NULL,
	[TransactionDate] [datetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[IBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccountType]    Script Date: 11/20/2020 12:18:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountType](
	[AccountTypeCode] [nvarchar](1) NOT NULL,
	[AccountTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AccountType] PRIMARY KEY CLUSTERED 
(
	[AccountTypeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TransactionAccount]    Script Date: 11/20/2020 12:18:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionAccount](
	[TransactionId] [bigint] IDENTITY(1,1) NOT NULL,
	[FromIBAN] [nvarchar](30) NOT NULL,
	[ToIBAN] [nvarchar](30) NULL,
	[Amount] [money] NOT NULL,
	[TransactionTypeCode] [nvarchar](1) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TransactionAccount] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TransactionType]    Script Date: 11/20/2020 12:18:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionType](
	[TransactionTypeCode] [nvarchar](1) NOT NULL,
	[TransactionTypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransactionType] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([IBAN], [AccountTypeCode], [Firstname], [Lastname], [Address], [Mobile], [Balance], [TransactionDate]) VALUES (N'NL41INGB8399675482', N'1', N'dd', N'ss', N'11', N'11', 5995.0000, CAST(N'2020-11-19 22:31:12.040' AS DateTime))
INSERT [dbo].[Account] ([IBAN], [AccountTypeCode], [Firstname], [Lastname], [Address], [Mobile], [Balance], [TransactionDate]) VALUES (N'NL68INGB5831335380', N'1', N'ss', N'dd', N'dd', N'002-1122', 6992.0000, CAST(N'2020-11-20 00:07:15.370' AS DateTime))
INSERT [dbo].[Account] ([IBAN], [AccountTypeCode], [Firstname], [Lastname], [Address], [Mobile], [Balance], [TransactionDate]) VALUES (N'NL76ABNA9955442484', N'1', N'Sosak', N'Tisak', N'11', N'02-11', 5997.0000, CAST(N'2020-11-20 00:03:43.147' AS DateTime))
INSERT [dbo].[AccountType] ([AccountTypeCode], [AccountTypeName]) VALUES (N'1', N'Saving Deposit')
INSERT [dbo].[AccountType] ([AccountTypeCode], [AccountTypeName]) VALUES (N'2', N'Current Deposit ')
INSERT [dbo].[AccountType] ([AccountTypeCode], [AccountTypeName]) VALUES (N'3', N'Fixed Deposit')
SET IDENTITY_INSERT [dbo].[TransactionAccount] ON 

INSERT [dbo].[TransactionAccount] ([TransactionId], [FromIBAN], [ToIBAN], [Amount], [TransactionTypeCode], [TransactionDate]) VALUES (6, N'NL41INGB8399675482', N'NL41INGB8399675482', 4995.0000, N'1', CAST(N'2020-11-20 00:13:10.170' AS DateTime))
INSERT [dbo].[TransactionAccount] ([TransactionId], [FromIBAN], [ToIBAN], [Amount], [TransactionTypeCode], [TransactionDate]) VALUES (7, N'NL68INGB5831335380', N'NL68INGB5831335380', 7992.0000, N'1', CAST(N'2020-11-20 00:13:21.660' AS DateTime))
INSERT [dbo].[TransactionAccount] ([TransactionId], [FromIBAN], [ToIBAN], [Amount], [TransactionTypeCode], [TransactionDate]) VALUES (8, N'NL68INGB5831335380', N'NL76ABNA9955442484', 1000.0000, N'3', CAST(N'2020-11-20 00:13:36.503' AS DateTime))
INSERT [dbo].[TransactionAccount] ([TransactionId], [FromIBAN], [ToIBAN], [Amount], [TransactionTypeCode], [TransactionDate]) VALUES (9, N'NL68INGB5831335380', N'NL76ABNA9955442484', 1000.0000, N'3', CAST(N'2020-11-20 00:13:44.830' AS DateTime))
INSERT [dbo].[TransactionAccount] ([TransactionId], [FromIBAN], [ToIBAN], [Amount], [TransactionTypeCode], [TransactionDate]) VALUES (10, N'NL68INGB5831335380', N'NL76ABNA9955442484', 1000.0000, N'3', CAST(N'2020-11-20 00:13:53.837' AS DateTime))
SET IDENTITY_INSERT [dbo].[TransactionAccount] OFF
INSERT [dbo].[TransactionType] ([TransactionTypeCode], [TransactionTypeName]) VALUES (N'1', N'Deposit')
INSERT [dbo].[TransactionType] ([TransactionTypeCode], [TransactionTypeName]) VALUES (N'2', N'Withdraw')
INSERT [dbo].[TransactionType] ([TransactionTypeCode], [TransactionTypeName]) VALUES (N'3', N'Transfer')
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_AccountType] FOREIGN KEY([AccountTypeCode])
REFERENCES [dbo].[AccountType] ([AccountTypeCode])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_AccountType]
GO
ALTER TABLE [dbo].[TransactionAccount]  WITH CHECK ADD  CONSTRAINT [FK_TransactionAccount_Account] FOREIGN KEY([FromIBAN])
REFERENCES [dbo].[Account] ([IBAN])
GO
ALTER TABLE [dbo].[TransactionAccount] CHECK CONSTRAINT [FK_TransactionAccount_Account]
GO
ALTER TABLE [dbo].[TransactionAccount]  WITH CHECK ADD  CONSTRAINT [FK_TransactionAccount_Account1] FOREIGN KEY([ToIBAN])
REFERENCES [dbo].[Account] ([IBAN])
GO
ALTER TABLE [dbo].[TransactionAccount] CHECK CONSTRAINT [FK_TransactionAccount_Account1]
GO
ALTER TABLE [dbo].[TransactionAccount]  WITH CHECK ADD  CONSTRAINT [FK_TransactionAccount_TransactionType] FOREIGN KEY([TransactionTypeCode])
REFERENCES [dbo].[TransactionType] ([TransactionTypeCode])
GO
ALTER TABLE [dbo].[TransactionAccount] CHECK CONSTRAINT [FK_TransactionAccount_TransactionType]
GO

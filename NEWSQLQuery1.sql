SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
[ID] [int] IDENTITY(1,1) NOT NULL,
[Userpassword] [int] FOREIGN KEY REFERENCES [dbo].[Users](Userpassword) NOT NULL,
[TestDate] [date],
[Mark] [int] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[AnswerValue] [int] NOT NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 15/06/2020 22:37:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionText] [nvarchar](50) NULL,
	[QuestionAnswer] [int] NULL,
	[Percent] [int] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (1, 12, 10)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (2, 12, 20)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (3, 12, 30)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (4, 12, 40)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (5, 13, 20)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (6, 13, 30)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (7, 13, 40)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (8, 13, 50)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (9, 14, 30)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (10, 14, 40)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (11, 14, 50)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (12, 14, 60)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (13, 15, 40)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (14, 15, 50)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (15, 15, 60)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (16, 15, 70)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (17, 16, 50)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (18, 16, 60)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (19, 16, 70)
INSERT [dbo].[Answers] ([ID], [QuestionID], [AnswerValue]) VALUES (20, 16, 80)
SET IDENTITY_INSERT [dbo].[Answers] OFF
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (1, N'1+1', 2, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (2, N'10*0', 0, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (3, N'5+5', 10, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (4, N'7+7', 14, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (5, N'8+2', 10, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (6, N'0+0', 0, 6)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (7, N'20+20', 40, 10)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (8, N'7-8', -1, 10)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (9, N'10*10', 100, 10)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (10, N'7*7', 49, 10)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (11, N'8+90', 89, 10)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (12, N'10+10', 2, 5)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (13, N'10+20', 6, 5)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (14, N'10+30', 10, 5)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (15, N'10+40', 14, 5)
INSERT [dbo].[Questions] ([ID], [QuestionText], [QuestionAnswer], [Percent]) VALUES (16, N'10+50', 18, 5)
SET IDENTITY_INSERT [dbo].[Questions] OFF
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Questions] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([ID])
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Answers_Questions]
GO
CREATE TABLE [dbo].[Users](
FullName varchar(20),
UserName varchar(20),
Userpassword  int primary key
);

INSERT INTO [dbo].[Users] (FullName,UserName,Userpassword)VALUES('yael','abcd',123)
INSERT INTO [dbo].[Users] (FullName,UserName,Userpassword)VALUES('dana','efg',452)
INSERT INTO [dbo].[Users] (FullName,UserName,Userpassword)VALUES('shara','hjkl',689)
INSERT INTO [dbo].[Users] (FullName,UserName,Userpassword)VALUES('esther','trgh',785)
INSERT INTO [dbo].[Users] (FullName,UserName,Userpassword)VALUES('lae','kjh',256)




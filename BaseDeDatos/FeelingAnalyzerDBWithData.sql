USE [FeelingAnalyzerDB]
GO
ALTER TABLE [dbo].[Phrases] DROP CONSTRAINT [FK_dbo.Phrases_dbo.Authors_Author_AuthorId]
GO
ALTER TABLE [dbo].[GeneralAlarm] DROP CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Entities_Entity_EntityId]
GO
ALTER TABLE [dbo].[GeneralAlarm] DROP CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[AuthorEntities] DROP CONSTRAINT [FK_dbo.AuthorEntities_dbo.Entities_Entity_EntityId]
GO
ALTER TABLE [dbo].[AuthorEntities] DROP CONSTRAINT [FK_dbo.AuthorEntities_dbo.Authors_Author_AuthorId]
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors] DROP CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.Authors_Author_AuthorId]
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors] DROP CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.AuthorAlarm_AuthorAlarm_AlarmId]
GO
ALTER TABLE [dbo].[AuthorAlarm] DROP CONSTRAINT [FK_dbo.AuthorAlarm_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[Analyses] DROP CONSTRAINT [FK_dbo.Analyses_dbo.Phrases_Phrase_PhraseId]
GO
ALTER TABLE [dbo].[Analyses] DROP CONSTRAINT [FK_dbo.Analyses_dbo.Entities_Entity_EntityId]
GO
/****** Object:  Table [dbo].[Phrases]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phrases]') AND type in (N'U'))
DROP TABLE [dbo].[Phrases]
GO
/****** Object:  Table [dbo].[GeneralAlarm]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralAlarm]') AND type in (N'U'))
DROP TABLE [dbo].[GeneralAlarm]
GO
/****** Object:  Table [dbo].[Feelings]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Feelings]') AND type in (N'U'))
DROP TABLE [dbo].[Feelings]
GO
/****** Object:  Table [dbo].[Entities]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entities]') AND type in (N'U'))
DROP TABLE [dbo].[Entities]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Authors]') AND type in (N'U'))
DROP TABLE [dbo].[Authors]
GO
/****** Object:  Table [dbo].[AuthorEntities]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorEntities]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorEntities]
GO
/****** Object:  Table [dbo].[AuthorAlarmAuthors]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorAlarmAuthors]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorAlarmAuthors]
GO
/****** Object:  Table [dbo].[AuthorAlarm]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorAlarm]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorAlarm]
GO
/****** Object:  Table [dbo].[Analyses]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Analyses]') AND type in (N'U'))
DROP TABLE [dbo].[Analyses]
GO
/****** Object:  Table [dbo].[Alarms]    Script Date: 24/6/2020 18:20:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alarms]') AND type in (N'U'))
DROP TABLE [dbo].[Alarms]
GO
/****** Object:  Table [dbo].[Alarms]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alarms](
	[AlarmId] [int] IDENTITY(1,1) NOT NULL,
	[PostNumber] [int] NOT NULL,
	[Type] [bit] NOT NULL,
	[TimeBack] [int] NOT NULL,
	[State] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Alarms] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Analyses]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analyses](
	[AnalysisId] [int] IDENTITY(1,1) NOT NULL,
	[PhraseType] [int] NOT NULL,
	[Entity_EntityId] [int] NULL,
	[Phrase_PhraseId] [int] NULL,
 CONSTRAINT [PK_dbo.Analyses] PRIMARY KEY CLUSTERED 
(
	[AnalysisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorAlarm]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorAlarm](
	[AlarmId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AuthorAlarm] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorAlarmAuthors]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorAlarmAuthors](
	[AuthorAlarm_AlarmId] [int] NOT NULL,
	[Author_AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AuthorAlarmAuthors] PRIMARY KEY CLUSTERED 
(
	[AuthorAlarm_AlarmId] ASC,
	[Author_AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorEntities]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorEntities](
	[Author_AuthorId] [int] NOT NULL,
	[Entity_EntityId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AuthorEntities] PRIMARY KEY CLUSTERED 
(
	[Author_AuthorId] ASC,
	[Entity_EntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](10) NULL,
	[Name] [nvarchar](15) NULL,
	[Surname] [nvarchar](15) NULL,
	[BirthDate] [datetime] NOT NULL,
	[TotalPosts] [int] NOT NULL,
	[PositivePosts] [int] NOT NULL,
	[NegativePosts] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entities]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entities](
	[EntityId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Entities] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feelings]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feelings](
	[FeelingId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Feelings] PRIMARY KEY CLUSTERED 
(
	[FeelingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralAlarm]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralAlarm](
	[AlarmId] [int] NOT NULL,
	[Entity_EntityId] [int] NOT NULL,
	[Counter] [int] NOT NULL,
 CONSTRAINT [PK_dbo.GeneralAlarm] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phrases]    Script Date: 24/6/2020 18:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phrases](
	[PhraseId] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[Date] [datetime] NOT NULL,
	[Author_AuthorId] [int] NULL,
 CONSTRAINT [PK_dbo.Phrases] PRIMARY KEY CLUSTERED 
(
	[PhraseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alarms] ON 
GO
INSERT [dbo].[Alarms] ([AlarmId], [PostNumber], [Type], [TimeBack], [State]) VALUES (1, 20, 1, 480, 1)
GO
INSERT [dbo].[Alarms] ([AlarmId], [PostNumber], [Type], [TimeBack], [State]) VALUES (2, 10, 0, 24, 0)
GO
INSERT [dbo].[Alarms] ([AlarmId], [PostNumber], [Type], [TimeBack], [State]) VALUES (3, 30, 1, 240, 1)
GO
INSERT [dbo].[Alarms] ([AlarmId], [PostNumber], [Type], [TimeBack], [State]) VALUES (4, 20, 0, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[Alarms] OFF
GO
SET IDENTITY_INSERT [dbo].[Analyses] ON 
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (1, 2, NULL, 1)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (2, 0, 2, 2)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (3, 2, NULL, 3)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (4, 0, NULL, 4)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (5, 2, 3, 5)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (6, 2, NULL, 6)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (7, 2, NULL, 7)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (8, 2, NULL, 8)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (9, 2, NULL, 9)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (10, 2, NULL, 10)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (11, 2, NULL, 11)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (12, 2, NULL, 12)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (13, 2, NULL, 13)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (14, 2, NULL, 14)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (15, 2, NULL, 15)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (16, 0, NULL, 16)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (17, 2, NULL, 17)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (18, 2, NULL, 18)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (19, 2, NULL, 19)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (20, 0, NULL, 20)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (21, 2, NULL, 21)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (22, 2, NULL, 22)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (23, 2, NULL, 23)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (24, 2, NULL, 24)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (25, 0, NULL, 25)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (26, 2, NULL, 26)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (27, 2, NULL, 27)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (28, 2, NULL, 28)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (29, 2, 2, 29)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (30, 2, 1, 30)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (31, 0, 13, 31)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (32, 1, 5, 32)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (33, 0, NULL, 33)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (34, 2, 4, 34)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (35, 1, 14, 35)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (36, 2, 13, 36)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (37, 2, NULL, 37)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (38, 2, NULL, 38)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (39, 2, 8, 39)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (40, 2, NULL, 40)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (41, 0, NULL, 41)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (42, 2, NULL, 42)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (43, 2, 16, 43)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (44, 0, NULL, 44)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (45, 2, 13, 45)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (46, 2, 4, 46)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (47, 2, 1, 47)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (48, 2, NULL, 48)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (49, 2, NULL, 49)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (50, 2, NULL, 50)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (51, 0, NULL, 51)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (52, 2, NULL, 52)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (53, 2, NULL, 53)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (54, 2, NULL, 54)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (55, 2, NULL, 55)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (56, 0, NULL, 56)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (57, 2, NULL, 57)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (58, 2, NULL, 58)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (59, 2, NULL, 59)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (60, 1, NULL, 60)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (61, 2, NULL, 61)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (62, 2, NULL, 62)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (63, 2, 14, 63)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (64, 2, 8, 64)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (65, 0, 11, 65)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (66, 0, NULL, 66)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (67, 0, NULL, 67)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (68, 2, NULL, 68)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (69, 2, NULL, 69)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (70, 2, NULL, 70)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (71, 2, NULL, 71)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (72, 2, NULL, 72)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (73, 2, NULL, 73)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (74, 0, NULL, 74)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (75, 0, NULL, 75)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (76, 0, NULL, 76)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (77, 0, NULL, 77)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (78, 0, NULL, 78)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (79, 0, NULL, 79)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (80, 0, NULL, 80)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (81, 0, NULL, 81)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (82, 0, 8, 82)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (83, 2, 9, 83)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (84, 1, 12, 84)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (85, 2, 12, 85)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (86, 2, 12, 86)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (87, 1, 12, 87)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (88, 1, NULL, 88)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (89, 1, 8, 89)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (90, 2, 10, 90)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (91, 2, 16, 91)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (92, 0, 9, 92)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (93, 2, 5, 93)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (94, 2, 10, 94)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (95, 2, 8, 95)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (96, 2, 8, 96)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (97, 2, 16, 97)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (98, 2, 16, 98)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (99, 2, 13, 99)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (100, 2, 16, 100)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (101, 0, NULL, 101)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (102, 0, NULL, 102)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (103, 0, NULL, 103)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (104, 0, NULL, 104)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (105, 0, NULL, 105)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (106, 0, 5, 106)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (107, 2, NULL, 107)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (108, 0, NULL, 108)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (109, 0, 16, 109)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (110, 0, 16, 110)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (111, 2, 16, 111)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (112, 0, 16, 112)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (113, 0, NULL, 113)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (114, 0, 16, 114)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (115, 0, 16, 115)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (116, 0, 16, 116)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (117, 0, 16, 117)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (118, 0, 16, 118)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (119, 2, 16, 119)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (120, 0, 16, 120)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (121, 2, 16, 121)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (122, 0, 16, 122)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (123, 0, 16, 123)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (124, 2, 16, 124)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (125, 0, 16, 125)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (126, 0, 16, 126)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (127, 0, 16, 127)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (128, 0, 16, 128)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (129, 0, 16, 129)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (130, 0, 16, 130)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (131, 0, 16, 131)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (132, 0, 16, 132)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (133, 0, 16, 133)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (134, 0, NULL, 134)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (135, 0, NULL, 135)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (136, 0, NULL, 136)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (137, 0, NULL, 137)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (138, 0, NULL, 138)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (139, 0, NULL, 139)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (140, 0, 13, 140)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (141, 0, NULL, 141)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (142, 0, NULL, 142)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (143, 0, NULL, 143)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (144, 0, NULL, 144)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (145, 0, NULL, 145)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (146, 0, NULL, 146)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (147, 0, NULL, 147)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (148, 0, NULL, 148)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (149, 0, NULL, 149)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (150, 0, NULL, 150)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (151, 0, NULL, 151)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (152, 0, NULL, 152)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (153, 0, NULL, 153)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (154, 0, NULL, 154)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (155, 0, NULL, 155)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (156, 0, NULL, 156)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (157, 0, NULL, 157)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (158, 0, 16, 158)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (159, 0, NULL, 159)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (160, 0, NULL, 160)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (161, 0, NULL, 161)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (162, 0, NULL, 162)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (163, 0, NULL, 163)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (164, 2, NULL, 164)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (165, 2, NULL, 165)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (166, 2, NULL, 166)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (167, 2, NULL, 167)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (168, 2, NULL, 168)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (169, 2, 10, 169)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (170, 2, NULL, 170)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (171, 2, NULL, 171)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (172, 2, 13, 172)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (173, 0, 14, 173)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (174, 2, 7, 174)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (175, 2, 5, 175)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (176, 0, 15, 176)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (177, 0, 15, 177)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (178, 2, 1, 178)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (179, 2, 2, 179)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (180, 0, 3, 180)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (181, 1, 2, 181)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (182, 1, 12, 182)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (183, 2, 12, 183)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (184, 2, 16, 184)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (185, 2, 8, 185)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (186, 0, NULL, 186)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (187, 0, NULL, 187)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (188, 2, NULL, 188)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (189, 2, NULL, 189)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (190, 0, 9, 190)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (191, 2, 15, 191)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (192, 1, 13, 192)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (193, 1, NULL, 193)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (194, 2, NULL, 194)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (195, 2, 14, 195)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (196, 1, NULL, 196)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (197, 1, 15, 197)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (198, 1, NULL, 198)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (199, 0, NULL, 199)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (200, 2, NULL, 200)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (201, 2, NULL, 201)
GO
INSERT [dbo].[Analyses] ([AnalysisId], [PhraseType], [Entity_EntityId], [Phrase_PhraseId]) VALUES (202, 2, NULL, 202)
GO
SET IDENTITY_INSERT [dbo].[Analyses] OFF
GO
INSERT [dbo].[AuthorAlarm] ([AlarmId]) VALUES (3)
GO
INSERT [dbo].[AuthorAlarm] ([AlarmId]) VALUES (4)
GO
INSERT [dbo].[AuthorAlarmAuthors] ([AuthorAlarm_AlarmId], [Author_AuthorId]) VALUES (3, 17)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (11, 1)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (12, 1)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (13, 1)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (8, 2)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (12, 2)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 2)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (8, 3)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (12, 3)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (13, 4)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 4)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (4, 5)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (5, 5)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (8, 5)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 5)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (4, 7)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (3, 8)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (7, 8)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 8)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (18, 8)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (14, 9)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (15, 9)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 9)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (8, 10)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 10)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 11)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (5, 12)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (14, 12)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (18, 12)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (4, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (9, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (14, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (17, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (18, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (20, 13)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 14)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 14)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (20, 14)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (4, 15)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (7, 15)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (14, 15)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (2, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (4, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (5, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (7, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (10, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (12, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (13, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (14, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (15, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (16, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (17, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (18, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (19, 16)
GO
INSERT [dbo].[AuthorEntities] ([Author_AuthorId], [Entity_EntityId]) VALUES (21, 16)
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (2, N'santi123', N'Santiago', N'Perez', CAST(N'1999-06-24T16:01:16.000' AS DateTime), 9, 5, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (3, N'felimar', N'Felipe', N'Martinez', CAST(N'1990-06-24T16:01:36.000' AS DateTime), 5, 1, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (4, N'jDeus', N'Joaquin', N'Deus', CAST(N'2000-05-24T16:01:52.000' AS DateTime), 13, 6, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (5, N'mPerez12', N'Marcelo', N'Perez', CAST(N'1998-06-24T16:02:13.000' AS DateTime), 14, 5, 1, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (6, N'juan_marti', N'Juan', N'Martinez', CAST(N'2001-06-24T16:02:27.000' AS DateTime), 3, 0, 1, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (7, N'ferQuiCNDF', N'Fernando', N'Quinteros', CAST(N'1997-06-24T16:03:06.000' AS DateTime), 12, 4, 3, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (8, N'franqCAP', N'Franco', N'Ruiz', CAST(N'1992-06-24T16:03:36.000' AS DateTime), 10, 4, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (9, N'tinchoDeg', N'Martin', N'Degener', CAST(N'2002-06-24T16:03:49.000' AS DateTime), 1, 1, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (10, N'tatiGom', N'Graziano', N'Gomez', CAST(N'2000-06-24T16:04:03.000' AS DateTime), 7, 2, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (11, N'juanjoSan', N'Juan Jose', N'Sanson', CAST(N'1999-06-24T16:04:17.000' AS DateTime), 2, 1, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (12, N'matiPine', N'Matias', N'Piñeyrua', CAST(N'1996-06-24T16:04:34.000' AS DateTime), 19, 9, 1, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (13, N'totitoTrou', N'Alfonso', N'Ximenez', CAST(N'1999-06-12T16:04:56.000' AS DateTime), 8, 4, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (14, N'frafra12', N'Santiago', N'Franfe', CAST(N'1999-06-24T16:05:52.000' AS DateTime), 14, 1, 1, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (15, N'ricarditu', N'Alfredo', N'Ricardo', CAST(N'1985-06-24T16:06:04.000' AS DateTime), 6, 3, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (16, N'andrew', N'Andres', N'Perez', CAST(N'1999-06-24T16:06:22.000' AS DateTime), 13, 2, 2, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (17, N'saritaJimi', N'Sara', N'Jimenez', CAST(N'1990-06-24T16:06:33.000' AS DateTime), 31, 30, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (18, N'olgafag', N'Olga', N'Fagundez', CAST(N'1972-06-24T16:06:50.000' AS DateTime), 11, 3, 1, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (19, N'pipiBechh', N'Pia', N'Becchio', CAST(N'2001-01-24T16:07:15.000' AS DateTime), 15, 4, 4, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (20, N'santiRoba', N'Santiago', N'Robaina', CAST(N'1999-10-12T16:07:40.000' AS DateTime), 7, 3, 0, 0)
GO
INSERT [dbo].[Authors] ([AuthorId], [Username], [Name], [Surname], [BirthDate], [TotalPosts], [PositivePosts], [NegativePosts], [Deleted]) VALUES (21, N'pepeMenses', N'Pedro', N'Meneses', CAST(N'1987-01-04T16:07:55.000' AS DateTime), 2, 2, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Entities] ON 
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (1, N'Coca', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (2, N'Sprite', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (3, N'Fanta', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (4, N'Pilsen', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (5, N'Patagonia', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (6, N'StellaArtois', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (7, N'Norteña', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (8, N'Apple', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (9, N'Samsung', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (10, N'Motorola', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (11, N'Huawei', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (12, N'FIFA', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (13, N'Peñarol', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (14, N'Nacional', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (15, N'Liverpool', 0)
GO
INSERT [dbo].[Entities] ([EntityId], [Name], [Deleted]) VALUES (16, N'BourneMouth', 0)
GO
SET IDENTITY_INSERT [dbo].[Entities] OFF
GO
SET IDENTITY_INSERT [dbo].[Feelings] ON 
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (1, N'corrupcion', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (2, N'malo', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (3, N'bueno', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (4, N'tremendo', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (5, N'excelente', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (6, N'feo', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (7, N'magico', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (8, N'berreta', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (9, N'pesimo', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (10, N'disconforme', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (11, N'quiero', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (12, N'odio', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (13, N'no me gusta', 0)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (14, N'feliz', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (15, N'hincha', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (16, N'rica', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (17, N'buena', 1)
GO
INSERT [dbo].[Feelings] ([FeelingId], [Name], [Type]) VALUES (18, N'mala', 0)
GO
SET IDENTITY_INSERT [dbo].[Feelings] OFF
GO
INSERT [dbo].[GeneralAlarm] ([AlarmId], [Entity_EntityId], [Counter]) VALUES (1, 16, 21)
GO
INSERT [dbo].[GeneralAlarm] ([AlarmId], [Entity_EntityId], [Counter]) VALUES (2, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[Phrases] ON 
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (1, N'Hola!', CAST(N'2019-06-25T16:14:08.000' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (2, N'Está buena la sprite y la fanta', CAST(N'2019-06-25T16:14:04.000' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (3, N'me gusta el arte', CAST(N'2019-06-25T16:16:08.907' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (4, N'quiero ser pintor', CAST(N'2019-06-25T16:16:16.700' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (5, N'fanta y norteña mi perdicion', CAST(N'2019-06-25T16:16:20.933' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (6, N'que lindo ser del Clemente', CAST(N'2019-06-25T16:16:27.577' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (7, N'Un dia voy a ir al espacio', CAST(N'2019-06-25T16:16:38.467' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (8, N'Me gusta comer ravioles', CAST(N'2019-06-25T16:16:50.747' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (9, N'QUE RIco TOMar un mate', CAST(N'2019-06-25T16:20:23.520' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (10, N'quisiera ser futbolista', CAST(N'2019-06-25T16:20:49.927' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (11, N'mañana voy al cine', CAST(N'2019-06-25T16:20:56.787' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (12, N'tremenda peli la de monsters', CAST(N'2019-08-30T16:21:07.150' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (13, N'como las compus asus nohay', CAST(N'2019-08-30T16:21:15.133' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (14, N'Alguien quiere venir a casa?', CAST(N'2019-08-30T16:21:25.077' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (15, N'Toy pa jugar un fut 5', CAST(N'2019-08-30T16:21:36.893' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (16, N'Que buena universidad la ORT', CAST(N'2019-08-30T16:21:47.247' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (17, N'Soy un genio!', CAST(N'2019-08-30T16:22:01.517' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (18, N'encontré 100 pesos!', CAST(N'2019-11-30T16:22:14.897' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (19, N'que pare de llover!', CAST(N'2019-11-30T16:22:23.033' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (20, N'quiero ir a las termas', CAST(N'2019-11-30T16:22:32.470' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (21, N'cuando sea grande voy a vivir en España', CAST(N'2019-06-30T16:22:42.000' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (22, N'AAAHHHHH Pandemia!', CAST(N'2019-09-13T16:23:08.000' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (23, N'Es el uno Ed Sheeran', CAST(N'2019-09-13T16:23:35.223' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (24, N'verano llegá ya', CAST(N'2019-09-13T16:23:49.380' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (25, N'feliz cumple santi!', CAST(N'2019-09-13T16:24:06.787' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (26, N'hoy veo got talent!', CAST(N'2020-01-14T17:24:16.220' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (27, N'alguien me puede llevar?', CAST(N'2020-01-14T17:24:26.013' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (28, N'que lindos los cuadros de Picasso', CAST(N'2020-01-14T17:24:35.403' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (29, N'Sprite y Norteña la combinación perfecta!', CAST(N'2020-01-14T17:24:44.960' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (30, N'La coca será buena pero no me gusta', CAST(N'2020-01-14T17:25:40.657' AS DateTime), 11)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (31, N'Estoy feliz de ser hincha de Peñarol', CAST(N'2020-01-14T17:26:12.740' AS DateTime), 9)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (32, N'tremenda la patagonia pero mala para la salud', CAST(N'2020-01-14T17:27:26.947' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (33, N'soy hincha de alma', CAST(N'2020-01-14T17:27:39.497' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (34, N'Pilsen, alma de amigos', CAST(N'2020-01-14T17:27:50.477' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (35, N'seré mala pero no me gusta como juega Nacional', CAST(N'2020-01-14T17:27:56.720' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (36, N'pesimo Nacional, bueno lo de Peñarol', CAST(N'2020-01-14T17:28:30.823' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (37, N'Soy muy bajo', CAST(N'2020-01-14T17:28:49.283' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (38, N'aguante el bolso!', CAST(N'2020-01-14T17:29:02.353' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (39, N'me compré un Samsung y mi hermano un Apple', CAST(N'2020-01-14T17:29:06.493' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (40, N'qUE divino el verano', CAST(N'2020-01-14T17:29:24.803' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (41, N'que bueno que ya se venga el receso...', CAST(N'2020-03-16T17:29:37.000' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (42, N'escuchen a LVP', CAST(N'2020-03-16T17:29:45.220' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (43, N'escuchen al Bournemouth cantar', CAST(N'2020-03-16T17:29:57.773' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (44, N'Es bueno el juego del Bourne', CAST(N'2020-03-16T17:30:09.457' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (45, N'final del mundo: Nacional vs Peñarol', CAST(N'2020-03-16T17:30:18.057' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (46, N'como me gustaría una Pilsen ahora', CAST(N'2020-03-16T17:30:27.483' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (47, N'coca fria= placer', CAST(N'2020-03-16T17:30:40.483' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (48, N'hacer deporte es importante', CAST(N'2020-03-16T17:30:49.643' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (49, N'juntos le ganamos al covid', CAST(N'2020-03-16T17:30:59.230' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (50, N'voy a hacerme un licuado', CAST(N'2020-03-16T17:31:05.057' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (51, N'quiero comer ensalada', CAST(N'2020-03-16T17:31:13.683' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (52, N'estoy enfermo', CAST(N'2020-03-16T17:31:21.480' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (53, N'estoy feliz! mi compu que era berreta se rompió!', CAST(N'2020-05-20T17:31:42.503' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (54, N'necesito un mouse', CAST(N'2020-05-20T17:32:01.330' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (55, N'voy a ser cantante', CAST(N'2020-05-20T17:32:12.023' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (56, N'quiero aprobar DA1', CAST(N'2020-05-20T17:32:20.877' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (57, N'vOY A APRENDER C SHARP', CAST(N'2020-05-20T17:32:29.177' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (58, N'de verdad?', CAST(N'2020-05-20T17:32:54.620' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (59, N'Sí! soy libre! no mas examenes', CAST(N'2020-05-20T17:33:01.447' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (60, N'que feo dia', CAST(N'2020-05-20T17:33:09.397' AS DateTime), 6)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (61, N'esta lindo para un asadito', CAST(N'2020-05-18T17:33:43.000' AS DateTime), 6)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (62, N'mate dulce ?', CAST(N'2020-06-19T17:34:05.573' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (63, N'no existis nacional!', CAST(N'2020-06-19T17:34:18.287' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (64, N'samsung o apple?', CAST(N'2020-06-19T17:34:26.160' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (65, N'huawei es muy buena', CAST(N'2020-06-19T17:34:33.223' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (66, N'quiero ser doctor', CAST(N'2020-06-19T17:34:49.233' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (67, N'quiero ir al baño', CAST(N'2020-06-19T17:34:57.653' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (68, N'otra vez clase por zoom', CAST(N'2020-06-19T17:35:03.403' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (69, N'mi profesor es un genio', CAST(N'2020-06-19T17:35:09.383' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (70, N'soy muy inteligente', CAST(N'2020-06-19T17:35:19.310' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (71, N'se hacer la mejor torta de chocolate', CAST(N'2020-06-19T17:35:25.767' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (72, N'no me salen las ecuacciones :(', CAST(N'2020-06-19T17:35:39.930' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (73, N'estoy aburrido', CAST(N'2020-06-19T17:35:52.770' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (74, N'feliz navidad a todos!', CAST(N'2019-12-24T17:37:39.153' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (75, N'feliz navidad', CAST(N'2019-12-24T17:37:49.417' AS DateTime), 3)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (76, N'feliz navidad', CAST(N'2019-12-24T17:37:53.840' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (77, N'feliz navidad', CAST(N'2019-12-24T17:37:57.197' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (78, N'feliz navidad :)', CAST(N'2019-12-24T17:38:00.587' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (79, N'basta de feliz navidad :)', CAST(N'2019-12-24T21:38:09.827' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (80, N'feliz navidad :) los quiero', CAST(N'2019-12-24T21:38:17.213' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (81, N'feliz navidad ;)', CAST(N'2019-12-24T21:38:25.357' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (82, N'en esta navidad quiero un cel apple', CAST(N'2019-12-24T21:38:34.887' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (83, N'te compre un samsung por navidad', CAST(N'2019-12-24T21:38:43.207' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (84, N'la fifa es un desastre, pura corrupcion', CAST(N'2019-12-24T21:39:04.607' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (85, N'horrible la fifa!', CAST(N'2019-12-24T21:39:19.397' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (86, N'mal lo de la fifa', CAST(N'2019-12-24T21:39:26.167' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (87, N'CORRUPCION en la FIFA', CAST(N'2019-12-24T21:39:31.463' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (88, N'te odio', CAST(N'2019-12-24T21:39:49.110' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (89, N'odio apple', CAST(N'2019-12-24T21:39:54.217' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (90, N'amo motorola', CAST(N'2019-12-24T21:39:58.293' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (91, N'me gusta el bournemouth', CAST(N'2019-12-24T21:40:10.730' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (92, N'quiero un samsung', CAST(N'2019-12-24T21:40:19.140' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (93, N'necesito una patagonia', CAST(N'2019-12-24T21:40:24.883' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (94, N'me dieron un motorola', CAST(N'2019-12-24T21:40:39.637' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (95, N'encontre un apple perdido', CAST(N'2019-12-24T21:40:49.057' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (96, N'i want an apple', CAST(N'2019-12-24T21:40:58.273' AS DateTime), 3)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (97, N'bournemouth que no nin no!', CAST(N'2019-12-24T21:41:05.133' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (98, N'soy del bournemouth', CAST(N'2019-12-24T21:41:22.137' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (99, N'aguante peñarol', CAST(N'2019-12-24T21:41:27.580' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (100, N'Bournemouth pa todo el mundo', CAST(N'2019-12-24T21:41:32.110' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (101, N'feliz año a todos!', CAST(N'2019-01-01T01:01:05.773' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (102, N'feliz año gente', CAST(N'2019-01-01T01:01:10.560' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (103, N'feliz año a todes!', CAST(N'2019-01-01T01:01:16.260' AS DateTime), 11)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (104, N'feliz añoooo', CAST(N'2019-01-01T01:01:21.417' AS DateTime), 8)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (105, N'feliz año a todos!', CAST(N'2019-01-01T01:01:28.947' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (106, N'estoy feliz de tomarme una patagonia en fin de año', CAST(N'2019-01-01T01:01:34.257' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (107, N'felices fiestas!', CAST(N'2019-01-01T01:01:50.600' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (108, N'hola! feliz año!', CAST(N'2019-01-01T01:01:57.363' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (109, N'magico el bournemouth!', CAST(N'2020-06-25T20:03:38.870' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (110, N'tremendo magico el bournemouth!', CAST(N'2020-06-25T20:03:51.087' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (111, N'bien el bournemouth!', CAST(N'2020-06-25T20:03:56.070' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (112, N'hincha del bournemouth', CAST(N'2020-06-25T20:04:06.677' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (113, N'quiero ', CAST(N'2020-06-25T20:04:48.967' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (114, N'quiero al bournemouth!', CAST(N'2020-06-25T20:04:56.330' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (115, N'naci hincha del bournemouth', CAST(N'2020-06-25T20:05:02.017' AS DateTime), 15)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (116, N'mis hijos son hinchas del bournemouth', CAST(N'2020-06-25T20:05:10.883' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (117, N'bournemouth, te quiero', CAST(N'2020-06-25T20:05:20.803' AS DateTime), 10)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (118, N'bournemouth me haces feliz', CAST(N'2020-06-25T20:05:30.553' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (119, N'bournemouth campeon! lindooo', CAST(N'2020-06-25T20:05:40.350' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (120, N'buenaa bournemouth', CAST(N'2020-06-25T20:06:00.250' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (121, N'bien bournemouth', CAST(N'2020-06-25T20:06:05.607' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (122, N'ricaa bournemouth', CAST(N'2020-06-25T20:06:27.207' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (123, N'buena jugada bournemouth!', CAST(N'2020-06-25T20:06:34.907' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (124, N'genial el  bournemouth', CAST(N'2020-06-25T20:06:41.923' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (125, N'bournemouth te quiero ', CAST(N'2020-06-25T20:06:50.690' AS DateTime), 2)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (126, N'te quiero bournemouth!', CAST(N'2020-06-22T20:07:24.040' AS DateTime), 21)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (127, N'buenaaaaaa bournemouth!', CAST(N'2020-06-22T20:07:26.997' AS DateTime), 21)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (128, N'muy bueno lo del bournemouth!', CAST(N'2020-06-22T20:08:09.150' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (129, N'buenooo bournemouth!', CAST(N'2020-06-22T20:08:17.320' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (130, N'bournemouth te quiero!', CAST(N'2020-06-22T20:08:34.690' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (131, N'bournemouth sos tremendo!', CAST(N'2020-06-22T20:08:44.000' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (132, N'tremendo partido el del bournemouth!', CAST(N'2020-06-22T20:08:55.587' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (133, N'bournemouth hincha tuyo siempre!', CAST(N'2020-06-22T20:09:02.413' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (134, N'buenoo', CAST(N'2020-06-22T20:11:09.040' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (135, N'tremendo lo tuyo!', CAST(N'2020-06-24T18:11:53.233' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (136, N'quiero eso', CAST(N'2020-06-24T18:12:01.383' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (137, N'rica pepsi', CAST(N'2020-06-24T18:12:05.087' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (138, N'buena gente ', CAST(N'2020-06-24T18:12:10.997' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (139, N'hincha de peñaro', CAST(N'2020-06-24T18:12:16.867' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (140, N'hincha de peñarol quise decir', CAST(N'2020-06-24T18:12:22.030' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (141, N'es magico este software', CAST(N'2020-06-24T18:12:29.830' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (142, N'es excelente el servicio', CAST(N'2020-06-24T18:12:35.713' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (143, N'hasta magico diria ', CAST(N'2020-06-24T18:12:41.777' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (144, N'tremendo partido salió', CAST(N'2020-06-24T18:12:48.037' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (145, N'soy hincha a muerte', CAST(N'2020-06-24T18:12:55.990' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (146, N'bueno, me voy a dormir', CAST(N'2020-06-24T18:13:03.517' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (147, N'gracias! excelente ', CAST(N'2020-06-24T18:13:09.577' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (148, N'no quiero ir a dormir', CAST(N'2020-06-24T18:13:21.883' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (149, N'quiero un sandwitch por favor', CAST(N'2020-06-24T18:13:31.813' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (150, N'feliz dia!', CAST(N'2020-06-24T18:13:39.723' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (151, N'feliz cumple tati!', CAST(N'2020-06-24T18:13:44.737' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (152, N'excelente dia', CAST(N'2020-06-24T18:14:10.467' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (153, N'quiero ser grane', CAST(N'2020-06-24T18:14:18.387' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (154, N'quiero jugar al play', CAST(N'2020-06-24T18:14:23.467' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (155, N'la torta de vainilla es rica', CAST(N'2020-06-24T18:14:35.363' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (156, N're buena la piza de ese bar', CAST(N'2020-06-24T18:14:43.337' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (157, N'que bueno todo!', CAST(N'2020-06-24T18:14:52.343' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (158, N'bournemouth sos magico', CAST(N'2020-06-24T18:15:01.107' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (159, N'excelente el partido de hoy', CAST(N'2020-06-24T18:15:11.660' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (160, N'feliz de la vida :)', CAST(N'2020-06-24T18:15:17.697' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (161, N'soy feliz', CAST(N'2020-06-24T18:15:25.403' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (162, N'soy tremendo..', CAST(N'2020-06-24T18:15:29.003' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (163, N'gracias, fue magico', CAST(N'2020-06-24T18:15:35.773' AS DateTime), 17)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (164, N'.', CAST(N'2020-06-24T18:16:51.213' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (165, N'.', CAST(N'2020-06-24T17:06:11.697' AS DateTime), 5)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (166, N':)', CAST(N'2020-06-24T17:10:40.247' AS DateTime), 13)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (167, N'-''''''', CAST(N'2020-06-24T17:13:57.963' AS DateTime), 6)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (168, N'terminando', CAST(N'2020-06-24T17:17:52.317' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (169, N'motorola', CAST(N'2020-06-24T17:17:59.497' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (170, N'al final', CAST(N'2020-06-24T17:18:03.077' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (171, N'creo que gané', CAST(N'2020-06-24T17:18:06.783' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (172, N'peñarol que no nin o', CAST(N'2020-06-24T17:18:12.310' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (173, N'nacional te quiero', CAST(N'2020-06-24T17:18:17.213' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (174, N'norteña siempre', CAST(N'2020-06-24T17:18:22.370' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (175, N'norteña o patagonia?', CAST(N'2020-06-24T17:18:29.097' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (176, N'tremendo partido se jugo el liverpool', CAST(N'2020-06-24T17:18:41.847' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (177, N'soy hincha de liverpool', CAST(N'2020-06-24T17:18:53.877' AS DateTime), 4)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (178, N'coca y fanta', CAST(N'2020-06-24T17:19:11.330' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (179, N'fanta y sprite', CAST(N'2020-06-24T17:19:18.093' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (180, N'bueno fanta', CAST(N'2020-06-24T17:19:21.923' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (181, N'odio la sprite', CAST(N'2020-06-24T17:19:24.637' AS DateTime), 12)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (182, N'la fifa es berreta', CAST(N'2020-06-24T17:19:34.780' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (183, N'todo mal con la fifa', CAST(N'2020-06-24T17:19:40.367' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (184, N'arriba el bournemouth!', CAST(N'2020-06-24T17:19:44.830' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (185, N'soy usuario de apple', CAST(N'2020-06-24T17:19:56.623' AS DateTime), 18)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (186, N'quiero una piza', CAST(N'2020-06-24T17:20:04.490' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (187, N'quiero jugar al xbox', CAST(N'2020-06-24T17:20:10.260' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (188, N'gane al futbol', CAST(N'2020-06-24T17:20:16.367' AS DateTime), 20)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (189, N'tomamos unos mates?', CAST(N'2020-06-24T17:20:22.210' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (190, N'samsung tremendo', CAST(N'2020-06-24T17:20:27.823' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (191, N'que mal liverpool', CAST(N'2020-06-24T17:20:34.153' AS DateTime), 14)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (192, N'que feo jugo peñarol', CAST(N'2020-06-24T17:20:49.240' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (193, N'que malo que sos', CAST(N'2020-06-24T17:20:56.953' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (194, N'hola!!!', CAST(N'2020-06-24T17:21:01.530' AS DateTime), 19)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (195, N'soy de nacional', CAST(N'2020-06-24T17:21:10.073' AS DateTime), 16)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (196, N'no me gusta nada', CAST(N'2020-06-24T17:21:24.890' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (197, N'no me gusta liverpool', CAST(N'2020-06-24T17:21:32.057' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (198, N'no me gusta comer ensalada', CAST(N'2020-06-24T17:21:36.907' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (199, N'no quiero eso', CAST(N'2020-06-24T17:21:43.707' AS DateTime), 7)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (200, N'hola !!', CAST(N'2020-06-24T17:21:48.273' AS DateTime), 3)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (201, N'sabes el camino?', CAST(N'2020-06-24T17:21:53.603' AS DateTime), 3)
GO
INSERT [dbo].[Phrases] ([PhraseId], [Content], [Date], [Author_AuthorId]) VALUES (202, N'estoy cansadoo', CAST(N'2020-06-24T17:21:57.850' AS DateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[Phrases] OFF
GO
ALTER TABLE [dbo].[Analyses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Analyses_dbo.Entities_Entity_EntityId] FOREIGN KEY([Entity_EntityId])
REFERENCES [dbo].[Entities] ([EntityId])
GO
ALTER TABLE [dbo].[Analyses] CHECK CONSTRAINT [FK_dbo.Analyses_dbo.Entities_Entity_EntityId]
GO
ALTER TABLE [dbo].[Analyses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Analyses_dbo.Phrases_Phrase_PhraseId] FOREIGN KEY([Phrase_PhraseId])
REFERENCES [dbo].[Phrases] ([PhraseId])
GO
ALTER TABLE [dbo].[Analyses] CHECK CONSTRAINT [FK_dbo.Analyses_dbo.Phrases_Phrase_PhraseId]
GO
ALTER TABLE [dbo].[AuthorAlarm]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorAlarm_dbo.Alarms_AlarmId] FOREIGN KEY([AlarmId])
REFERENCES [dbo].[Alarms] ([AlarmId])
GO
ALTER TABLE [dbo].[AuthorAlarm] CHECK CONSTRAINT [FK_dbo.AuthorAlarm_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.AuthorAlarm_AuthorAlarm_AlarmId] FOREIGN KEY([AuthorAlarm_AlarmId])
REFERENCES [dbo].[AuthorAlarm] ([AlarmId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors] CHECK CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.AuthorAlarm_AuthorAlarm_AlarmId]
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.Authors_Author_AuthorId] FOREIGN KEY([Author_AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AuthorAlarmAuthors] CHECK CONSTRAINT [FK_dbo.AuthorAlarmAuthors_dbo.Authors_Author_AuthorId]
GO
ALTER TABLE [dbo].[AuthorEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorEntities_dbo.Authors_Author_AuthorId] FOREIGN KEY([Author_AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AuthorEntities] CHECK CONSTRAINT [FK_dbo.AuthorEntities_dbo.Authors_Author_AuthorId]
GO
ALTER TABLE [dbo].[AuthorEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorEntities_dbo.Entities_Entity_EntityId] FOREIGN KEY([Entity_EntityId])
REFERENCES [dbo].[Entities] ([EntityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AuthorEntities] CHECK CONSTRAINT [FK_dbo.AuthorEntities_dbo.Entities_Entity_EntityId]
GO
ALTER TABLE [dbo].[GeneralAlarm]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Alarms_AlarmId] FOREIGN KEY([AlarmId])
REFERENCES [dbo].[Alarms] ([AlarmId])
GO
ALTER TABLE [dbo].[GeneralAlarm] CHECK CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[GeneralAlarm]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Entities_Entity_EntityId] FOREIGN KEY([Entity_EntityId])
REFERENCES [dbo].[Entities] ([EntityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GeneralAlarm] CHECK CONSTRAINT [FK_dbo.GeneralAlarm_dbo.Entities_Entity_EntityId]
GO
ALTER TABLE [dbo].[Phrases]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Phrases_dbo.Authors_Author_AuthorId] FOREIGN KEY([Author_AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Phrases] CHECK CONSTRAINT [FK_dbo.Phrases_dbo.Authors_Author_AuthorId]
GO
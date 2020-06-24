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
/****** Object:  Table [dbo].[Phrases]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phrases]') AND type in (N'U'))
DROP TABLE [dbo].[Phrases]
GO
/****** Object:  Table [dbo].[GeneralAlarm]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralAlarm]') AND type in (N'U'))
DROP TABLE [dbo].[GeneralAlarm]
GO
/****** Object:  Table [dbo].[Feelings]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Feelings]') AND type in (N'U'))
DROP TABLE [dbo].[Feelings]
GO
/****** Object:  Table [dbo].[Entities]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entities]') AND type in (N'U'))
DROP TABLE [dbo].[Entities]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Authors]') AND type in (N'U'))
DROP TABLE [dbo].[Authors]
GO
/****** Object:  Table [dbo].[AuthorEntities]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorEntities]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorEntities]
GO
/****** Object:  Table [dbo].[AuthorAlarmAuthors]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorAlarmAuthors]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorAlarmAuthors]
GO
/****** Object:  Table [dbo].[AuthorAlarm]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorAlarm]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorAlarm]
GO
/****** Object:  Table [dbo].[Analyses]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Analyses]') AND type in (N'U'))
DROP TABLE [dbo].[Analyses]
GO
/****** Object:  Table [dbo].[Alarms]    Script Date: 24/6/2020 18:24:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alarms]') AND type in (N'U'))
DROP TABLE [dbo].[Alarms]
GO
/****** Object:  Table [dbo].[Alarms]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[Analyses]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[AuthorAlarm]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[AuthorAlarmAuthors]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[AuthorEntities]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[Authors]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[Entities]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[Feelings]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[GeneralAlarm]    Script Date: 24/6/2020 18:24:39 ******/
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
/****** Object:  Table [dbo].[Phrases]    Script Date: 24/6/2020 18:24:39 ******/
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
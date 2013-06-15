USE [AEIS]
GO
/****** Object:  Table [dbo].[alert_tab]    Script Date: 06/09/2013 12:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alert_tab](
	[alert_id] [int] IDENTITY(1,1) NOT NULL,
	[exam_id] [int] NOT NULL,
	[position_id] [int] NOT NULL,
	[alert_type] [char](1) NOT NULL,
	[alert_time] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[alert_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


USE [AEIS]
GO
/****** Object:  Table [dbo].[candidate_exam]    Script Date: 06/09/2013 12:10:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[candidate_exam](
	[candidate_exam_id] [int] NULL,
	[exam_id] [int] NULL,
	[candidate_id] [int] NULL
) ON [PRIMARY]



USE [AEIS]
GO
/****** Object:  Table [dbo].[candidate_position]    Script Date: 06/09/2013 12:10:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[candidate_position](
	[can_pos_id] [int] IDENTITY(1,1) NOT NULL,
	[exam_id] [int] NOT NULL,
	[position_id] [int] NOT NULL,
	[candidate_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[can_pos_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




USE [AEIS]
GO
/****** Object:  Table [dbo].[candidate_tab]    Script Date: 06/09/2013 12:10:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[candidate_tab](
	[candidate_id] [int] IDENTITY(1,1) NOT NULL,
	[candidate_full_name] [varchar](500) NULL,
	[candidate_name_initials] [varchar](500) NULL,
	[candidate_title] [varchar](10) NULL,
	[candidate_nationality_id] [varchar](100) NULL,
	[candidate_nic] [varchar](10) NULL,
	[candidate_dob] [date] NULL,
	[candidate_gender] [char](1) NULL,
	[candidate_address] [varchar](500) NULL,
	[candidate_telno] [varchar](14) NULL,
	[candidate_email] [varchar](100) NULL,
	[candidate_img] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[candidate_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



USE [AEIS]
GO
/****** Object:  Table [dbo].[examination_tab]    Script Date: 06/09/2013 12:11:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[examination_tab](
	[exam_id] [int] IDENTITY(1,1) NOT NULL,
	[exam_date] [date] NOT NULL,
	[exam_start_time] [time] NOT NULL,
	[exam_end_time] [time] NOT NULL,
	[exam_hall_id] [int] NOT NULL,
	[exam_subject_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[exam_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



USE [AEIS]
GO
/****** Object:  Table [dbo].[hall_position]    Script Date: 06/09/2013 12:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hall_position](
	[hall_pos_id] [int] IDENTITY(1,1) NOT NULL,
	[hall_id] [int] NOT NULL,
	[position_id] [int] NOT NULL,
	[pos_x] [int] NOT NULL,
	[pos_y] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[hall_pos_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



USE [AEIS]
GO
/****** Object:  Table [dbo].[invigilator_exam]    Script Date: 06/09/2013 12:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invigilator_exam](
	[invigilator_exam_id] [int] NULL,
	[exam_id] [int] NULL,
	[invigilator_id] [int] NULL
) ON [PRIMARY]



USE [AEIS]
GO
/****** Object:  Table [dbo].[invigilator_tab]    Script Date: 06/09/2013 12:11:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invigilator_tab](
	[invigilator_id] [int] IDENTITY(1,1) NOT NULL,
	[invigilator_full_name] [varchar](500) NULL,
	[invigilator_name_initials] [varchar](500) NULL,
	[invigilator_title] [varchar](10) NULL,
	[invigilator_nationality_id] [int] NULL,
	[invigilator_nic] [varchar](10) NULL,
	[invigilator_dob] [varchar](1) NULL,
	[invigilator_address] [varchar](500) NULL,
	[invigilator_telno] [varchar](14) NULL,
	[invigilator_email] [varchar](100) NULL,
	[invigilator_date_joined] [varchar](1) NULL,
	[invigilator_qualifications] [varchar](1000) NULL,
	[invigilator_designation_id] [int] NULL,
	[invigilator_img] [varchar](200) NULL,
	[invigilator_gender] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[invigilator_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



USE [AEIS]
GO
/****** Object:  Table [dbo].[mcq_answers_tab]    Script Date: 06/09/2013 12:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mcq_answers_tab](
	[answer_id] [int] NOT NULL,
	[candidate_id] [int] NOT NULL,
	[exam_id] [int] NOT NULL,
	[answersheet_path] [varchar](200) NOT NULL,
	[a1] [int] NOT NULL,
	[a2] [int] NOT NULL,
	[a3] [int] NOT NULL,
	[a4] [int] NOT NULL,
	[a5] [int] NOT NULL,
	[a6] [int] NOT NULL,
	[a7] [int] NOT NULL,
	[a8] [int] NOT NULL,
	[a9] [int] NOT NULL,
	[a10] [int] NOT NULL,
	[a11] [int] NOT NULL,
	[a12] [int] NOT NULL,
	[a13] [int] NOT NULL,
	[a14] [int] NOT NULL,
	[a15] [int] NOT NULL,
	[a16] [int] NOT NULL,
	[a17] [int] NOT NULL,
	[a18] [int] NOT NULL,
	[a19] [int] NOT NULL,
	[a20] [int] NOT NULL,
	[a21] [int] NOT NULL,
	[a22] [int] NOT NULL,
	[a23] [int] NOT NULL,
	[a24] [int] NOT NULL,
	[a25] [int] NOT NULL,
	[a26] [int] NOT NULL,
	[a27] [int] NOT NULL,
	[a28] [int] NOT NULL,
	[a29] [int] NOT NULL,
	[a30] [int] NOT NULL,
	[a31] [int] NOT NULL,
	[a32] [int] NOT NULL,
	[a33] [int] NOT NULL,
	[a34] [int] NOT NULL,
	[a35] [int] NOT NULL,
	[a36] [int] NOT NULL,
	[a37] [int] NOT NULL,
	[a38] [int] NOT NULL,
	[a39] [int] NOT NULL,
	[a40] [int] NOT NULL,
	[total_mark] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[answer_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



USE [AEIS]
GO
/****** Object:  Table [dbo].[mcq_marking_scheme_tab]    Script Date: 06/09/2013 12:11:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mcq_marking_scheme_tab](
	[marking_scheme_id] [int] IDENTITY(1,1) NOT NULL,
	[exam_id] [int] NOT NULL,
	[a1] [int] NULL,
	[a2] [int] NULL,
	[a3] [int] NULL,
	[a4] [int] NULL,
	[a5] [int] NULL,
	[a6] [int] NULL,
	[a7] [int] NULL,
	[a8] [int] NULL,
	[a9] [int] NULL,
	[a10] [int] NULL,
	[a11] [int] NULL,
	[a12] [int] NULL,
	[a13] [int] NULL,
	[a14] [int] NULL,
	[a15] [int] NULL,
	[a16] [int] NULL,
	[a17] [int] NULL,
	[a18] [int] NULL,
	[a19] [int] NULL,
	[a20] [int] NULL,
	[a21] [int] NULL,
	[a22] [int] NULL,
	[a23] [int] NULL,
	[a24] [int] NULL,
	[a25] [int] NULL,
	[a26] [int] NULL,
	[a27] [int] NULL,
	[a28] [int] NULL,
	[a29] [int] NULL,
	[a30] [int] NULL,
	[a31] [int] NULL,
	[a32] [int] NULL,
	[a33] [int] NULL,
	[a34] [int] NULL,
	[a35] [int] NULL,
	[a36] [int] NULL,
	[a37] [int] NULL,
	[a38] [int] NULL,
	[a39] [int] NULL,
	[a40] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[marking_scheme_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




USE [AEIS]
GO
/****** Object:  Table [dbo].[nationality_tab]    Script Date: 06/09/2013 12:12:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nationality_tab](
	[nationality_id] [int] NOT NULL,
	[nationality_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nationality_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



USE [AEIS]
GO
/****** Object:  Table [dbo].[User_Login_Tracker]    Script Date: 06/09/2013 12:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login_Tracker](
	[user_id] [nchar](30) NOT NULL,
	[logged_date] [datetime] NOT NULL,
	[logged_time] [nchar](15) NOT NULL
) ON [PRIMARY]





USE [AEIS]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/09/2013 12:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [nchar](30) NOT NULL,
	[first_name] [nchar](50) NOT NULL,
	[last_name] [nchar](50) NOT NULL,
	[title] [nchar](5) NOT NULL,
	[user_level] [nchar](30) NOT NULL,
	[user_name] [nchar](20) NOT NULL,
	[password] [nchar](200) NOT NULL,
	[email] [nchar](100) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[created_time] [nchar](10) NOT NULL,
	[photograph] [image] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

USE [EmailVerifier]
GO
/****** Object:  Table [dbo].[last_settings]    Script Date: 12/29/2014 10:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
--for by user settings
CREATE TABLE [dbo].[last_settings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[ConnectionString] [varchar](max) NOT NULL,
	[iConnectionType] [tinyint] NOT NULL,
	[id_field] [varchar](50) NOT NULL,
	[table_name] [varchar](50) NOT NULL,
	[email_field_name] [varchar](50) NOT NULL,
	[dns_server] [varchar](50) NULL,
	[chkFixTyposMajorISP] [bit] NOT NULL,
	[chkFixKnownTyposGeneral] [bit] NOT NULL,
	[chkDeleteFictitiousDomains] [bit] NOT NULL,
	[chkDeleteSpamTrapDomains] [bit] NOT NULL,
	[chkDeleteSpamTrapAddresses] [bit] NOT NULL,
	[chkDeleteWirelessDomains] [bit] NOT NULL,
	[chkDeleteRoleUsernames] [bit] NOT NULL,
	[chkFixTypoSuffix] [bit] NOT NULL,
	[chkDeleteBadFormatedEmails] [bit] NOT NULL,
	[chkDeleteBadFormatedMajorISP] [bit] NOT NULL,
	[chkDeleteEmailsWithNoMXgeneral] [bit] NOT NULL,
	[chkDeleteEmailifMXcantVerifyMajorISP] [bit] NOT NULL,
	[chkDeleteEmailifMXcantVerifyGeneral] [bit] NOT NULL,
 CONSTRAINT [PK_last_settings] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[model_table_with_indexes]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[model_table_with_indexes](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](max) NULL,
	[new_email] [varchar](max) NOT NULL,
	[reasoncode] [tinyint] NOT NULL,
	[supressionid] [tinyint] NOT NULL,
 CONSTRAINT [PK_imported_email_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[popular_domains]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[popular_domains](
	[ID] [int] NOT NULL,
	[domain] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reason]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reason](
	[id] [int] NOT NULL,
	[reason_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_reason] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reasonid_description]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reasonid_description](
	[id] [tinyint] NOT NULL,
	[logic_reason] [varchar](50) NOT NULL,
 CONSTRAINT [PK_reasonid_description] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[supression]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supression](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[email_or_string] [varchar](75) NOT NULL,
	[reason] [tinyint] NULL,
	[the_rule] [tinyint] NULL,
	[replace_with] [varchar](30) NULL,
 CONSTRAINT [PK_supression] PRIMARY KEY CLUSTERED 
(
	[email_or_string] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[the_rule]    Script Date: 12/29/2014 10:59:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[the_rule](
	[id] [tinyint] NOT NULL,
	[rule_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_the_rule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

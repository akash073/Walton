USE [WSMS]
GO
/****** Object:  Table [dbo].[incentive_distribution_percentages]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_distribution_percentages](
	[incentive_distribution_percentage_id] [bigint] IDENTITY(1,1) NOT NULL,
	[corporate] [decimal](18, 2) NULL,
	[cellphone_incharge] [decimal](18, 2) NULL,
	[main_incharge] [decimal](18, 2) NULL,
	[others] [decimal](18, 2) NULL,
 CONSTRAINT [PK_distribution_percentages] PRIMARY KEY CLUSTERED 
(
	[incentive_distribution_percentage_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_limits]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_limits](
	[incentive_limit_id] [bigint] IDENTITY(1,1) NOT NULL,
	[penalty_day] [int] NULL,
	[bonus_day] [int] NULL,
	[bonus_limit_15] [int] NULL,
	[bouns_limit_30] [int] NULL,
 CONSTRAINT [PK_incentive_limits] PRIMARY KEY CLUSTERED 
(
	[incentive_limit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_master]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_master](
	[incentive_master_id] [bigint] IDENTITY(1,1) NOT NULL,
	[servicepointId] [int] NOT NULL,
	[incentive_distribution_percentage_id] [bigint] NOT NULL,
	[incentive_limit_id] [bigint] NOT NULL,
	[incentive_rate_id] [bigint] NOT NULL,
	[calculated_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_incentive_master] PRIMARY KEY CLUSTERED 
(
	[incentive_master_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_penalties]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_penalties](
	[incentive_penalty_id] [bigint] IDENTITY(1,1) NOT NULL,
	[incentive_master_id] [bigint] NOT NULL,
	[technicianId] [int] NOT NULL,
	[qcid] [int] NOT NULL,
	[serviceid_previous] [bigint] NOT NULL,
	[serviceid_next] [bigint] NOT NULL,
 CONSTRAINT [PK_incentive_penalty] PRIMARY KEY CLUSTERED 
(
	[incentive_penalty_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_qcs]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_qcs](
	[incentive_qc_id] [bigint] IDENTITY(1,1) NOT NULL,
	[incentive_master_id] [bigint] NOT NULL,
	[qc_id] [int] NULL,
	[qc_total_phone] [int] NULL,
 CONSTRAINT [PK_incentive_qcs] PRIMARY KEY CLUSTERED 
(
	[incentive_qc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_rates]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_rates](
	[incentive_rate_id] [bigint] IDENTITY(1,1) NOT NULL,
	[technician_distributable_rate] [decimal](18, 2) NULL,
	[technician_nondistributable_rate] [decimal](18, 2) NULL,
	[technician_software_rate] [decimal](18, 2) NULL,
	[technician_bounce_rate] [decimal](18, 2) NULL,
	[technician_software_bounce_rate] [decimal](18, 2) NULL,
	[qc_rate] [decimal](18, 2) NULL,
	[qc_bounce_rate] [decimal](18, 2) NULL,
	[receiver_receive_rate] [decimal](18, 2) NULL,
	[receiver_software_rate] [decimal](18, 2) NULL,
	[receiver_bonus_delivery_rate] [decimal](18, 2) NULL,
 CONSTRAINT [PK_incentive_rates] PRIMARY KEY CLUSTERED 
(
	[incentive_rate_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_receivers]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_receivers](
	[incentive_receiver_id] [bigint] IDENTITY(1,1) NOT NULL,
	[incentive_master_id] [bigint] NOT NULL,
	[receiver] [nchar](10) NULL,
	[total_receive] [int] NULL,
	[total_software] [int] NULL,
	[toatl_24_delivery] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[incentive_receiver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[incentive_technicians]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[incentive_technicians](
	[incentive_technician_id] [bigint] IDENTITY(1,1) NOT NULL,
	[incentive_master_Id] [bigint] NOT NULL,
	[techinican_id] [int] NOT NULL,
	[total_phone_distributable] [int] NOT NULL,
	[total_phone_nondistributable] [int] NOT NULL,
 CONSTRAINT [PK_technician_qc] PRIMARY KEY CLUSTERED 
(
	[incentive_technician_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Log]    Script Date: 11/02/2016 12:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](5000) NOT NULL,
	[Level] [varchar](5000) NOT NULL,
	[Logger] [varchar](5000) NOT NULL,
	[Message] [varchar](5000) NOT NULL,
	[Exception] [varchar](5000) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[incentive_rates] ON 

INSERT [dbo].[incentive_rates] ([incentive_rate_id], [technician_distributable_rate], [technician_nondistributable_rate], [technician_software_rate], [technician_bounce_rate], [technician_software_bounce_rate], [qc_rate], [qc_bounce_rate], [receiver_receive_rate], [receiver_software_rate], [receiver_bonus_delivery_rate]) VALUES (1, CAST(31.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(-31.50 AS Decimal(18, 2)), CAST(-10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(-10.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[incentive_rates] OFF
SET IDENTITY_INSERT [dbo].[Log] ON 

INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (1, CAST(N'2016-02-11 11:36:34.380' AS DateTime), N'9', N'INFO', N'incentive_policy.Program', N'dekhi test Incentive app', N'System.Exception: object not found
')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (2, CAST(N'2016-02-11 11:37:47.580' AS DateTime), N'1', N'INFO', N'incentive_policy.Program', N'dekhi test Incentive app', N'System.DivideByZeroException: Attempted to divide by zero.
   at incentive_policy.Program.Main(String[] args) in e:\Incentive Of Wsms\incentive_policy\incentive_policy\Program.cs:line 46
')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (3, CAST(N'2016-02-11 11:44:25.357' AS DateTime), N'11', N'FATAL', N'incentive_policy.Program', N'alask', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (4, CAST(N'2016-02-11 11:45:21.147' AS DateTime), N'9', N'FATAL', N'incentive_policy.Program', N'alaskdfdddd', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (5, CAST(N'2016-02-11 11:50:16.947' AS DateTime), N'8', N'WARN', N'incentive_policy.Program', N'akash', N'')
INSERT [dbo].[Log] ([Id], [Date], [Thread], [Level], [Logger], [Message], [Exception]) VALUES (6, CAST(N'2016-02-11 11:50:43.123' AS DateTime), N'9', N'WARN', N'incentive_policy.Program', N'akash', N'')
SET IDENTITY_INSERT [dbo].[Log] OFF
ALTER TABLE [dbo].[incentive_master]  WITH CHECK ADD  CONSTRAINT [FK_incentive_master_incentive_distribution_percentages] FOREIGN KEY([incentive_distribution_percentage_id])
REFERENCES [dbo].[incentive_distribution_percentages] ([incentive_distribution_percentage_id])
GO
ALTER TABLE [dbo].[incentive_master] CHECK CONSTRAINT [FK_incentive_master_incentive_distribution_percentages]
GO
ALTER TABLE [dbo].[incentive_master]  WITH CHECK ADD  CONSTRAINT [FK_incentive_master_incentive_limits] FOREIGN KEY([incentive_limit_id])
REFERENCES [dbo].[incentive_limits] ([incentive_limit_id])
GO
ALTER TABLE [dbo].[incentive_master] CHECK CONSTRAINT [FK_incentive_master_incentive_limits]
GO
ALTER TABLE [dbo].[incentive_master]  WITH CHECK ADD  CONSTRAINT [FK_incentive_master_incentive_rates] FOREIGN KEY([incentive_rate_id])
REFERENCES [dbo].[incentive_rates] ([incentive_rate_id])
GO
ALTER TABLE [dbo].[incentive_master] CHECK CONSTRAINT [FK_incentive_master_incentive_rates]
GO
ALTER TABLE [dbo].[incentive_penalties]  WITH CHECK ADD  CONSTRAINT [FK_incentive_penalty_incentive_master] FOREIGN KEY([incentive_master_id])
REFERENCES [dbo].[incentive_master] ([incentive_master_id])
GO
ALTER TABLE [dbo].[incentive_penalties] CHECK CONSTRAINT [FK_incentive_penalty_incentive_master]
GO
ALTER TABLE [dbo].[incentive_qcs]  WITH CHECK ADD  CONSTRAINT [FK_incentive_qcs_incentive_master] FOREIGN KEY([incentive_master_id])
REFERENCES [dbo].[incentive_master] ([incentive_master_id])
GO
ALTER TABLE [dbo].[incentive_qcs] CHECK CONSTRAINT [FK_incentive_qcs_incentive_master]
GO
ALTER TABLE [dbo].[incentive_receivers]  WITH CHECK ADD  CONSTRAINT [FK_incentive_receivers_incentive_master] FOREIGN KEY([incentive_master_id])
REFERENCES [dbo].[incentive_master] ([incentive_master_id])
GO
ALTER TABLE [dbo].[incentive_receivers] CHECK CONSTRAINT [FK_incentive_receivers_incentive_master]
GO
ALTER TABLE [dbo].[incentive_technicians]  WITH CHECK ADD  CONSTRAINT [FK_incentive_technicians_incentive_master] FOREIGN KEY([incentive_master_Id])
REFERENCES [dbo].[incentive_master] ([incentive_master_id])
GO
ALTER TABLE [dbo].[incentive_technicians] CHECK CONSTRAINT [FK_incentive_technicians_incentive_master]
GO

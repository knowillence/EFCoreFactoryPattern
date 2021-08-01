Demo project that will switch entity framework between SQL Server and MySQL.
In AppSettings.json file change the value of the DBProvider from SQLServer to MySQLServer.
Create the following table in both SQL Server and MySQL before you run this code.

SQL Server Script to create table

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ref_record_status](
	[record_status_id] [int] NOT NULL,
	[record_status_name] [varchar](50) NOT NULL,
	[record_status_desc] [varchar](500) NULL,
 CONSTRAINT [PK_ref_record_status] PRIMARY KEY CLUSTERED 
(
	[record_status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ref_record_status] ([record_status_id], [record_status_name], [record_status_desc]) VALUES (-1, N'Deleted', N'Deleted records are marked with this staus')
GO
INSERT [dbo].[ref_record_status] ([record_status_id], [record_status_name], [record_status_desc]) VALUES (0, N'Inactive', N'Inactive records are marked with this status')
GO
INSERT [dbo].[ref_record_status] ([record_status_id], [record_status_name], [record_status_desc]) VALUES (1, N'Active', N'Active records are marked with this status.')
GO

MySQL Create Table Script

CREATE TABLE `ref_record_status` (
  `record_status_id` int NOT NULL,
  `record_status_name` varchar(50) NOT NULL,
  `record_status_desc` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`record_status_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `ref_record_status` VALUES (-1,'Deleted','Deleted records. Don\'t show them anywhere.'),(0,'Inactive','Inactive records show only when user requests it.'),(1,'Active','Active records show this always');

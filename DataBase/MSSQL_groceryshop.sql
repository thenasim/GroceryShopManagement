USE [master]
GO
/****** Object:  Database [groceryshop]    Script Date: 1/3/2021 6:17:20 PM ******/
CREATE DATABASE [groceryshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'groceryshop', FILENAME = N'D:\Installed__Programs\MS Sql Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\groceryshop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'groceryshop_log', FILENAME = N'D:\Installed__Programs\MS Sql Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\groceryshop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [groceryshop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [groceryshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [groceryshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [groceryshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [groceryshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [groceryshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [groceryshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [groceryshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [groceryshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [groceryshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [groceryshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [groceryshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [groceryshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [groceryshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [groceryshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [groceryshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [groceryshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [groceryshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [groceryshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [groceryshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [groceryshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [groceryshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [groceryshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [groceryshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [groceryshop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [groceryshop] SET  MULTI_USER 
GO
ALTER DATABASE [groceryshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [groceryshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [groceryshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [groceryshop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [groceryshop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [groceryshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [groceryshop] SET QUERY_STORE = OFF
GO
USE [groceryshop]
GO
/****** Object:  Table [dbo].[category]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[updated_at] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[full_name] [nvarchar](255) NOT NULL,
	[email] [nvarchar](255) NULL,
	[gender] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[birthdate] [date] NULL,
	[phone] [nvarchar](255) NULL,
	[join_date] [date] NULL,
	[salary] [float] NOT NULL,
	[user_id] [nvarchar](255) NULL,
	[updated_at] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logins]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[user_id] [nvarchar](255) NULL,
	[updated_at] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
	[price] [float] NOT NULL,
	[purchase_price] [float] NOT NULL,
	[quantity] [float] NOT NULL,
	[updated_at] [datetime] NOT NULL,
	[category_id] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[total_price] [float] NOT NULL,
	[quantity] [float] NOT NULL,
	[updated_at] [datetime] NOT NULL,
	[product_id] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 1/3/2021 6:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[appid] [nvarchar](255) NOT NULL,
	[updated_at] [datetime] NOT NULL,
	[user_type] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (1, N'ca-1', N'Fruits and Vegetables', CAST(N'2021-01-03T16:22:32.833' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (10, N'ca-10', N'Pet Care', CAST(N'2021-01-03T18:09:04.170' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (11, N'ca-11', N'Home Appliances', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (12, N'ca-12', N'Baby Care', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (13, N'ca-13', N'Test', CAST(N'2021-01-03T18:00:20.370' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (14, N'ca-14', N'Test', CAST(N'2021-01-03T18:00:42.373' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (15, N'ca-15', N'Test', CAST(N'2021-01-03T18:00:47.263' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (16, N'ca-16', N'Test', CAST(N'2021-01-03T18:00:52.957' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (17, N'ca-17', N'Test', CAST(N'2021-01-03T18:01:18.763' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (2, N'ca-2', N'Meat and Fish', CAST(N'2021-01-03T16:22:32.833' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (3, N'ca-3', N'Cooking', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (4, N'ca-4', N'Beverages', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (5, N'ca-5', N'Home and Cleaning', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (6, N'ca-6', N'Pest Control', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (7, N'ca-7', N'Office Products', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (8, N'ca-8', N'Beauty Products', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
INSERT [dbo].[category] ([id], [appid], [name], [updated_at]) VALUES (9, N'ca-9', N'Health Products', CAST(N'2021-01-03T16:22:32.837' AS DateTime))
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([id], [appid], [full_name], [email], [gender], [address], [birthdate], [phone], [join_date], [salary], [user_id], [updated_at]) VALUES (1, N'em-1', N'nasim uddin', N'nasim@gmail.com', N'male', N'bogra', CAST(N'1996-02-08' AS Date), N'01790058492', CAST(N'2010-03-14' AS Date), 45000, N'us-1', CAST(N'2021-01-03T16:24:30.453' AS DateTime))
INSERT [dbo].[employee] ([id], [appid], [full_name], [email], [gender], [address], [birthdate], [phone], [join_date], [salary], [user_id], [updated_at]) VALUES (2, N'em-2', N'asif ahmed', N'asif@gmail.com', N'male', N'dhaka', CAST(N'1998-05-09' AS Date), N'01790058491', CAST(N'2019-05-14' AS Date), 75000, N'us-2', CAST(N'2021-01-03T16:22:32.843' AS DateTime))
INSERT [dbo].[employee] ([id], [appid], [full_name], [email], [gender], [address], [birthdate], [phone], [join_date], [salary], [user_id], [updated_at]) VALUES (3, N'em-3', N'shameem ahmed', N'shameem@gmail.com', N'male', N'chittagong', CAST(N'1998-10-25' AS Date), N'01790058490', CAST(N'2012-10-14' AS Date), 80500, N'us-3', CAST(N'2021-01-03T16:22:32.847' AS DateTime))
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[logins] ON 

INSERT [dbo].[logins] ([id], [appid], [password], [user_id], [updated_at]) VALUES (1, N'lg-1', N'nasimuddin', N'us-1', CAST(N'2021-01-03T16:24:30.453' AS DateTime))
INSERT [dbo].[logins] ([id], [appid], [password], [user_id], [updated_at]) VALUES (2, N'lg-2', N'asifahmed', N'us-2', CAST(N'2021-01-03T16:22:32.843' AS DateTime))
INSERT [dbo].[logins] ([id], [appid], [password], [user_id], [updated_at]) VALUES (3, N'lg-3', N'shameem', N'us-3', CAST(N'2021-01-03T16:22:32.843' AS DateTime))
SET IDENTITY_INSERT [dbo].[logins] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (1, N'pr-1', N'Green Apple', 169, 150, 99, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (10, N'pr-10', N'Beef Boneless', 899, 700, 99, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (11, N'pr-11', N'Catla Fish', 430, 409, 20, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (12, N'pr-12', N'Rui Fish', 350, 329, 30, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (13, N'pr-13', N'Puti Fish', 69, 61, 100, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (14, N'pr-14', N'Coconut', 72, 61, 97, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (15, N'pr-15', N'Chinigura Rice', 100, 95, 100, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-3')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (16, N'pr-16', N'Miniket Rice Premium', 350, 320, 300, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-3')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (17, N'pr-17', N'Aarong Miniket Rice', 385, 330, 300, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-3')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (18, N'pr-18', N'Shezan Mango Juice', 20, 18, 122, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-4')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (19, N'pr-19', N'Nescafe', 350, 300, 122, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-4')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (2, N'pr-2', N'Malta', 179, 156, 24, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (20, N'pr-20', N'Cyprina Grape Juice', 350, 310, 122, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-4')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (21, N'pr-21', N'Orange Juice', 150, 120, 122, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-4')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (22, N'pr-22', N'Odonil Natural Air Freshner', 45, 40, 10, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-5')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (23, N'pr-23', N'Bashundhara Kitchen Towel', 114, 98, 100, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-5')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (24, N'pr-24', N'Oil', 34, 30, 30, CAST(N'2021-01-03T18:01:18.770' AS DateTime), N'ca-17')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (3, N'pr-3', N'Orange', 279, 206, 300, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (4, N'pr-4', N'Amla', 49, 30, 59, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (5, N'pr-5', N'Red Grapes', 105, 100, 25, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (6, N'pr-6', N'Bananna Chompa', 59, 55, 25, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (7, N'pr-7', N'Coconut', 72, 61, 100, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-1')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (8, N'pr-8', N'Beef Bone', 569, 500, 85, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
INSERT [dbo].[products] ([id], [appid], [title], [price], [purchase_price], [quantity], [updated_at], [category_id]) VALUES (9, N'pr-9', N'Boiler Chicken', 219, 180, 120, CAST(N'2021-01-03T16:22:32.840' AS DateTime), N'ca-2')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([id], [appid], [total_price], [quantity], [updated_at], [product_id]) VALUES (1, N'sa-1', 169, 1, CAST(N'2021-01-03T17:54:16.690' AS DateTime), N'pr-1')
INSERT [dbo].[sales] ([id], [appid], [total_price], [quantity], [updated_at], [product_id]) VALUES (2, N'sa-2', 899, 1, CAST(N'2021-01-03T17:54:16.693' AS DateTime), N'pr-10')
INSERT [dbo].[sales] ([id], [appid], [total_price], [quantity], [updated_at], [product_id]) VALUES (3, N'sa-3', 216, 3, CAST(N'2021-01-03T17:54:16.693' AS DateTime), N'pr-14')
INSERT [dbo].[sales] ([id], [appid], [total_price], [quantity], [updated_at], [product_id]) VALUES (4, N'sa-4', 179, 1, CAST(N'2021-01-01T10:10:00.000' AS DateTime), N'pr-2')
INSERT [dbo].[sales] ([id], [appid], [total_price], [quantity], [updated_at], [product_id]) VALUES (5, N'sa-5', 1050, 10, CAST(N'2021-01-01T10:10:00.000' AS DateTime), N'pr-5')
SET IDENTITY_INSERT [dbo].[sales] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [appid], [updated_at], [user_type]) VALUES (1, N'us-1', CAST(N'2021-01-03T16:24:30.450' AS DateTime), N'Admin')
INSERT [dbo].[users] ([id], [appid], [updated_at], [user_type]) VALUES (2, N'us-2', CAST(N'2021-01-03T16:22:32.843' AS DateTime), N'Employee')
INSERT [dbo].[users] ([id], [appid], [updated_at], [user_type]) VALUES (3, N'us-3', CAST(N'2021-01-03T16:22:32.843' AS DateTime), N'Manager')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__employee__AB6E616413F56BBA]    Script Date: 1/3/2021 6:17:20 PM ******/
ALTER TABLE [dbo].[employee] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__employee__B43B145FD6736151]    Script Date: 1/3/2021 6:17:20 PM ******/
ALTER TABLE [dbo].[employee] ADD UNIQUE NONCLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[employee] ADD  DEFAULT ((0)) FOR [salary]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([appid])
GO
ALTER TABLE [dbo].[logins]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([appid])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([appid])
GO
ALTER TABLE [dbo].[sales]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([appid])
GO
USE [master]
GO
ALTER DATABASE [groceryshop] SET  READ_WRITE 
GO

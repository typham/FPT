USE [FPTDb]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 15-04-2017 10:36:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NULL,
	[ListPermission] [varchar](500) NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 15-04-2017 10:36:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
 CONSTRAINT [PK_dbo.ProductCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 15-04-2017 10:36:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 15-04-2017 10:36:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 15-04-2017 10:36:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [nvarchar](100) NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([Id], [RoleID], [ListPermission]) VALUES (1, 1, N'Product-GetAll;Product-GetById;Product-Add;Product-Updatee;Product-Delete')
INSERT [dbo].[Permissions] ([Id], [RoleID], [ListPermission]) VALUES (2, 2, N'Product-GetAll;Product-GetById;Product-Add;Product-Update;Product-Delete')
SET IDENTITY_INSERT [dbo].[Permissions] OFF
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (1, N'Phone')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (2, N'Tablet')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (3, N'Laptop')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (4, N'PC')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (5, N'Product category ...')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (6, N'Product category ...')
INSERT [dbo].[ProductCategory] ([Id], [Name]) VALUES (7, N'Product category ...')
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryID]) VALUES (1, N'Product 1', N'dsfs', 100, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryID]) VALUES (2, N'Product 2', N'dfs', 200, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryID]) VALUES (4, N'Product 3', N'thyt', 500, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryID]) VALUES (5, N'Product 4', N'sdfsd', 500, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [CategoryID]) VALUES (8, N'Product 5', N'aaaab', 500, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [Password], [RoleID]) VALUES (1, N'admin', N'e10adc3949ba59abbe56e057f20f883e', 1)
INSERT [dbo].[Users] ([Id], [Username], [Password], [RoleID]) VALUES (2, N'user1', N'e10adc3949ba59abbe56e057f20f883e', 2)
INSERT [dbo].[Users] ([Id], [Username], [Password], [RoleID]) VALUES (3, N'user2', N'e10adc3949ba59abbe56e057f20f883e', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF

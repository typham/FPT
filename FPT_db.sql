USE [FPTDb]
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

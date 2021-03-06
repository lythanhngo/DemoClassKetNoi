USE [master]
GO
/****** Object:  Database [QLTS]    Script Date: 06/25/2018 19:16:12 ******/
CREATE DATABASE [QLTS]
GO
USE [QLTS]
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKV] [int] NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[UuTien] [float] NULL,
 CONSTRAINT [pk_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [UuTien]) VALUES (1, N'Khu vực 1', 5)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [UuTien]) VALUES (2, N'Khu vực 2', 2)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [UuTien]) VALUES (3, N'Khu vực biên giới hải đảo', 2)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [UuTien]) VALUES (4, N'Khu vực 3', 1)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [UuTien]) VALUES (5, N'Khu vực 4', 0.5)
/****** Object:  Table [dbo].[QUEQUAN]    Script Date: 06/25/2018 19:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUEQUAN](
	[MaQQ] [int] NOT NULL,
	[TenQQ] [nvarchar](50) NULL,
 CONSTRAINT [pk_QUEQUAN] PRIMARY KEY CLUSTERED 
(
	[MaQQ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (1, N'Cần Thơ')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (2, N'Vĩnh Long')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (3, N'Đồng Nai')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (4, N'Bến Tre')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (5, N'Bình Dươg')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (6, N'Đồng Tháp')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (7, N'Long An')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (8, N'Tiền Giang')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (9, N'Sóc Trăng')
INSERT [dbo].[QUEQUAN] ([MaQQ], [TenQQ]) VALUES (10, N'Cà Mau')
/****** Object:  Table [dbo].[TuyenSinhFull]    Script Date: 06/25/2018 19:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenSinhFull](
	[MaTS] [int] NOT NULL,
	[Ho] [nvarchar](40) NULL,
	[Ten] [nvarchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[Phai] [bit] NOT NULL,
	[MaQQ] [int] NULL,
	[MaKV] [int] NULL,
	[TenQQ] [nvarchar](50) NULL,
	[TenKV] [nvarchar](50) NULL,
	[UuTien] [float] NULL,
	[DMon1] [float] NULL,
	[DMon2] [float] NULL,
	[DMon3] [float] NULL,
	[GhiChu] [nvarchar](100) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (1, N'Nguyễn Hoàng', N'Mai', CAST(0x00005A9200000000 AS DateTime), 1, 2, 1, N'Vĩnh Long', N'Khu vực 1', 5, 3, 8, 3, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (2, N'Lê Văn', N'Sáng', CAST(0x000079F300000000 AS DateTime), 1, 2, 2, N'Vĩnh Long', N'Khu vực 2', 2, 3, 0, 1.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (3, N'Mai Thị Ánh', N'Phương', CAST(0x00007D2F00000000 AS DateTime), 0, 3, 3, N'Đồng Nai', N'Khu vực biên giới hải đảo', 2, 8, 0, 6, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (4, N'Nguyễn Thị Mai', N'Trang', CAST(0x0000805400000000 AS DateTime), 0, 2, 4, N'Vĩnh Long', N'Khu vực 3', 1, 7, 9, 1, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (5, N'Nguyễn Thị Minh', N'Minh', CAST(0x00007FEA00000000 AS DateTime), 0, 5, 5, N'Bình Dươg', N'Khu vực 4', 0.5, 5, 5, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (6, N'Lê Văn', N'Thái', CAST(0x0000780C00000000 AS DateTime), 1, 6, 1, N'Đồng Tháp', N'Khu vực 1', 5, 7, 9, 8, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (7, N'Nguyễn Thị Anh', N'Đào', CAST(0x00007EF300000000 AS DateTime), 0, 7, 2, N'Long An', N'Khu vực 2', 2, 4.5, 3.5, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (8, N'Nguyễn Anh', N'Dũng', CAST(0x00007E0000000000 AS DateTime), 1, 8, 3, N'Tiền Giang', N'Khu vực biên giới hải đảo', 2, 7, 9, 6, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (9, N'Nguyễn Ánh', N'Tuyết', CAST(0x00007FE000000000 AS DateTime), 0, 9, 4, N'Sóc Trăng', N'Khu vực 3', 1, 2.5, 4.5, 9, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (10, N'Nguyễn Thị', N'Duyên', CAST(0x000079D600000000 AS DateTime), 0, 10, 5, N'Cà Mau', N'Khu vực 4', 0.5, 8, 9, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (11, N'Nguyễn Văn', N'Bình', CAST(0x00007E9900000000 AS DateTime), 1, 1, 1, N'Cần Thơ', N'Khu vực 1', 5, 8, 8, 8, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (12, N'Nguyễn Thị Anh', N'Đào', CAST(0x00007F8100000000 AS DateTime), 0, 2, 1, N'Vĩnh Long', N'Khu vực 1', 5, 8, 1, 1, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (13, N'Nguyễn Văn', N'Tiến', CAST(0x00007DF800000000 AS DateTime), 1, 2, 2, N'Vĩnh Long', N'Khu vực 2', 2, 8, 0.5, 3.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (14, N'Nguyễn Anh', N'Tú', CAST(0x00007D0F00000000 AS DateTime), 1, 3, 3, N'Đồng Nai', N'Khu vực biên giới hải đảo', 2, 8, 2, 3.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (15, N'Nguyễn Tấn', N'Phước', CAST(0x00007A1600000000 AS DateTime), 0, 3, 4, N'Đồng Nai', N'Khu vực 3', 1, 4, 6, 5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (16, N'Trần Anh', N'Tuấn', CAST(0x00007A9B00000000 AS DateTime), 1, 4, 5, N'Bến Tre', N'Khu vực 4', 0.5, 8, 6, 4, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (17, N'Trần Xuân', N'Hồng', CAST(0x0000815700000000 AS DateTime), 1, 5, 2, N'Bình Dươg', N'Khu vực 2', 2, 8, 6, 2, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (18, N'Trần Anh', N'Dũng', CAST(0x00007E7C00000000 AS DateTime), 1, 6, 1, N'Đồng Tháp', N'Khu vực 1', 5, 8, 6, 3, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (19, N'Nguyễn Anh', N'Quân', CAST(0x00007FDF00000000 AS DateTime), 1, 1, 1, N'Cần Thơ', N'Khu vực 1', 5, 8, 5, 1.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (20, N'Nguyễn Văn', N'Thỏ', CAST(0x00007D7400000000 AS DateTime), 1, 2, 3, N'Vĩnh Long', N'Khu vực biên giới hải đảo', 2, 4, 8, 0, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (21, N'Nguyễn Tấn', N'Phước', CAST(0x00007E7200000000 AS DateTime), 0, 3, 1, N'Đồng Nai', N'Khu vực 1', 5, 7, 7, 7, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (22, N'Mai Hoàng', N'Mai', CAST(0x0000793900000000 AS DateTime), 1, 7, 2, N'Long An', N'Khu vực 2', 2, 5, 4, 0, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (23, N'Hoàng', N'Hoa', CAST(0x000079F800000000 AS DateTime), 0, 9, 3, N'Sóc Trăng', N'Khu vực biên giới hải đảo', 2, 5, 6, 4, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (24, N'Mai Văn', N'Ân', CAST(0x00007E5300000000 AS DateTime), 1, 2, 3, N'Vĩnh Long', N'Khu vực biên giới hải đảo', 2, 8, 9, 6, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (25, N'Nguyễn Thị Hồng', N'Thuý', CAST(0x00007E6D00000000 AS DateTime), 0, 6, 3, N'Đồng Tháp', N'Khu vực biên giới hải đảo', 2, 10, 10, 10, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (26, N'Võ Thị Cẩm', N'Duyên', CAST(0x00007CA700000000 AS DateTime), 0, 5, 2, N'Bình Dươg', N'Khu vực 2', 2, 7, 0, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (27, N'Lê Xuân', N'Hoà', CAST(0x00007C4A00000000 AS DateTime), 0, 4, 1, N'Bến Tre', N'Khu vực 1', 5, 9, 0, 8, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (28, N'Nguyễn Thị Mai', N'Phương', CAST(0x00007E5D00000000 AS DateTime), 0, 1, 2, N'Cần Thơ', N'Khu vực 2', 2, 7, 2.5, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (29, N'Lê An', N'An', CAST(0x00007CB000000000 AS DateTime), 0, 4, 5, N'Bến Tre', N'Khu vực 4', 0.5, 8, 9, 9, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (30, N'Nguyễn Văn', N'Tú', CAST(0x00007F6C00000000 AS DateTime), 1, 8, 4, N'Tiền Giang', N'Khu vực 3', 1, 1, 2.5, 3.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (31, N'Nguyễn Minh', N'Hằng', CAST(0x00007B9200000000 AS DateTime), 0, 9, 1, N'Sóc Trăng', N'Khu vực 1', 5, 8, 1, 2.5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (32, N'Lê Văn', N'Hai', CAST(0x000080C000000000 AS DateTime), 1, 2, 1, N'Vĩnh Long', N'Khu vực 1', 5, 10, 10, 10, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (33, N'Lê Thị ', N'Hoa', CAST(0x0000815000000000 AS DateTime), 0, 4, 5, N'Bến Tre', N'Khu vực 4', 0.5, 6, 7, 5, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (34, N'Trần Thị ', N'Quyên', CAST(0x00007C9000000000 AS DateTime), 0, 5, 5, N'Bình Dươg', N'Khu vực 4', 0.5, 5, 4, 6, NULL)
INSERT [dbo].[TuyenSinhFull] ([MaTS], [Ho], [Ten], [NgaySinh], [Phai], [MaQQ], [MaKV], [TenQQ], [TenKV], [UuTien], [DMon1], [DMon2], [DMon3], [GhiChu]) VALUES (35, N'Ngô Thị Tuyết', N'Vân', CAST(0x0000732200000000 AS DateTime), 0, 7, 1, N'Long An', N'Khu vực 1', 5, 6, 7, 9, NULL)
/****** Object:  Table [dbo].[THISINH]    Script Date: 06/25/2018 19:16:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THISINH](
	[MaTS] [int] NOT NULL,
	[Ho] [nvarchar](100) NULL,
	[Ten] [nvarchar](100) NULL,
	[Phai] [bit] NULL,
	[NS] [datetime] NULL,
	[MaKV] [int] NULL,
	[MaQQ] [int] NULL,
 CONSTRAINT [pk_THISINH] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (1, N'Nguyễn Hoàng', N'Mai', 1, CAST(0x00005A9200000000 AS DateTime), 1, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (2, N'Lê Văn', N'Sáng', 1, CAST(0x000079F300000000 AS DateTime), 2, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (3, N'Mai Thị Ánh', N'Phương', 0, CAST(0x00007D2F00000000 AS DateTime), 3, 3)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (4, N'Nguyễn Thị Mai', N'Trang', 0, CAST(0x0000805400000000 AS DateTime), 4, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (5, N'Nguyễn Thị Minh', N'Minh', 0, CAST(0x00007FEA00000000 AS DateTime), 5, 5)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (6, N'Lê Văn', N'Thái', 1, CAST(0x0000780C00000000 AS DateTime), 1, 6)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (7, N'Nguyễn Thị Anh', N'Đào', 0, CAST(0x00007EF300000000 AS DateTime), 2, 7)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (8, N'Nguyễn Anh', N'Dũng', 1, CAST(0x00007E0000000000 AS DateTime), 3, 8)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (9, N'Nguyễn Ánh', N'Tuyết', 0, CAST(0x00007FE000000000 AS DateTime), 4, 9)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (10, N'Nguyễn Thị', N'Duyên', 0, CAST(0x000079D600000000 AS DateTime), 5, 10)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (11, N'Nguyễn Văn', N'Bình', 1, CAST(0x00007E9900000000 AS DateTime), 1, 1)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (12, N'Nguyễn Thị Anh', N'Đào', 0, CAST(0x00007F8100000000 AS DateTime), 1, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (13, N'Nguyễn Văn', N'Tiến', 1, CAST(0x00007DF800000000 AS DateTime), 2, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (14, N'Nguyễn Anh', N'Tú', 1, CAST(0x00007D0F00000000 AS DateTime), 3, 3)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (15, N'Nguyễn Tấn', N'Phước', 0, CAST(0x00007A1600000000 AS DateTime), 4, 3)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (16, N'Trần Anh', N'Tuấn', 1, CAST(0x00007A9B00000000 AS DateTime), 5, 4)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (17, N'Trần Xuân', N'Hồng', 1, CAST(0x0000815700000000 AS DateTime), 2, 5)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (18, N'Trần Anh', N'Dũng', 1, CAST(0x00007E7C00000000 AS DateTime), 1, 6)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (19, N'Nguyễn Anh', N'Quân', 1, CAST(0x00007FDF00000000 AS DateTime), 1, 1)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (20, N'Nguyễn Văn', N'Thỏ', 1, CAST(0x00007D7400000000 AS DateTime), 3, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (21, N'Nguyễn Tấn', N'Phước', 0, CAST(0x00007E7200000000 AS DateTime), 1, 3)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (22, N'Mai Hoàng', N'Mai', 1, CAST(0x0000793900000000 AS DateTime), 2, 7)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (23, N'Hoàng', N'Hoa', 0, CAST(0x000079F800000000 AS DateTime), 3, 9)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (24, N'Mai Văn', N'Ân', 1, CAST(0x00007E5300000000 AS DateTime), 3, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (25, N'Nguyễn Thị Hồng', N'Thuý', 0, CAST(0x00007E6D00000000 AS DateTime), 3, 6)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (26, N'Võ Thị Cẩm', N'Duyên', 0, CAST(0x00007CA700000000 AS DateTime), 2, 5)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (27, N'Lê Xuân', N'Hoà', 0, CAST(0x00007C4A00000000 AS DateTime), 1, 4)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (28, N'Nguyễn Thị Mai', N'Phương', 0, CAST(0x00007E5D00000000 AS DateTime), 2, 1)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (29, N'Lê An', N'An', 0, CAST(0x00007CB000000000 AS DateTime), 5, 4)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (30, N'Nguyễn Văn', N'Tú', 1, CAST(0x00007F6C00000000 AS DateTime), 4, 8)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (31, N'Nguyễn Minh', N'Hằng', 0, CAST(0x00007B9200000000 AS DateTime), 1, 9)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (32, N'Lê Văn', N'Hai', 1, CAST(0x000080C000000000 AS DateTime), 1, 2)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (33, N'Lê Thị ', N'Hoa', 0, CAST(0x0000815000000000 AS DateTime), 5, 4)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (34, N'Trần Thị ', N'Quyên', 0, CAST(0x00007C9000000000 AS DateTime), 5, 5)
INSERT [dbo].[THISINH] ([MaTS], [Ho], [Ten], [Phai], [NS], [MaKV], [MaQQ]) VALUES (35, N'Ngô Thị Tuyết', N'Vân', 0, CAST(0x0000732200000000 AS DateTime), 1, 7)
/****** Object:  StoredProcedure [dbo].[themkhuvuc]    Script Date: 06/25/2018 19:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[themkhuvuc] (@ma int, @ten nvarchar(50), @uutien float)
As
Begin
	Insert Into KHUVUC(MaKV, TenKV, UuTien) values (@ma, @ten, @uutien)
End
GO
/****** Object:  Table [dbo].[KQTS]    Script Date: 06/25/2018 19:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQTS](
	[MaTS] [int] NOT NULL,
	[DMon1] [float] NULL,
	[DMon2] [float] NULL,
	[DMon3] [float] NULL,
	[Ghichu] [nvarchar](100) NULL,
 CONSTRAINT [pk_KQTS] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (1, 3, 8, 3, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (2, 3, 0, 1.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (3, 8, 0, 6, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (4, 7, 9, 1, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (5, 5, 5, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (6, 7, 9, 8, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (7, 4.5, 3.5, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (8, 7, 9, 6, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (9, 2.5, 4.5, 9, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (10, 8, 9, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (11, 8, 8, 8, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (12, 8, 1, 1, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (13, 8, 0.5, 3.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (14, 8, 2, 3.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (15, 4, 6, 5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (16, 8, 6, 4, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (17, 8, 6, 2, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (18, 8, 6, 3, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (19, 8, 5, 1.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (20, 4, 8, 0, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (21, 7, 7, 7, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (22, 5, 4, 0, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (23, 5, 6, 4, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (24, 8, 9, 6, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (25, 10, 10, 10, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (26, 7, 0, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (27, 9, 0, 8, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (28, 7, 2.5, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (29, 8, 9, 9, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (30, 1, 2.5, 3.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (31, 8, 1, 2.5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (32, 10, 10, 10, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (33, 6, 7, 5, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (34, 5, 4, 6, NULL)
INSERT [dbo].[KQTS] ([MaTS], [DMon1], [DMon2], [DMon3], [Ghichu]) VALUES (35, 6, 7, 9, NULL)
/****** Object:  View [dbo].[Cau4]    Script Date: 06/25/2018 19:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[Cau4]
As
	SELECT ts.Ho, ts.Ten, kv.TenKV, qq.TenQQ, ts.NS, ts.Phai,(kq.DMon1+kq.DMon2+kq.DMon3) AS DIEMTONG
	FROM QUEQUAN qq, THISINH ts, KHUVUC kv, KQTS kq
	WHERE
		ts.MaKV = kv.MaKV AND
		ts.MaQQ = qq.MaQQ AND
		ts.MaTS = kq.MaTS AND
		kv.TenKV = N'Khu vực 1' AND
		qq.TenQQ = N'Vĩnh Long' AND
		(kq.DMon1+kq.DMon2+kq.DMon3) >= 15
	GROUP BY
		ts.Ho, ts.Ten, kv.TenKV, qq.TenQQ, ts.NS, ts.Phai,kq.DMon1,kq.DMon2,kq.DMon3
GO
/****** Object:  ForeignKey [lk_TS_KV]    Script Date: 06/25/2018 19:16:13 ******/
ALTER TABLE [dbo].[THISINH]  WITH CHECK ADD  CONSTRAINT [lk_TS_KV] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THISINH] CHECK CONSTRAINT [lk_TS_KV]
GO
/****** Object:  ForeignKey [lk_TS_QQ]    Script Date: 06/25/2018 19:16:13 ******/
ALTER TABLE [dbo].[THISINH]  WITH CHECK ADD  CONSTRAINT [lk_TS_QQ] FOREIGN KEY([MaQQ])
REFERENCES [dbo].[QUEQUAN] ([MaQQ])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THISINH] CHECK CONSTRAINT [lk_TS_QQ]
GO
/****** Object:  ForeignKey [lk_TS_KQ]    Script Date: 06/25/2018 19:16:15 ******/
ALTER TABLE [dbo].[KQTS]  WITH CHECK ADD  CONSTRAINT [lk_TS_KQ] FOREIGN KEY([MaTS])
REFERENCES [dbo].[THISINH] ([MaTS])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KQTS] CHECK CONSTRAINT [lk_TS_KQ]
GO

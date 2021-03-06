ALTER TABLE [dbo].[Telefon] DROP CONSTRAINT [FK_Telefon_KontaktOsoba]
GO
ALTER TABLE [dbo].[Mail] DROP CONSTRAINT [FK_Mail_KontaktOsoba]
GO
ALTER TABLE [dbo].[KontaktOsoba] DROP CONSTRAINT [FK_KontaktOsoba_Skola]
GO
/****** Object:  Table [dbo].[Telefon]    Script Date: 21/12/2018 19:11:19 ******/
DROP TABLE [dbo].[Telefon]
GO
/****** Object:  Table [dbo].[Skola]    Script Date: 21/12/2018 19:11:19 ******/
DROP TABLE [dbo].[Skola]
GO
/****** Object:  Table [dbo].[Mail]    Script Date: 21/12/2018 19:11:19 ******/
DROP TABLE [dbo].[Mail]
GO
/****** Object:  Table [dbo].[KontaktOsoba]    Script Date: 21/12/2018 19:11:19 ******/
DROP TABLE [dbo].[KontaktOsoba]
GO
/****** Object:  Table [dbo].[KontaktOsoba]    Script Date: 21/12/2018 19:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KontaktOsoba](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[RadnoMesto] [nvarchar](50) NULL,
	[IdSkola] [int] NULL,
 CONSTRAINT [PK_KontaktOsoba] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mail]    Script Date: 21/12/2018 19:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Oznaka] [nvarchar](50) NULL,
	[Adresa] [nvarchar](50) NULL,
	[IdKontaktOsoba] [int] NULL,
 CONSTRAINT [PK_Mail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skola]    Script Date: 21/12/2018 19:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skola](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NazivSkole] [nvarchar](50) NULL,
	[AdresaSkole] [nvarchar](50) NULL,
	[Opstina] [nvarchar](50) NULL,
	[PostanskiBroj] [int] NULL,
	[MaticniBroj] [nvarchar](50) NULL,
	[PIB] [nvarchar](50) NULL,
	[BrojRacuna] [nvarchar](50) NULL,
	[WebStranica] [nvarchar](50) NULL,
	[Pecat] [nvarchar](50) NULL,
	[Beleska] [nvarchar](50) NULL,
 CONSTRAINT [PK_Skola] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefon]    Script Date: 21/12/2018 19:11:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Oznaka] [nvarchar](50) NULL,
	[Broj] [nvarchar](50) NULL,
	[Lokal] [nvarchar](50) NULL,
	[IdKontaktOsoba] [int] NULL,
 CONSTRAINT [PK_Telefon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KontaktOsoba] ON 

INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1235, N'Ivana', N'Slovic', N'dev', 1)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1236, N'Marija', N'Markovic', N'Dizajner', NULL)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1237, N'Jovan', N'Jankovic', N'domar', 1)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1238, N'Luka', N'Dogandzic', N'Direktor', NULL)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1239, N'Stefan', N'Stefanovic', N'Menadzer', NULL)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1240, N'Katarina', N'Prijovic', N'marketing', NULL)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1241, N'Luka', N'Dogandzic', N'Direktor', NULL)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1242, N'Nikolina', N'Grabovica', N'Menadzer', 2)
INSERT [dbo].[KontaktOsoba] ([Id], [Ime], [Prezime], [RadnoMesto], [IdSkola]) VALUES (1244, N'Andjelija', N'Mihajlovic', N'Cistacica', 1)
SET IDENTITY_INSERT [dbo].[KontaktOsoba] OFF
SET IDENTITY_INSERT [dbo].[Mail] ON 

INSERT [dbo].[Mail] ([Id], [Oznaka], [Adresa], [IdKontaktOsoba]) VALUES (2, N'Privatni', N'ivana@gmail.com', 1235)
INSERT [dbo].[Mail] ([Id], [Oznaka], [Adresa], [IdKontaktOsoba]) VALUES (3, N'Poslovni', N'marija90@gmail.com', 1236)
INSERT [dbo].[Mail] ([Id], [Oznaka], [Adresa], [IdKontaktOsoba]) VALUES (9, N'Poslovni', N'nikolinag@gmail.co', 1242)
INSERT [dbo].[Mail] ([Id], [Oznaka], [Adresa], [IdKontaktOsoba]) VALUES (11, N'Privatni', N'jovanj@gmail.com', 1237)
SET IDENTITY_INSERT [dbo].[Mail] OFF
SET IDENTITY_INSERT [dbo].[Skola] ON 

INSERT [dbo].[Skola] ([Id], [NazivSkole], [AdresaSkole], [Opstina], [PostanskiBroj], [MaticniBroj], [PIB], [BrojRacuna], [WebStranica], [Pecat], [Beleska]) VALUES (1, N'Osnovna škola Vuk Karadžić', N'Nemanjina 125', N'Beograd(Stari Grad)', 11000, N'07002912', N'101953815', N'205-5468716-17', N'http://www.osnovnaskolavukkaradzic.edu.rs/', N'pecat.jpg', N'Nema')
INSERT [dbo].[Skola] ([Id], [NazivSkole], [AdresaSkole], [Opstina], [PostanskiBroj], [MaticniBroj], [PIB], [BrojRacuna], [WebStranica], [Pecat], [Beleska]) VALUES (2, N'Osnovna skola Josif Pancic', N'Pozeska 52', N'Beograd(Cukarica)', 11030, N'07014317', N'101014076', N'145-88547894-', N'http://www.osjosifpancic.rs/', N'pecatJP.jpg', N'Nema beleske')
SET IDENTITY_INSERT [dbo].[Skola] OFF
SET IDENTITY_INSERT [dbo].[Telefon] ON 

INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (112, N'Privatni', N'0646565656', N'+381', 1235)
INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (113, N'Poslovni', N'065555333', N'+381', 1236)
INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (114, N'Poslovni', N'0648887771', N'+381', 1235)
INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (115, N'Privatni', N'+381', N'55555', 1240)
INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (116, N'Poslovni', N'06488877712', N'+381', 1242)
INSERT [dbo].[Telefon] ([Id], [Oznaka], [Broj], [Lokal], [IdKontaktOsoba]) VALUES (118, N'Poslovni', N'0648887771', N'+381', 1237)
SET IDENTITY_INSERT [dbo].[Telefon] OFF
ALTER TABLE [dbo].[KontaktOsoba]  WITH CHECK ADD  CONSTRAINT [FK_KontaktOsoba_Skola] FOREIGN KEY([IdSkola])
REFERENCES [dbo].[Skola] ([Id])
GO
ALTER TABLE [dbo].[KontaktOsoba] CHECK CONSTRAINT [FK_KontaktOsoba_Skola]
GO
ALTER TABLE [dbo].[Mail]  WITH CHECK ADD  CONSTRAINT [FK_Mail_KontaktOsoba] FOREIGN KEY([IdKontaktOsoba])
REFERENCES [dbo].[KontaktOsoba] ([Id])
GO
ALTER TABLE [dbo].[Mail] CHECK CONSTRAINT [FK_Mail_KontaktOsoba]
GO
ALTER TABLE [dbo].[Telefon]  WITH CHECK ADD  CONSTRAINT [FK_Telefon_KontaktOsoba] FOREIGN KEY([IdKontaktOsoba])
REFERENCES [dbo].[KontaktOsoba] ([Id])
GO
ALTER TABLE [dbo].[Telefon] CHECK CONSTRAINT [FK_Telefon_KontaktOsoba]
GO

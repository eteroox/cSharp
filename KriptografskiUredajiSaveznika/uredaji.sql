USE [master]
GO
/****** Object:  Database [uredaji]    Script Date: 01/09/2017 14:24:18 ******/
CREATE DATABASE [uredaji] ON  PRIMARY 
( NAME = N'uredaji', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\uredaji.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'uredaji_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\uredaji_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [uredaji] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [uredaji].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [uredaji] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [uredaji] SET ANSI_NULLS OFF
GO
ALTER DATABASE [uredaji] SET ANSI_PADDING OFF
GO
ALTER DATABASE [uredaji] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [uredaji] SET ARITHABORT OFF
GO
ALTER DATABASE [uredaji] SET AUTO_CLOSE ON
GO
ALTER DATABASE [uredaji] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [uredaji] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [uredaji] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [uredaji] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [uredaji] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [uredaji] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [uredaji] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [uredaji] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [uredaji] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [uredaji] SET  ENABLE_BROKER
GO
ALTER DATABASE [uredaji] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [uredaji] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [uredaji] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [uredaji] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [uredaji] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [uredaji] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [uredaji] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [uredaji] SET  READ_WRITE
GO
ALTER DATABASE [uredaji] SET RECOVERY SIMPLE
GO
ALTER DATABASE [uredaji] SET  MULTI_USER
GO
ALTER DATABASE [uredaji] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [uredaji] SET DB_CHAINING OFF
GO
USE [uredaji]
GO
/****** Object:  Table [dbo].[typex]    Script Date: 01/09/2017 14:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[typex](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[slovo] [varchar](10) NULL,
	[sifra] [varchar](10) NULL,
	[sigabaSifra] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[typex] ON
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (1, N'a', N'1t11', N'1s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (2, N'b', N'1t12', N'2s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (3, N'c', N'1t13', N'3s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (4, N'd', N'1t14', N'4s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (5, N'e', N'1t15', N'5s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (6, N'f', N'1t16', N'6s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (7, N'g', N'1t17', N'7s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (8, N'h', N'1t18', N'8s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (9, N'i', N'1t19', N'9s')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (10, N'j', N'1t20', N'as')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (11, N'k', N'2t10', N'bs')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (12, N'l', N'2t11', N'cs')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (13, N'm', N'2t12', N'ds')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (14, N'n', N'2t13', N'es')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (15, N'o', N'2t14', N'fs')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (16, N'p', N'2t15', N's1')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (17, N'q', N'3t10', N's2')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (18, N'r', N'3t11', N's3')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (19, N's', N'3t12', N's4')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (20, N't', N'3t13', N's5')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (21, N'u', N'3t14', N's6')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (22, N'v', N'3t15', N's7')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (23, N'w', N'3t16', N's8')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (24, N'x', N'3t17', N's9')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (25, N'y', N'3t18', N'sa')
INSERT [dbo].[typex] ([id], [slovo], [sifra], [sigabaSifra]) VALUES (26, N'z', N'3t19', N'sb')
SET IDENTITY_INSERT [dbo].[typex] OFF
/****** Object:  Table [dbo].[pravila]    Script Date: 01/09/2017 14:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pravila](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pravilo] [text] NULL,
	[opis] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[pravila] ON
INSERT [dbo].[pravila] ([id], [pravilo], [opis]) VALUES (1, N'U zadatku je potrebno za dobiveni sifrirani kod odrediti pozicije rotora i text koji je potrebno upisati i potvrditi da bi se poruka desifrirala. Sve potrebne informacije se nalaze u trenutno otvorenim prozorima. Oprez kad ugasite zadatak postoji mogucnost da se isti nece ponovo prikazati !', N'Typex je Britanski stroj za sifriranje koji se koristio od 1937. , a bio je adaptacija njemacke Enigme s nizom poboljsanja koja su uvelike povecala njegovu sigurnost . Typex Mark 22/23 su bili modificirani na nacin da povecauju sigurnost pri komunikaciji te da budu kompatibilni sa Njemackom enigmom. Presretnute poruke su se dekriptirale uz pomoc istih . Typex se sastojao od pet rotora od kojih su dva bila staticka te tri dinamicka. Svaki kotac na rotoru se sastojao od dvadeset I sest slova . Mark 23 se kasnije koristio za komunikaciju izmedu Amerikanaca I Britanaca te je I nakon rata ostao u upotrebi.')
INSERT [dbo].[pravila] ([id], [pravilo], [opis]) VALUES (2, N'Potrebno je dobiveni tekst desifrirati pomocu dane tablice te dobiveni tekst unjeti i potvrditi', N'Sigaba je stroj za sifriranje koji je koristila Amerika I prije ulaska u drugi svijetski rat. Bila je daleko naprednija od enigma I typexa. Koristila se sa 15 rotora . Tih 15 rotora se dijelilo u 3 skupine : 5 sifrirnih rotora , 5 index rotora I 5 kontrolnih rotora. Otvoreni tekst se unosio preko tipkovnice . Nakon ulaska Amerike u rat sigaba je bila modificirana sa ccmom kako bi mogla komunicirati sa britanskim typexom. Za razliku od Britanske verzije ccm typexa , sigaba je mogla u bilo kojem trenutku izvaditi ccm dio I nastaviti se koristiti kao sigaba. Sigaba je bila u uporabi jos mnogo godina poslije rata .')
INSERT [dbo].[pravila] ([id], [pravilo], [opis]) VALUES (3, N'Uvod', N'Kriptografski uredaji saveznika su uredaji koje su saveznici koristili pri medusobnoj komunikaciji I pri desifriranju presretenih poruka . Britanci su koristili Typex koji je zapravo preinacena Njemacka enigma dok su Amerikanci koristili vlastiti stroj koji se zvao Sigaba. Nakon sto su Amerikanci usli u rat doslo je do potrebe za medusobnom komunikacijom izmedu saveznika ( preciznije Amerikanaca I Britanaca ) te je osmisljen CCM stroj. S obzirom da Amerikanci nisu htjeli dijeliti Sigabu napravili posebno CCM dio za Typex I CCM dio za Sigabu kako bi bili kompatibilni I mogli komunicirati.')
SET IDENTITY_INSERT [dbo].[pravila] OFF
/****** Object:  Table [dbo].[poruke]    Script Date: 01/09/2017 14:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[poruke](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sifrirano] [text] NULL,
	[desifrirano] [text] NULL,
	[konacno] [text] NULL,
	[sifriranoSigaba] [text] NULL,
	[greska] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[poruke] ON
INSERT [dbo].[poruke] ([id], [sifrirano], [desifrirano], [konacno], [sifriranoSigaba], [greska]) VALUES (1, N'1t143t151t11 3t153t111t112t151t131t11 2t131t11 1t201t151t142t132t141t20 1t173t111t112t131t19', N'dva vrapca na jednoj grani stoje', N'Napad na normandiju u 10', N'4ss71s s7s31ss13s1s es1s as5s4sesfsas 7ss31ses9s s4s5s2as5s', N'45276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373452763386667122513502037021536835365768228423086862601785635919657796232806531734164700285647306887857727039497094396266591984776431591426642998813374263583356122048442755979988305757326811032181493734527633866671225135020370215368353657682284230868626017856359196577962328065317341647002856473068878577270394970943962665919847764315914266429988133742635833561220484427559799883057573268110321814937345276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373')
INSERT [dbo].[poruke] ([id], [sifrirano], [desifrirano], [konacno], [sifriranoSigaba], [greska]) VALUES (2, N'3t133t111t19 2t103t111t113t151t15 3t14 1t201t151t142t132t141t20 3t123t131t112t111t19', N'tri krave u jednoj stali', N'Sutra pocinje prodor u Rusiju', N's5s39s bss31ss75s s6 as5s4sesfsas s4s51scs9s', N'45276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373452763386667122513502037021536835365768228423086862601785635919657796232806531734164700285647306887857727039497094396266591984776431591426642998813374263583356122048442755979988305757326811032181493734527633866671225135020370215368353657682284230868626017856359196577962328065317341647002856473068878577270394970943962665919847764315914266429988133742635833561220484427559799883057573268110321814937345276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373')
INSERT [dbo].[poruke] ([id], [sifrirano], [desifrirano], [konacno], [sifriranoSigaba], [greska]) VALUES (3, N'3t133t111t19 2t121t111t132t101t16 3t121t15 2t103t111t111t20 1t201t151t142t132t132t141t17 2t101t112t121t192t131t11 17173t111t191t203t14', N'Tri macke se kraj jednog kamina griju', N'Bravo Bravo Bravo', N's5s39s ds1s3sbs5s s45s 6ss31s as5s4sesfs7s bs1sds9ses1s 7ss39sass6', N'45276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373452763386667122513502037021536835365768228423086862601785635919657796232806531734164700285647306887857727039497094396266591984776431591426642998813374263583356122048442755979988305757326811032181493734527633866671225135020370215368353657682284230868626017856359196577962328065317341647002856473068878577270394970943962665919847764315914266429988133742635833561220484427559799883057573268110321814937345276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373')
INSERT [dbo].[poruke] ([id], [sifrirano], [desifrirano], [konacno], [sifriranoSigaba], [greska]) VALUES (4, N'1t143t151t11 2t153t121t11 2t131t11 3t133t112t141t201t191t133t14 3t111t111t142t131t192t101t11 2t111t111t203t14', N'dva psa na trojicu radnika laju', N'Uspjesno desifrirana poruka ( ovo je ta poruka )', N'4ss71a s1s41s es1s s5s3fsas9s3ss6 s31s4ses9sbs1s cs1aass6', N'45276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373452763386667122513502037021536835365768228423086862601785635919657796232806531734164700285647306887857727039497094396266591984776431591426642998813374263583356122048442755979988305757326811032181493734527633866671225135020370215368353657682284230868626017856359196577962328065317341647002856473068878577270394970943962665919847764315914266429988133742635833561220484427559799883057573268110321814937345276338666712251350203702153683536576822842308686260178563591965779623280653173416470028564730688785772703949709439626659198477643159142664299881337426358335612204844275597998830575732681103218149373')
SET IDENTITY_INSERT [dbo].[poruke] OFF

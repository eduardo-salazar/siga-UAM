USE [master]
GO
/****** Object:  Database [uam_agenda]    Script Date: 31/10/2012 12:39:34 a.m. ******/
CREATE DATABASE [uam_agenda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'uam_agenda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\uam_agenda.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'uam_agenda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\uam_agenda_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [uam_agenda] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [uam_agenda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [uam_agenda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [uam_agenda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [uam_agenda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [uam_agenda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [uam_agenda] SET ARITHABORT OFF 
GO
ALTER DATABASE [uam_agenda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [uam_agenda] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [uam_agenda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [uam_agenda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [uam_agenda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [uam_agenda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [uam_agenda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [uam_agenda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [uam_agenda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [uam_agenda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [uam_agenda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [uam_agenda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [uam_agenda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [uam_agenda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [uam_agenda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [uam_agenda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [uam_agenda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [uam_agenda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [uam_agenda] SET RECOVERY FULL 
GO
ALTER DATABASE [uam_agenda] SET  MULTI_USER 
GO
ALTER DATABASE [uam_agenda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [uam_agenda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [uam_agenda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [uam_agenda] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'uam_agenda', N'ON'
GO
USE [uam_agenda]
GO
/****** Object:  User [sai]    Script Date: 31/10/2012 12:39:35 a.m. ******/
CREATE USER [sai] FOR LOGIN [sai] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sai]
GO
/****** Object:  Table [dbo].[alerta]    Script Date: 31/10/2012 12:39:35 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alerta](
	[id_alerta] [int] IDENTITY(1,1) NOT NULL,
	[id_aula] [int] NOT NULL,
	[descripcion] [ntext] NULL,
	[fecha_evento] [datetime] NOT NULL,
	[fecha_recordatorio] [datetime] NOT NULL,
	[observaciones] [ntext] NULL,
	[id_alerta_estado] [int] NULL,
 CONSTRAINT [PK_alerta] PRIMARY KEY CLUSTERED 
(
	[id_alerta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[alerta_estado]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alerta_estado](
	[id_alerta_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_alerta_estado] PRIMARY KEY CLUSTERED 
(
	[id_alerta_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asignacion_clase]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignacion_clase](
	[id_asignacion] [int] IDENTITY(1,1) NOT NULL,
	[id_aula] [int] NOT NULL,
	[id_grupo] [int] NOT NULL,
	[inicio] [datetime] NOT NULL,
	[fin] [datetime] NOT NULL,
 CONSTRAINT [PK_asignacion_clase] PRIMARY KEY CLUSTERED 
(
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[asignacion_varios]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignacion_varios](
	[id_asignacion] [int] IDENTITY(1,1) NOT NULL,
	[id_aula] [int] NOT NULL,
	[inicio] [datetime] NOT NULL,
	[fin] [datetime] NOT NULL,
	[id_tipo_uso] [int] NOT NULL,
	[observaciones] [ntext] NULL,
 CONSTRAINT [PK_asignacion_varios] PRIMARY KEY CLUSTERED 
(
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[asignatura]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asignatura](
	[id_asignatura] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[id_facultad] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
 CONSTRAINT [PK_asignatura] PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asignatura_categoria]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asignatura_categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_asignatura_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aula]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo] [int] NOT NULL,
	[descripcion] [varchar](6) NOT NULL,
	[capacidad] [int] NULL,
	[id_edificio] [int] NOT NULL,
	[piso] [int] NOT NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_aula] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aula_equipo]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula_equipo](
	[id_aula] [int] NOT NULL,
	[id_equipo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[observaciones] [ntext] NULL,
 CONSTRAINT [PK_aula_equipo] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC,
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aula_estado]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aula_estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_aula_estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aula_tipo]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aula_tipo](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_aula] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aula_tipo_uso]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aula_tipo_uso](
	[id_tipo_uso] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_aula_tipo_uso] PRIMARY KEY CLUSTERED 
(
	[id_tipo_uso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[docente]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[docente](
	[id_docente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_docente] PRIMARY KEY CLUSTERED 
(
	[id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[edificio]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edificio](
	[id_edificio] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_edificio] PRIMARY KEY CLUSTERED 
(
	[id_edificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[equipo]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipo](
	[id_equipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[observacion] [ntext] NULL,
 CONSTRAINT [PK_equipo] PRIMARY KEY CLUSTERED 
(
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facultad]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facultad](
	[id_facultad] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_facultad] PRIMARY KEY CLUSTERED 
(
	[id_facultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[grupo]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupo](
	[id_grupo] [int] IDENTITY(1,1) NOT NULL,
	[id_asignatura] [int] NOT NULL,
	[id_docente] [int] NULL,
	[cant_estudiante] [int] NULL,
	[id_periodo] [int] NOT NULL,
 CONSTRAINT [PK_grupo] PRIMARY KEY CLUSTERED 
(
	[id_grupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[membership]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[membership](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](25) NOT NULL,
	[password] [nchar](28) NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[periodo]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[periodo](
	[id_periodo] [int] IDENTITY(1,1) NOT NULL,
	[periodo_inicio] [datetime] NOT NULL,
	[periodo_fin] [datetime] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_periodo] PRIMARY KEY CLUSTERED 
(
	[id_periodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vista_Asignaturas]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Asignaturas]
AS
SELECT        dbo.asignatura.id_asignatura, dbo.asignatura.nombre, dbo.asignatura.id_facultad, dbo.facultad.descripcion AS descripcionFacultad, 
                         dbo.asignatura.id_categoria, dbo.asignatura_categoria.descripcion AS descripcionCategoria
FROM            dbo.asignatura INNER JOIN
                         dbo.asignatura_categoria ON dbo.asignatura.id_categoria = dbo.asignatura_categoria.id_categoria INNER JOIN
                         dbo.facultad ON dbo.asignatura.id_facultad = dbo.facultad.id_facultad

GO
/****** Object:  View [dbo].[Vista_Grupos]    Script Date: 31/10/2012 12:39:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Vista_Grupos]
as
select t1.id_grupo as id,
		t1.id_asignatura as idAsignatura,
		t2.nombre as nombreAsignatura,
		t1.id_docente as idDocente,
		t3.nombre as nombreDocente,
		t1.cant_estudiante as cantEstudiantes,
		t1.id_periodo as idPeriodo,
		t4.descripcion as descripcionPeriodo
from grupo t1 inner join asignatura t2 on t1.id_asignatura=t2.id_asignatura 
	inner join docente t3 on t1.id_docente=t3.id_docente
	inner join periodo t4 on t1.id_periodo=t4.id_periodo

GO
ALTER TABLE [dbo].[alerta]  WITH CHECK ADD  CONSTRAINT [FK_alerta_alerta_estado] FOREIGN KEY([id_alerta_estado])
REFERENCES [dbo].[alerta_estado] ([id_alerta_estado])
GO
ALTER TABLE [dbo].[alerta] CHECK CONSTRAINT [FK_alerta_alerta_estado]
GO
ALTER TABLE [dbo].[alerta]  WITH CHECK ADD  CONSTRAINT [FK_alerta_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[alerta] CHECK CONSTRAINT [FK_alerta_aula]
GO
ALTER TABLE [dbo].[asignacion_clase]  WITH CHECK ADD  CONSTRAINT [FK_asignacion_clase_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[asignacion_clase] CHECK CONSTRAINT [FK_asignacion_clase_aula]
GO
ALTER TABLE [dbo].[asignacion_clase]  WITH CHECK ADD  CONSTRAINT [FK_asignacion_clase_grupo] FOREIGN KEY([id_grupo])
REFERENCES [dbo].[grupo] ([id_grupo])
GO
ALTER TABLE [dbo].[asignacion_clase] CHECK CONSTRAINT [FK_asignacion_clase_grupo]
GO
ALTER TABLE [dbo].[asignacion_varios]  WITH CHECK ADD  CONSTRAINT [FK_asignacion_varios_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[asignacion_varios] CHECK CONSTRAINT [FK_asignacion_varios_aula]
GO
ALTER TABLE [dbo].[asignacion_varios]  WITH CHECK ADD  CONSTRAINT [FK_asignacion_varios_aula_tipo_uso] FOREIGN KEY([id_tipo_uso])
REFERENCES [dbo].[aula_tipo_uso] ([id_tipo_uso])
GO
ALTER TABLE [dbo].[asignacion_varios] CHECK CONSTRAINT [FK_asignacion_varios_aula_tipo_uso]
GO
ALTER TABLE [dbo].[asignatura]  WITH CHECK ADD  CONSTRAINT [FK_asignatura_asignatura_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[asignatura_categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[asignatura] CHECK CONSTRAINT [FK_asignatura_asignatura_categoria]
GO
ALTER TABLE [dbo].[asignatura]  WITH CHECK ADD  CONSTRAINT [FK_asignatura_facultad] FOREIGN KEY([id_facultad])
REFERENCES [dbo].[facultad] ([id_facultad])
GO
ALTER TABLE [dbo].[asignatura] CHECK CONSTRAINT [FK_asignatura_facultad]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD  CONSTRAINT [FK_aula_aula_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[aula_estado] ([id_estado])
GO
ALTER TABLE [dbo].[aula] CHECK CONSTRAINT [FK_aula_aula_estado]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD  CONSTRAINT [FK_aula_aula_tipo] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[aula_tipo] ([id_tipo])
GO
ALTER TABLE [dbo].[aula] CHECK CONSTRAINT [FK_aula_aula_tipo]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD  CONSTRAINT [FK_aula_edificio] FOREIGN KEY([id_edificio])
REFERENCES [dbo].[edificio] ([id_edificio])
GO
ALTER TABLE [dbo].[aula] CHECK CONSTRAINT [FK_aula_edificio]
GO
ALTER TABLE [dbo].[aula_equipo]  WITH CHECK ADD  CONSTRAINT [FK_aula_equipo_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[aula_equipo] CHECK CONSTRAINT [FK_aula_equipo_aula]
GO
ALTER TABLE [dbo].[aula_equipo]  WITH CHECK ADD  CONSTRAINT [FK_aula_equipo_equipo] FOREIGN KEY([id_equipo])
REFERENCES [dbo].[equipo] ([id_equipo])
GO
ALTER TABLE [dbo].[aula_equipo] CHECK CONSTRAINT [FK_aula_equipo_equipo]
GO
ALTER TABLE [dbo].[grupo]  WITH CHECK ADD  CONSTRAINT [FK_grupo_asignatura] FOREIGN KEY([id_asignatura])
REFERENCES [dbo].[asignatura] ([id_asignatura])
GO
ALTER TABLE [dbo].[grupo] CHECK CONSTRAINT [FK_grupo_asignatura]
GO
ALTER TABLE [dbo].[grupo]  WITH CHECK ADD  CONSTRAINT [FK_grupo_docente] FOREIGN KEY([id_docente])
REFERENCES [dbo].[docente] ([id_docente])
GO
ALTER TABLE [dbo].[grupo] CHECK CONSTRAINT [FK_grupo_docente]
GO
ALTER TABLE [dbo].[grupo]  WITH CHECK ADD  CONSTRAINT [FK_grupo_periodo] FOREIGN KEY([id_periodo])
REFERENCES [dbo].[periodo] ([id_periodo])
GO
ALTER TABLE [dbo].[grupo] CHECK CONSTRAINT [FK_grupo_periodo]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla donde se asignan los grupos a las diferentes aulas disponibles. La fecha de inicio y de fin es para diferenciar las diferentes aulas que puede utilizar un grupo en diferentes dias' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'asignacion_clase'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Categoria de asignatura en relacion si es asignatura de grado, postgrado, maestria, etc.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'asignatura_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de Tipo de Aula: laboratorio, Auditorio, Aula,etc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'aula_tipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cantidad de Estudiantes inscritos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'grupo', @level2type=N'COLUMN',@level2name=N'cant_estudiante'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Corresponde a la modalidad del grupo. La duracion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'grupo', @level2type=N'COLUMN',@level2name=N'id_periodo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Duracion de las modalidades de los grupos: Semestre, trimestre y su duracion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'periodo', @level2type=N'COLUMN',@level2name=N'periodo_fin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "asignatura"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "asignatura_categoria"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "facultad"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Asignaturas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Asignaturas'
GO
USE [master]
GO
ALTER DATABASE [uam_agenda] SET  READ_WRITE 
GO


-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2016 20:57:16
-- Generated from EDMX file: C:\Users\ThinkPadW7\documents\visual studio 2015\Projects\ITCManager\DataAccess\ModeloITCCore\ModeloITCCore.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ITC_DBPOwer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PermisoPermisoAcceso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisoAcceso] DROP CONSTRAINT [FK_PermisoPermisoAcceso];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_PersonaRolAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolEmpleado] DROP CONSTRAINT [FK_PersonaRolEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolVendedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_PersonaRolVendedor];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolVendedor1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_PersonaRolVendedor1];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolVendedor2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_PersonaRolVendedor2];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoEstadoAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_RolAlumnoEstadoAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoDetalleCondicionEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCondicionEmpleado] DROP CONSTRAINT [FK_RolEmpleadoDetalleCondicionEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permiso] DROP CONSTRAINT [FK_RolEmpleadoPermiso];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CondicionEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CondicionEmpleado];
GO
IF OBJECT_ID(N'[dbo].[DetalleCondicionEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleCondicionEmpleado];
GO
IF OBJECT_ID(N'[dbo].[EstadoAlumno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoAlumno];
GO
IF OBJECT_ID(N'[dbo].[Permiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permiso];
GO
IF OBJECT_ID(N'[dbo].[PermisoAcceso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermisoAcceso];
GO
IF OBJECT_ID(N'[dbo].[Persona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persona];
GO
IF OBJECT_ID(N'[dbo].[RolAlumno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolAlumno];
GO
IF OBJECT_ID(N'[dbo].[RolEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolEmpleado];
GO
IF OBJECT_ID(N'[dbo].[RolVendedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolVendedor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CondicionEmpleado'
CREATE TABLE [dbo].[CondicionEmpleado] (
    [IdCondicionEmpleado] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'DetalleCondicionEmpleado'
CREATE TABLE [dbo].[DetalleCondicionEmpleado] (
    [IdDetalleCondicionEmpleado] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [IdCondicionEmpleado] int  NOT NULL
);
GO

-- Creating table 'EstadoAlumno'
CREATE TABLE [dbo].[EstadoAlumno] (
    [IdEstadoAlumno] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoAlumno] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Permiso'
CREATE TABLE [dbo].[Permiso] (
    [IdPermiso] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL,
    [DetallePermiso] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermisoAcceso'
CREATE TABLE [dbo].[PermisoAcceso] (
    [IdPermisoAcceso] int IDENTITY(1,1) NOT NULL,
    [IdPermiso] int  NOT NULL,
    [DetalleAcceso] nvarchar(max)  NOT NULL,
    [PermisoActivo] bit  NOT NULL
);
GO

-- Creating table 'Persona'
CREATE TABLE [dbo].[Persona] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Nombres] nvarchar(max)  NOT NULL,
    [FechaNac] datetime  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Barrio] nvarchar(max)  NOT NULL,
    [Ciudad] nvarchar(max)  NOT NULL,
    [Provincia] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NOT NULL,
    [CelCorp] nvarchar(max)  NOT NULL,
    [TelAlternativo] nvarchar(max)  NOT NULL,
    [EstadoCivil] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolAlumno'
CREATE TABLE [dbo].[RolAlumno] (
    [IdRolAlumno] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdCapacitacion] int  NOT NULL,
    [IdInformeCiudadHorarios] int  NOT NULL,
    [IdEstadoAlumno] int  NOT NULL
);
GO

-- Creating table 'RolEmpleado'
CREATE TABLE [dbo].[RolEmpleado] (
    [IdRolEmpleado] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdPuesto] nvarchar(max)  NOT NULL,
    [IdCondicionEmpleado] int  NOT NULL
);
GO

-- Creating table 'RolVendedor'
CREATE TABLE [dbo].[RolVendedor] (
    [IdRolVendedor] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdSubgerente] int  NOT NULL,
    [IdGerente] int  NOT NULL
);
GO

-- Creating table 'PruebaBorrarSet'
CREATE TABLE [dbo].[PruebaBorrarSet] (
    [IdPruebaBorrar] int IDENTITY(1,1) NOT NULL,
    [DetallePruebaBorrar] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCondicionEmpleado] in table 'CondicionEmpleado'
ALTER TABLE [dbo].[CondicionEmpleado]
ADD CONSTRAINT [PK_CondicionEmpleado]
    PRIMARY KEY CLUSTERED ([IdCondicionEmpleado] ASC);
GO

-- Creating primary key on [IdDetalleCondicionEmpleado] in table 'DetalleCondicionEmpleado'
ALTER TABLE [dbo].[DetalleCondicionEmpleado]
ADD CONSTRAINT [PK_DetalleCondicionEmpleado]
    PRIMARY KEY CLUSTERED ([IdDetalleCondicionEmpleado] ASC);
GO

-- Creating primary key on [IdEstadoAlumno] in table 'EstadoAlumno'
ALTER TABLE [dbo].[EstadoAlumno]
ADD CONSTRAINT [PK_EstadoAlumno]
    PRIMARY KEY CLUSTERED ([IdEstadoAlumno] ASC);
GO

-- Creating primary key on [IdPermiso] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [PK_Permiso]
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC);
GO

-- Creating primary key on [IdPermisoAcceso] in table 'PermisoAcceso'
ALTER TABLE [dbo].[PermisoAcceso]
ADD CONSTRAINT [PK_PermisoAcceso]
    PRIMARY KEY CLUSTERED ([IdPermisoAcceso] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Persona'
ALTER TABLE [dbo].[Persona]
ADD CONSTRAINT [PK_Persona]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdRolAlumno] in table 'RolAlumno'
ALTER TABLE [dbo].[RolAlumno]
ADD CONSTRAINT [PK_RolAlumno]
    PRIMARY KEY CLUSTERED ([IdRolAlumno] ASC);
GO

-- Creating primary key on [IdRolEmpleado] in table 'RolEmpleado'
ALTER TABLE [dbo].[RolEmpleado]
ADD CONSTRAINT [PK_RolEmpleado]
    PRIMARY KEY CLUSTERED ([IdRolEmpleado] ASC);
GO

-- Creating primary key on [IdRolVendedor] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [PK_RolVendedor]
    PRIMARY KEY CLUSTERED ([IdRolVendedor] ASC);
GO

-- Creating primary key on [IdPruebaBorrar] in table 'PruebaBorrarSet'
ALTER TABLE [dbo].[PruebaBorrarSet]
ADD CONSTRAINT [PK_PruebaBorrarSet]
    PRIMARY KEY CLUSTERED ([IdPruebaBorrar] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdRolEmpleado] in table 'DetalleCondicionEmpleado'
ALTER TABLE [dbo].[DetalleCondicionEmpleado]
ADD CONSTRAINT [FK_RolEmpleadoDetalleCondicionEmpleado]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoDetalleCondicionEmpleado'
CREATE INDEX [IX_FK_RolEmpleadoDetalleCondicionEmpleado]
ON [dbo].[DetalleCondicionEmpleado]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdEstadoAlumno] in table 'RolAlumno'
ALTER TABLE [dbo].[RolAlumno]
ADD CONSTRAINT [FK_RolAlumnoEstadoAlumno]
    FOREIGN KEY ([IdEstadoAlumno])
    REFERENCES [dbo].[EstadoAlumno]
        ([IdEstadoAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolAlumnoEstadoAlumno'
CREATE INDEX [IX_FK_RolAlumnoEstadoAlumno]
ON [dbo].[RolAlumno]
    ([IdEstadoAlumno]);
GO

-- Creating foreign key on [IdPermiso] in table 'PermisoAcceso'
ALTER TABLE [dbo].[PermisoAcceso]
ADD CONSTRAINT [FK_PermisoPermisoAcceso]
    FOREIGN KEY ([IdPermiso])
    REFERENCES [dbo].[Permiso]
        ([IdPermiso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermisoPermisoAcceso'
CREATE INDEX [IX_FK_PermisoPermisoAcceso]
ON [dbo].[PermisoAcceso]
    ([IdPermiso]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'Permiso'
ALTER TABLE [dbo].[Permiso]
ADD CONSTRAINT [FK_RolEmpleadoPermiso]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoPermiso'
CREATE INDEX [IX_FK_RolEmpleadoPermiso]
ON [dbo].[Permiso]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdPersona] in table 'RolAlumno'
ALTER TABLE [dbo].[RolAlumno]
ADD CONSTRAINT [FK_PersonaRolAlumno]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolAlumno'
CREATE INDEX [IX_FK_PersonaRolAlumno]
ON [dbo].[RolAlumno]
    ([IdPersona]);
GO

-- Creating foreign key on [IdPersona] in table 'RolEmpleado'
ALTER TABLE [dbo].[RolEmpleado]
ADD CONSTRAINT [FK_PersonaRolEmpleado]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolEmpleado'
CREATE INDEX [IX_FK_PersonaRolEmpleado]
ON [dbo].[RolEmpleado]
    ([IdPersona]);
GO

-- Creating foreign key on [IdPersona] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_PersonaRolVendedor]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolVendedor'
CREATE INDEX [IX_FK_PersonaRolVendedor]
ON [dbo].[RolVendedor]
    ([IdPersona]);
GO

-- Creating foreign key on [IdGerente] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_PersonaRolVendedor1]
    FOREIGN KEY ([IdGerente])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolVendedor1'
CREATE INDEX [IX_FK_PersonaRolVendedor1]
ON [dbo].[RolVendedor]
    ([IdGerente]);
GO

-- Creating foreign key on [IdSubgerente] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_PersonaRolVendedor2]
    FOREIGN KEY ([IdSubgerente])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolVendedor2'
CREATE INDEX [IX_FK_PersonaRolVendedor2]
ON [dbo].[RolVendedor]
    ([IdSubgerente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
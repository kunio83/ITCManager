
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/10/2016 18:19:51
-- Generated from EDMX file: C:\Users\Ezequiel\Source\Repos\ITCManagerRepositorio\ITCManager.Core.DataAccess\ModeloITCCore\ModeloITCCore.edmx
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

IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoDetalleCondicionEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCondicionEmpleado] DROP CONSTRAINT [FK_RolEmpleadoDetalleCondicionEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoEstadoAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_RolAlumnoEstadoAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_PermisoPermisoAcceso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisoAcceso] DROP CONSTRAINT [FK_PermisoPermisoAcceso];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permiso] DROP CONSTRAINT [FK_RolEmpleadoPermiso];
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
IF OBJECT_ID(N'[dbo].[FK_PersonaAsignacionRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AsignacionReciboSet] DROP CONSTRAINT [FK_PersonaAsignacionRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolLocador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolLocadorSet] DROP CONSTRAINT [FK_PersonaRolLocador];
GO
IF OBJECT_ID(N'[dbo].[FK_LineaLineaCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LineaCiudadSet] DROP CONSTRAINT [FK_LineaLineaCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_CiudadLineaCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LineaCiudadSet] DROP CONSTRAINT [FK_CiudadLineaCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_LocalidadCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadSet] DROP CONSTRAINT [FK_LocalidadCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_CiudadRolCiudadEnProceso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadEnProcesoSet] DROP CONSTRAINT [FK_CiudadRolCiudadEnProceso];
GO
IF OBJECT_ID(N'[dbo].[FK_CiudadRolCiudadActiva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaSet] DROP CONSTRAINT [FK_CiudadRolCiudadActiva];
GO
IF OBJECT_ID(N'[dbo].[FK_LineaCiudadCiudadPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadPersonalSet] DROP CONSTRAINT [FK_LineaCiudadCiudadPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoCiudadPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadPersonalSet] DROP CONSTRAINT [FK_RolEmpleadoCiudadPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaCiudadActivaLocaciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadActivaLocacionesSet] DROP CONSTRAINT [FK_RolCiudadActivaCiudadActivaLocaciones];
GO
IF OBJECT_ID(N'[dbo].[FK_LocacionCiudadActivaLocaciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadActivaLocacionesSet] DROP CONSTRAINT [FK_LocacionCiudadActivaLocaciones];
GO
IF OBJECT_ID(N'[dbo].[FK_RolLocadorLocacionRolLocador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocacionRolLocadorSet] DROP CONSTRAINT [FK_RolLocadorLocacionRolLocador];
GO
IF OBJECT_ID(N'[dbo].[FK_LocacionLocacionRolLocador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocacionRolLocadorSet] DROP CONSTRAINT [FK_LocacionLocacionRolLocador];
GO
IF OBJECT_ID(N'[dbo].[FK_LocacionRolLocacionAlojamiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolLocacionAlojamientoSet] DROP CONSTRAINT [FK_LocacionRolLocacionAlojamiento];
GO
IF OBJECT_ID(N'[dbo].[FK_LocacionRolLocacionSalon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolLocacionSalonSet] DROP CONSTRAINT [FK_LocacionRolLocacionSalon];
GO
IF OBJECT_ID(N'[dbo].[FK_PlanBaseRolCiudadActivaPlan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaPlanSet] DROP CONSTRAINT [FK_PlanBaseRolCiudadActivaPlan];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaRolCiudadActivaPlan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaPlanSet] DROP CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaPlan];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoPlanVendedorAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlanVendedorAlumnoSet] DROP CONSTRAINT [FK_RolAlumnoPlanVendedorAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_RolVendedorPlanVendedorAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlanVendedorAlumnoSet] DROP CONSTRAINT [FK_RolVendedorPlanVendedorAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaPlanPlanVendedorAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlanVendedorAlumnoSet] DROP CONSTRAINT [FK_RolCiudadActivaPlanPlanVendedorAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_CapacitacionRolAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_CapacitacionRolAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_HorarioRolCiudadActivaHorario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaHorarioSet] DROP CONSTRAINT [FK_HorarioRolCiudadActivaHorario];
GO
IF OBJECT_ID(N'[dbo].[FK_DiaRolCiudadActivaHorario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaHorarioSet] DROP CONSTRAINT [FK_DiaRolCiudadActivaHorario];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaRolCiudadActivaHorario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaHorarioSet] DROP CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaHorario];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaHorarioRolAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_RolCiudadActivaHorarioRolAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolCobrador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCobradorSet] DROP CONSTRAINT [FK_PersonaRolCobrador];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoRendicionRendicionCobradorCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPersonaCiudadSet] DROP CONSTRAINT [FK_EstadoRendicionRendicionCobradorCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaRendicionCobradorCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPersonaCiudadSet] DROP CONSTRAINT [FK_RolCiudadActivaRendicionCobradorCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaPagoPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoSet] DROP CONSTRAINT [FK_FormaPagoPago];
GO
IF OBJECT_ID(N'[dbo].[FK_PlanVendedorAlumnoPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoSet] DROP CONSTRAINT [FK_PlanVendedorAlumnoPago];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoPagoTarjeta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoTarjetaSet] DROP CONSTRAINT [FK_PagoPagoTarjeta];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRendicionPersonaCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPersonaCiudadSet] DROP CONSTRAINT [FK_PersonaRendicionPersonaCiudad];
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
IF OBJECT_ID(N'[dbo].[AsignacionReciboSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AsignacionReciboSet];
GO
IF OBJECT_ID(N'[dbo].[LineaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LineaSet];
GO
IF OBJECT_ID(N'[dbo].[LineaCiudadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LineaCiudadSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadSet];
GO
IF OBJECT_ID(N'[dbo].[LocalidadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocalidadSet];
GO
IF OBJECT_ID(N'[dbo].[RolCiudadEnProcesoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCiudadEnProcesoSet];
GO
IF OBJECT_ID(N'[dbo].[RolCiudadActivaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCiudadActivaSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadPersonalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadPersonalSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadActivaLocacionesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadActivaLocacionesSet];
GO
IF OBJECT_ID(N'[dbo].[LocacionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocacionSet];
GO
IF OBJECT_ID(N'[dbo].[RolLocadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolLocadorSet];
GO
IF OBJECT_ID(N'[dbo].[LocacionRolLocadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocacionRolLocadorSet];
GO
IF OBJECT_ID(N'[dbo].[RolLocacionAlojamientoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolLocacionAlojamientoSet];
GO
IF OBJECT_ID(N'[dbo].[RolLocacionSalonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolLocacionSalonSet];
GO
IF OBJECT_ID(N'[dbo].[PlanBaseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlanBaseSet];
GO
IF OBJECT_ID(N'[dbo].[RolCiudadActivaPlanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCiudadActivaPlanSet];
GO
IF OBJECT_ID(N'[dbo].[PlanVendedorAlumnoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlanVendedorAlumnoSet];
GO
IF OBJECT_ID(N'[dbo].[CapacitacionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CapacitacionSet];
GO
IF OBJECT_ID(N'[dbo].[HorarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HorarioSet];
GO
IF OBJECT_ID(N'[dbo].[RolCiudadActivaHorarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCiudadActivaHorarioSet];
GO
IF OBJECT_ID(N'[dbo].[DiaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiaSet];
GO
IF OBJECT_ID(N'[dbo].[RolCobradorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCobradorSet];
GO
IF OBJECT_ID(N'[dbo].[RendicionPersonaCiudadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RendicionPersonaCiudadSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoRendicionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoRendicionSet];
GO
IF OBJECT_ID(N'[dbo].[PagoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoSet];
GO
IF OBJECT_ID(N'[dbo].[FormaPagoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaPagoSet];
GO
IF OBJECT_ID(N'[dbo].[PagoTarjetaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoTarjetaSet];
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
    [IdRolCiudadActivaHorario] int  NOT NULL,
    [IdEstadoAlumno] int  NOT NULL
);
GO

-- Creating table 'RolEmpleado'
CREATE TABLE [dbo].[RolEmpleado] (
    [IdRolEmpleado] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdPuesto] nvarchar(max)  NOT NULL,
    [IdCondicionEmpleado] int  NOT NULL,
    [CelCorp] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolVendedor'
CREATE TABLE [dbo].[RolVendedor] (
    [IdRolVendedor] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdSubgerente] int  NOT NULL,
    [IdGerente] int  NOT NULL,
    [CelCorp] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AsignacionReciboSet'
CREATE TABLE [dbo].[AsignacionReciboSet] (
    [IdAsignacionRecibo] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [NumRecibo] int  NOT NULL,
    [IdPersona] int  NOT NULL
);
GO

-- Creating table 'LineaSet'
CREATE TABLE [dbo].[LineaSet] (
    [IdLinea] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'LineaCiudadSet'
CREATE TABLE [dbo].[LineaCiudadSet] (
    [IdLineaCiudad] int IDENTITY(1,1) NOT NULL,
    [IdLinea] int  NOT NULL,
    [IdCiudad] int  NOT NULL
);
GO

-- Creating table 'CiudadSet'
CREATE TABLE [dbo].[CiudadSet] (
    [IdCiudad] int IDENTITY(1,1) NOT NULL,
    [DesignacionCiudad] nvarchar(max)  NOT NULL,
    [IdLocalidad] int  NOT NULL,
    [PeriodoApertura] nvarchar(max)  NOT NULL,
    [CantidadMeses] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LocalidadSet'
CREATE TABLE [dbo].[LocalidadSet] (
    [IdLocalidad] int IDENTITY(1,1) NOT NULL,
    [NombreLocalidad] nvarchar(max)  NOT NULL,
    [Provincia] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCiudadEnProcesoSet'
CREATE TABLE [dbo].[RolCiudadEnProcesoSet] (
    [IdRolCiudadEnProceso] int IDENTITY(1,1) NOT NULL,
    [IdCiudad] int  NOT NULL,
    [InformeCiudad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCiudadActivaSet'
CREATE TABLE [dbo].[RolCiudadActivaSet] (
    [IdRolCiudadActiva] int IDENTITY(1,1) NOT NULL,
    [IdCiudad] int  NOT NULL
);
GO

-- Creating table 'CiudadPersonalSet'
CREATE TABLE [dbo].[CiudadPersonalSet] (
    [IdCiudadPersonal] int IDENTITY(1,1) NOT NULL,
    [IdLineaCiudad] int  NOT NULL,
    [Periodo] nvarchar(max)  NOT NULL,
    [IdRolEmpleado] int  NOT NULL
);
GO

-- Creating table 'CiudadActivaLocacionesSet'
CREATE TABLE [dbo].[CiudadActivaLocacionesSet] (
    [IdCiudadActivaLocaciones] int IDENTITY(1,1) NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [IdLocacion] int  NOT NULL
);
GO

-- Creating table 'LocacionSet'
CREATE TABLE [dbo].[LocacionSet] (
    [IdLocacion] int IDENTITY(1,1) NOT NULL,
    [DetalleLocacion] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolLocadorSet'
CREATE TABLE [dbo].[RolLocadorSet] (
    [IdRolLocador] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [Condicion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LocacionRolLocadorSet'
CREATE TABLE [dbo].[LocacionRolLocadorSet] (
    [IdLocacionRolLocador] int IDENTITY(1,1) NOT NULL,
    [IdLocacion] int  NOT NULL,
    [IdRolLocador] int  NOT NULL
);
GO

-- Creating table 'RolLocacionAlojamientoSet'
CREATE TABLE [dbo].[RolLocacionAlojamientoSet] (
    [IdRolLocacionAlojamiento] int IDENTITY(1,1) NOT NULL,
    [IdLocacion] int  NOT NULL,
    [Dias] nvarchar(max)  NOT NULL,
    [CantDormitorios] nvarchar(max)  NOT NULL,
    [CantCamas] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolLocacionSalonSet'
CREATE TABLE [dbo].[RolLocacionSalonSet] (
    [IdRolLocacionSalon] int IDENTITY(1,1) NOT NULL,
    [IdLocacion] int  NOT NULL,
    [Tamaño] nvarchar(max)  NOT NULL,
    [Mesas] nvarchar(max)  NOT NULL,
    [Sillas] nvarchar(max)  NOT NULL,
    [AireAcondicionado] nvarchar(max)  NOT NULL,
    [Calefaccion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PlanBaseSet'
CREATE TABLE [dbo].[PlanBaseSet] (
    [IdPlanBase] int IDENTITY(1,1) NOT NULL,
    [DetallePlanBase] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCiudadActivaPlanSet'
CREATE TABLE [dbo].[RolCiudadActivaPlanSet] (
    [IdRolCiudadActivaPlan] int IDENTITY(1,1) NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [IdPlanBase] int  NOT NULL,
    [ValorMatricula] nvarchar(max)  NOT NULL,
    [CantCuotas] nvarchar(max)  NOT NULL,
    [ValorCuota] nvarchar(max)  NOT NULL,
    [ValorDescuento] nvarchar(max)  NOT NULL,
    [ValorCertificado] nvarchar(max)  NOT NULL,
    [ComisionIda] nvarchar(max)  NOT NULL,
    [ComisionVuelta] nvarchar(max)  NOT NULL,
    [ComisionCertificado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PlanVendedorAlumnoSet'
CREATE TABLE [dbo].[PlanVendedorAlumnoSet] (
    [IdPlanVendedorAlumno] int IDENTITY(1,1) NOT NULL,
    [IdRolCiudadActivaPlan] int  NOT NULL,
    [IdRolAlumno] int  NOT NULL,
    [IdRolVendedor] int  NOT NULL,
    [ObservacionGerente] nvarchar(max)  NOT NULL,
    [ObservacionOficinaBaires] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CapacitacionSet'
CREATE TABLE [dbo].[CapacitacionSet] (
    [IdCapacitacion] int IDENTITY(1,1) NOT NULL,
    [NombreCapacitacion] nvarchar(max)  NOT NULL,
    [Temario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HorarioSet'
CREATE TABLE [dbo].[HorarioSet] (
    [IdHorario] int IDENTITY(1,1) NOT NULL,
    [DetalleHorario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCiudadActivaHorarioSet'
CREATE TABLE [dbo].[RolCiudadActivaHorarioSet] (
    [IdRolCiudadActivaHorario] int IDENTITY(1,1) NOT NULL,
    [IdDia] int  NOT NULL,
    [IdHorario] int  NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL
);
GO

-- Creating table 'DiaSet'
CREATE TABLE [dbo].[DiaSet] (
    [IdDia] int IDENTITY(1,1) NOT NULL,
    [DetalleDia] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCobradorSet'
CREATE TABLE [dbo].[RolCobradorSet] (
    [IdRolCobrador] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [CelCorp] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RendicionPersonaCiudadSet'
CREATE TABLE [dbo].[RendicionPersonaCiudadSet] (
    [IdRendicionPersonaCiudad] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [IdEstadoRendicion] int  NOT NULL
);
GO

-- Creating table 'EstadoRendicionSet'
CREATE TABLE [dbo].[EstadoRendicionSet] (
    [IdEstadoRendicion] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoRednicion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoSet'
CREATE TABLE [dbo].[PagoSet] (
    [IdPago] int IDENTITY(1,1) NOT NULL,
    [IdPlanVendedorAlumno] int  NOT NULL,
    [MontoPagado] nvarchar(max)  NOT NULL,
    [IdFormaPago] int  NOT NULL,
    [IdItemPagado] int  NOT NULL
);
GO

-- Creating table 'FormaPagoSet'
CREATE TABLE [dbo].[FormaPagoSet] (
    [IdFormaPago] int IDENTITY(1,1) NOT NULL,
    [DetalleFormaPago] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoTarjetaSet'
CREATE TABLE [dbo].[PagoTarjetaSet] (
    [IdPagoTarjeta] int IDENTITY(1,1) NOT NULL,
    [IdPago] int  NOT NULL,
    [MontoAPagar] nvarchar(max)  NOT NULL,
    [Cuotas] nvarchar(max)  NOT NULL,
    [Recargo] nvarchar(max)  NOT NULL,
    [MontoTotal] nvarchar(max)  NOT NULL,
    [NumeroTarjeta] nvarchar(max)  NOT NULL,
    [EmisorTarjeta] nvarchar(max)  NOT NULL,
    [CodSeguridad] nvarchar(max)  NOT NULL,
    [Vencimiento] nvarchar(max)  NOT NULL,
    [TitularTarjeta] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL
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

-- Creating primary key on [IdAsignacionRecibo] in table 'AsignacionReciboSet'
ALTER TABLE [dbo].[AsignacionReciboSet]
ADD CONSTRAINT [PK_AsignacionReciboSet]
    PRIMARY KEY CLUSTERED ([IdAsignacionRecibo] ASC);
GO

-- Creating primary key on [IdLinea] in table 'LineaSet'
ALTER TABLE [dbo].[LineaSet]
ADD CONSTRAINT [PK_LineaSet]
    PRIMARY KEY CLUSTERED ([IdLinea] ASC);
GO

-- Creating primary key on [IdLineaCiudad] in table 'LineaCiudadSet'
ALTER TABLE [dbo].[LineaCiudadSet]
ADD CONSTRAINT [PK_LineaCiudadSet]
    PRIMARY KEY CLUSTERED ([IdLineaCiudad] ASC);
GO

-- Creating primary key on [IdCiudad] in table 'CiudadSet'
ALTER TABLE [dbo].[CiudadSet]
ADD CONSTRAINT [PK_CiudadSet]
    PRIMARY KEY CLUSTERED ([IdCiudad] ASC);
GO

-- Creating primary key on [IdLocalidad] in table 'LocalidadSet'
ALTER TABLE [dbo].[LocalidadSet]
ADD CONSTRAINT [PK_LocalidadSet]
    PRIMARY KEY CLUSTERED ([IdLocalidad] ASC);
GO

-- Creating primary key on [IdRolCiudadEnProceso] in table 'RolCiudadEnProcesoSet'
ALTER TABLE [dbo].[RolCiudadEnProcesoSet]
ADD CONSTRAINT [PK_RolCiudadEnProcesoSet]
    PRIMARY KEY CLUSTERED ([IdRolCiudadEnProceso] ASC);
GO

-- Creating primary key on [IdRolCiudadActiva] in table 'RolCiudadActivaSet'
ALTER TABLE [dbo].[RolCiudadActivaSet]
ADD CONSTRAINT [PK_RolCiudadActivaSet]
    PRIMARY KEY CLUSTERED ([IdRolCiudadActiva] ASC);
GO

-- Creating primary key on [IdCiudadPersonal] in table 'CiudadPersonalSet'
ALTER TABLE [dbo].[CiudadPersonalSet]
ADD CONSTRAINT [PK_CiudadPersonalSet]
    PRIMARY KEY CLUSTERED ([IdCiudadPersonal] ASC);
GO

-- Creating primary key on [IdCiudadActivaLocaciones] in table 'CiudadActivaLocacionesSet'
ALTER TABLE [dbo].[CiudadActivaLocacionesSet]
ADD CONSTRAINT [PK_CiudadActivaLocacionesSet]
    PRIMARY KEY CLUSTERED ([IdCiudadActivaLocaciones] ASC);
GO

-- Creating primary key on [IdLocacion] in table 'LocacionSet'
ALTER TABLE [dbo].[LocacionSet]
ADD CONSTRAINT [PK_LocacionSet]
    PRIMARY KEY CLUSTERED ([IdLocacion] ASC);
GO

-- Creating primary key on [IdRolLocador] in table 'RolLocadorSet'
ALTER TABLE [dbo].[RolLocadorSet]
ADD CONSTRAINT [PK_RolLocadorSet]
    PRIMARY KEY CLUSTERED ([IdRolLocador] ASC);
GO

-- Creating primary key on [IdLocacionRolLocador] in table 'LocacionRolLocadorSet'
ALTER TABLE [dbo].[LocacionRolLocadorSet]
ADD CONSTRAINT [PK_LocacionRolLocadorSet]
    PRIMARY KEY CLUSTERED ([IdLocacionRolLocador] ASC);
GO

-- Creating primary key on [IdRolLocacionAlojamiento] in table 'RolLocacionAlojamientoSet'
ALTER TABLE [dbo].[RolLocacionAlojamientoSet]
ADD CONSTRAINT [PK_RolLocacionAlojamientoSet]
    PRIMARY KEY CLUSTERED ([IdRolLocacionAlojamiento] ASC);
GO

-- Creating primary key on [IdRolLocacionSalon] in table 'RolLocacionSalonSet'
ALTER TABLE [dbo].[RolLocacionSalonSet]
ADD CONSTRAINT [PK_RolLocacionSalonSet]
    PRIMARY KEY CLUSTERED ([IdRolLocacionSalon] ASC);
GO

-- Creating primary key on [IdPlanBase] in table 'PlanBaseSet'
ALTER TABLE [dbo].[PlanBaseSet]
ADD CONSTRAINT [PK_PlanBaseSet]
    PRIMARY KEY CLUSTERED ([IdPlanBase] ASC);
GO

-- Creating primary key on [IdRolCiudadActivaPlan] in table 'RolCiudadActivaPlanSet'
ALTER TABLE [dbo].[RolCiudadActivaPlanSet]
ADD CONSTRAINT [PK_RolCiudadActivaPlanSet]
    PRIMARY KEY CLUSTERED ([IdRolCiudadActivaPlan] ASC);
GO

-- Creating primary key on [IdPlanVendedorAlumno] in table 'PlanVendedorAlumnoSet'
ALTER TABLE [dbo].[PlanVendedorAlumnoSet]
ADD CONSTRAINT [PK_PlanVendedorAlumnoSet]
    PRIMARY KEY CLUSTERED ([IdPlanVendedorAlumno] ASC);
GO

-- Creating primary key on [IdCapacitacion] in table 'CapacitacionSet'
ALTER TABLE [dbo].[CapacitacionSet]
ADD CONSTRAINT [PK_CapacitacionSet]
    PRIMARY KEY CLUSTERED ([IdCapacitacion] ASC);
GO

-- Creating primary key on [IdHorario] in table 'HorarioSet'
ALTER TABLE [dbo].[HorarioSet]
ADD CONSTRAINT [PK_HorarioSet]
    PRIMARY KEY CLUSTERED ([IdHorario] ASC);
GO

-- Creating primary key on [IdRolCiudadActivaHorario] in table 'RolCiudadActivaHorarioSet'
ALTER TABLE [dbo].[RolCiudadActivaHorarioSet]
ADD CONSTRAINT [PK_RolCiudadActivaHorarioSet]
    PRIMARY KEY CLUSTERED ([IdRolCiudadActivaHorario] ASC);
GO

-- Creating primary key on [IdDia] in table 'DiaSet'
ALTER TABLE [dbo].[DiaSet]
ADD CONSTRAINT [PK_DiaSet]
    PRIMARY KEY CLUSTERED ([IdDia] ASC);
GO

-- Creating primary key on [IdRolCobrador] in table 'RolCobradorSet'
ALTER TABLE [dbo].[RolCobradorSet]
ADD CONSTRAINT [PK_RolCobradorSet]
    PRIMARY KEY CLUSTERED ([IdRolCobrador] ASC);
GO

-- Creating primary key on [IdRendicionPersonaCiudad] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [PK_RendicionPersonaCiudadSet]
    PRIMARY KEY CLUSTERED ([IdRendicionPersonaCiudad] ASC);
GO

-- Creating primary key on [IdEstadoRendicion] in table 'EstadoRendicionSet'
ALTER TABLE [dbo].[EstadoRendicionSet]
ADD CONSTRAINT [PK_EstadoRendicionSet]
    PRIMARY KEY CLUSTERED ([IdEstadoRendicion] ASC);
GO

-- Creating primary key on [IdPago] in table 'PagoSet'
ALTER TABLE [dbo].[PagoSet]
ADD CONSTRAINT [PK_PagoSet]
    PRIMARY KEY CLUSTERED ([IdPago] ASC);
GO

-- Creating primary key on [IdFormaPago] in table 'FormaPagoSet'
ALTER TABLE [dbo].[FormaPagoSet]
ADD CONSTRAINT [PK_FormaPagoSet]
    PRIMARY KEY CLUSTERED ([IdFormaPago] ASC);
GO

-- Creating primary key on [IdPagoTarjeta] in table 'PagoTarjetaSet'
ALTER TABLE [dbo].[PagoTarjetaSet]
ADD CONSTRAINT [PK_PagoTarjetaSet]
    PRIMARY KEY CLUSTERED ([IdPagoTarjeta] ASC);
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

-- Creating foreign key on [IdPersona] in table 'AsignacionReciboSet'
ALTER TABLE [dbo].[AsignacionReciboSet]
ADD CONSTRAINT [FK_PersonaAsignacionRecibo]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaAsignacionRecibo'
CREATE INDEX [IX_FK_PersonaAsignacionRecibo]
ON [dbo].[AsignacionReciboSet]
    ([IdPersona]);
GO

-- Creating foreign key on [IdPersona] in table 'RolLocadorSet'
ALTER TABLE [dbo].[RolLocadorSet]
ADD CONSTRAINT [FK_PersonaRolLocador]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolLocador'
CREATE INDEX [IX_FK_PersonaRolLocador]
ON [dbo].[RolLocadorSet]
    ([IdPersona]);
GO

-- Creating foreign key on [IdLinea] in table 'LineaCiudadSet'
ALTER TABLE [dbo].[LineaCiudadSet]
ADD CONSTRAINT [FK_LineaLineaCiudad]
    FOREIGN KEY ([IdLinea])
    REFERENCES [dbo].[LineaSet]
        ([IdLinea])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LineaLineaCiudad'
CREATE INDEX [IX_FK_LineaLineaCiudad]
ON [dbo].[LineaCiudadSet]
    ([IdLinea]);
GO

-- Creating foreign key on [IdCiudad] in table 'LineaCiudadSet'
ALTER TABLE [dbo].[LineaCiudadSet]
ADD CONSTRAINT [FK_CiudadLineaCiudad]
    FOREIGN KEY ([IdCiudad])
    REFERENCES [dbo].[CiudadSet]
        ([IdCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CiudadLineaCiudad'
CREATE INDEX [IX_FK_CiudadLineaCiudad]
ON [dbo].[LineaCiudadSet]
    ([IdCiudad]);
GO

-- Creating foreign key on [IdLocalidad] in table 'CiudadSet'
ALTER TABLE [dbo].[CiudadSet]
ADD CONSTRAINT [FK_LocalidadCiudad]
    FOREIGN KEY ([IdLocalidad])
    REFERENCES [dbo].[LocalidadSet]
        ([IdLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocalidadCiudad'
CREATE INDEX [IX_FK_LocalidadCiudad]
ON [dbo].[CiudadSet]
    ([IdLocalidad]);
GO

-- Creating foreign key on [IdCiudad] in table 'RolCiudadEnProcesoSet'
ALTER TABLE [dbo].[RolCiudadEnProcesoSet]
ADD CONSTRAINT [FK_CiudadRolCiudadEnProceso]
    FOREIGN KEY ([IdCiudad])
    REFERENCES [dbo].[CiudadSet]
        ([IdCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CiudadRolCiudadEnProceso'
CREATE INDEX [IX_FK_CiudadRolCiudadEnProceso]
ON [dbo].[RolCiudadEnProcesoSet]
    ([IdCiudad]);
GO

-- Creating foreign key on [IdCiudad] in table 'RolCiudadActivaSet'
ALTER TABLE [dbo].[RolCiudadActivaSet]
ADD CONSTRAINT [FK_CiudadRolCiudadActiva]
    FOREIGN KEY ([IdCiudad])
    REFERENCES [dbo].[CiudadSet]
        ([IdCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CiudadRolCiudadActiva'
CREATE INDEX [IX_FK_CiudadRolCiudadActiva]
ON [dbo].[RolCiudadActivaSet]
    ([IdCiudad]);
GO

-- Creating foreign key on [IdLineaCiudad] in table 'CiudadPersonalSet'
ALTER TABLE [dbo].[CiudadPersonalSet]
ADD CONSTRAINT [FK_LineaCiudadCiudadPersonal]
    FOREIGN KEY ([IdLineaCiudad])
    REFERENCES [dbo].[LineaCiudadSet]
        ([IdLineaCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LineaCiudadCiudadPersonal'
CREATE INDEX [IX_FK_LineaCiudadCiudadPersonal]
ON [dbo].[CiudadPersonalSet]
    ([IdLineaCiudad]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'CiudadPersonalSet'
ALTER TABLE [dbo].[CiudadPersonalSet]
ADD CONSTRAINT [FK_RolEmpleadoCiudadPersonal]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoCiudadPersonal'
CREATE INDEX [IX_FK_RolEmpleadoCiudadPersonal]
ON [dbo].[CiudadPersonalSet]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'CiudadActivaLocacionesSet'
ALTER TABLE [dbo].[CiudadActivaLocacionesSet]
ADD CONSTRAINT [FK_RolCiudadActivaCiudadActivaLocaciones]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaCiudadActivaLocaciones'
CREATE INDEX [IX_FK_RolCiudadActivaCiudadActivaLocaciones]
ON [dbo].[CiudadActivaLocacionesSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdLocacion] in table 'CiudadActivaLocacionesSet'
ALTER TABLE [dbo].[CiudadActivaLocacionesSet]
ADD CONSTRAINT [FK_LocacionCiudadActivaLocaciones]
    FOREIGN KEY ([IdLocacion])
    REFERENCES [dbo].[LocacionSet]
        ([IdLocacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocacionCiudadActivaLocaciones'
CREATE INDEX [IX_FK_LocacionCiudadActivaLocaciones]
ON [dbo].[CiudadActivaLocacionesSet]
    ([IdLocacion]);
GO

-- Creating foreign key on [IdRolLocador] in table 'LocacionRolLocadorSet'
ALTER TABLE [dbo].[LocacionRolLocadorSet]
ADD CONSTRAINT [FK_RolLocadorLocacionRolLocador]
    FOREIGN KEY ([IdRolLocador])
    REFERENCES [dbo].[RolLocadorSet]
        ([IdRolLocador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolLocadorLocacionRolLocador'
CREATE INDEX [IX_FK_RolLocadorLocacionRolLocador]
ON [dbo].[LocacionRolLocadorSet]
    ([IdRolLocador]);
GO

-- Creating foreign key on [IdLocacion] in table 'LocacionRolLocadorSet'
ALTER TABLE [dbo].[LocacionRolLocadorSet]
ADD CONSTRAINT [FK_LocacionLocacionRolLocador]
    FOREIGN KEY ([IdLocacion])
    REFERENCES [dbo].[LocacionSet]
        ([IdLocacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocacionLocacionRolLocador'
CREATE INDEX [IX_FK_LocacionLocacionRolLocador]
ON [dbo].[LocacionRolLocadorSet]
    ([IdLocacion]);
GO

-- Creating foreign key on [IdLocacion] in table 'RolLocacionAlojamientoSet'
ALTER TABLE [dbo].[RolLocacionAlojamientoSet]
ADD CONSTRAINT [FK_LocacionRolLocacionAlojamiento]
    FOREIGN KEY ([IdLocacion])
    REFERENCES [dbo].[LocacionSet]
        ([IdLocacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocacionRolLocacionAlojamiento'
CREATE INDEX [IX_FK_LocacionRolLocacionAlojamiento]
ON [dbo].[RolLocacionAlojamientoSet]
    ([IdLocacion]);
GO

-- Creating foreign key on [IdLocacion] in table 'RolLocacionSalonSet'
ALTER TABLE [dbo].[RolLocacionSalonSet]
ADD CONSTRAINT [FK_LocacionRolLocacionSalon]
    FOREIGN KEY ([IdLocacion])
    REFERENCES [dbo].[LocacionSet]
        ([IdLocacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocacionRolLocacionSalon'
CREATE INDEX [IX_FK_LocacionRolLocacionSalon]
ON [dbo].[RolLocacionSalonSet]
    ([IdLocacion]);
GO

-- Creating foreign key on [IdPlanBase] in table 'RolCiudadActivaPlanSet'
ALTER TABLE [dbo].[RolCiudadActivaPlanSet]
ADD CONSTRAINT [FK_PlanBaseRolCiudadActivaPlan]
    FOREIGN KEY ([IdPlanBase])
    REFERENCES [dbo].[PlanBaseSet]
        ([IdPlanBase])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlanBaseRolCiudadActivaPlan'
CREATE INDEX [IX_FK_PlanBaseRolCiudadActivaPlan]
ON [dbo].[RolCiudadActivaPlanSet]
    ([IdPlanBase]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'RolCiudadActivaPlanSet'
ALTER TABLE [dbo].[RolCiudadActivaPlanSet]
ADD CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaPlan]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaRolCiudadActivaPlan'
CREATE INDEX [IX_FK_RolCiudadActivaRolCiudadActivaPlan]
ON [dbo].[RolCiudadActivaPlanSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdRolAlumno] in table 'PlanVendedorAlumnoSet'
ALTER TABLE [dbo].[PlanVendedorAlumnoSet]
ADD CONSTRAINT [FK_RolAlumnoPlanVendedorAlumno]
    FOREIGN KEY ([IdRolAlumno])
    REFERENCES [dbo].[RolAlumno]
        ([IdRolAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolAlumnoPlanVendedorAlumno'
CREATE INDEX [IX_FK_RolAlumnoPlanVendedorAlumno]
ON [dbo].[PlanVendedorAlumnoSet]
    ([IdRolAlumno]);
GO

-- Creating foreign key on [IdRolVendedor] in table 'PlanVendedorAlumnoSet'
ALTER TABLE [dbo].[PlanVendedorAlumnoSet]
ADD CONSTRAINT [FK_RolVendedorPlanVendedorAlumno]
    FOREIGN KEY ([IdRolVendedor])
    REFERENCES [dbo].[RolVendedor]
        ([IdRolVendedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolVendedorPlanVendedorAlumno'
CREATE INDEX [IX_FK_RolVendedorPlanVendedorAlumno]
ON [dbo].[PlanVendedorAlumnoSet]
    ([IdRolVendedor]);
GO

-- Creating foreign key on [IdRolCiudadActivaPlan] in table 'PlanVendedorAlumnoSet'
ALTER TABLE [dbo].[PlanVendedorAlumnoSet]
ADD CONSTRAINT [FK_RolCiudadActivaPlanPlanVendedorAlumno]
    FOREIGN KEY ([IdRolCiudadActivaPlan])
    REFERENCES [dbo].[RolCiudadActivaPlanSet]
        ([IdRolCiudadActivaPlan])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaPlanPlanVendedorAlumno'
CREATE INDEX [IX_FK_RolCiudadActivaPlanPlanVendedorAlumno]
ON [dbo].[PlanVendedorAlumnoSet]
    ([IdRolCiudadActivaPlan]);
GO

-- Creating foreign key on [IdCapacitacion] in table 'RolAlumno'
ALTER TABLE [dbo].[RolAlumno]
ADD CONSTRAINT [FK_CapacitacionRolAlumno]
    FOREIGN KEY ([IdCapacitacion])
    REFERENCES [dbo].[CapacitacionSet]
        ([IdCapacitacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CapacitacionRolAlumno'
CREATE INDEX [IX_FK_CapacitacionRolAlumno]
ON [dbo].[RolAlumno]
    ([IdCapacitacion]);
GO

-- Creating foreign key on [IdHorario] in table 'RolCiudadActivaHorarioSet'
ALTER TABLE [dbo].[RolCiudadActivaHorarioSet]
ADD CONSTRAINT [FK_HorarioRolCiudadActivaHorario]
    FOREIGN KEY ([IdHorario])
    REFERENCES [dbo].[HorarioSet]
        ([IdHorario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HorarioRolCiudadActivaHorario'
CREATE INDEX [IX_FK_HorarioRolCiudadActivaHorario]
ON [dbo].[RolCiudadActivaHorarioSet]
    ([IdHorario]);
GO

-- Creating foreign key on [IdDia] in table 'RolCiudadActivaHorarioSet'
ALTER TABLE [dbo].[RolCiudadActivaHorarioSet]
ADD CONSTRAINT [FK_DiaRolCiudadActivaHorario]
    FOREIGN KEY ([IdDia])
    REFERENCES [dbo].[DiaSet]
        ([IdDia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiaRolCiudadActivaHorario'
CREATE INDEX [IX_FK_DiaRolCiudadActivaHorario]
ON [dbo].[RolCiudadActivaHorarioSet]
    ([IdDia]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'RolCiudadActivaHorarioSet'
ALTER TABLE [dbo].[RolCiudadActivaHorarioSet]
ADD CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaHorario]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaRolCiudadActivaHorario'
CREATE INDEX [IX_FK_RolCiudadActivaRolCiudadActivaHorario]
ON [dbo].[RolCiudadActivaHorarioSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdRolCiudadActivaHorario] in table 'RolAlumno'
ALTER TABLE [dbo].[RolAlumno]
ADD CONSTRAINT [FK_RolCiudadActivaHorarioRolAlumno]
    FOREIGN KEY ([IdRolCiudadActivaHorario])
    REFERENCES [dbo].[RolCiudadActivaHorarioSet]
        ([IdRolCiudadActivaHorario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaHorarioRolAlumno'
CREATE INDEX [IX_FK_RolCiudadActivaHorarioRolAlumno]
ON [dbo].[RolAlumno]
    ([IdRolCiudadActivaHorario]);
GO

-- Creating foreign key on [IdPersona] in table 'RolCobradorSet'
ALTER TABLE [dbo].[RolCobradorSet]
ADD CONSTRAINT [FK_PersonaRolCobrador]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRolCobrador'
CREATE INDEX [IX_FK_PersonaRolCobrador]
ON [dbo].[RolCobradorSet]
    ([IdPersona]);
GO

-- Creating foreign key on [IdEstadoRendicion] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [FK_EstadoRendicionRendicionCobradorCiudad]
    FOREIGN KEY ([IdEstadoRendicion])
    REFERENCES [dbo].[EstadoRendicionSet]
        ([IdEstadoRendicion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoRendicionRendicionCobradorCiudad'
CREATE INDEX [IX_FK_EstadoRendicionRendicionCobradorCiudad]
ON [dbo].[RendicionPersonaCiudadSet]
    ([IdEstadoRendicion]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [FK_RolCiudadActivaRendicionCobradorCiudad]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaRendicionCobradorCiudad'
CREATE INDEX [IX_FK_RolCiudadActivaRendicionCobradorCiudad]
ON [dbo].[RendicionPersonaCiudadSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdFormaPago] in table 'PagoSet'
ALTER TABLE [dbo].[PagoSet]
ADD CONSTRAINT [FK_FormaPagoPago]
    FOREIGN KEY ([IdFormaPago])
    REFERENCES [dbo].[FormaPagoSet]
        ([IdFormaPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaPagoPago'
CREATE INDEX [IX_FK_FormaPagoPago]
ON [dbo].[PagoSet]
    ([IdFormaPago]);
GO

-- Creating foreign key on [IdPlanVendedorAlumno] in table 'PagoSet'
ALTER TABLE [dbo].[PagoSet]
ADD CONSTRAINT [FK_PlanVendedorAlumnoPago]
    FOREIGN KEY ([IdPlanVendedorAlumno])
    REFERENCES [dbo].[PlanVendedorAlumnoSet]
        ([IdPlanVendedorAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlanVendedorAlumnoPago'
CREATE INDEX [IX_FK_PlanVendedorAlumnoPago]
ON [dbo].[PagoSet]
    ([IdPlanVendedorAlumno]);
GO

-- Creating foreign key on [IdPago] in table 'PagoTarjetaSet'
ALTER TABLE [dbo].[PagoTarjetaSet]
ADD CONSTRAINT [FK_PagoPagoTarjeta]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[PagoSet]
        ([IdPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoPagoTarjeta'
CREATE INDEX [IX_FK_PagoPagoTarjeta]
ON [dbo].[PagoTarjetaSet]
    ([IdPago]);
GO

-- Creating foreign key on [IdPersona] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [FK_PersonaRendicionPersonaCiudad]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaRendicionPersonaCiudad'
CREATE INDEX [IX_FK_PersonaRendicionPersonaCiudad]
ON [dbo].[RendicionPersonaCiudadSet]
    ([IdPersona]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
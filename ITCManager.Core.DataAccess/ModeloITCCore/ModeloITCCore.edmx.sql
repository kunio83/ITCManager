
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2016 19:17:59
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
IF OBJECT_ID(N'[dbo].[FK_PersonaRolEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolEmpleado] DROP CONSTRAINT [FK_PersonaRolEmpleado];
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
IF OBJECT_ID(N'[dbo].[FK_ItemPagadoPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoSet] DROP CONSTRAINT [FK_ItemPagadoPago];
GO
IF OBJECT_ID(N'[dbo].[FK_RendicionPersonaCiudadRendicionPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPagoSet] DROP CONSTRAINT [FK_RendicionPersonaCiudadRendicionPago];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoRendicionPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPagoSet] DROP CONSTRAINT [FK_PagoRendicionPago];
GO
IF OBJECT_ID(N'[dbo].[FK_GastoBaseRolCiudadActivaGastos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaGastosSet] DROP CONSTRAINT [FK_GastoBaseRolCiudadActivaGastos];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaRolCiudadActivaGastos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolCiudadActivaGastosSet] DROP CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaGastos];
GO
IF OBJECT_ID(N'[dbo].[FK_RendicionPersonaCiudadRendicionGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionGastoSet] DROP CONSTRAINT [FK_RendicionPersonaCiudadRendicionGasto];
GO
IF OBJECT_ID(N'[dbo].[FK_GastoBaseRendicionGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionGastoSet] DROP CONSTRAINT [FK_GastoBaseRendicionGasto];
GO
IF OBJECT_ID(N'[dbo].[FK_RendicionPersonaCiudadRendicionDeposito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionDepositoSet] DROP CONSTRAINT [FK_RendicionPersonaCiudadRendicionDeposito];
GO
IF OBJECT_ID(N'[dbo].[FK_DepositoRendicionDeposito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionDepositoSet] DROP CONSTRAINT [FK_DepositoRendicionDeposito];
GO
IF OBJECT_ID(N'[dbo].[FK_CuentaBancoDeposito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepositoSet] DROP CONSTRAINT [FK_CuentaBancoDeposito];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoDepositoDeposito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepositoSet] DROP CONSTRAINT [FK_EstadoDepositoDeposito];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaDeposito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepositoSet] DROP CONSTRAINT [FK_PersonaDeposito];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoPagoTarjetaPagoTarjeta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoTarjetaSet] DROP CONSTRAINT [FK_EstadoPagoTarjetaPagoTarjeta];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoPagoCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoChequeSet] DROP CONSTRAINT [FK_PagoPagoCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoChequeCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChequeSet] DROP CONSTRAINT [FK_TipoChequeCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoChequeCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChequeSet] DROP CONSTRAINT [FK_EstadoChequeCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaPagoRendicionGasto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionGastoSet] DROP CONSTRAINT [FK_FormaPagoRendicionGasto];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoPagoCheque1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoChequeSet] DROP CONSTRAINT [FK_PagoPagoCheque1];
GO
IF OBJECT_ID(N'[dbo].[FK_ChequePagoCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoChequeSet] DROP CONSTRAINT [FK_ChequePagoCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_ChequeGastoCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GastoChequeSet] DROP CONSTRAINT [FK_ChequeGastoCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_RendicionGastoGastoCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GastoChequeSet] DROP CONSTRAINT [FK_RendicionGastoGastoCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoCompraCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraSet] DROP CONSTRAINT [FK_EstadoCompraCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ChequeCompraCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalChequeSet] DROP CONSTRAINT [FK_ChequeCompraCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraDetalleCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCompraSet] DROP CONSTRAINT [FK_CompraDetalleCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosDetalleCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCompraSet] DROP CONSTRAINT [FK_ProductosDetalleCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProveedorCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraSet] DROP CONSTRAINT [FK_ProveedorCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_TarjetaPropiaCompraTarjeta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalTarjetaSet] DROP CONSTRAINT [FK_TarjetaPropiaCompraTarjeta];
GO
IF OBJECT_ID(N'[dbo].[FK_ArmadoEquipoDetalleArmadoEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleArmadoEquipoSet] DROP CONSTRAINT [FK_ArmadoEquipoDetalleArmadoEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosDetalleArmadoEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleArmadoEquipoSet] DROP CONSTRAINT [FK_ProductosDetalleArmadoEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_ArmadoEquipoCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadEquiposSet] DROP CONSTRAINT [FK_ArmadoEquipoCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_AsignacionCiudadEquiposCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadEquiposSet] DROP CONSTRAINT [FK_AsignacionCiudadEquiposCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosCiudadProductos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadProductosSet] DROP CONSTRAINT [FK_ProductosCiudadProductos];
GO
IF OBJECT_ID(N'[dbo].[FK_AsignacionCiudadEquiposCiudadProductos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadProductosSet] DROP CONSTRAINT [FK_AsignacionCiudadEquiposCiudadProductos];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaAsignacionCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AsignacionCiudadEquiposSet] DROP CONSTRAINT [FK_RolCiudadActivaAsignacionCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoAsignacionEquipoAsignacionCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AsignacionCiudadEquiposSet] DROP CONSTRAINT [FK_EstadoAsignacionEquipoAsignacionCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_CoeficTarjetasPagoTarjeta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoTarjetaSet] DROP CONSTRAINT [FK_CoeficTarjetasPagoTarjeta];
GO
IF OBJECT_ID(N'[dbo].[FK_ArmadoEquipoRendicionVentaEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionVentaEquipoSet] DROP CONSTRAINT [FK_ArmadoEquipoRendicionVentaEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoRendicionVentaEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionVentaEquipoSet] DROP CONSTRAINT [FK_PagoRendicionVentaEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoVentaRendicionVentaEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionVentaEquipoSet] DROP CONSTRAINT [FK_EstadoVentaRendicionVentaEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_ReciboAsignacionRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AsignacionReciboSet] DROP CONSTRAINT [FK_ReciboAsignacionRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_CuentaBancoChequePropio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChequePropioSet] DROP CONSTRAINT [FK_CuentaBancoChequePropio];
GO
IF OBJECT_ID(N'[dbo].[FK_ChequePropioCompraChequePropio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalChequePropioSet] DROP CONSTRAINT [FK_ChequePropioCompraChequePropio];
GO
IF OBJECT_ID(N'[dbo].[FK_CuentaBancoTransferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransferenciaSet] DROP CONSTRAINT [FK_CuentaBancoTransferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_CuentaBancoTerceroTransferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransferenciaSet] DROP CONSTRAINT [FK_CuentaBancoTerceroTransferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoTransferenciaTransferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransferenciaSet] DROP CONSTRAINT [FK_EstadoTransferenciaTransferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_TransferenciaCompraTransferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalTransferenciaSet] DROP CONSTRAINT [FK_TransferenciaCompraTransferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalCompraTransferencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalTransferenciaSet] DROP CONSTRAINT [FK_PagoLocalCompraTransferencia];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalPagoLocalChequePropio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalChequePropioSet] DROP CONSTRAINT [FK_PagoLocalPagoLocalChequePropio];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalPagoLocalTarjeta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalTarjetaSet] DROP CONSTRAINT [FK_PagoLocalPagoLocalTarjeta];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalPagoLocalCheque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalChequeSet] DROP CONSTRAINT [FK_PagoLocalPagoLocalCheque];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaPagoLocalPagoLocal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalSet] DROP CONSTRAINT [FK_FormaPagoLocalPagoLocal];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoRolVendedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_RolEmpleadoRolVendedor];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoRolVendedor1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_RolEmpleadoRolVendedor1];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoRolVendedor2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolVendedor] DROP CONSTRAINT [FK_RolEmpleadoRolVendedor2];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoAsignacionRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AsignacionReciboSet] DROP CONSTRAINT [FK_RolEmpleadoAsignacionRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoRendicionPersonaCiudad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RendicionPersonaCiudadSet] DROP CONSTRAINT [FK_RolEmpleadoRendicionPersonaCiudad];
GO
IF OBJECT_ID(N'[dbo].[FK_CondicionEmpleadoRolEmpleadoCondicion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCondicionEmpleado] DROP CONSTRAINT [FK_CondicionEmpleadoRolEmpleadoCondicion];
GO
IF OBJECT_ID(N'[dbo].[FK_RolEmpleadoRolDocente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolDocenteSet] DROP CONSTRAINT [FK_RolEmpleadoRolDocente];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaRolAlumno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumno] DROP CONSTRAINT [FK_PersonaRolAlumno];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaHorarioAlumnoHorario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlumnoHorarioSet] DROP CONSTRAINT [FK_RolCiudadActivaHorarioAlumnoHorario];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoAlumnoHorario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlumnoHorarioSet] DROP CONSTRAINT [FK_RolAlumnoAlumnoHorario];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoRolAlumnoPresentismo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumnoPresentismoSet] DROP CONSTRAINT [FK_RolAlumnoRolAlumnoPresentismo];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalGastoLocal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GastoLocalSet] DROP CONSTRAINT [FK_PagoLocalGastoLocal];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraSet] DROP CONSTRAINT [FK_PagoLocalCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalPagoLocalCajaEfectivo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalCajaEfectivoSet] DROP CONSTRAINT [FK_PagoLocalPagoLocalCajaEfectivo];
GO
IF OBJECT_ID(N'[dbo].[FK_ProveedorEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnvioSet] DROP CONSTRAINT [FK_ProveedorEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnvioSet] DROP CONSTRAINT [FK_RolCiudadActivaEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_EnvioEnvioCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnvioCiudadEquiposSet] DROP CONSTRAINT [FK_EnvioEnvioCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_PagoLocalPagoLocalEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalEnvioSet] DROP CONSTRAINT [FK_PagoLocalPagoLocalEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_CajaEfectivoMovimientoInternoEfectivo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovimientoInternoEfectivoSet] DROP CONSTRAINT [FK_CajaEfectivoMovimientoInternoEfectivo];
GO
IF OBJECT_ID(N'[dbo].[FK_CajaEfectivoMovimientoInternoEfectivo1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovimientoInternoEfectivoSet] DROP CONSTRAINT [FK_CajaEfectivoMovimientoInternoEfectivo1];
GO
IF OBJECT_ID(N'[dbo].[FK_AsignacionCiudadEquiposEnvioCiudadEquipos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnvioCiudadEquiposSet] DROP CONSTRAINT [FK_AsignacionCiudadEquiposEnvioCiudadEquipos];
GO
IF OBJECT_ID(N'[dbo].[FK_RolCiudadActivaCiudadFechasHorarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CiudadFechasHorariosSet] DROP CONSTRAINT [FK_RolCiudadActivaCiudadFechasHorarios];
GO
IF OBJECT_ID(N'[dbo].[FK_RolAlumnoRolAlumnoPracticas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumnoPracticasSet] DROP CONSTRAINT [FK_RolAlumnoRolAlumnoPracticas];
GO
IF OBJECT_ID(N'[dbo].[FK_CiudadFechasHorariosRolAlumnoPracticas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolAlumnoPracticasSet] DROP CONSTRAINT [FK_CiudadFechasHorariosRolAlumnoPracticas];
GO
IF OBJECT_ID(N'[dbo].[FK_CajaEfectivoPagoLocalCajaEfectivo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagoLocalCajaEfectivoSet] DROP CONSTRAINT [FK_CajaEfectivoPagoLocalCajaEfectivo];
GO
IF OBJECT_ID(N'[dbo].[FK_PuestoRolEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolEmpleado] DROP CONSTRAINT [FK_PuestoRolEmpleado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

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
IF OBJECT_ID(N'[dbo].[ItemPagadoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemPagadoSet];
GO
IF OBJECT_ID(N'[dbo].[RendicionPagoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RendicionPagoSet];
GO
IF OBJECT_ID(N'[dbo].[GastoBaseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GastoBaseSet];
GO
IF OBJECT_ID(N'[dbo].[RolCiudadActivaGastosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolCiudadActivaGastosSet];
GO
IF OBJECT_ID(N'[dbo].[RendicionGastoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RendicionGastoSet];
GO
IF OBJECT_ID(N'[dbo].[RendicionDepositoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RendicionDepositoSet];
GO
IF OBJECT_ID(N'[dbo].[DepositoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepositoSet];
GO
IF OBJECT_ID(N'[dbo].[CuentaBancoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuentaBancoSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoDepositoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoDepositoSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoPagoTarjetaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoPagoTarjetaSet];
GO
IF OBJECT_ID(N'[dbo].[PagoChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoChequeSet];
GO
IF OBJECT_ID(N'[dbo].[ChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChequeSet];
GO
IF OBJECT_ID(N'[dbo].[TipoChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoChequeSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoChequeSet];
GO
IF OBJECT_ID(N'[dbo].[GastoChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GastoChequeSet];
GO
IF OBJECT_ID(N'[dbo].[ProductosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductosSet];
GO
IF OBJECT_ID(N'[dbo].[ProveedorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProveedorSet];
GO
IF OBJECT_ID(N'[dbo].[CompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompraSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoCompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoCompraSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalChequeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalChequeSet];
GO
IF OBJECT_ID(N'[dbo].[DetalleCompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleCompraSet];
GO
IF OBJECT_ID(N'[dbo].[TarjetaPropiaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TarjetaPropiaSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalTarjetaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalTarjetaSet];
GO
IF OBJECT_ID(N'[dbo].[ArmadoEquipoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArmadoEquipoSet];
GO
IF OBJECT_ID(N'[dbo].[DetalleArmadoEquipoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleArmadoEquipoSet];
GO
IF OBJECT_ID(N'[dbo].[AsignacionCiudadEquiposSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AsignacionCiudadEquiposSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadEquiposSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadEquiposSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadProductosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadProductosSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoAsignacionEquipoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoAsignacionEquipoSet];
GO
IF OBJECT_ID(N'[dbo].[CoeficTarjetasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoeficTarjetasSet];
GO
IF OBJECT_ID(N'[dbo].[RendicionVentaEquipoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RendicionVentaEquipoSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoVentaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoVentaSet];
GO
IF OBJECT_ID(N'[dbo].[ReciboSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReciboSet];
GO
IF OBJECT_ID(N'[dbo].[ChequePropioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChequePropioSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalChequePropioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalChequePropioSet];
GO
IF OBJECT_ID(N'[dbo].[FormaPagoLocalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaPagoLocalSet];
GO
IF OBJECT_ID(N'[dbo].[CuentaBancoTerceroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuentaBancoTerceroSet];
GO
IF OBJECT_ID(N'[dbo].[TransferenciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransferenciaSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoTransferenciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoTransferenciaSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalTransferenciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalTransferenciaSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalSet];
GO
IF OBJECT_ID(N'[dbo].[GastoLocalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GastoLocalSet];
GO
IF OBJECT_ID(N'[dbo].[CondicionEmpleadoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CondicionEmpleadoSet];
GO
IF OBJECT_ID(N'[dbo].[RolDocenteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolDocenteSet];
GO
IF OBJECT_ID(N'[dbo].[AlumnoHorarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlumnoHorarioSet];
GO
IF OBJECT_ID(N'[dbo].[CiudadFechasHorariosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CiudadFechasHorariosSet];
GO
IF OBJECT_ID(N'[dbo].[RolAlumnoPresentismoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolAlumnoPresentismoSet];
GO
IF OBJECT_ID(N'[dbo].[RolAlumnoPracticasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolAlumnoPracticasSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalCajaEfectivoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalCajaEfectivoSet];
GO
IF OBJECT_ID(N'[dbo].[MovimientoInternoEfectivoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovimientoInternoEfectivoSet];
GO
IF OBJECT_ID(N'[dbo].[EnvioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EnvioSet];
GO
IF OBJECT_ID(N'[dbo].[EnvioCiudadEquiposSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EnvioCiudadEquiposSet];
GO
IF OBJECT_ID(N'[dbo].[PagoLocalEnvioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagoLocalEnvioSet];
GO
IF OBJECT_ID(N'[dbo].[CajaEfectivoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CajaEfectivoSet];
GO
IF OBJECT_ID(N'[dbo].[PuestoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PuestoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DetalleCondicionEmpleado'
CREATE TABLE [dbo].[DetalleCondicionEmpleado] (
    [IdRolEmpleadoCondicion] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [IdCondicionEmpleado] int  NOT NULL,
    [MontoCondicion] nvarchar(max)  NOT NULL
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
    [IdEstadoAlumno] int  NOT NULL
);
GO

-- Creating table 'RolEmpleado'
CREATE TABLE [dbo].[RolEmpleado] (
    [IdRolEmpleado] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [IdPuesto] int  NOT NULL,
    [CelCorp] nvarchar(max)  NOT NULL,
    [Usuario] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [SueldoBasico] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'RolVendedor'
CREATE TABLE [dbo].[RolVendedor] (
    [IdRolVendedor] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL,
    [IdSubgerente] int  NOT NULL,
    [IdGerente] int  NOT NULL
);
GO

-- Creating table 'AsignacionReciboSet'
CREATE TABLE [dbo].[AsignacionReciboSet] (
    [IdAsignacionRecibo] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [IdRecibo] int  NOT NULL,
    [IdRolEmpleado] int  NOT NULL
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
    [IdCiudad] int  NOT NULL,
    [FechaInicioVenta] nvarchar(max)  NOT NULL,
    [FechaInicioDictado] nvarchar(max)  NOT NULL,
    [CantidadClases] nvarchar(max)  NOT NULL
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
    [NroRecibo] nvarchar(max)  NOT NULL,
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

-- Creating table 'RendicionPersonaCiudadSet'
CREATE TABLE [dbo].[RendicionPersonaCiudadSet] (
    [IdRendicionEmpleadoCiudad] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL,
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
    [IdItemPagado] int  NOT NULL,
    [NroRecibo] nvarchar(max)  NOT NULL
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
    [IdCuotas] int  NOT NULL,
    [Recargo] nvarchar(max)  NOT NULL,
    [MontoTotal] nvarchar(max)  NOT NULL,
    [NumeroTarjeta] nvarchar(max)  NOT NULL,
    [EmisorTarjeta] nvarchar(max)  NOT NULL,
    [CodSeguridad] nvarchar(max)  NOT NULL,
    [Vencimiento] nvarchar(max)  NOT NULL,
    [TitularTarjeta] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [CodAut] nvarchar(max)  NOT NULL,
    [IdEstadoPagoTarjeta] int  NOT NULL
);
GO

-- Creating table 'ItemPagadoSet'
CREATE TABLE [dbo].[ItemPagadoSet] (
    [IdItemPagado] int IDENTITY(1,1) NOT NULL,
    [DetalleItemPagado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RendicionPagoSet'
CREATE TABLE [dbo].[RendicionPagoSet] (
    [IdRendicionPago] int IDENTITY(1,1) NOT NULL,
    [IdRendicionEmpleadoCiudad] int  NOT NULL,
    [IdPago] int  NOT NULL
);
GO

-- Creating table 'GastoBaseSet'
CREATE TABLE [dbo].[GastoBaseSet] (
    [IdGastoBase] int IDENTITY(1,1) NOT NULL,
    [DetalleGastoBase] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolCiudadActivaGastosSet'
CREATE TABLE [dbo].[RolCiudadActivaGastosSet] (
    [IdRolCiudadActivaGastos] int IDENTITY(1,1) NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [IdGastoBase] int  NOT NULL,
    [ValorEstimMensual] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RendicionGastoSet'
CREATE TABLE [dbo].[RendicionGastoSet] (
    [IdRendicionGasto] int IDENTITY(1,1) NOT NULL,
    [IdRendicionEmpleadoCiudad] int  NOT NULL,
    [IdGastoBase] int  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [IdFormaPago] int  NOT NULL
);
GO

-- Creating table 'RendicionDepositoSet'
CREATE TABLE [dbo].[RendicionDepositoSet] (
    [IdRendicionDeposito] int IDENTITY(1,1) NOT NULL,
    [IdRendicionEmpleadoCiudad] int  NOT NULL,
    [IdDeposito] int  NOT NULL
);
GO

-- Creating table 'DepositoSet'
CREATE TABLE [dbo].[DepositoSet] (
    [IdDeposito] int IDENTITY(1,1) NOT NULL,
    [IdPersona] int  NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [IdCuentaBanco] int  NOT NULL,
    [IdEstadoDeposito] int  NOT NULL
);
GO

-- Creating table 'CuentaBancoSet'
CREATE TABLE [dbo].[CuentaBancoSet] (
    [IdCuentaBanco] int IDENTITY(1,1) NOT NULL,
    [Banco] nvarchar(max)  NOT NULL,
    [NroCuenta] nvarchar(max)  NOT NULL,
    [TipoCuenta] nvarchar(max)  NOT NULL,
    [CBU] nvarchar(max)  NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [Cuit] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL,
    [CuentaActiva] bit  NOT NULL
);
GO

-- Creating table 'EstadoDepositoSet'
CREATE TABLE [dbo].[EstadoDepositoSet] (
    [IdEstadoDeposito] int IDENTITY(1,1) NOT NULL,
    [DetalleEstado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstadoPagoTarjetaSet'
CREATE TABLE [dbo].[EstadoPagoTarjetaSet] (
    [IdEstadoPagoTarjeta] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoPagoTarjeta] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoChequeSet'
CREATE TABLE [dbo].[PagoChequeSet] (
    [IdPagoCheque] int IDENTITY(1,1) NOT NULL,
    [IdPago] int  NOT NULL,
    [IdCheque] int  NOT NULL
);
GO

-- Creating table 'ChequeSet'
CREATE TABLE [dbo].[ChequeSet] (
    [IdCheque] int IDENTITY(1,1) NOT NULL,
    [Banco] nvarchar(max)  NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [NroCheque] nvarchar(max)  NOT NULL,
    [FechaEmision] nvarchar(max)  NOT NULL,
    [FechaPago] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [IdTipoCheque] int  NOT NULL,
    [IdEstadoCheque] int  NOT NULL
);
GO

-- Creating table 'TipoChequeSet'
CREATE TABLE [dbo].[TipoChequeSet] (
    [IdTipoCheque] int IDENTITY(1,1) NOT NULL,
    [DetalleTipoCheque] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstadoChequeSet'
CREATE TABLE [dbo].[EstadoChequeSet] (
    [IdEstadoCheque] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoCheque] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GastoChequeSet'
CREATE TABLE [dbo].[GastoChequeSet] (
    [IdGastoCheque] int IDENTITY(1,1) NOT NULL,
    [IdRendicionGasto] int  NOT NULL,
    [IdCheque] int  NOT NULL
);
GO

-- Creating table 'ProductosSet'
CREATE TABLE [dbo].[ProductosSet] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [DetalleProducto] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL,
    [TipoProducto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProveedorSet'
CREATE TABLE [dbo].[ProveedorSet] (
    [IdProveedor] int IDENTITY(1,1) NOT NULL,
    [RazonSocial] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL,
    [TelefonoContacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompraSet'
CREATE TABLE [dbo].[CompraSet] (
    [IdCompra] int IDENTITY(1,1) NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [IdProveedor] int  NOT NULL,
    [IdEstadoCompra] int  NOT NULL,
    [IdPagoLocal] int  NOT NULL
);
GO

-- Creating table 'EstadoCompraSet'
CREATE TABLE [dbo].[EstadoCompraSet] (
    [IdEstadoCompra] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoCompra] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoLocalChequeSet'
CREATE TABLE [dbo].[PagoLocalChequeSet] (
    [IdPagoLocalCheque] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [IdCheque] int  NOT NULL
);
GO

-- Creating table 'DetalleCompraSet'
CREATE TABLE [dbo].[DetalleCompraSet] (
    [IdDetalleCompra] int IDENTITY(1,1) NOT NULL,
    [IdCompra] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [Cantidad] nvarchar(max)  NOT NULL,
    [Precio] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TarjetaPropiaSet'
CREATE TABLE [dbo].[TarjetaPropiaSet] (
    [IdTarjetaPropia] int IDENTITY(1,1) NOT NULL,
    [Emsior] nvarchar(max)  NOT NULL,
    [NroTarjeta] nvarchar(max)  NOT NULL,
    [FechaVto] nvarchar(max)  NOT NULL,
    [CodSeguridad] nvarchar(max)  NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoLocalTarjetaSet'
CREATE TABLE [dbo].[PagoLocalTarjetaSet] (
    [IdPagoLocalTarjeta] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [IdTarjetaPropia] int  NOT NULL,
    [CantCuotas] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ArmadoEquipoSet'
CREATE TABLE [dbo].[ArmadoEquipoSet] (
    [IdArmadoEquipo] int IDENTITY(1,1) NOT NULL,
    [NumeroEquipo] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalleArmadoEquipoSet'
CREATE TABLE [dbo].[DetalleArmadoEquipoSet] (
    [IdDetalleArmadoEquipo] int IDENTITY(1,1) NOT NULL,
    [IdArmadoEquipo] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [Cantidad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AsignacionCiudadEquiposSet'
CREATE TABLE [dbo].[AsignacionCiudadEquiposSet] (
    [IdAsignacionCiudadEquipo] int IDENTITY(1,1) NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [IdEstadoAsignacionEquipo] int  NOT NULL
);
GO

-- Creating table 'CiudadEquiposSet'
CREATE TABLE [dbo].[CiudadEquiposSet] (
    [IdCiudadEquipos] int IDENTITY(1,1) NOT NULL,
    [IdAsignacionCiudadEquipo] int  NOT NULL,
    [IdArmadoEquipo] int  NOT NULL
);
GO

-- Creating table 'CiudadProductosSet'
CREATE TABLE [dbo].[CiudadProductosSet] (
    [IdCiudadProductos] int IDENTITY(1,1) NOT NULL,
    [IdAsignacionCiudadEquipo] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [Cantidad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstadoAsignacionEquipoSet'
CREATE TABLE [dbo].[EstadoAsignacionEquipoSet] (
    [IdEstadoAsignacionEquipo] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoASignacionEquipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CoeficTarjetasSet'
CREATE TABLE [dbo].[CoeficTarjetasSet] (
    [IdCuotas] int IDENTITY(1,1) NOT NULL,
    [Coeficiente] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RendicionVentaEquipoSet'
CREATE TABLE [dbo].[RendicionVentaEquipoSet] (
    [IdRendicionVentaEquipo] int IDENTITY(1,1) NOT NULL,
    [IdPago] int  NOT NULL,
    [IdArmadoEquipo] int  NOT NULL,
    [IdEstadoVenta] int  NOT NULL
);
GO

-- Creating table 'EstadoVentaSet'
CREATE TABLE [dbo].[EstadoVentaSet] (
    [IdEstadoVenta] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoVenta] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ReciboSet'
CREATE TABLE [dbo].[ReciboSet] (
    [IdRecibo] int IDENTITY(1,1) NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ChequePropioSet'
CREATE TABLE [dbo].[ChequePropioSet] (
    [IdChequePropio] int IDENTITY(1,1) NOT NULL,
    [NroCheque] nvarchar(max)  NOT NULL,
    [FechaEmision] nvarchar(max)  NOT NULL,
    [FechaPago] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [Destinatario] nvarchar(max)  NOT NULL,
    [IdEstadoCheque] int  NOT NULL,
    [IdCuentaBanco] int  NOT NULL
);
GO

-- Creating table 'PagoLocalChequePropioSet'
CREATE TABLE [dbo].[PagoLocalChequePropioSet] (
    [IdPagoLocalChequePropio] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [IdChequePropio] int  NOT NULL
);
GO

-- Creating table 'FormaPagoLocalSet'
CREATE TABLE [dbo].[FormaPagoLocalSet] (
    [IdFormaPagoLocal] int IDENTITY(1,1) NOT NULL,
    [DetalleFormaPagoLocal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CuentaBancoTerceroSet'
CREATE TABLE [dbo].[CuentaBancoTerceroSet] (
    [IdCuentaBanco] int IDENTITY(1,1) NOT NULL,
    [Banco] nvarchar(max)  NOT NULL,
    [NroCuenta] nvarchar(max)  NOT NULL,
    [TipoCuenta] nvarchar(max)  NOT NULL,
    [CBU] nvarchar(max)  NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [Cuit] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL,
    [CuentaActiva] bit  NOT NULL
);
GO

-- Creating table 'TransferenciaSet'
CREATE TABLE [dbo].[TransferenciaSet] (
    [IdTransferencia] int IDENTITY(1,1) NOT NULL,
    [IdCuentaBanco] int  NOT NULL,
    [IdCuentaBancoTercero] int  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [IdEstadoTransferencia] int  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstadoTransferenciaSet'
CREATE TABLE [dbo].[EstadoTransferenciaSet] (
    [IdEstadoTransferencia] int IDENTITY(1,1) NOT NULL,
    [DetalleEstadoTransferencia] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagoLocalTransferenciaSet'
CREATE TABLE [dbo].[PagoLocalTransferenciaSet] (
    [IdPagoLocalTransferencia] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [IdTransferencia] int  NOT NULL
);
GO

-- Creating table 'PagoLocalSet'
CREATE TABLE [dbo].[PagoLocalSet] (
    [IdPagoLocal] int IDENTITY(1,1) NOT NULL,
    [FechaPago] nvarchar(max)  NOT NULL,
    [IdFormaPagoLocal] int  NOT NULL
);
GO

-- Creating table 'GastoLocalSet'
CREATE TABLE [dbo].[GastoLocalSet] (
    [IdGastoLocal] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Detalle] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CondicionEmpleadoSet'
CREATE TABLE [dbo].[CondicionEmpleadoSet] (
    [IdCondicionEmpleado] int IDENTITY(1,1) NOT NULL,
    [DetalleCOndicionEmpleado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolDocenteSet'
CREATE TABLE [dbo].[RolDocenteSet] (
    [IdRolDocente] int IDENTITY(1,1) NOT NULL,
    [IdRolEmpleado] int  NOT NULL
);
GO

-- Creating table 'AlumnoHorarioSet'
CREATE TABLE [dbo].[AlumnoHorarioSet] (
    [IdAlumnoHorario] int IDENTITY(1,1) NOT NULL,
    [IdRolAlumno] int  NOT NULL,
    [IdRolCiudadActivaHorario] int  NOT NULL,
    [TipoHorario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CiudadFechasHorariosSet'
CREATE TABLE [dbo].[CiudadFechasHorariosSet] (
    [IdCiudadFechasHorarios] int IDENTITY(1,1) NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [IdRolCiudadActivaHorarios] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolAlumnoPresentismoSet'
CREATE TABLE [dbo].[RolAlumnoPresentismoSet] (
    [IdRolAlumnoPresentismo] int IDENTITY(1,1) NOT NULL,
    [IdRolAlumno] int  NOT NULL,
    [NumeroClase] nvarchar(max)  NOT NULL,
    [EstadoClase] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolAlumnoPracticasSet'
CREATE TABLE [dbo].[RolAlumnoPracticasSet] (
    [IdRolAlumnoPracticas] int IDENTITY(1,1) NOT NULL,
    [IdCiudadFechasHorarios] int  NOT NULL,
    [TipoPractica] nvarchar(max)  NOT NULL,
    [EstadoPractica] nvarchar(max)  NOT NULL,
    [IdRolAlumno] int  NOT NULL
);
GO

-- Creating table 'PagoLocalCajaEfectivoSet'
CREATE TABLE [dbo].[PagoLocalCajaEfectivoSet] (
    [IdPagoLocalCajaEfectivo] int IDENTITY(1,1) NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [FechaPagoCajaEfectivo] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [IdCajaEfectivo] int  NOT NULL
);
GO

-- Creating table 'MovimientoInternoEfectivoSet'
CREATE TABLE [dbo].[MovimientoInternoEfectivoSet] (
    [IdMovimientoInternoEfectivo] int IDENTITY(1,1) NOT NULL,
    [IdCajaEfectivoOrigen] int  NOT NULL,
    [FechaMovimientoInternoEfectivo] nvarchar(max)  NOT NULL,
    [IdcajaEfectivoDestino] int  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EnvioSet'
CREATE TABLE [dbo].[EnvioSet] (
    [IdEnvio] int IDENTITY(1,1) NOT NULL,
    [FechaSolicitudEnvío] nvarchar(max)  NOT NULL,
    [FechaSalidaEnvío] nvarchar(max)  NOT NULL,
    [FechaEstimadaRecepción] nvarchar(max)  NOT NULL,
    [IdProveedor] int  NOT NULL,
    [TipoRetiroEnvio] nvarchar(max)  NOT NULL,
    [TipoEntregaEnvio] nvarchar(max)  NOT NULL,
    [CantidadBultos] nvarchar(max)  NOT NULL,
    [CiudadOrigenEnvio] nvarchar(max)  NOT NULL,
    [CiudadDestinoEnvio] nvarchar(max)  NOT NULL,
    [IdRolCiudadActiva] int  NOT NULL,
    [Remitente] nvarchar(max)  NOT NULL,
    [Destinatarios] nvarchar(max)  NOT NULL,
    [TipoPago] nvarchar(max)  NOT NULL,
    [Monto] nvarchar(max)  NOT NULL,
    [EstadoEnvio] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EnvioCiudadEquiposSet'
CREATE TABLE [dbo].[EnvioCiudadEquiposSet] (
    [IdEnvioCiudadEquipos] int IDENTITY(1,1) NOT NULL,
    [IdEnvio] int  NOT NULL,
    [IdAsignacionCiudadEquipo] int  NOT NULL
);
GO

-- Creating table 'PagoLocalEnvioSet'
CREATE TABLE [dbo].[PagoLocalEnvioSet] (
    [IdPagoLocalEnvio] int IDENTITY(1,1) NOT NULL,
    [IdEnvio] nvarchar(max)  NOT NULL,
    [IdPagoLocal] int  NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Observaciones] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CajaEfectivoSet'
CREATE TABLE [dbo].[CajaEfectivoSet] (
    [IdCajaEfectivo] int IDENTITY(1,1) NOT NULL,
    [DetalleCajaEfectivo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PuestoSet'
CREATE TABLE [dbo].[PuestoSet] (
    [IdPuesto] int IDENTITY(1,1) NOT NULL,
    [DetallePuesto] nvarchar(max)  NOT NULL,
    [SueldoBasico] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdRolEmpleadoCondicion] in table 'DetalleCondicionEmpleado'
ALTER TABLE [dbo].[DetalleCondicionEmpleado]
ADD CONSTRAINT [PK_DetalleCondicionEmpleado]
    PRIMARY KEY CLUSTERED ([IdRolEmpleadoCondicion] ASC);
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

-- Creating primary key on [IdRendicionEmpleadoCiudad] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [PK_RendicionPersonaCiudadSet]
    PRIMARY KEY CLUSTERED ([IdRendicionEmpleadoCiudad] ASC);
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

-- Creating primary key on [IdItemPagado] in table 'ItemPagadoSet'
ALTER TABLE [dbo].[ItemPagadoSet]
ADD CONSTRAINT [PK_ItemPagadoSet]
    PRIMARY KEY CLUSTERED ([IdItemPagado] ASC);
GO

-- Creating primary key on [IdRendicionPago] in table 'RendicionPagoSet'
ALTER TABLE [dbo].[RendicionPagoSet]
ADD CONSTRAINT [PK_RendicionPagoSet]
    PRIMARY KEY CLUSTERED ([IdRendicionPago] ASC);
GO

-- Creating primary key on [IdGastoBase] in table 'GastoBaseSet'
ALTER TABLE [dbo].[GastoBaseSet]
ADD CONSTRAINT [PK_GastoBaseSet]
    PRIMARY KEY CLUSTERED ([IdGastoBase] ASC);
GO

-- Creating primary key on [IdRolCiudadActivaGastos] in table 'RolCiudadActivaGastosSet'
ALTER TABLE [dbo].[RolCiudadActivaGastosSet]
ADD CONSTRAINT [PK_RolCiudadActivaGastosSet]
    PRIMARY KEY CLUSTERED ([IdRolCiudadActivaGastos] ASC);
GO

-- Creating primary key on [IdRendicionGasto] in table 'RendicionGastoSet'
ALTER TABLE [dbo].[RendicionGastoSet]
ADD CONSTRAINT [PK_RendicionGastoSet]
    PRIMARY KEY CLUSTERED ([IdRendicionGasto] ASC);
GO

-- Creating primary key on [IdRendicionDeposito] in table 'RendicionDepositoSet'
ALTER TABLE [dbo].[RendicionDepositoSet]
ADD CONSTRAINT [PK_RendicionDepositoSet]
    PRIMARY KEY CLUSTERED ([IdRendicionDeposito] ASC);
GO

-- Creating primary key on [IdDeposito] in table 'DepositoSet'
ALTER TABLE [dbo].[DepositoSet]
ADD CONSTRAINT [PK_DepositoSet]
    PRIMARY KEY CLUSTERED ([IdDeposito] ASC);
GO

-- Creating primary key on [IdCuentaBanco] in table 'CuentaBancoSet'
ALTER TABLE [dbo].[CuentaBancoSet]
ADD CONSTRAINT [PK_CuentaBancoSet]
    PRIMARY KEY CLUSTERED ([IdCuentaBanco] ASC);
GO

-- Creating primary key on [IdEstadoDeposito] in table 'EstadoDepositoSet'
ALTER TABLE [dbo].[EstadoDepositoSet]
ADD CONSTRAINT [PK_EstadoDepositoSet]
    PRIMARY KEY CLUSTERED ([IdEstadoDeposito] ASC);
GO

-- Creating primary key on [IdEstadoPagoTarjeta] in table 'EstadoPagoTarjetaSet'
ALTER TABLE [dbo].[EstadoPagoTarjetaSet]
ADD CONSTRAINT [PK_EstadoPagoTarjetaSet]
    PRIMARY KEY CLUSTERED ([IdEstadoPagoTarjeta] ASC);
GO

-- Creating primary key on [IdPagoCheque] in table 'PagoChequeSet'
ALTER TABLE [dbo].[PagoChequeSet]
ADD CONSTRAINT [PK_PagoChequeSet]
    PRIMARY KEY CLUSTERED ([IdPagoCheque] ASC);
GO

-- Creating primary key on [IdCheque] in table 'ChequeSet'
ALTER TABLE [dbo].[ChequeSet]
ADD CONSTRAINT [PK_ChequeSet]
    PRIMARY KEY CLUSTERED ([IdCheque] ASC);
GO

-- Creating primary key on [IdTipoCheque] in table 'TipoChequeSet'
ALTER TABLE [dbo].[TipoChequeSet]
ADD CONSTRAINT [PK_TipoChequeSet]
    PRIMARY KEY CLUSTERED ([IdTipoCheque] ASC);
GO

-- Creating primary key on [IdEstadoCheque] in table 'EstadoChequeSet'
ALTER TABLE [dbo].[EstadoChequeSet]
ADD CONSTRAINT [PK_EstadoChequeSet]
    PRIMARY KEY CLUSTERED ([IdEstadoCheque] ASC);
GO

-- Creating primary key on [IdGastoCheque] in table 'GastoChequeSet'
ALTER TABLE [dbo].[GastoChequeSet]
ADD CONSTRAINT [PK_GastoChequeSet]
    PRIMARY KEY CLUSTERED ([IdGastoCheque] ASC);
GO

-- Creating primary key on [IdProducto] in table 'ProductosSet'
ALTER TABLE [dbo].[ProductosSet]
ADD CONSTRAINT [PK_ProductosSet]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdProveedor] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [PK_ProveedorSet]
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC);
GO

-- Creating primary key on [IdCompra] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [PK_CompraSet]
    PRIMARY KEY CLUSTERED ([IdCompra] ASC);
GO

-- Creating primary key on [IdEstadoCompra] in table 'EstadoCompraSet'
ALTER TABLE [dbo].[EstadoCompraSet]
ADD CONSTRAINT [PK_EstadoCompraSet]
    PRIMARY KEY CLUSTERED ([IdEstadoCompra] ASC);
GO

-- Creating primary key on [IdPagoLocalCheque] in table 'PagoLocalChequeSet'
ALTER TABLE [dbo].[PagoLocalChequeSet]
ADD CONSTRAINT [PK_PagoLocalChequeSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalCheque] ASC);
GO

-- Creating primary key on [IdDetalleCompra] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [PK_DetalleCompraSet]
    PRIMARY KEY CLUSTERED ([IdDetalleCompra] ASC);
GO

-- Creating primary key on [IdTarjetaPropia] in table 'TarjetaPropiaSet'
ALTER TABLE [dbo].[TarjetaPropiaSet]
ADD CONSTRAINT [PK_TarjetaPropiaSet]
    PRIMARY KEY CLUSTERED ([IdTarjetaPropia] ASC);
GO

-- Creating primary key on [IdPagoLocalTarjeta] in table 'PagoLocalTarjetaSet'
ALTER TABLE [dbo].[PagoLocalTarjetaSet]
ADD CONSTRAINT [PK_PagoLocalTarjetaSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalTarjeta] ASC);
GO

-- Creating primary key on [IdArmadoEquipo] in table 'ArmadoEquipoSet'
ALTER TABLE [dbo].[ArmadoEquipoSet]
ADD CONSTRAINT [PK_ArmadoEquipoSet]
    PRIMARY KEY CLUSTERED ([IdArmadoEquipo] ASC);
GO

-- Creating primary key on [IdDetalleArmadoEquipo] in table 'DetalleArmadoEquipoSet'
ALTER TABLE [dbo].[DetalleArmadoEquipoSet]
ADD CONSTRAINT [PK_DetalleArmadoEquipoSet]
    PRIMARY KEY CLUSTERED ([IdDetalleArmadoEquipo] ASC);
GO

-- Creating primary key on [IdAsignacionCiudadEquipo] in table 'AsignacionCiudadEquiposSet'
ALTER TABLE [dbo].[AsignacionCiudadEquiposSet]
ADD CONSTRAINT [PK_AsignacionCiudadEquiposSet]
    PRIMARY KEY CLUSTERED ([IdAsignacionCiudadEquipo] ASC);
GO

-- Creating primary key on [IdCiudadEquipos] in table 'CiudadEquiposSet'
ALTER TABLE [dbo].[CiudadEquiposSet]
ADD CONSTRAINT [PK_CiudadEquiposSet]
    PRIMARY KEY CLUSTERED ([IdCiudadEquipos] ASC);
GO

-- Creating primary key on [IdCiudadProductos] in table 'CiudadProductosSet'
ALTER TABLE [dbo].[CiudadProductosSet]
ADD CONSTRAINT [PK_CiudadProductosSet]
    PRIMARY KEY CLUSTERED ([IdCiudadProductos] ASC);
GO

-- Creating primary key on [IdEstadoAsignacionEquipo] in table 'EstadoAsignacionEquipoSet'
ALTER TABLE [dbo].[EstadoAsignacionEquipoSet]
ADD CONSTRAINT [PK_EstadoAsignacionEquipoSet]
    PRIMARY KEY CLUSTERED ([IdEstadoAsignacionEquipo] ASC);
GO

-- Creating primary key on [IdCuotas] in table 'CoeficTarjetasSet'
ALTER TABLE [dbo].[CoeficTarjetasSet]
ADD CONSTRAINT [PK_CoeficTarjetasSet]
    PRIMARY KEY CLUSTERED ([IdCuotas] ASC);
GO

-- Creating primary key on [IdRendicionVentaEquipo] in table 'RendicionVentaEquipoSet'
ALTER TABLE [dbo].[RendicionVentaEquipoSet]
ADD CONSTRAINT [PK_RendicionVentaEquipoSet]
    PRIMARY KEY CLUSTERED ([IdRendicionVentaEquipo] ASC);
GO

-- Creating primary key on [IdEstadoVenta] in table 'EstadoVentaSet'
ALTER TABLE [dbo].[EstadoVentaSet]
ADD CONSTRAINT [PK_EstadoVentaSet]
    PRIMARY KEY CLUSTERED ([IdEstadoVenta] ASC);
GO

-- Creating primary key on [IdRecibo] in table 'ReciboSet'
ALTER TABLE [dbo].[ReciboSet]
ADD CONSTRAINT [PK_ReciboSet]
    PRIMARY KEY CLUSTERED ([IdRecibo] ASC);
GO

-- Creating primary key on [IdChequePropio] in table 'ChequePropioSet'
ALTER TABLE [dbo].[ChequePropioSet]
ADD CONSTRAINT [PK_ChequePropioSet]
    PRIMARY KEY CLUSTERED ([IdChequePropio] ASC);
GO

-- Creating primary key on [IdPagoLocalChequePropio] in table 'PagoLocalChequePropioSet'
ALTER TABLE [dbo].[PagoLocalChequePropioSet]
ADD CONSTRAINT [PK_PagoLocalChequePropioSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalChequePropio] ASC);
GO

-- Creating primary key on [IdFormaPagoLocal] in table 'FormaPagoLocalSet'
ALTER TABLE [dbo].[FormaPagoLocalSet]
ADD CONSTRAINT [PK_FormaPagoLocalSet]
    PRIMARY KEY CLUSTERED ([IdFormaPagoLocal] ASC);
GO

-- Creating primary key on [IdCuentaBanco] in table 'CuentaBancoTerceroSet'
ALTER TABLE [dbo].[CuentaBancoTerceroSet]
ADD CONSTRAINT [PK_CuentaBancoTerceroSet]
    PRIMARY KEY CLUSTERED ([IdCuentaBanco] ASC);
GO

-- Creating primary key on [IdTransferencia] in table 'TransferenciaSet'
ALTER TABLE [dbo].[TransferenciaSet]
ADD CONSTRAINT [PK_TransferenciaSet]
    PRIMARY KEY CLUSTERED ([IdTransferencia] ASC);
GO

-- Creating primary key on [IdEstadoTransferencia] in table 'EstadoTransferenciaSet'
ALTER TABLE [dbo].[EstadoTransferenciaSet]
ADD CONSTRAINT [PK_EstadoTransferenciaSet]
    PRIMARY KEY CLUSTERED ([IdEstadoTransferencia] ASC);
GO

-- Creating primary key on [IdPagoLocalTransferencia] in table 'PagoLocalTransferenciaSet'
ALTER TABLE [dbo].[PagoLocalTransferenciaSet]
ADD CONSTRAINT [PK_PagoLocalTransferenciaSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalTransferencia] ASC);
GO

-- Creating primary key on [IdPagoLocal] in table 'PagoLocalSet'
ALTER TABLE [dbo].[PagoLocalSet]
ADD CONSTRAINT [PK_PagoLocalSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocal] ASC);
GO

-- Creating primary key on [IdGastoLocal] in table 'GastoLocalSet'
ALTER TABLE [dbo].[GastoLocalSet]
ADD CONSTRAINT [PK_GastoLocalSet]
    PRIMARY KEY CLUSTERED ([IdGastoLocal] ASC);
GO

-- Creating primary key on [IdCondicionEmpleado] in table 'CondicionEmpleadoSet'
ALTER TABLE [dbo].[CondicionEmpleadoSet]
ADD CONSTRAINT [PK_CondicionEmpleadoSet]
    PRIMARY KEY CLUSTERED ([IdCondicionEmpleado] ASC);
GO

-- Creating primary key on [IdRolDocente] in table 'RolDocenteSet'
ALTER TABLE [dbo].[RolDocenteSet]
ADD CONSTRAINT [PK_RolDocenteSet]
    PRIMARY KEY CLUSTERED ([IdRolDocente] ASC);
GO

-- Creating primary key on [IdAlumnoHorario] in table 'AlumnoHorarioSet'
ALTER TABLE [dbo].[AlumnoHorarioSet]
ADD CONSTRAINT [PK_AlumnoHorarioSet]
    PRIMARY KEY CLUSTERED ([IdAlumnoHorario] ASC);
GO

-- Creating primary key on [IdCiudadFechasHorarios] in table 'CiudadFechasHorariosSet'
ALTER TABLE [dbo].[CiudadFechasHorariosSet]
ADD CONSTRAINT [PK_CiudadFechasHorariosSet]
    PRIMARY KEY CLUSTERED ([IdCiudadFechasHorarios] ASC);
GO

-- Creating primary key on [IdRolAlumnoPresentismo] in table 'RolAlumnoPresentismoSet'
ALTER TABLE [dbo].[RolAlumnoPresentismoSet]
ADD CONSTRAINT [PK_RolAlumnoPresentismoSet]
    PRIMARY KEY CLUSTERED ([IdRolAlumnoPresentismo] ASC);
GO

-- Creating primary key on [IdRolAlumnoPracticas] in table 'RolAlumnoPracticasSet'
ALTER TABLE [dbo].[RolAlumnoPracticasSet]
ADD CONSTRAINT [PK_RolAlumnoPracticasSet]
    PRIMARY KEY CLUSTERED ([IdRolAlumnoPracticas] ASC);
GO

-- Creating primary key on [IdPagoLocalCajaEfectivo] in table 'PagoLocalCajaEfectivoSet'
ALTER TABLE [dbo].[PagoLocalCajaEfectivoSet]
ADD CONSTRAINT [PK_PagoLocalCajaEfectivoSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalCajaEfectivo] ASC);
GO

-- Creating primary key on [IdMovimientoInternoEfectivo] in table 'MovimientoInternoEfectivoSet'
ALTER TABLE [dbo].[MovimientoInternoEfectivoSet]
ADD CONSTRAINT [PK_MovimientoInternoEfectivoSet]
    PRIMARY KEY CLUSTERED ([IdMovimientoInternoEfectivo] ASC);
GO

-- Creating primary key on [IdEnvio] in table 'EnvioSet'
ALTER TABLE [dbo].[EnvioSet]
ADD CONSTRAINT [PK_EnvioSet]
    PRIMARY KEY CLUSTERED ([IdEnvio] ASC);
GO

-- Creating primary key on [IdEnvioCiudadEquipos] in table 'EnvioCiudadEquiposSet'
ALTER TABLE [dbo].[EnvioCiudadEquiposSet]
ADD CONSTRAINT [PK_EnvioCiudadEquiposSet]
    PRIMARY KEY CLUSTERED ([IdEnvioCiudadEquipos] ASC);
GO

-- Creating primary key on [IdPagoLocalEnvio] in table 'PagoLocalEnvioSet'
ALTER TABLE [dbo].[PagoLocalEnvioSet]
ADD CONSTRAINT [PK_PagoLocalEnvioSet]
    PRIMARY KEY CLUSTERED ([IdPagoLocalEnvio] ASC);
GO

-- Creating primary key on [IdCajaEfectivo] in table 'CajaEfectivoSet'
ALTER TABLE [dbo].[CajaEfectivoSet]
ADD CONSTRAINT [PK_CajaEfectivoSet]
    PRIMARY KEY CLUSTERED ([IdCajaEfectivo] ASC);
GO

-- Creating primary key on [IdPuesto] in table 'PuestoSet'
ALTER TABLE [dbo].[PuestoSet]
ADD CONSTRAINT [PK_PuestoSet]
    PRIMARY KEY CLUSTERED ([IdPuesto] ASC);
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

-- Creating foreign key on [IdItemPagado] in table 'PagoSet'
ALTER TABLE [dbo].[PagoSet]
ADD CONSTRAINT [FK_ItemPagadoPago]
    FOREIGN KEY ([IdItemPagado])
    REFERENCES [dbo].[ItemPagadoSet]
        ([IdItemPagado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemPagadoPago'
CREATE INDEX [IX_FK_ItemPagadoPago]
ON [dbo].[PagoSet]
    ([IdItemPagado]);
GO

-- Creating foreign key on [IdRendicionEmpleadoCiudad] in table 'RendicionPagoSet'
ALTER TABLE [dbo].[RendicionPagoSet]
ADD CONSTRAINT [FK_RendicionPersonaCiudadRendicionPago]
    FOREIGN KEY ([IdRendicionEmpleadoCiudad])
    REFERENCES [dbo].[RendicionPersonaCiudadSet]
        ([IdRendicionEmpleadoCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RendicionPersonaCiudadRendicionPago'
CREATE INDEX [IX_FK_RendicionPersonaCiudadRendicionPago]
ON [dbo].[RendicionPagoSet]
    ([IdRendicionEmpleadoCiudad]);
GO

-- Creating foreign key on [IdPago] in table 'RendicionPagoSet'
ALTER TABLE [dbo].[RendicionPagoSet]
ADD CONSTRAINT [FK_PagoRendicionPago]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[PagoSet]
        ([IdPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoRendicionPago'
CREATE INDEX [IX_FK_PagoRendicionPago]
ON [dbo].[RendicionPagoSet]
    ([IdPago]);
GO

-- Creating foreign key on [IdGastoBase] in table 'RolCiudadActivaGastosSet'
ALTER TABLE [dbo].[RolCiudadActivaGastosSet]
ADD CONSTRAINT [FK_GastoBaseRolCiudadActivaGastos]
    FOREIGN KEY ([IdGastoBase])
    REFERENCES [dbo].[GastoBaseSet]
        ([IdGastoBase])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GastoBaseRolCiudadActivaGastos'
CREATE INDEX [IX_FK_GastoBaseRolCiudadActivaGastos]
ON [dbo].[RolCiudadActivaGastosSet]
    ([IdGastoBase]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'RolCiudadActivaGastosSet'
ALTER TABLE [dbo].[RolCiudadActivaGastosSet]
ADD CONSTRAINT [FK_RolCiudadActivaRolCiudadActivaGastos]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaRolCiudadActivaGastos'
CREATE INDEX [IX_FK_RolCiudadActivaRolCiudadActivaGastos]
ON [dbo].[RolCiudadActivaGastosSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdRendicionEmpleadoCiudad] in table 'RendicionGastoSet'
ALTER TABLE [dbo].[RendicionGastoSet]
ADD CONSTRAINT [FK_RendicionPersonaCiudadRendicionGasto]
    FOREIGN KEY ([IdRendicionEmpleadoCiudad])
    REFERENCES [dbo].[RendicionPersonaCiudadSet]
        ([IdRendicionEmpleadoCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RendicionPersonaCiudadRendicionGasto'
CREATE INDEX [IX_FK_RendicionPersonaCiudadRendicionGasto]
ON [dbo].[RendicionGastoSet]
    ([IdRendicionEmpleadoCiudad]);
GO

-- Creating foreign key on [IdGastoBase] in table 'RendicionGastoSet'
ALTER TABLE [dbo].[RendicionGastoSet]
ADD CONSTRAINT [FK_GastoBaseRendicionGasto]
    FOREIGN KEY ([IdGastoBase])
    REFERENCES [dbo].[GastoBaseSet]
        ([IdGastoBase])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GastoBaseRendicionGasto'
CREATE INDEX [IX_FK_GastoBaseRendicionGasto]
ON [dbo].[RendicionGastoSet]
    ([IdGastoBase]);
GO

-- Creating foreign key on [IdRendicionEmpleadoCiudad] in table 'RendicionDepositoSet'
ALTER TABLE [dbo].[RendicionDepositoSet]
ADD CONSTRAINT [FK_RendicionPersonaCiudadRendicionDeposito]
    FOREIGN KEY ([IdRendicionEmpleadoCiudad])
    REFERENCES [dbo].[RendicionPersonaCiudadSet]
        ([IdRendicionEmpleadoCiudad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RendicionPersonaCiudadRendicionDeposito'
CREATE INDEX [IX_FK_RendicionPersonaCiudadRendicionDeposito]
ON [dbo].[RendicionDepositoSet]
    ([IdRendicionEmpleadoCiudad]);
GO

-- Creating foreign key on [IdDeposito] in table 'RendicionDepositoSet'
ALTER TABLE [dbo].[RendicionDepositoSet]
ADD CONSTRAINT [FK_DepositoRendicionDeposito]
    FOREIGN KEY ([IdDeposito])
    REFERENCES [dbo].[DepositoSet]
        ([IdDeposito])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepositoRendicionDeposito'
CREATE INDEX [IX_FK_DepositoRendicionDeposito]
ON [dbo].[RendicionDepositoSet]
    ([IdDeposito]);
GO

-- Creating foreign key on [IdCuentaBanco] in table 'DepositoSet'
ALTER TABLE [dbo].[DepositoSet]
ADD CONSTRAINT [FK_CuentaBancoDeposito]
    FOREIGN KEY ([IdCuentaBanco])
    REFERENCES [dbo].[CuentaBancoSet]
        ([IdCuentaBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaBancoDeposito'
CREATE INDEX [IX_FK_CuentaBancoDeposito]
ON [dbo].[DepositoSet]
    ([IdCuentaBanco]);
GO

-- Creating foreign key on [IdEstadoDeposito] in table 'DepositoSet'
ALTER TABLE [dbo].[DepositoSet]
ADD CONSTRAINT [FK_EstadoDepositoDeposito]
    FOREIGN KEY ([IdEstadoDeposito])
    REFERENCES [dbo].[EstadoDepositoSet]
        ([IdEstadoDeposito])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoDepositoDeposito'
CREATE INDEX [IX_FK_EstadoDepositoDeposito]
ON [dbo].[DepositoSet]
    ([IdEstadoDeposito]);
GO

-- Creating foreign key on [IdPersona] in table 'DepositoSet'
ALTER TABLE [dbo].[DepositoSet]
ADD CONSTRAINT [FK_PersonaDeposito]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo].[Persona]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaDeposito'
CREATE INDEX [IX_FK_PersonaDeposito]
ON [dbo].[DepositoSet]
    ([IdPersona]);
GO

-- Creating foreign key on [IdEstadoPagoTarjeta] in table 'PagoTarjetaSet'
ALTER TABLE [dbo].[PagoTarjetaSet]
ADD CONSTRAINT [FK_EstadoPagoTarjetaPagoTarjeta]
    FOREIGN KEY ([IdEstadoPagoTarjeta])
    REFERENCES [dbo].[EstadoPagoTarjetaSet]
        ([IdEstadoPagoTarjeta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPagoTarjetaPagoTarjeta'
CREATE INDEX [IX_FK_EstadoPagoTarjetaPagoTarjeta]
ON [dbo].[PagoTarjetaSet]
    ([IdEstadoPagoTarjeta]);
GO

-- Creating foreign key on [IdPago] in table 'PagoChequeSet'
ALTER TABLE [dbo].[PagoChequeSet]
ADD CONSTRAINT [FK_PagoPagoCheque]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[PagoSet]
        ([IdPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoPagoCheque'
CREATE INDEX [IX_FK_PagoPagoCheque]
ON [dbo].[PagoChequeSet]
    ([IdPago]);
GO

-- Creating foreign key on [IdTipoCheque] in table 'ChequeSet'
ALTER TABLE [dbo].[ChequeSet]
ADD CONSTRAINT [FK_TipoChequeCheque]
    FOREIGN KEY ([IdTipoCheque])
    REFERENCES [dbo].[TipoChequeSet]
        ([IdTipoCheque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoChequeCheque'
CREATE INDEX [IX_FK_TipoChequeCheque]
ON [dbo].[ChequeSet]
    ([IdTipoCheque]);
GO

-- Creating foreign key on [IdEstadoCheque] in table 'ChequeSet'
ALTER TABLE [dbo].[ChequeSet]
ADD CONSTRAINT [FK_EstadoChequeCheque]
    FOREIGN KEY ([IdEstadoCheque])
    REFERENCES [dbo].[EstadoChequeSet]
        ([IdEstadoCheque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoChequeCheque'
CREATE INDEX [IX_FK_EstadoChequeCheque]
ON [dbo].[ChequeSet]
    ([IdEstadoCheque]);
GO

-- Creating foreign key on [IdFormaPago] in table 'RendicionGastoSet'
ALTER TABLE [dbo].[RendicionGastoSet]
ADD CONSTRAINT [FK_FormaPagoRendicionGasto]
    FOREIGN KEY ([IdFormaPago])
    REFERENCES [dbo].[FormaPagoSet]
        ([IdFormaPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaPagoRendicionGasto'
CREATE INDEX [IX_FK_FormaPagoRendicionGasto]
ON [dbo].[RendicionGastoSet]
    ([IdFormaPago]);
GO

-- Creating foreign key on [IdPago] in table 'PagoChequeSet'
ALTER TABLE [dbo].[PagoChequeSet]
ADD CONSTRAINT [FK_PagoPagoCheque1]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[PagoSet]
        ([IdPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoPagoCheque1'
CREATE INDEX [IX_FK_PagoPagoCheque1]
ON [dbo].[PagoChequeSet]
    ([IdPago]);
GO

-- Creating foreign key on [IdCheque] in table 'PagoChequeSet'
ALTER TABLE [dbo].[PagoChequeSet]
ADD CONSTRAINT [FK_ChequePagoCheque]
    FOREIGN KEY ([IdCheque])
    REFERENCES [dbo].[ChequeSet]
        ([IdCheque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChequePagoCheque'
CREATE INDEX [IX_FK_ChequePagoCheque]
ON [dbo].[PagoChequeSet]
    ([IdCheque]);
GO

-- Creating foreign key on [IdCheque] in table 'GastoChequeSet'
ALTER TABLE [dbo].[GastoChequeSet]
ADD CONSTRAINT [FK_ChequeGastoCheque]
    FOREIGN KEY ([IdCheque])
    REFERENCES [dbo].[ChequeSet]
        ([IdCheque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChequeGastoCheque'
CREATE INDEX [IX_FK_ChequeGastoCheque]
ON [dbo].[GastoChequeSet]
    ([IdCheque]);
GO

-- Creating foreign key on [IdRendicionGasto] in table 'GastoChequeSet'
ALTER TABLE [dbo].[GastoChequeSet]
ADD CONSTRAINT [FK_RendicionGastoGastoCheque]
    FOREIGN KEY ([IdRendicionGasto])
    REFERENCES [dbo].[RendicionGastoSet]
        ([IdRendicionGasto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RendicionGastoGastoCheque'
CREATE INDEX [IX_FK_RendicionGastoGastoCheque]
ON [dbo].[GastoChequeSet]
    ([IdRendicionGasto]);
GO

-- Creating foreign key on [IdEstadoCompra] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_EstadoCompraCompra]
    FOREIGN KEY ([IdEstadoCompra])
    REFERENCES [dbo].[EstadoCompraSet]
        ([IdEstadoCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoCompraCompra'
CREATE INDEX [IX_FK_EstadoCompraCompra]
ON [dbo].[CompraSet]
    ([IdEstadoCompra]);
GO

-- Creating foreign key on [IdCheque] in table 'PagoLocalChequeSet'
ALTER TABLE [dbo].[PagoLocalChequeSet]
ADD CONSTRAINT [FK_ChequeCompraCheque]
    FOREIGN KEY ([IdCheque])
    REFERENCES [dbo].[ChequeSet]
        ([IdCheque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChequeCompraCheque'
CREATE INDEX [IX_FK_ChequeCompraCheque]
ON [dbo].[PagoLocalChequeSet]
    ([IdCheque]);
GO

-- Creating foreign key on [IdCompra] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [FK_CompraDetalleCompra]
    FOREIGN KEY ([IdCompra])
    REFERENCES [dbo].[CompraSet]
        ([IdCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraDetalleCompra'
CREATE INDEX [IX_FK_CompraDetalleCompra]
ON [dbo].[DetalleCompraSet]
    ([IdCompra]);
GO

-- Creating foreign key on [IdProducto] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [FK_ProductosDetalleCompra]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[ProductosSet]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosDetalleCompra'
CREATE INDEX [IX_FK_ProductosDetalleCompra]
ON [dbo].[DetalleCompraSet]
    ([IdProducto]);
GO

-- Creating foreign key on [IdProveedor] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_ProveedorCompra]
    FOREIGN KEY ([IdProveedor])
    REFERENCES [dbo].[ProveedorSet]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorCompra'
CREATE INDEX [IX_FK_ProveedorCompra]
ON [dbo].[CompraSet]
    ([IdProveedor]);
GO

-- Creating foreign key on [IdTarjetaPropia] in table 'PagoLocalTarjetaSet'
ALTER TABLE [dbo].[PagoLocalTarjetaSet]
ADD CONSTRAINT [FK_TarjetaPropiaCompraTarjeta]
    FOREIGN KEY ([IdTarjetaPropia])
    REFERENCES [dbo].[TarjetaPropiaSet]
        ([IdTarjetaPropia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TarjetaPropiaCompraTarjeta'
CREATE INDEX [IX_FK_TarjetaPropiaCompraTarjeta]
ON [dbo].[PagoLocalTarjetaSet]
    ([IdTarjetaPropia]);
GO

-- Creating foreign key on [IdArmadoEquipo] in table 'DetalleArmadoEquipoSet'
ALTER TABLE [dbo].[DetalleArmadoEquipoSet]
ADD CONSTRAINT [FK_ArmadoEquipoDetalleArmadoEquipo]
    FOREIGN KEY ([IdArmadoEquipo])
    REFERENCES [dbo].[ArmadoEquipoSet]
        ([IdArmadoEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArmadoEquipoDetalleArmadoEquipo'
CREATE INDEX [IX_FK_ArmadoEquipoDetalleArmadoEquipo]
ON [dbo].[DetalleArmadoEquipoSet]
    ([IdArmadoEquipo]);
GO

-- Creating foreign key on [IdProducto] in table 'DetalleArmadoEquipoSet'
ALTER TABLE [dbo].[DetalleArmadoEquipoSet]
ADD CONSTRAINT [FK_ProductosDetalleArmadoEquipo]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[ProductosSet]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosDetalleArmadoEquipo'
CREATE INDEX [IX_FK_ProductosDetalleArmadoEquipo]
ON [dbo].[DetalleArmadoEquipoSet]
    ([IdProducto]);
GO

-- Creating foreign key on [IdArmadoEquipo] in table 'CiudadEquiposSet'
ALTER TABLE [dbo].[CiudadEquiposSet]
ADD CONSTRAINT [FK_ArmadoEquipoCiudadEquipos]
    FOREIGN KEY ([IdArmadoEquipo])
    REFERENCES [dbo].[ArmadoEquipoSet]
        ([IdArmadoEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArmadoEquipoCiudadEquipos'
CREATE INDEX [IX_FK_ArmadoEquipoCiudadEquipos]
ON [dbo].[CiudadEquiposSet]
    ([IdArmadoEquipo]);
GO

-- Creating foreign key on [IdAsignacionCiudadEquipo] in table 'CiudadEquiposSet'
ALTER TABLE [dbo].[CiudadEquiposSet]
ADD CONSTRAINT [FK_AsignacionCiudadEquiposCiudadEquipos]
    FOREIGN KEY ([IdAsignacionCiudadEquipo])
    REFERENCES [dbo].[AsignacionCiudadEquiposSet]
        ([IdAsignacionCiudadEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AsignacionCiudadEquiposCiudadEquipos'
CREATE INDEX [IX_FK_AsignacionCiudadEquiposCiudadEquipos]
ON [dbo].[CiudadEquiposSet]
    ([IdAsignacionCiudadEquipo]);
GO

-- Creating foreign key on [IdProducto] in table 'CiudadProductosSet'
ALTER TABLE [dbo].[CiudadProductosSet]
ADD CONSTRAINT [FK_ProductosCiudadProductos]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[ProductosSet]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosCiudadProductos'
CREATE INDEX [IX_FK_ProductosCiudadProductos]
ON [dbo].[CiudadProductosSet]
    ([IdProducto]);
GO

-- Creating foreign key on [IdAsignacionCiudadEquipo] in table 'CiudadProductosSet'
ALTER TABLE [dbo].[CiudadProductosSet]
ADD CONSTRAINT [FK_AsignacionCiudadEquiposCiudadProductos]
    FOREIGN KEY ([IdAsignacionCiudadEquipo])
    REFERENCES [dbo].[AsignacionCiudadEquiposSet]
        ([IdAsignacionCiudadEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AsignacionCiudadEquiposCiudadProductos'
CREATE INDEX [IX_FK_AsignacionCiudadEquiposCiudadProductos]
ON [dbo].[CiudadProductosSet]
    ([IdAsignacionCiudadEquipo]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'AsignacionCiudadEquiposSet'
ALTER TABLE [dbo].[AsignacionCiudadEquiposSet]
ADD CONSTRAINT [FK_RolCiudadActivaAsignacionCiudadEquipos]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaAsignacionCiudadEquipos'
CREATE INDEX [IX_FK_RolCiudadActivaAsignacionCiudadEquipos]
ON [dbo].[AsignacionCiudadEquiposSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdEstadoAsignacionEquipo] in table 'AsignacionCiudadEquiposSet'
ALTER TABLE [dbo].[AsignacionCiudadEquiposSet]
ADD CONSTRAINT [FK_EstadoAsignacionEquipoAsignacionCiudadEquipos]
    FOREIGN KEY ([IdEstadoAsignacionEquipo])
    REFERENCES [dbo].[EstadoAsignacionEquipoSet]
        ([IdEstadoAsignacionEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoAsignacionEquipoAsignacionCiudadEquipos'
CREATE INDEX [IX_FK_EstadoAsignacionEquipoAsignacionCiudadEquipos]
ON [dbo].[AsignacionCiudadEquiposSet]
    ([IdEstadoAsignacionEquipo]);
GO

-- Creating foreign key on [IdCuotas] in table 'PagoTarjetaSet'
ALTER TABLE [dbo].[PagoTarjetaSet]
ADD CONSTRAINT [FK_CoeficTarjetasPagoTarjeta]
    FOREIGN KEY ([IdCuotas])
    REFERENCES [dbo].[CoeficTarjetasSet]
        ([IdCuotas])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoeficTarjetasPagoTarjeta'
CREATE INDEX [IX_FK_CoeficTarjetasPagoTarjeta]
ON [dbo].[PagoTarjetaSet]
    ([IdCuotas]);
GO

-- Creating foreign key on [IdArmadoEquipo] in table 'RendicionVentaEquipoSet'
ALTER TABLE [dbo].[RendicionVentaEquipoSet]
ADD CONSTRAINT [FK_ArmadoEquipoRendicionVentaEquipo]
    FOREIGN KEY ([IdArmadoEquipo])
    REFERENCES [dbo].[ArmadoEquipoSet]
        ([IdArmadoEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArmadoEquipoRendicionVentaEquipo'
CREATE INDEX [IX_FK_ArmadoEquipoRendicionVentaEquipo]
ON [dbo].[RendicionVentaEquipoSet]
    ([IdArmadoEquipo]);
GO

-- Creating foreign key on [IdPago] in table 'RendicionVentaEquipoSet'
ALTER TABLE [dbo].[RendicionVentaEquipoSet]
ADD CONSTRAINT [FK_PagoRendicionVentaEquipo]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[PagoSet]
        ([IdPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoRendicionVentaEquipo'
CREATE INDEX [IX_FK_PagoRendicionVentaEquipo]
ON [dbo].[RendicionVentaEquipoSet]
    ([IdPago]);
GO

-- Creating foreign key on [IdEstadoVenta] in table 'RendicionVentaEquipoSet'
ALTER TABLE [dbo].[RendicionVentaEquipoSet]
ADD CONSTRAINT [FK_EstadoVentaRendicionVentaEquipo]
    FOREIGN KEY ([IdEstadoVenta])
    REFERENCES [dbo].[EstadoVentaSet]
        ([IdEstadoVenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoVentaRendicionVentaEquipo'
CREATE INDEX [IX_FK_EstadoVentaRendicionVentaEquipo]
ON [dbo].[RendicionVentaEquipoSet]
    ([IdEstadoVenta]);
GO

-- Creating foreign key on [IdRecibo] in table 'AsignacionReciboSet'
ALTER TABLE [dbo].[AsignacionReciboSet]
ADD CONSTRAINT [FK_ReciboAsignacionRecibo]
    FOREIGN KEY ([IdRecibo])
    REFERENCES [dbo].[ReciboSet]
        ([IdRecibo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReciboAsignacionRecibo'
CREATE INDEX [IX_FK_ReciboAsignacionRecibo]
ON [dbo].[AsignacionReciboSet]
    ([IdRecibo]);
GO

-- Creating foreign key on [IdCuentaBanco] in table 'ChequePropioSet'
ALTER TABLE [dbo].[ChequePropioSet]
ADD CONSTRAINT [FK_CuentaBancoChequePropio]
    FOREIGN KEY ([IdCuentaBanco])
    REFERENCES [dbo].[CuentaBancoSet]
        ([IdCuentaBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaBancoChequePropio'
CREATE INDEX [IX_FK_CuentaBancoChequePropio]
ON [dbo].[ChequePropioSet]
    ([IdCuentaBanco]);
GO

-- Creating foreign key on [IdChequePropio] in table 'PagoLocalChequePropioSet'
ALTER TABLE [dbo].[PagoLocalChequePropioSet]
ADD CONSTRAINT [FK_ChequePropioCompraChequePropio]
    FOREIGN KEY ([IdChequePropio])
    REFERENCES [dbo].[ChequePropioSet]
        ([IdChequePropio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChequePropioCompraChequePropio'
CREATE INDEX [IX_FK_ChequePropioCompraChequePropio]
ON [dbo].[PagoLocalChequePropioSet]
    ([IdChequePropio]);
GO

-- Creating foreign key on [IdCuentaBanco] in table 'TransferenciaSet'
ALTER TABLE [dbo].[TransferenciaSet]
ADD CONSTRAINT [FK_CuentaBancoTransferencia]
    FOREIGN KEY ([IdCuentaBanco])
    REFERENCES [dbo].[CuentaBancoSet]
        ([IdCuentaBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaBancoTransferencia'
CREATE INDEX [IX_FK_CuentaBancoTransferencia]
ON [dbo].[TransferenciaSet]
    ([IdCuentaBanco]);
GO

-- Creating foreign key on [IdCuentaBanco] in table 'TransferenciaSet'
ALTER TABLE [dbo].[TransferenciaSet]
ADD CONSTRAINT [FK_CuentaBancoTerceroTransferencia]
    FOREIGN KEY ([IdCuentaBanco])
    REFERENCES [dbo].[CuentaBancoTerceroSet]
        ([IdCuentaBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuentaBancoTerceroTransferencia'
CREATE INDEX [IX_FK_CuentaBancoTerceroTransferencia]
ON [dbo].[TransferenciaSet]
    ([IdCuentaBanco]);
GO

-- Creating foreign key on [IdEstadoTransferencia] in table 'TransferenciaSet'
ALTER TABLE [dbo].[TransferenciaSet]
ADD CONSTRAINT [FK_EstadoTransferenciaTransferencia]
    FOREIGN KEY ([IdEstadoTransferencia])
    REFERENCES [dbo].[EstadoTransferenciaSet]
        ([IdEstadoTransferencia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoTransferenciaTransferencia'
CREATE INDEX [IX_FK_EstadoTransferenciaTransferencia]
ON [dbo].[TransferenciaSet]
    ([IdEstadoTransferencia]);
GO

-- Creating foreign key on [IdTransferencia] in table 'PagoLocalTransferenciaSet'
ALTER TABLE [dbo].[PagoLocalTransferenciaSet]
ADD CONSTRAINT [FK_TransferenciaCompraTransferencia]
    FOREIGN KEY ([IdTransferencia])
    REFERENCES [dbo].[TransferenciaSet]
        ([IdTransferencia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransferenciaCompraTransferencia'
CREATE INDEX [IX_FK_TransferenciaCompraTransferencia]
ON [dbo].[PagoLocalTransferenciaSet]
    ([IdTransferencia]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalTransferenciaSet'
ALTER TABLE [dbo].[PagoLocalTransferenciaSet]
ADD CONSTRAINT [FK_PagoLocalCompraTransferencia]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalCompraTransferencia'
CREATE INDEX [IX_FK_PagoLocalCompraTransferencia]
ON [dbo].[PagoLocalTransferenciaSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalChequePropioSet'
ALTER TABLE [dbo].[PagoLocalChequePropioSet]
ADD CONSTRAINT [FK_PagoLocalPagoLocalChequePropio]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalPagoLocalChequePropio'
CREATE INDEX [IX_FK_PagoLocalPagoLocalChequePropio]
ON [dbo].[PagoLocalChequePropioSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalTarjetaSet'
ALTER TABLE [dbo].[PagoLocalTarjetaSet]
ADD CONSTRAINT [FK_PagoLocalPagoLocalTarjeta]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalPagoLocalTarjeta'
CREATE INDEX [IX_FK_PagoLocalPagoLocalTarjeta]
ON [dbo].[PagoLocalTarjetaSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalChequeSet'
ALTER TABLE [dbo].[PagoLocalChequeSet]
ADD CONSTRAINT [FK_PagoLocalPagoLocalCheque]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalPagoLocalCheque'
CREATE INDEX [IX_FK_PagoLocalPagoLocalCheque]
ON [dbo].[PagoLocalChequeSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdFormaPagoLocal] in table 'PagoLocalSet'
ALTER TABLE [dbo].[PagoLocalSet]
ADD CONSTRAINT [FK_FormaPagoLocalPagoLocal]
    FOREIGN KEY ([IdFormaPagoLocal])
    REFERENCES [dbo].[FormaPagoLocalSet]
        ([IdFormaPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaPagoLocalPagoLocal'
CREATE INDEX [IX_FK_FormaPagoLocalPagoLocal]
ON [dbo].[PagoLocalSet]
    ([IdFormaPagoLocal]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_RolEmpleadoRolVendedor]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoRolVendedor'
CREATE INDEX [IX_FK_RolEmpleadoRolVendedor]
ON [dbo].[RolVendedor]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdSubgerente] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_RolEmpleadoRolVendedor1]
    FOREIGN KEY ([IdSubgerente])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoRolVendedor1'
CREATE INDEX [IX_FK_RolEmpleadoRolVendedor1]
ON [dbo].[RolVendedor]
    ([IdSubgerente]);
GO

-- Creating foreign key on [IdGerente] in table 'RolVendedor'
ALTER TABLE [dbo].[RolVendedor]
ADD CONSTRAINT [FK_RolEmpleadoRolVendedor2]
    FOREIGN KEY ([IdGerente])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoRolVendedor2'
CREATE INDEX [IX_FK_RolEmpleadoRolVendedor2]
ON [dbo].[RolVendedor]
    ([IdGerente]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'AsignacionReciboSet'
ALTER TABLE [dbo].[AsignacionReciboSet]
ADD CONSTRAINT [FK_RolEmpleadoAsignacionRecibo]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoAsignacionRecibo'
CREATE INDEX [IX_FK_RolEmpleadoAsignacionRecibo]
ON [dbo].[AsignacionReciboSet]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'RendicionPersonaCiudadSet'
ALTER TABLE [dbo].[RendicionPersonaCiudadSet]
ADD CONSTRAINT [FK_RolEmpleadoRendicionPersonaCiudad]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoRendicionPersonaCiudad'
CREATE INDEX [IX_FK_RolEmpleadoRendicionPersonaCiudad]
ON [dbo].[RendicionPersonaCiudadSet]
    ([IdRolEmpleado]);
GO

-- Creating foreign key on [IdCondicionEmpleado] in table 'DetalleCondicionEmpleado'
ALTER TABLE [dbo].[DetalleCondicionEmpleado]
ADD CONSTRAINT [FK_CondicionEmpleadoRolEmpleadoCondicion]
    FOREIGN KEY ([IdCondicionEmpleado])
    REFERENCES [dbo].[CondicionEmpleadoSet]
        ([IdCondicionEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CondicionEmpleadoRolEmpleadoCondicion'
CREATE INDEX [IX_FK_CondicionEmpleadoRolEmpleadoCondicion]
ON [dbo].[DetalleCondicionEmpleado]
    ([IdCondicionEmpleado]);
GO

-- Creating foreign key on [IdRolEmpleado] in table 'RolDocenteSet'
ALTER TABLE [dbo].[RolDocenteSet]
ADD CONSTRAINT [FK_RolEmpleadoRolDocente]
    FOREIGN KEY ([IdRolEmpleado])
    REFERENCES [dbo].[RolEmpleado]
        ([IdRolEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolEmpleadoRolDocente'
CREATE INDEX [IX_FK_RolEmpleadoRolDocente]
ON [dbo].[RolDocenteSet]
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

-- Creating foreign key on [IdRolCiudadActivaHorario] in table 'AlumnoHorarioSet'
ALTER TABLE [dbo].[AlumnoHorarioSet]
ADD CONSTRAINT [FK_RolCiudadActivaHorarioAlumnoHorario]
    FOREIGN KEY ([IdRolCiudadActivaHorario])
    REFERENCES [dbo].[RolCiudadActivaHorarioSet]
        ([IdRolCiudadActivaHorario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaHorarioAlumnoHorario'
CREATE INDEX [IX_FK_RolCiudadActivaHorarioAlumnoHorario]
ON [dbo].[AlumnoHorarioSet]
    ([IdRolCiudadActivaHorario]);
GO

-- Creating foreign key on [IdRolAlumno] in table 'AlumnoHorarioSet'
ALTER TABLE [dbo].[AlumnoHorarioSet]
ADD CONSTRAINT [FK_RolAlumnoAlumnoHorario]
    FOREIGN KEY ([IdRolAlumno])
    REFERENCES [dbo].[RolAlumno]
        ([IdRolAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolAlumnoAlumnoHorario'
CREATE INDEX [IX_FK_RolAlumnoAlumnoHorario]
ON [dbo].[AlumnoHorarioSet]
    ([IdRolAlumno]);
GO

-- Creating foreign key on [IdRolAlumno] in table 'RolAlumnoPresentismoSet'
ALTER TABLE [dbo].[RolAlumnoPresentismoSet]
ADD CONSTRAINT [FK_RolAlumnoRolAlumnoPresentismo]
    FOREIGN KEY ([IdRolAlumno])
    REFERENCES [dbo].[RolAlumno]
        ([IdRolAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolAlumnoRolAlumnoPresentismo'
CREATE INDEX [IX_FK_RolAlumnoRolAlumnoPresentismo]
ON [dbo].[RolAlumnoPresentismoSet]
    ([IdRolAlumno]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'GastoLocalSet'
ALTER TABLE [dbo].[GastoLocalSet]
ADD CONSTRAINT [FK_PagoLocalGastoLocal]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalGastoLocal'
CREATE INDEX [IX_FK_PagoLocalGastoLocal]
ON [dbo].[GastoLocalSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_PagoLocalCompra]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalCompra'
CREATE INDEX [IX_FK_PagoLocalCompra]
ON [dbo].[CompraSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalCajaEfectivoSet'
ALTER TABLE [dbo].[PagoLocalCajaEfectivoSet]
ADD CONSTRAINT [FK_PagoLocalPagoLocalCajaEfectivo]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalPagoLocalCajaEfectivo'
CREATE INDEX [IX_FK_PagoLocalPagoLocalCajaEfectivo]
ON [dbo].[PagoLocalCajaEfectivoSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdProveedor] in table 'EnvioSet'
ALTER TABLE [dbo].[EnvioSet]
ADD CONSTRAINT [FK_ProveedorEnvio]
    FOREIGN KEY ([IdProveedor])
    REFERENCES [dbo].[ProveedorSet]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorEnvio'
CREATE INDEX [IX_FK_ProveedorEnvio]
ON [dbo].[EnvioSet]
    ([IdProveedor]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'EnvioSet'
ALTER TABLE [dbo].[EnvioSet]
ADD CONSTRAINT [FK_RolCiudadActivaEnvio]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaEnvio'
CREATE INDEX [IX_FK_RolCiudadActivaEnvio]
ON [dbo].[EnvioSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdEnvio] in table 'EnvioCiudadEquiposSet'
ALTER TABLE [dbo].[EnvioCiudadEquiposSet]
ADD CONSTRAINT [FK_EnvioEnvioCiudadEquipos]
    FOREIGN KEY ([IdEnvio])
    REFERENCES [dbo].[EnvioSet]
        ([IdEnvio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EnvioEnvioCiudadEquipos'
CREATE INDEX [IX_FK_EnvioEnvioCiudadEquipos]
ON [dbo].[EnvioCiudadEquiposSet]
    ([IdEnvio]);
GO

-- Creating foreign key on [IdPagoLocal] in table 'PagoLocalEnvioSet'
ALTER TABLE [dbo].[PagoLocalEnvioSet]
ADD CONSTRAINT [FK_PagoLocalPagoLocalEnvio]
    FOREIGN KEY ([IdPagoLocal])
    REFERENCES [dbo].[PagoLocalSet]
        ([IdPagoLocal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagoLocalPagoLocalEnvio'
CREATE INDEX [IX_FK_PagoLocalPagoLocalEnvio]
ON [dbo].[PagoLocalEnvioSet]
    ([IdPagoLocal]);
GO

-- Creating foreign key on [IdcajaEfectivoDestino] in table 'MovimientoInternoEfectivoSet'
ALTER TABLE [dbo].[MovimientoInternoEfectivoSet]
ADD CONSTRAINT [FK_CajaEfectivoMovimientoInternoEfectivo]
    FOREIGN KEY ([IdcajaEfectivoDestino])
    REFERENCES [dbo].[CajaEfectivoSet]
        ([IdCajaEfectivo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CajaEfectivoMovimientoInternoEfectivo'
CREATE INDEX [IX_FK_CajaEfectivoMovimientoInternoEfectivo]
ON [dbo].[MovimientoInternoEfectivoSet]
    ([IdcajaEfectivoDestino]);
GO

-- Creating foreign key on [IdCajaEfectivoOrigen] in table 'MovimientoInternoEfectivoSet'
ALTER TABLE [dbo].[MovimientoInternoEfectivoSet]
ADD CONSTRAINT [FK_CajaEfectivoMovimientoInternoEfectivo1]
    FOREIGN KEY ([IdCajaEfectivoOrigen])
    REFERENCES [dbo].[CajaEfectivoSet]
        ([IdCajaEfectivo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CajaEfectivoMovimientoInternoEfectivo1'
CREATE INDEX [IX_FK_CajaEfectivoMovimientoInternoEfectivo1]
ON [dbo].[MovimientoInternoEfectivoSet]
    ([IdCajaEfectivoOrigen]);
GO

-- Creating foreign key on [IdAsignacionCiudadEquipo] in table 'EnvioCiudadEquiposSet'
ALTER TABLE [dbo].[EnvioCiudadEquiposSet]
ADD CONSTRAINT [FK_AsignacionCiudadEquiposEnvioCiudadEquipos]
    FOREIGN KEY ([IdAsignacionCiudadEquipo])
    REFERENCES [dbo].[AsignacionCiudadEquiposSet]
        ([IdAsignacionCiudadEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AsignacionCiudadEquiposEnvioCiudadEquipos'
CREATE INDEX [IX_FK_AsignacionCiudadEquiposEnvioCiudadEquipos]
ON [dbo].[EnvioCiudadEquiposSet]
    ([IdAsignacionCiudadEquipo]);
GO

-- Creating foreign key on [IdRolCiudadActiva] in table 'CiudadFechasHorariosSet'
ALTER TABLE [dbo].[CiudadFechasHorariosSet]
ADD CONSTRAINT [FK_RolCiudadActivaCiudadFechasHorarios]
    FOREIGN KEY ([IdRolCiudadActiva])
    REFERENCES [dbo].[RolCiudadActivaSet]
        ([IdRolCiudadActiva])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolCiudadActivaCiudadFechasHorarios'
CREATE INDEX [IX_FK_RolCiudadActivaCiudadFechasHorarios]
ON [dbo].[CiudadFechasHorariosSet]
    ([IdRolCiudadActiva]);
GO

-- Creating foreign key on [IdRolAlumno] in table 'RolAlumnoPracticasSet'
ALTER TABLE [dbo].[RolAlumnoPracticasSet]
ADD CONSTRAINT [FK_RolAlumnoRolAlumnoPracticas]
    FOREIGN KEY ([IdRolAlumno])
    REFERENCES [dbo].[RolAlumno]
        ([IdRolAlumno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolAlumnoRolAlumnoPracticas'
CREATE INDEX [IX_FK_RolAlumnoRolAlumnoPracticas]
ON [dbo].[RolAlumnoPracticasSet]
    ([IdRolAlumno]);
GO

-- Creating foreign key on [IdCiudadFechasHorarios] in table 'RolAlumnoPracticasSet'
ALTER TABLE [dbo].[RolAlumnoPracticasSet]
ADD CONSTRAINT [FK_CiudadFechasHorariosRolAlumnoPracticas]
    FOREIGN KEY ([IdCiudadFechasHorarios])
    REFERENCES [dbo].[CiudadFechasHorariosSet]
        ([IdCiudadFechasHorarios])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CiudadFechasHorariosRolAlumnoPracticas'
CREATE INDEX [IX_FK_CiudadFechasHorariosRolAlumnoPracticas]
ON [dbo].[RolAlumnoPracticasSet]
    ([IdCiudadFechasHorarios]);
GO

-- Creating foreign key on [IdCajaEfectivo] in table 'PagoLocalCajaEfectivoSet'
ALTER TABLE [dbo].[PagoLocalCajaEfectivoSet]
ADD CONSTRAINT [FK_CajaEfectivoPagoLocalCajaEfectivo]
    FOREIGN KEY ([IdCajaEfectivo])
    REFERENCES [dbo].[CajaEfectivoSet]
        ([IdCajaEfectivo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CajaEfectivoPagoLocalCajaEfectivo'
CREATE INDEX [IX_FK_CajaEfectivoPagoLocalCajaEfectivo]
ON [dbo].[PagoLocalCajaEfectivoSet]
    ([IdCajaEfectivo]);
GO

-- Creating foreign key on [IdPuesto] in table 'RolEmpleado'
ALTER TABLE [dbo].[RolEmpleado]
ADD CONSTRAINT [FK_PuestoRolEmpleado]
    FOREIGN KEY ([IdPuesto])
    REFERENCES [dbo].[PuestoSet]
        ([IdPuesto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PuestoRolEmpleado'
CREATE INDEX [IX_FK_PuestoRolEmpleado]
ON [dbo].[RolEmpleado]
    ([IdPuesto]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
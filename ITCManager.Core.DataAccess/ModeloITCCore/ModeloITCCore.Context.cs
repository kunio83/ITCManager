﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Core.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using ITCManager.Core.Entities;
    
    public partial class ITC_DBPOwerEntities : DbContext
    {
        public ITC_DBPOwerEntities()
            : base("name=ITC_DBPOwerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RolEmpleadoCondicion> DetalleCondicionEmpleado { get; set; }
        public virtual DbSet<EstadoAlumno> EstadoAlumno { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<PermisoAcceso> PermisoAcceso { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<RolAlumno> RolAlumno { get; set; }
        public virtual DbSet<RolEmpleado> RolEmpleado { get; set; }
        public virtual DbSet<RolVendedor> RolVendedor { get; set; }
        public virtual DbSet<AsignacionRecibo> AsignacionReciboSet { get; set; }
        public virtual DbSet<Ciudad> CiudadSet { get; set; }
        public virtual DbSet<Localidad> LocalidadSet { get; set; }
        public virtual DbSet<RolCiudadEnProceso> RolCiudadEnProcesoSet { get; set; }
        public virtual DbSet<RolCiudadActiva> RolCiudadActivaSet { get; set; }
        public virtual DbSet<CiudadPersonal> CiudadPersonalSet { get; set; }
        public virtual DbSet<CiudadActivaLocaciones> CiudadActivaLocacionesSet { get; set; }
        public virtual DbSet<Locacion> LocacionSet { get; set; }
        public virtual DbSet<RolLocador> RolLocadorSet { get; set; }
        public virtual DbSet<LocacionRolLocador> LocacionRolLocadorSet { get; set; }
        public virtual DbSet<RolLocacionAlojamiento> RolLocacionAlojamientoSet { get; set; }
        public virtual DbSet<RolLocacionSalon> RolLocacionSalonSet { get; set; }
        public virtual DbSet<PlanBase> PlanBaseSet { get; set; }
        public virtual DbSet<RolCiudadActivaPlan> RolCiudadActivaPlanSet { get; set; }
        public virtual DbSet<PlanVendedorAlumno> PlanVendedorAlumnoSet { get; set; }
        public virtual DbSet<Capacitacion> CapacitacionSet { get; set; }
        public virtual DbSet<Horario> HorarioSet { get; set; }
        public virtual DbSet<RolCiudadActivaHorario> RolCiudadActivaHorarioSet { get; set; }
        public virtual DbSet<Dia> DiaSet { get; set; }
        public virtual DbSet<RendicionPersonaCiudad> RendicionPersonaCiudadSet { get; set; }
        public virtual DbSet<EstadoRendicion> EstadoRendicionSet { get; set; }
        public virtual DbSet<Pago> PagoSet { get; set; }
        public virtual DbSet<FormaPago> FormaPagoSet { get; set; }
        public virtual DbSet<PagoTarjeta> PagoTarjetaSet { get; set; }
        public virtual DbSet<ItemPagado> ItemPagadoSet { get; set; }
        public virtual DbSet<RendicionPago> RendicionPagoSet { get; set; }
        public virtual DbSet<GastoBase> GastoBaseSet { get; set; }
        public virtual DbSet<RolCiudadActivaGastos> RolCiudadActivaGastosSet { get; set; }
        public virtual DbSet<RendicionGasto> RendicionGastoSet { get; set; }
        public virtual DbSet<RendicionDeposito> RendicionDepositoSet { get; set; }
        public virtual DbSet<Deposito> DepositoSet { get; set; }
        public virtual DbSet<CuentaBanco> CuentaBancoSet { get; set; }
        public virtual DbSet<EstadoDeposito> EstadoDepositoSet { get; set; }
        public virtual DbSet<EstadoPagoTarjeta> EstadoPagoTarjetaSet { get; set; }
        public virtual DbSet<PagoCheque> PagoChequeSet { get; set; }
        public virtual DbSet<Cheque> ChequeSet { get; set; }
        public virtual DbSet<TipoCheque> TipoChequeSet { get; set; }
        public virtual DbSet<EstadoCheque> EstadoChequeSet { get; set; }
        public virtual DbSet<GastoCheque> GastoChequeSet { get; set; }
        public virtual DbSet<Productos> ProductosSet { get; set; }
        public virtual DbSet<Proveedor> ProveedorSet { get; set; }
        public virtual DbSet<Compra> CompraSet { get; set; }
        public virtual DbSet<EstadoCompra> EstadoCompraSet { get; set; }
        public virtual DbSet<PagoLocalCheque> PagoLocalChequeSet { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompraSet { get; set; }
        public virtual DbSet<TarjetaPropia> TarjetaPropiaSet { get; set; }
        public virtual DbSet<PagoLocalTarjeta> PagoLocalTarjetaSet { get; set; }
        public virtual DbSet<ArmadoEquipo> ArmadoEquipoSet { get; set; }
        public virtual DbSet<DetalleArmadoEquipo> DetalleArmadoEquipoSet { get; set; }
        public virtual DbSet<AsignacionCiudadEquipos> AsignacionCiudadEquiposSet { get; set; }
        public virtual DbSet<CiudadEquipos> CiudadEquiposSet { get; set; }
        public virtual DbSet<CiudadProductos> CiudadProductosSet { get; set; }
        public virtual DbSet<EstadoAsignacionEquipo> EstadoAsignacionEquipoSet { get; set; }
        public virtual DbSet<CoeficTarjetas> CoeficTarjetasSet { get; set; }
        public virtual DbSet<RendicionVentaEquipo> RendicionVentaEquipoSet { get; set; }
        public virtual DbSet<EstadoVenta> EstadoVentaSet { get; set; }
        public virtual DbSet<Recibo> ReciboSet { get; set; }
        public virtual DbSet<ChequePropio> ChequePropioSet { get; set; }
        public virtual DbSet<PagoLocalChequePropio> PagoLocalChequePropioSet { get; set; }
        public virtual DbSet<FormaPagoLocal> FormaPagoLocalSet { get; set; }
        public virtual DbSet<CuentaBancoTercero> CuentaBancoTerceroSet { get; set; }
        public virtual DbSet<Transferencia> TransferenciaSet { get; set; }
        public virtual DbSet<EstadoTransferencia> EstadoTransferenciaSet { get; set; }
        public virtual DbSet<PagoLocalTransferencia> PagoLocalTransferenciaSet { get; set; }
        public virtual DbSet<PagoLocal> PagoLocalSet { get; set; }
        public virtual DbSet<GastoLocal> GastoLocalSet { get; set; }
        public virtual DbSet<CondicionEmpleado> CondicionEmpleadoSet { get; set; }
        public virtual DbSet<RolDocente> RolDocenteSet { get; set; }
        public virtual DbSet<AlumnoHorario> AlumnoHorarioSet { get; set; }
        public virtual DbSet<CiudadFechasHorarios> CiudadFechasHorariosSet { get; set; }
        public virtual DbSet<RolAlumnoPresentismo> RolAlumnoPresentismoSet { get; set; }
        public virtual DbSet<RolAlumnoPracticas> RolAlumnoPracticasSet { get; set; }
        public virtual DbSet<PagoLocalCajaEfectivo> PagoLocalCajaEfectivoSet { get; set; }
        public virtual DbSet<MovimientoInternoEfectivo> MovimientoInternoEfectivoSet { get; set; }
        public virtual DbSet<Envio> EnvioSet { get; set; }
        public virtual DbSet<EnvioCiudadEquipos> EnvioCiudadEquiposSet { get; set; }
        public virtual DbSet<PagoLocalEnvio> PagoLocalEnvioSet { get; set; }
        public virtual DbSet<CajaEfectivo> CajaEfectivoSet { get; set; }
        public virtual DbSet<Puesto> PuestoSet { get; set; }
        public virtual DbSet<Vale> ValeSet { get; set; }
        public virtual DbSet<SueldoPago> SueldoPagoSet { get; set; }
        public virtual DbSet<RendicionVale> RendicionValeSet { get; set; }
        public virtual DbSet<ValeFinanciacion> ValeFinanciacionSet { get; set; }
        public virtual DbSet<PagoLocalSueldo> PagoLocalSueldoSet { get; set; }
        public virtual DbSet<RendicionSueldo> RendicionSueldoSet { get; set; }
    }
}

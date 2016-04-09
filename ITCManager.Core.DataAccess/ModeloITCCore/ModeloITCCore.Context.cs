﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Core.DataAccess
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
    
        public virtual DbSet<CondicionEmpleado> CondicionEmpleado { get; set; }
        public virtual DbSet<DetalleCondicionEmpleado> DetalleCondicionEmpleado { get; set; }
        public virtual DbSet<EstadoAlumno> EstadoAlumno { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<PermisoAcceso> PermisoAcceso { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<RolAlumno> RolAlumno { get; set; }
        public virtual DbSet<RolEmpleado> RolEmpleado { get; set; }
        public virtual DbSet<RolVendedor> RolVendedor { get; set; }
        public virtual DbSet<AsignacionRecibo> AsignacionReciboSet { get; set; }
        public virtual DbSet<Linea> LineaSet { get; set; }
        public virtual DbSet<LineaCiudad> LineaCiudadSet { get; set; }
        public virtual DbSet<Ciudad> CiudadSet { get; set; }
        public virtual DbSet<Localidad> LocalidadSet { get; set; }
        public virtual DbSet<RolCiudadEnProceso> RolCiudadEnProcesoSet { get; set; }
        public virtual DbSet<RolCiudadActiva> RolCiudadActivaSet { get; set; }
        public virtual DbSet<CiudadPersonal> CiudadPersonalSet { get; set; }
        public virtual DbSet<CiudadActivaLocaciones> CiudadActivaLocacionesSet { get; set; }
        public virtual DbSet<Locacion> LocacionSet { get; set; }
        public virtual DbSet<RolLocacionAuspicio> RolLocacionAuspicioSet { get; set; }
        public virtual DbSet<RolLocador> RolLocadorSet { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
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
        public virtual DbSet<LineaDocentes> LineaDocentesSet { get; set; }
    }
}

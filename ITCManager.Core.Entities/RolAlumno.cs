//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class RolAlumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolAlumno()
        {
            this.PlanVendedorAlumno = new HashSet<PlanVendedorAlumno>();
            this.AlumnoHorario = new HashSet<AlumnoHorario>();
            this.RolAlumnoPresentismo = new HashSet<RolAlumnoPresentismo>();
            this.RolAlumnoPracticas = new HashSet<RolAlumnoPracticas>();
        }
    
        public int IdRolAlumno { get; set; }
        public int IdPersona { get; set; }
        public int IdCapacitacion { get; set; }
        public int IdEstadoAlumno { get; set; }
    
        public virtual EstadoAlumno EstadoAlumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanVendedorAlumno> PlanVendedorAlumno { get; set; }
        public virtual Capacitacion Capacitacion { get; set; }
        public virtual Persona Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoHorario> AlumnoHorario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolAlumnoPresentismo> RolAlumnoPresentismo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolAlumnoPracticas> RolAlumnoPracticas { get; set; }
    }
}

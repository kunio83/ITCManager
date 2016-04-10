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
    
    public partial class PlanVendedorAlumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanVendedorAlumno()
        {
            this.Pago = new HashSet<Pago>();
        }
    
        public int IdPlanVendedorAlumno { get; set; }
        public int IdRolCiudadActivaPlan { get; set; }
        public int IdRolAlumno { get; set; }
        public int IdRolVendedor { get; set; }
        public string ObservacionGerente { get; set; }
        public string ObservacionOficinaBaires { get; set; }
    
        public virtual RolAlumno RolAlumno { get; set; }
        public virtual RolVendedor RolVendedor { get; set; }
        public virtual RolCiudadActivaPlan RolCiudadActivaPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pago { get; set; }
    }
}

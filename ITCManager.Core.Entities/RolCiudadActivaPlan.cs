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
    using System.Runtime.Serialization;

    public partial class RolCiudadActivaPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolCiudadActivaPlan()
        {
            this.PlanVendedorAlumno = new HashSet<PlanVendedorAlumno>();
        }
    
        public int IdRolCiudadActivaPlan { get; set; }
        public int IdRolCiudadActiva { get; set; }
        public int IdPlanBase { get; set; }
        public string ValorMatricula { get; set; }
        public string CantCuotas { get; set; }
        public string ValorCuota { get; set; }
        public string ValorDescuento { get; set; }
        public string ValorCertificado { get; set; }
        public string ComisionIda { get; set; }
        public string ComisionVuelta { get; set; }
        public string ComisionCertificado { get; set; }

        [IgnoreDataMember]
        public virtual PlanBase PlanBase { get; set; }
        [IgnoreDataMember]
        public virtual RolCiudadActiva RolCiudadActiva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<PlanVendedorAlumno> PlanVendedorAlumno { get; set; }
    }
}

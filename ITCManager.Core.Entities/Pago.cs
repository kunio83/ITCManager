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
    
    public partial class Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pago()
        {
            this.PagoTarjeta = new HashSet<PagoTarjeta>();
        }
    
        public int IdPago { get; set; }
        public int IdPlanVendedorAlumno { get; set; }
        public string MontoPagado { get; set; }
        public int IdFormaPago { get; set; }
        public int IdItemPagado { get; set; }
    
        public virtual FormaPago FormaPago { get; set; }
        public virtual PlanVendedorAlumno PlanVendedorAlumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoTarjeta> PagoTarjeta { get; set; }
    }
}

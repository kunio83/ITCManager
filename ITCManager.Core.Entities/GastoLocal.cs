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
    
    public partial class GastoLocal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GastoLocal()
        {
            this.GastoLocalPagoLocal = new HashSet<GastoLocalPagoLocal>();
        }
    
        public int IdGastoLocal { get; set; }
        public string Fecha { get; set; }
        public string Detalle { get; set; }
        public string Observaciones { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GastoLocalPagoLocal> GastoLocalPagoLocal { get; set; }
    }
}
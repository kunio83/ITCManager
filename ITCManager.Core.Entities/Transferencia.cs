//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transferencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transferencia()
        {
            this.CompraTransferencia = new HashSet<PagoLocalTransferencia>();
        }
    
        public int IdTransferencia { get; set; }
        public int IdCuentaBanco { get; set; }
        public int IdCuentaBancoTercero { get; set; }
        public string Monto { get; set; }
        public int IdEstadoTransferencia { get; set; }
        public string Observaciones { get; set; }
    
        public virtual CuentaBanco CuentaBanco { get; set; }
        public virtual CuentaBancoTercero CuentaBancoTercero { get; set; }
        public virtual EstadoTransferencia EstadoTransferencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoLocalTransferencia> CompraTransferencia { get; set; }
    }
}

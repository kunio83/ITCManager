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
    
    public partial class PagoCheque
    {
        public int IdPagoCheque { get; set; }
        public int IdPago { get; set; }
        public int IdCheque { get; set; }
    
        public virtual Pago Pago { get; set; }
        public virtual Pago Pago1 { get; set; }
        public virtual Cheque Cheque { get; set; }
    }
}

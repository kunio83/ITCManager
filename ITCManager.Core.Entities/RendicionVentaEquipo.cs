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
    
    public partial class RendicionVentaEquipo
    {
        public int IdRendicionVentaEquipo { get; set; }
        public int IdPago { get; set; }
        public int IdArmadoEquipo { get; set; }
        public int IdEstadoVenta { get; set; }
    
        public virtual ArmadoEquipo ArmadoEquipo { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual EstadoVenta EstadoVenta { get; set; }
    }
}

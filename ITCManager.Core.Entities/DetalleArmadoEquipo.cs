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
    
    public partial class DetalleArmadoEquipo
    {
        public int IdDetalleArmadoEquipo { get; set; }
        public int IdArmadoEquipo { get; set; }
        public int IdProducto { get; set; }
    
        public virtual ArmadoEquipo ArmadoEquipo { get; set; }
        public virtual Productos Productos { get; set; }
    }
}

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
    
    public partial class GastoLocalPagoLocal
    {
        public int IdGastoLocalPagoLocal { get; set; }
        public int IdGastoLocal { get; set; }
        public int IdPagoLocal { get; set; }
    
        public virtual GastoLocal GastoLocal { get; set; }
        public virtual PagoLocal PagoLocal { get; set; }
    }
}

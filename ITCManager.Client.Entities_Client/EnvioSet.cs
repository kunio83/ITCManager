//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITCManager.Client.Entities_Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnvioSet
    {
        public long IdEnvio { get; set; }
        public System.DateTime FechaSolicitudEnvío { get; set; }
        public System.DateTime FechaSalidaEnvío { get; set; }
        public System.DateTime FechaEstimadaRecepción { get; set; }
        public long IdProveedor { get; set; }
        public string TipoRetiroEnvio { get; set; }
        public string TipoEntregaEnvio { get; set; }
        public string CantidadBultos { get; set; }
        public string CiudadOrigenEnvio { get; set; }
        public string CiudadDestinoEnvio { get; set; }
        public long IdRolCiudadActiva { get; set; }
        public string Remitente { get; set; }
        public string Destinatarios { get; set; }
        public string TipoPago { get; set; }
        public string Monto { get; set; }
        public string EstadoEnvio { get; set; }
        public string Observaciones { get; set; }
        public string NumeroGuia { get; set; }
    }
}
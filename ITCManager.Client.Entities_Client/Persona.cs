namespace ITCManager.Client.Entities_Client
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public System.DateTime FechaNac { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Celular { get; set; }
        public string TelAlternativo { get; set; }
        public string EstadoCivil { get; set; }
        public string Mail { get; set; }
    }
}
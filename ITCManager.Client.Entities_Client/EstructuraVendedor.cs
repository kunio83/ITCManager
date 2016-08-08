using System.Collections.Generic;

namespace ITCManager.Client.Entities_Client
{
    public class EstructuraVendedorInicial : IEntidadITC
    {
        public RolEmpleado RolEmpledoActual { get; set; }
        public List<Persona> PersonaVendedores { get; set; }
        public List<RolEmpleado> RolVendedores { get; set; }
        public RolCiudadActivaSet RolCiudadActiva { get; set; }
        public List<RolCiudadActivaPlanSet> RolCiudadActivaPlanes { get; set; }
        public List<RolCiudadActivaHorarioSet> RolCiudadActivaHorarios { get; set; }
        public List<HorarioSet> Horarios { get; set; }
        public List<DiaSet> Dias { get; set; }
        public List<PlanVendedorAlumnoSet> PlanVendedorAlumnos { get; set; }
        public List<CapacitacionSet> Capacitaciones { get; set; }
        public CiudadPersonalSet CiudadPersonal { get; set; }
        public CiudadSet Ciudad { get; set; }
        public LocalidadSet Localidad { get; set; }
        //pagos, rendicion, cheques...
    }
}
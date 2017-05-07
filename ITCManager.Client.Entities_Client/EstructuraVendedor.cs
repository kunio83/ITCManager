using System.Collections.Generic;

namespace ITCManager.Client.Entities_Client
{
    public class EstructuraVendedorInicial : IEntidadITC
    {
        public RolEmpleado RolEmpledoActual { get; set; }
        public List<Persona> PersonaVendedores { get; set; }
        public List<RolEmpleado> RolEmpleados { get; set; }
        public List<RolVendedor> RolVendedores { get; set; }
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
        public List<PlanBaseSet> PlanesBase { get; set; }
        public List<ItemPagadoSet> ItemsPagado { get; set; }
        public List<FormaPagoSet> FormasPago { get; set; }
        public List<PagoSet> Pagos { get; set; }
        public List<PagoChequeSet> PagosCheque { get; set; }
        public List<ChequeSet> Cheques { get; set; }
        public List<EstadoChequeSet> EstadosCheque { get; set; }
        public List<GastoChequeSet> GastosCheque { get; set; }
        public List<RolAlumno> RolesAlumno { get; set; }
        public List<Persona> PersonasAlumnos { get; set; }
        public List<EstadoAlumno> EstadosAlumno { get; set; }
        //pagos, rendicion, cheques...
    }
}
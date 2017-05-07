using System.Collections.Generic;

namespace ITCManager.Core.Entities
{
    public class EstructuraVendedorInicial : IEntidadITC
    {
        public RolEmpleado RolEmpledoActual { get; set; }
        public List<Persona> PersonaVendedores { get; set; }
        public List<RolEmpleado> RolEmpleados { get; set; }
        public List<RolVendedor> RolVendedores { get; set; }
        public RolCiudadActiva RolCiudadActiva { get; set; }
        public List<RolCiudadActivaPlan> RolCiudadActivaPlanes { get; set; }
        public List<RolCiudadActivaHorario> RolCiudadActivaHorarios { get; set; }
        public List<Horario> Horarios { get; set; }
        public List<Dia> Dias { get; set; }
        public List<PlanVendedorAlumno> PlanVendedorAlumnos { get; set; }
        public List<Capacitacion> Capacitaciones { get; set; }
        public CiudadPersonal CiudadPersonal { get; set; }
        public Ciudad Ciudad { get; set; }
        public Localidad Localidad { get; set; }
        public List<PlanBase> PlanesBase { get; set; }
        public List<ItemPagado> ItemsPagado { get; set; }
        public List<FormaPago> FormasPago { get; set; }
        public List<Pago> Pagos { get; set; }
        public List<PagoCheque> PagosCheque { get; set; }
        public List<Cheque> Cheques { get; set; }
        public List<EstadoCheque> EstadosCheque { get; set; }
        public List<GastoCheque> GastosCheque { get; set; }
        public List<RolAlumno> RolesAlumno { get; set; }
        public List<Persona> PersonasAlumnos { get; set; }
        public List<EstadoAlumno> EstadosAlumno { get; set; }
        //pagos, rendicion, cheques...
    }
}
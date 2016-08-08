using System.Collections.Generic;

namespace ITCManager.Core.Entities
{
    public class EstructuraVendedorInicial : IEntidadITC
    {
        public RolEmpleado RolEmpledoActual { get; set; }
        public List<Persona> PersonaVendedores { get; set; }
        public List<RolEmpleado> RolVendedores { get; set; }
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
        //pagos, rendicion, cheques...
    }

    public class EstructuraVendedorEnProceso : IEntidadITC
    {
        public List<Pago> Pagos { get; set; }
        public RendicionPersonaCiudad RendicionPersonaCiudad { get; set; }
        public List<EstadoRendicion> EstadoRendiciones { get; set; }
        public List<RendicionPago> RendicionPagos { get; set; }
        public List<RendicionDeposito> RendicionDeposito { get; set; }
        public List<Persona> PersonaAlumnos { get; set; }
        public List<RolAlumno> RolAlumnos { get; set; }
        public List<AlumnoHorario> AlumnoHorarios { get; set; }
    }

}
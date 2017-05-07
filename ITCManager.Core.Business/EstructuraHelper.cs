using ITCManager.Core.DataAccess;
using ITCManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Core.Business
{
    public static class EstructuraHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();

        //Aca debo instanciar las entidades que usan las estructuras...
        static private Repository<RolEmpleado> rolEmpleadoRepository;
        static private Repository<RolCiudadActiva> rolCiudadActivaRepository;
        static private Repository<RolCiudadActivaPlan> rolCiudadActivaPlanRepository;
        static private Repository<Localidad> localidadRepository;
        static private Repository<PlanVendedorAlumno> planVendedorAlumnoRepository;
        static private Repository<Ciudad> ciudadRepository;
        static private Repository<CiudadPersonal> ciudadPersonalRepository;
        static private Repository<RolVendedor> rolVendedorRepository;
        static private Repository<Capacitacion> capacitacionRepository;
        static private Repository<Dia> diaRepository;
        static private Repository<Horario> horarioRepository;
        static private Repository<PlanBase> planBaseRepository;
        static private Repository<Persona> personaRepository;
        static private Repository<Puesto> puestoRepository;

        static private Repository<RolAlumno> rolAlumnoRepository;
        static private Repository<ItemPagado> itemPagadoRepository;
        static private Repository<FormaPago> formaPagoRepository;
        static private Repository<Pago> pagoRepository;
        static private Repository<PagoCheque> pagoChequeRepository;
        static private Repository<Cheque> chequeRepository;
        static private Repository<EstadoCheque> estadoChequeRepository;
        static private Repository<GastoCheque> gastoChequeRepository;
        static private Repository<EstadoAlumno> estadoAlumnoRepository;









        public static EstructuraVendedorInicial GetEsctructuraVendedorByToken(string token)
        {
            try
            {
                rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
                //Obtengo su rol empleado a traves del token
                List<RolEmpleado> lstRolEmpleado = rolEmpleadoRepository.Table.ToList();
                RolEmpleado rolEmpleado = lstRolEmpleado.FirstOrDefault(e => e.Contraseña == token);

                if (rolEmpleado != null)
                {
                    //Identifico su RolCiudadActiva
                    EstructuraVendedorInicial result = new EstructuraVendedorInicial();

                    ciudadPersonalRepository = unitOfWork.Repository<CiudadPersonal>();
                    rolCiudadActivaRepository = unitOfWork.Repository<RolCiudadActiva>();
                    ciudadRepository = unitOfWork.Repository<Ciudad>();
                    rolVendedorRepository = unitOfWork.Repository<RolVendedor>();
                    planVendedorAlumnoRepository = unitOfWork.Repository<PlanVendedorAlumno>();
                    rolCiudadActivaPlanRepository = unitOfWork.Repository<RolCiudadActivaPlan>();
                    localidadRepository = unitOfWork.Repository<Localidad>();
                    capacitacionRepository = unitOfWork.Repository<Capacitacion>();
                    diaRepository = unitOfWork.Repository<Dia>();
                    horarioRepository = unitOfWork.Repository<Horario>();
                    planBaseRepository = unitOfWork.Repository<PlanBase>();
                    personaRepository = unitOfWork.Repository<Persona>();
                    puestoRepository = unitOfWork.Repository<Puesto>();
                    itemPagadoRepository = unitOfWork.Repository<ItemPagado>();
                    formaPagoRepository = unitOfWork.Repository<FormaPago>();
                    pagoRepository = unitOfWork.Repository<Pago>();
                    pagoChequeRepository = unitOfWork.Repository<PagoCheque>();
                    chequeRepository = unitOfWork.Repository<Cheque>();
                    estadoChequeRepository = unitOfWork.Repository<EstadoCheque>();
                    gastoChequeRepository = unitOfWork.Repository<GastoCheque>();
                    rolAlumnoRepository = unitOfWork.Repository<RolAlumno>();
                    estadoAlumnoRepository = unitOfWork.Repository<EstadoAlumno>();

                    CiudadPersonal ciudadPersonal = ciudadPersonalRepository.Table.FirstOrDefault(e => e.IdRolEmpleado == rolEmpleado.IdRolEmpleado);
                        if (ciudadPersonal == null) return null;
                    Ciudad ciudad = ciudadRepository.GetById(ciudadPersonal.IdCiudad);
                    Localidad localidad = localidadRepository.GetById(ciudad.IdLocalidad);
                    RolCiudadActiva rolCiudadActiva = rolCiudadActivaRepository.Table.FirstOrDefault(e => e.IdCiudad == ciudadPersonal.IdCiudad);
                    List<RolCiudadActivaPlan> rolCiudadActivaPlanes = rolCiudadActivaPlanRepository.Table.Where(e => e.IdRolCiudadActiva == rolCiudadActiva.IdRolCiudadActiva).ToList();
                    List<Capacitacion> capacitaciones = capacitacionRepository.Table.ToList();
                    List<Dia> dias = diaRepository.Table.ToList();
                    List<Horario> horarios = horarioRepository.Table.ToList();
                    List<PlanBase> planBases = planBaseRepository.Table.ToList();
                    List<EstadoAlumno> estadosAlumno = estadoAlumnoRepository.Table.ToList();
                    //Traigo solo los vendedores
                    List<Puesto> puestos = puestoRepository.Table.ToList();
                    int idPuestoVendedor = puestos.FirstOrDefault(e => e.DetallePuesto.ToUpper().Contains("VENDEDOR")).IdPuesto;
                    List<RolEmpleado> rolEmpleadoVendedores = lstRolEmpleado.Where(e => e.IdPuesto == idPuestoVendedor).ToList();
                    var rolVendedores = (from v in rolVendedorRepository.Table.ToList()
                                         join c in lstRolEmpleado
                                         on v.IdRolEmpleado equals c.IdRolEmpleado
                                         select v);

                    List < int > lstIdsVendedores = rolEmpleadoVendedores.Select(r => r.IdPersona).ToList<int>();
                    var personaVendedores = (from p in personaRepository.Table.ToList()
                                                join c in lstRolEmpleado.Where(e => e.IdPuesto == idPuestoVendedor)
                                                on p.IdPersona equals c.IdPersona
                                                select p);

                    //Traigo alumnos con sus pagos...etc
                    var planesVendedorAlumno = (from p in planVendedorAlumnoRepository.Table.ToList()
                                                                     join c in rolCiudadActivaPlanes
                                                                     on p.IdRolCiudadActivaPlan equals c.IdRolCiudadActivaPlan
                                                                     select p); 

                    var rolAlumnos = (from p in rolAlumnoRepository.Table.ToList()
                                      join c in planesVendedorAlumno
                                      on p.IdRolAlumno equals c.IdRolAlumno
                                      select p);

                    var personaAlumnos = (from p in personaRepository.Table.ToList()
                                          join c in rolAlumnos
                                          on p.IdPersona equals c.IdPersona
                                          select p);


                    //Cargo la info en la estructura
                    result.RolEmpledoActual = rolEmpleado;
                    result.CiudadPersonal = ciudadPersonal;
                    result.Ciudad = ciudad;
                    result.Localidad = localidad;
                    result.RolCiudadActiva = rolCiudadActiva;
                    result.RolCiudadActivaPlanes = rolCiudadActivaPlanes;
                    result.Dias = dias;
                    result.Capacitaciones = capacitaciones;
                    result.Horarios = horarios;
                    result.PlanesBase = planBases;
                    result.PersonaVendedores = personaVendedores.ToList();
                    result.RolVendedores = rolVendedores.ToList();
                    result.RolEmpleados = rolEmpleadoVendedores;
                    result.PlanVendedorAlumnos = planesVendedorAlumno.ToList();
                    result.RolesAlumno = rolAlumnos.ToList();
                    result.PersonasAlumnos = personaAlumnos.ToList();
                    result.EstadosAlumno = estadosAlumno;

                    return result;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public static Persona GetPersonaById(int idPersona)
        //{
        //    Persona result;
        //    personaRepository = unitOfWork.Repository<Persona>();
        //    result = personaRepository.GetById(idPersona);
        //    return result;
        //}

        //public static Persona GetPersonaByDni(string dni)
        //{
        //    Persona result;
        //    personaRepository = unitOfWork.Repository<Persona>();
        //    result = personaRepository.Table.FirstOrDefault(z => z.DNI == dni.Trim());
        //    return result;
        //}

        //public static List<Persona> GetAll()
        //{
        //    List<Persona> result;
        //    personaRepository = unitOfWork.Repository<Persona>();
        //    result = personaRepository.Table.ToList<Persona>();
        //    return result;
        //}

        //public static List<Persona> GetAllByEmpleado(RolEmpleado empleado)
        //{
        //    List<Persona> result;
        //    personaRepository = unitOfWork.Repository<Persona>();
        //    result = personaRepository.Table.ToList<Persona>();
        //    return result;
        //}

        //public static void Save(Persona persona)
        //{
        //    personaRepository.Update(persona);
        //}
    }
}

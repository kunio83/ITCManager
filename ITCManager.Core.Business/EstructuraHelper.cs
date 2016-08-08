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

        public static EstructuraVendedorInicial GetEsctructuraVendedorByToken(string token)
        {
            try
            {
                rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
                //Obtengo su rol empleado a traves del token
                RolEmpleado rolEmpleado = rolEmpleadoRepository.Table.FirstOrDefault(e => e.Contraseña == token);
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

                    CiudadPersonal ciudadPersonal = ciudadPersonalRepository.Table.FirstOrDefault(e => e.IdRolEmpleado == rolEmpleado.IdRolEmpleado);
                    if (ciudadPersonal == null) return null;
                    Ciudad ciudad = ciudadRepository.GetById(ciudadPersonal.IdCiudad);
                    Localidad localidad = localidadRepository.GetById(ciudad.IdLocalidad);
                    RolCiudadActiva rolCiudadActiva = rolCiudadActivaRepository.Table.FirstOrDefault(e => e.IdCiudad == ciudadPersonal.IdCiudad);
                    List<RolCiudadActivaPlan> rolCiudadActivaPlanes = rolCiudadActivaPlanRepository.Table.Where(e => e.IdRolCiudadActiva == rolCiudadActiva.IdRolCiudadActiva).ToList();

                    //Cargo la info en la estructura
                    result.RolEmpledoActual = rolEmpleado;
                    result.CiudadPersonal = ciudadPersonal;
                    result.Ciudad = ciudad;
                    result.Localidad = localidad;
                    result.RolCiudadActiva = rolCiudadActiva;
                    result.RolCiudadActivaPlanes = rolCiudadActivaPlanes;

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

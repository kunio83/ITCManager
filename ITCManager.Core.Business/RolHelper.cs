using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Core.Entities;
using ITCManager.Core.DataAccess;

namespace ITCManager.Core.Business
{
    public class RolHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();
        static private Repository<Persona> personaRepository;
        static private Repository<RolEmpleado> rolEmpleadoRepository;



        public static IQueryable<Persona> GetPersonaEmpleados()
        {
            personaRepository = unitOfWork.Repository<Persona>();
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();

            var queryPersEmp = from p in personaRepository.Table
                               join e in rolEmpleadoRepository.Table on p.IdPersona equals e.IdPersona
                               select p;
                               //{
                               //    p.IdPersona,
                               //    p.Nombres,
                               //    p.Apellido,
                               //    p.DNI,
                               //    e.IdPuesto,
                               //    e.Permiso,
                               //    e.CelCorp
                               //};

            //var persona = personaRepository.Table.FirstOrDefault(z => z.IdPersona == 2);

            //var rolEmpleado = new RolEmpleado();
            //persona.RolEmpleado.Add(rolEmpleado);
            //personaRepository.Update(persona);


            return queryPersEmp;
        }

        public static List<RolEmpleado> GetRolEmpleados()
        {
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            return rolEmpleadoRepository.Table.ToList<RolEmpleado>();
        }

        public static RolEmpleado GetEmpleadoByPersona(Persona persona)
        {
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            return rolEmpleadoRepository.GetById(persona.IdPersona);
        }

        public void guardarRol(Persona pers)
        {

        }
    }
}

using ITCManager.Core.DataAccess;
using ITCManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Core.Business
{
    public static class LoginHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();

        //Aca debo instanciar las entidades que usan las estructuras...
        static private Repository<RolEmpleado> rolEmpleadoRepository;
        static private Repository<Persona> personaRepository;


        public static RolEmpleado GetRolEmpleadoByDniToken(string dni, string token)
        {
            try
            {
                rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
                personaRepository = unitOfWork.Repository<Persona>();

                Persona persona = personaRepository.Table.FirstOrDefault(e => e.DNI == dni); 
                if(persona != null)
                //Obtengo su rol empleado a traves del token
                    return rolEmpleadoRepository.Table.FirstOrDefault(e => e.Contraseña == token && e.IdPersona == persona.IdPersona);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

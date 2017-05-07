using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Core.Entities;
using ITCManager.Core.DataAccess;
using System.Net.Http;

namespace ITCManager.Core.Business
{
    public class RolEmpleadoHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();
        static private Repository<RolEmpleado> rolEmpleadoRepository;

        public static RolEmpleado GetRolEmpleadoById(int idRolEmpleado)
        {
            RolEmpleado result;
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            result = rolEmpleadoRepository.GetById(idRolEmpleado);
            return result;
        }

        public static RolEmpleado GetRolEmpleadoByToken(string token)
        {
            RolEmpleado result;
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            result = rolEmpleadoRepository.Table.FirstOrDefault(e => e.Contraseña == token);
            return result;
        }

        public static List<RolEmpleado> GetAll()
        {
            List<RolEmpleado> result;
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            result = rolEmpleadoRepository.Table.ToList();
            return result;
        }

        public static List<RolEmpleado> GetAllByEmpleado(RolEmpleado empleado)
        {
            List<RolEmpleado> result;
            rolEmpleadoRepository = unitOfWork.Repository<RolEmpleado>();
            result = rolEmpleadoRepository.Table.ToList();
            return result;
        }

        public static void Save(RolEmpleado rolEmpleado)
        {
            rolEmpleadoRepository.Update(rolEmpleado);
        }
    }
}

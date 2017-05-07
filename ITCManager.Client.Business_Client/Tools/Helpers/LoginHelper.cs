using ITCManager.Client.DataAccess_Client.DBTools;
using ITCManager.Client.Entities_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools.Helpers
{
    public static class LoginHelper
    {
        public static RolEmpleado GetRolEmpleadoActual()
        {
            UnitOfWork uow = new UnitOfWork();
            Repository<RolEmpleadoActual> repoRolActual = uow.Repository<RolEmpleadoActual>();
            Repository<RolEmpleado> repoRolEmpleado = uow.Repository<RolEmpleado>();

            RolEmpleadoActual rolEmpleadoActual = repoRolActual.Table.FirstOrDefault();

            if (rolEmpleadoActual == null) return null;

            return repoRolEmpleado.GetById(rolEmpleadoActual.IdRolEmpleado);
        }

        public static RolEmpleado GetRolEmpleadoLogueado(string token)
        {
            GestorITCApi gestor = new GestorITCApi(token);
            return gestor.GestorRolEmpleado.TraerPorId(0);
        }

        public static PuestoSet GetPuesto(string token, RolEmpleado rolEmpleado)
        {
            GestorITCApi gestor = new GestorITCApi(token);
            return gestor.GestorPuesto.TraerPorId((int)rolEmpleado.IdPuesto);
        }
    }
}

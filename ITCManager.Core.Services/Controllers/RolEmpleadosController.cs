using ITCManager.Core.Business;
using ITCManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITCManager.Core.Services.Controllers
{
    public class RolEmpleadosController : ApiController
    {
        public RolEmpleado Get(int id)
        {
            var re = Request;
            var headers = re.Headers;
            string token = String.Empty;
            string dni = String.Empty;

            if (headers.Contains("Authentication"))
            { 
                token = headers.GetValues("Authentication").First();
                return RolEmpleadoHelper.GetRolEmpleadoByToken(token);
            }

            return RolEmpleadoHelper.GetRolEmpleadoById(id);
        }

        public IEnumerable<RolEmpleado> Get()
        {
            return RolEmpleadoHelper.GetAll();
        }

        public void Post([FromBody]RolEmpleado rolEmpleado)
        {
            RolEmpleadoHelper.Save(rolEmpleado);
        }

        public void Put([FromBody]RolEmpleado rolEmpleado)
        {
            RolEmpleadoHelper.Save(rolEmpleado);
        }
    }
}

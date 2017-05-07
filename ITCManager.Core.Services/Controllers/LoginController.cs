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
    public class LoginController : ApiController
    {
        public RolEmpleado Get(string dni, string token)
        {
            return LoginHelper.GetRolEmpleadoByDniToken(dni, token);
        }

        public RolEmpleado Get()
        {
            var re = Request;
            var headers = re.Headers;
            string token = String.Empty;
            string dni = String.Empty;

            if (headers.Contains("Authentication"))
                token = headers.GetValues("Authentication").First();
            if (headers.Contains("dni"))
                dni = headers.GetValues("dni").First();

            return LoginHelper.GetRolEmpleadoByDniToken(dni, token);
        }

        //public void Post([FromBody]Persona persona)
        //{
        //    PersonaHelper.Save(persona);
        //}

        //public void Put([FromBody]Persona persona)
        //{
        //    PersonaHelper.Save(persona);
        //}
    }
}

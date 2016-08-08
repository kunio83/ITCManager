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
    public class PersonasController : ApiController
    {
        public Persona Get(int id)
        {
            return PersonaHelper.GetPersonaById(id);
        }

        public IEnumerable<Persona> Get()
        {
            var re = Request;
            var headers = re.Headers;

            if (headers.Contains("User-Agent"))
            {
                string token = headers.GetValues("User-Agent").First();
            }


            return PersonaHelper.GetAll();
        }

        public void Post([FromBody]Persona persona)
        {
            PersonaHelper.Save(persona);
        }

        public void Put([FromBody]Persona persona)
        {
            PersonaHelper.Save(persona);
        }
    }
}

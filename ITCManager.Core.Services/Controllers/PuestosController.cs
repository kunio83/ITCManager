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
    public class PuestosController : ApiController
    {
        public Puesto Get(int id)
        {
            return PuestoHelper.GetPuestoById(id);
        }

        public IEnumerable<Puesto> Get()
        {
            //var re = Request;
            //var headers = re.Headers;

            //if (headers.Contains("User-Agent"))
            //{
            //    string token = headers.GetValues("User-Agent").First();
            //}


            return PuestoHelper.GetAll();
        }

        public void Post([FromBody]Puesto puesto)
        {
            PuestoHelper.Save(puesto);
        }

        public void Put([FromBody]Puesto puesto)
        {
            PuestoHelper.Save(puesto);
        }
    }
}

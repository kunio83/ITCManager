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
    public class EstructurasController : ApiController
    {
        public EstructuraVendedorInicial Get(string token)
        {
            return EstructuraHelper.GetEsctructuraVendedorByToken(token);
        }

        public EstructuraVendedorInicial Get()
        {
            var re = Request;
            var headers = re.Headers;
            string token = String.Empty;
            List<EstructuraVendedorInicial> result = new List<EstructuraVendedorInicial>();
            if (headers.Contains("Authentication"))
            {
                token = headers.GetValues("Authentication").First();
            }
            return EstructuraHelper.GetEsctructuraVendedorByToken(token);
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

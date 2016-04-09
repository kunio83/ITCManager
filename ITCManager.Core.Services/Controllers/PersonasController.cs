using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ITCManager.Core.Entities;
using ITCManager.Core.Business;

namespace ITCManager.Core.Services.Controllers
{
    public class PersonasController : ApiController
    {
        public String Get(int id)
        {
            return ITCHelper.GetPersonaById(id).Nombres;
        }

    }
}

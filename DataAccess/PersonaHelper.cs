using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class PersonaHelper : IPersonaHelper
    {
        ITC_DBPOwerEntities ctx;

        public List<Persona> GetPersonas()
        {
            using (ctx = new ITC_DBPOwerEntities())
            {
                return ctx.Persona.ToList();
            }
                
        }


    }
}

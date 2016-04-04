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

        public Persona GetPersonaById(int idPersona)
        {
            using (ctx = new ITC_DBPOwerEntities())
            {
                return ctx.Persona.FirstOrDefault(z => z.IdPersona == idPersona);
            }

        }


    }
}

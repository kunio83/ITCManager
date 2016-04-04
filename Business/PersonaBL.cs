using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;
using DataAccess;

namespace Bussiness
{
    public class PersonaBL
    {
        static PersonaHelper helper = new PersonaHelper();

        public static List<Persona> GetPersonas()
        {
            return helper.GetPersonas();
        }

        public static Persona GetPersonaById(int idPersona)
        {
            return helper.GetPersonaById(idPersona); ;
        }
    }
}

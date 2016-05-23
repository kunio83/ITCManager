using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Core.Entities;
using ITCManager.Core.DataAccess;

namespace ITCManager.Core.Business
{
    public class PersonaHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();
        static private Repository<Persona> personaRepository;

        public static Persona GetPersonaById(int idPersona)
        {
            Persona result;
            personaRepository = unitOfWork.Repository<Persona>();
            result = personaRepository.GetById(idPersona);
            return result;
        }

        public static Persona GetPersonaByDni(string dni)
        {
            Persona result;
            personaRepository = unitOfWork.Repository<Persona>();
            result = personaRepository.Table.FirstOrDefault(z => z.DNI == dni.Trim());
            return result;
        }

        public static List<Persona> GetAll()
        {
            List<Persona> result;
            personaRepository = unitOfWork.Repository<Persona>();
            result = personaRepository.Table.ToList<Persona>();
            return result;
        }

        public static void Save(Persona persona)
        {
            personaRepository.Update(persona);
        }
    }
}

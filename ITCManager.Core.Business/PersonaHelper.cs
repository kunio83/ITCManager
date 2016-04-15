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

        public static Persona GetPersonaByDni(string dni)
        {
            Persona result;
            personaRepository = unitOfWork.Repository<Persona>();
            result = personaRepository.Table.FirstOrDefault(z => z.DNI == dni.Trim());
            return result;
        }
    }
}

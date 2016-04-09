using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ITCManager.Core.Entities;
using ITCManager.Core.DataAccess;

namespace ITCManager.Core.Business
{
    public static class ITCHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();
        static private Repository<Persona> personaRepository;

        //public static Persona GetPersonaById(int id)
        //{
        //    Persona result;
        //    personaRepository = unitOfWork.Repository<Persona>();
        //    result = personaRepository.GetById(id);
        //    return result;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Core.Entities;
using ITCManager.Core.DataAccess;
using System.Net.Http;

namespace ITCManager.Core.Business
{
    public class PuestoHelper
    {
        static private UnitOfWork unitOfWork = new UnitOfWork();
        static private Repository<Puesto> puestoRepository;

        public static Puesto GetPuestoById(int idPersona)
        {
            Puesto result;
            puestoRepository = unitOfWork.Repository<Puesto>();
            result = puestoRepository.GetById(idPersona);
            return result;
        }

        public static List<Puesto> GetAll()
        {
            List<Puesto> result;
            puestoRepository = unitOfWork.Repository<Puesto>();
            result = puestoRepository.Table.ToList();
            return result;
        }        

        public static void Save(Puesto puesto)
        {
            puestoRepository.Update(puesto);
        }
    }
}

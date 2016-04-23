using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Client.DataAccess_Client;
using ITCManager.Client.Entities_Client;

namespace ITCManager.Client.Business
{
    public static class Class1
    {
        static PersonaRepositoryDA personaRepo;

        public static void conectar()
        {
            SqliteConect conect = new SqliteConect();
            conect.Conectar();
        }

        public static String GetNombreById(int idPersona)
        {
            //String result = string.Empty;
            //SqliteConect conect = new SqliteConect();
            //return conect.GetNombreById(idPersona);
            return "";
        }

        public static List<Persona> Getall()
        {
            using (personaRepo = new PersonaRepositoryDA())
            {
                return personaRepo.GetAll();
            }
        }

        public static List<Persona>  traerPorFechNac(DateTime dateTime)
        {
            List<Persona> todos = Getall();

            return todos.Where(z => z.FechaNac == dateTime).ToList();

        }

    }
}

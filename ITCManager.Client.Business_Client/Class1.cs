using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Client.DataAccess_Client;

namespace ITCManager.Client.Business
{
    public static class Class1
    {
        public static void conectar()
        {
            SqliteConect conect = new SqliteConect();
            conect.Conectar();
        }

        public static String GetNombreById(int idPersona)
        {
            String result = string.Empty;
            SqliteConect conect = new SqliteConect();
            return conect.GetNombreById(idPersona);
        }
    }
}

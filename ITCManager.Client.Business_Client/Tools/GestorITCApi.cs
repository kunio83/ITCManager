using ITCManager.Client.Business_Client.Tools.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools
{
    public class GestorITCApi
    {
        public GestorPersona Persona { get; set; }

        public GestorITCApi(string token)
        {
            //String endpoint = "http://152.168.17.190/ejemplo/api/";
            String endpoint = "http://localhost/itcservice/api/";
            //String token = "";

            this.Persona = new GestorPersona(endpoint, token);
        }


    }

}

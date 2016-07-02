using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools.Helpers
{
    public static class RequestHelper
    {
        public static IRestRequest CrearRequest(String nombreMetodo, String token, Method metodo)
        {
            IRestRequest request = new RestRequest(nombreMetodo, metodo);
            request.RequestFormat = DataFormat.Json;

            //request.AddHeader("Authentication", token);
            //request.AddHeader("User-Agent", "TiendaNubeCore (znube.com.ar)");
            //request.AddHeader("Content-Type", "application/json");

            return request;
        }

    }
}

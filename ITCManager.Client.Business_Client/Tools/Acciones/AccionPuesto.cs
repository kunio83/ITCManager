using System;
using System.Collections.Generic;
using ITCManager.Client.Entities_Client;
using RestSharp;

namespace ITCManager.Client.Business_Client.Tools.Acciones
{
    internal class AccionPuesto : IAccionEntidad
    {
        public IRestRequest ObtenerRequestDELETE(string token, int entityId)
        {
            throw new NotImplementedException();
        }

        public IRestRequest ObtenerRequestGET(string token)
        {
            var nombreMetodo = String.Format("/puestos");

            return Helpers.RequestHelper.CrearRequest(nombreMetodo, token, Method.GET);
        }

        public IRestRequest ObtenerRequestGETbyID(string token, int entityId)
        {
            var nombreMetodo = String.Format("/puestos/" + entityId);

            return Helpers.RequestHelper.CrearRequest(nombreMetodo, token, Method.GET);
        }

        public IRestRequest ObtenerRequestGETbyKey(string token, Dictionary<string, string> filter, int paginaActual = 1)
        {
            throw new NotImplementedException();
        }

        public IRestRequest ObtenerRequestPOST(string token, IEntidadITC entidad)
        {
            var nombreMetodo = String.Format("/puestos");

            IRestRequest resultado = Helpers.RequestHelper.CrearRequest(nombreMetodo, token, Method.POST);

            resultado.AddBody(entidad);

            return resultado;
        }

        public IRestRequest ObtenerRequestPUT(string token, int entityId, IEntidadITC entidad)
        {
            var nombreMetodo = String.Format("/puestos/{0}", entityId);

            IRestRequest resultado = Helpers.RequestHelper.CrearRequest(nombreMetodo, token, Method.PUT);

            resultado.AddBody(entidad);

            return resultado;
        }
    }
}
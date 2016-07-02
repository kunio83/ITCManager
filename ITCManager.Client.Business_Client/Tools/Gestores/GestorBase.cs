using ITCManager.Client.Business_Client.Tools.Acciones;
using RestSharp;
using System;
namespace ITCManager.Client.Business_Client.Tools.Gestores
{
    public abstract class GestorBase
    {
        protected String _token;
        protected String _direccion;
        protected IAccionEntidad _accion;

        protected IRestClient _restClient;


        protected GestorBase(String direccion, String token, IAccionEntidad accion)
        {
            this._direccion = direccion;
            this._token = token;
            this._accion = accion;
            this._restClient = new RestClient(direccion);
        }
    }
}
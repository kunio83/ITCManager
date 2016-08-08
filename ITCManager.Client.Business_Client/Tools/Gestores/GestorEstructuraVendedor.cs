using ITCManager.Client.Business_Client.Tools.Acciones;
using ITCManager.Client.Business_Client.Tools.Helpers;
using ITCManager.Client.Entities_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools.Gestores
{
    public class GestorEstructuraVendedor : GestorBase
    {
        //private String _token;
        public GestorEstructuraVendedor(String direccion, String token) : base(direccion, token, new AccionEstructuraVendedor())
        {
            this._token = Encrypto.GetSHA1(token);
        }

        public List<EstructuraVendedorInicial> TraerTodos()
        {
            var request = _accion.ObtenerRequestGET(this._token);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener la Estructura", new Exception(resultadojSon.Content));
            }

            var resultado = HelperJson.DeSerializar<List<EstructuraVendedorInicial>>(resultadojSon.Content);

            return resultado;

        }

        public EstructuraVendedorInicial TraerPorId(int entityId)
        {
            var request = _accion.ObtenerRequestGETbyID(_token, entityId);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener la estructura " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }

            var resultado = Helpers.HelperJson.DeSerializar<EstructuraVendedorInicial>(resultadojSon.Content);

            return resultado;
        }

        public Int32 Crear(EstructuraVendedorInicial persona)
        {
            var request = _accion.ObtenerRequestPOST(_token, persona);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.Created))
            {
                throw new Exception("No se pudo crear el cliente.", new Exception(resultadojSon.Content));
            }

            var objetoCreado = Helpers.HelperJson.DeSerializar<EstructuraVendedorInicial>(resultadojSon.Content);

            return 0;
        }

        public void Modificar(Int32 entityId, EstructuraVendedorInicial persona)
        {
            var request = _accion.ObtenerRequestPUT(_token, entityId, persona);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo modificar la persona " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }
        }
    }
}

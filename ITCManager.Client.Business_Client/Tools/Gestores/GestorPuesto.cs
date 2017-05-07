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
    public class GestorPuesto : GestorBase
    {
        //private String _token;
        public GestorPuesto(String direccion, String token) : base(direccion, token, new AccionPuesto())
        {
            this._token = token;
        }

        public List<PuestoSet> TraerTodos()
        {
            var request = _accion.ObtenerRequestGET(this._token);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener todos los puestos", new Exception(resultadojSon.Content));
            }

            var resultado = HelperJson.DeSerializar<List<PuestoSet>>(resultadojSon.Content);

            return resultado;

        }

        public PuestoSet TraerPorId(int entityId)
        {
            var request = _accion.ObtenerRequestGETbyID(_token, entityId);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener el puesto " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }

            var resultado = Helpers.HelperJson.DeSerializar<PuestoSet>(resultadojSon.Content);

            return resultado;
        }

        public long Crear(PuestoSet puesto)
        {
            var request = _accion.ObtenerRequestPOST(_token, puesto);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.Created))
            {
                throw new Exception("No se pudo crear el puesto.", new Exception(resultadojSon.Content));
            }

            var objetoCreado = Helpers.HelperJson.DeSerializar<PuestoSet>(resultadojSon.Content);

            return objetoCreado.IdPuesto;
        }

        public void Modificar(Int32 entityId, PuestoSet puesto)
        {
            var request = _accion.ObtenerRequestPUT(_token, entityId, puesto);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo modificar el puesto " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }
        }
    }
}

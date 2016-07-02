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
    public class GestorPersona : GestorBase
    {
        public GestorPersona(String direccion, String token) : base(direccion, token, new AccionPersona())
        {

        }

        public List<Persona> TraerTodos()
        {
            var request = _accion.ObtenerRequestGET(_token);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener todos las personas", new Exception(resultadojSon.Content));
            }

            var resultado = HelperJson.DeSerializar<List<Persona>>(resultadojSon.Content);

            return resultado;

        }

        public Persona TraerPorId(int entityId)
        {
            var request = _accion.ObtenerRequestGETbyID(_token, entityId);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener el cliente " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }

            var resultado = Helpers.HelperJson.DeSerializar<Persona>(resultadojSon.Content);

            return resultado;
        }

        public Int32 Crear(Persona persona)
        {
            var request = _accion.ObtenerRequestPOST(_token, persona);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.Created))
            {
                throw new Exception("No se pudo crear el cliente.", new Exception(resultadojSon.Content));
            }

            var objetoCreado = Helpers.HelperJson.DeSerializar<Persona>(resultadojSon.Content);

            return objetoCreado.IdPersona;
        }

        public void Modificar(Int32 entityId, Persona persona)
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

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
    public class GestorRolEmpleado : GestorBase
    {
        //private String _token;
        public GestorRolEmpleado(String direccion, String token) : base(direccion, token, new AccionRolEmpleado())
        {
            this._token = Encrypto.GetSHA1(token);
        }

        public List<RolEmpleado> TraerTodos()
        {
            var request = _accion.ObtenerRequestGET(this._token);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener el RolEmpleado", new Exception(resultadojSon.Content));
            }

            var resultado = HelperJson.DeSerializar<List<RolEmpleado>>(resultadojSon.Content);

            return resultado;

        }

        public RolEmpleado TraerPorId(int entityId)
        {
            var request = _accion.ObtenerRequestGETbyID(_token, entityId);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo obtener la RolEmpleado " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }

            var resultado = Helpers.HelperJson.DeSerializar<RolEmpleado>(resultadojSon.Content);

            return resultado;
        }

        public Int32 Crear(RolEmpleado rolEmpleado)
        {
            var request = _accion.ObtenerRequestPOST(_token, rolEmpleado);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.Created))
            {
                throw new Exception("No se pudo crear el cliente.", new Exception(resultadojSon.Content));
            }

            var objetoCreado = Helpers.HelperJson.DeSerializar<RolEmpleado>(resultadojSon.Content);

            return 0;
        }

        public void Modificar(Int32 entityId, RolEmpleado rolEmpleado)
        {
            var request = _accion.ObtenerRequestPUT(_token, entityId, rolEmpleado);

            var resultadojSon = _restClient.Execute(request);

            if (!HttpStatusCodeHelper.IsHttpStatusCodeExpected(resultadojSon.StatusCode, System.Net.HttpStatusCode.OK))
            {
                throw new Exception("No se pudo modificar la persona " + entityId.ToString() + ".", new Exception(resultadojSon.Content));
            }
        }
    }
}

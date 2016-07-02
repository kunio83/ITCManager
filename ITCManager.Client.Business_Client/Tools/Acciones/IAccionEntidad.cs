using System;
using RestSharp;
using System.Collections.Generic;
using ITCManager.Client.Entities_Client;

namespace ITCManager.Client.Business_Client.Tools.Acciones
{
    public interface IAccionEntidad
    {
        /// <summary>
        /// Trae todas las entitys.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        IRestRequest ObtenerRequestGET(String token);

        /// <summary>
        /// Trae la entity por su id.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        IRestRequest ObtenerRequestGETbyID(String token, Int32 entityId);


        /// <summary>
        /// Crea una entity.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        IRestRequest ObtenerRequestPOST(String token, IEntidadITC entidad);


        /// <summary>
        /// Modifica una entity.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        IRestRequest ObtenerRequestPUT(String token, Int32 entityId, IEntidadITC entidad);


        /// <summary>
        /// Elimina una entity.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        IRestRequest ObtenerRequestDELETE(String token, Int32 entityId);

    }
}
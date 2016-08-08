using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Client.DataAccess_Client;
using ITCManager.Client.Business_Client.Tools.Gestores;
using ITCManager.Client.Entities_Client;
using ITCManager.Client.Business_Client.Tools.Helpers;

namespace ITCManager.Client.Business_Client.Tools
{
    public class Aprovisionador
    {
        GestorITCApi _gestor;
        UnitOfWork _unitOfWork;

        public Aprovisionador(String token)
        {
            this._gestor = new GestorITCApi(token);
            this._unitOfWork = new UnitOfWork();
        }

        public void AprovisionarVendedor()
        {
            //Desde aca vamos a llenar las tablas necesarias para que el vendedor trabaje 
            try
            {
                EstructuraVendedorInicial estructuraVendedor = this._gestor.EstructuraVendedor.TraerPorId(0);
                if (estructuraVendedor != null)
                {
                    Repository<RolEmpleado> rolEmpleadoRepo = this._unitOfWork.Repository<RolEmpleado>();
                    Repository<CiudadPersonalSet> ciudadPersonalRepo = this._unitOfWork.Repository<CiudadPersonalSet>();
                    Repository<CiudadSet> ciudadRepo = this._unitOfWork.Repository<CiudadSet>();
                    Repository<LocalidadSet> localidadPersonalRepo = this._unitOfWork.Repository<LocalidadSet>();
                    Repository<RolCiudadActivaSet> rolCiudadActivaRepo = this._unitOfWork.Repository<RolCiudadActivaSet>();
                    Repository<RolCiudadActivaPlanSet> rolCiudadActivaPlanRepo = this._unitOfWork.Repository<RolCiudadActivaPlanSet>();


                    rolEmpleadoRepo.Insert(estructuraVendedor.RolEmpledoActual);
                    ciudadPersonalRepo.Insert(estructuraVendedor.CiudadPersonal);
                    ciudadRepo.Insert(estructuraVendedor.Ciudad);
                    localidadPersonalRepo.Insert(estructuraVendedor.Localidad);
                    rolCiudadActivaRepo.Insert(estructuraVendedor.RolCiudadActiva);

                    foreach (var r in estructuraVendedor.RolCiudadActivaPlanes)
                        rolCiudadActivaPlanRepo.Insert(r);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarPersona()
        {

        }
        public void AprovisionarDocente()
        {

        }

        public void AprovisionarCobrador()
        {

        }
    }
}

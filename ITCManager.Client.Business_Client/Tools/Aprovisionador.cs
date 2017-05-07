using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCManager.Client.Business_Client.Tools.Gestores;
using ITCManager.Client.Entities_Client;
using ITCManager.Client.Business_Client.Tools.Helpers;
using ITCManager.Client.DataAccess_Client.DBTools;

namespace ITCManager.Client.Business_Client.Tools
{
    public class Aprovisionador
    {
        GestorITCApi _gestor;
        UnitOfWork _unitOfWork;

        /*Vendedor*/
        Repository<RolEmpleado> _rolEmpleadoRepo;
        Repository<RolVendedor> _rolVendedorRepo;
        Repository<CiudadPersonalSet> _ciudadPersonalRepo;
        Repository<CiudadSet> _ciudadRepo;
        Repository<LocalidadSet> _localidadPersonalRepo;
        Repository<RolCiudadActivaSet> _rolCiudadActivaRepo;
        Repository<RolCiudadActivaPlanSet> _rolCiudadActivaPlanRepo;
        Repository<RolEmpleadoActual> _rolEmpleadoActualRepo;
        Repository<HorarioSet> _horarioRepo;
        Repository<CapacitacionSet> _capacitacionRepo;
        Repository<DiaSet> _diaRepo;
        Repository<PlanBaseSet> _planBaseRepo;
        Repository<Persona> _personaRepo;
        Repository<EstadoAlumno> _estadoAlumnoRepo;


        public Aprovisionador(String token)
        {
            this._gestor = new GestorITCApi(token);
            this._unitOfWork = new UnitOfWork();

            //Clear DB
            DBHelper.ClearDb();

            //Vendedor
            this._rolEmpleadoRepo = this._unitOfWork.Repository<RolEmpleado>();
            this._rolVendedorRepo = this._unitOfWork.Repository<RolVendedor>();
            this._ciudadPersonalRepo = this._unitOfWork.Repository<CiudadPersonalSet>();
            this._ciudadRepo = this._unitOfWork.Repository<CiudadSet>();
            this._localidadPersonalRepo = this._unitOfWork.Repository<LocalidadSet>();
            this._rolCiudadActivaRepo = this._unitOfWork.Repository<RolCiudadActivaSet>();
            this._rolCiudadActivaPlanRepo = this._unitOfWork.Repository<RolCiudadActivaPlanSet>();
            this._rolEmpleadoActualRepo = this._unitOfWork.Repository<RolEmpleadoActual>();
            this._horarioRepo = this._unitOfWork.Repository<HorarioSet>();
            this._capacitacionRepo = this._unitOfWork.Repository<CapacitacionSet>();
            this._diaRepo = this._unitOfWork.Repository<DiaSet>();
            this._planBaseRepo = this._unitOfWork.Repository<PlanBaseSet>();
            this._personaRepo = this._unitOfWork.Repository<Persona>();
            this._estadoAlumnoRepo = this._unitOfWork.Repository<EstadoAlumno>();
        }

        public void AprovisionarVendedor()
        {
            //Desde aca vamos a llenar las tablas necesarias para que el vendedor trabaje 
            try
            {
                EstructuraVendedorInicial estructuraVendedor = this._gestor.EstructuraVendedor.TraerPorId(0);
                if (estructuraVendedor != null)
                {
                    RolEmpleadoActual rolEmpleadoActual = new RolEmpleadoActual() { IdRolEmpleadoActual = 0, IdRolEmpleado = estructuraVendedor.RolEmpledoActual.IdRolEmpleado };
                    this._rolEmpleadoActualRepo.Insert(rolEmpleadoActual);

                    this._rolEmpleadoRepo.Insert(estructuraVendedor.RolEmpledoActual);
                    this._ciudadPersonalRepo.Insert(estructuraVendedor.CiudadPersonal);
                    this._ciudadRepo.Insert(estructuraVendedor.Ciudad);
                    this._localidadPersonalRepo.Insert(estructuraVendedor.Localidad);
                    this._rolCiudadActivaRepo.Insert(estructuraVendedor.RolCiudadActiva);

                    foreach (var r in estructuraVendedor.Horarios)
                        this._horarioRepo.Insert(r);

                    foreach (var r in estructuraVendedor.Capacitaciones)
                        this._capacitacionRepo.Insert(r);

                    foreach (var r in estructuraVendedor.Dias)
                        this._diaRepo.Insert(r);

                    foreach (var r in estructuraVendedor.PlanesBase)
                        this._planBaseRepo.Insert(r);

                    foreach (var r in estructuraVendedor.RolCiudadActivaPlanes)
                        this._rolCiudadActivaPlanRepo.Insert(r);

                    foreach (var r in estructuraVendedor.PersonaVendedores)
                        this._personaRepo.Insert(r);

                    foreach (var r in estructuraVendedor.RolEmpleados)
                        this._rolEmpleadoRepo.Insert(r);

                    foreach (var r in estructuraVendedor.RolVendedores)
                        this._rolVendedorRepo.Insert(r);

                    foreach (var r in estructuraVendedor.EstadosAlumno)
                        this._estadoAlumnoRepo.Insert(r);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AprovisionarDocente()
        {

        }

        public void AprovisionarCobrador()
        {

        }
    }
}

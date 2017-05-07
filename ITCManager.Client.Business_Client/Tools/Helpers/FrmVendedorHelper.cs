using ITCManager.Client.DataAccess_Client.DBTools;
using ITCManager.Client.Entities_Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Client.Business_Client.Tools.Helpers
{
    public static class FrmVendedorHelper
    {
        public static List<Persona> GetPersonasRolEmpeados()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<Persona> personaRepo = unit.Repository<Persona>();
            Repository<RolEmpleado> roleEmpleadoRepo = unit.Repository<RolEmpleado>();
            var personas = personaRepo.Table.ToList();
            var idsPersonaEmpleados = roleEmpleadoRepo.Table.Select(e => e.IdPersona);
            List<Persona> result = new List<Persona>();

            foreach (var p in personas)
                if (idsPersonaEmpleados.Contains(p.IdPersona))
                    result.Add(p);

            return result;
        }

        public static Persona GetUltimaPersona(DataRowView personaActual)
        {
            DataRowView dataRowView = (DataRowView)personaActual;
            int idPersona = int.Parse(personaActual["IdPersona"].ToString());
            //***************** TODAVIA ME SIGUE DEVOLVIENDO -1 EL PINCHE CURRENTTTTTT*********************//
            if (idPersona != 0)
            {
                UnitOfWork unit = new UnitOfWork();
                Repository<Persona> personaRepo = unit.Repository<Persona>();
                return (Persona)personaRepo.Table.FirstOrDefault(e => e.IdPersona == idPersona);
            }
            return null;
        }

        public static List<Persona> GetPersonasRolAlumnos()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<Persona> personaRepo = unit.Repository<Persona>();
            Repository<RolAlumno> roleRolAlumnoRepo = unit.Repository<RolAlumno>();

            var personasAlumnos = (from p in personaRepo.Table.ToList()
                                   join a in roleRolAlumnoRepo.Table.ToList()
                                   on p.IdPersona equals a.IdPersona
                                   select p);
            return personasAlumnos.ToList();
        }

        public static List<CapacitacionSet> GetCapacitaciones()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<CapacitacionSet> capacitacionRepo = unit.Repository<CapacitacionSet>();
            return capacitacionRepo.Table.ToList();
        }

        public static List<DiaSet> GetDias()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<DiaSet> diasRepo = unit.Repository<DiaSet>();
            return diasRepo.Table.ToList();
        }

        public static List<HorarioSet> GetHorarios()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<HorarioSet> horarioRepo = unit.Repository<HorarioSet>();
            return horarioRepo.Table.ToList();
        }

        public static RolCiudadActivaHorarioSet GuardarRolCiudadActivaHorarioSet(RolCiudadActivaHorarioSet rolCiudadActivaHorario)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Repository<RolCiudadActivaHorarioSet> rolCiudadActivaHorarioSetRepo = unit.Repository<RolCiudadActivaHorarioSet>();
                rolCiudadActivaHorarioSetRepo.Insert(rolCiudadActivaHorario);
                return rolCiudadActivaHorarioSetRepo.Table.OrderByDescending(e => e.IdRolCiudadActivaHorario).FirstOrDefault();
            };
        }

        public static List<PlanBaseSet> GetPlanes()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<PlanBaseSet> planRepo = unit.Repository<PlanBaseSet>();
            return planRepo.Table.ToList();
        }

        public static List<EstadoAlumno> GetEstadosAlumno()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<EstadoAlumno> estadoAlumnoRepo = unit.Repository<EstadoAlumno>();
            return estadoAlumnoRepo.Table.ToList();
        }

        public static PlanBaseSet CrearNuevoPlan(PlanBaseSet planBanse, RolCiudadActivaPlanSet rolCiudadActivaPlanSet)
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<PlanBaseSet> planRepo = unit.Repository<PlanBaseSet>();
            Repository<RolCiudadActivaPlanSet> rolCiudadActivaPlanRepo = unit.Repository<RolCiudadActivaPlanSet>();
            long idPlanBase = planRepo.Table.OrderByDescending(e => e.IdPlanBase).FirstOrDefault().IdPlanBase + 1;
            long idRolCiudadActivaPlan = rolCiudadActivaPlanRepo.Table.OrderByDescending(e => e.IdRolCiudadActivaPlan).FirstOrDefault().IdRolCiudadActivaPlan + 1;

            planBanse.IdPlanBase = idPlanBase;
            rolCiudadActivaPlanSet.IdPlanBase = idPlanBase;
            rolCiudadActivaPlanSet.IdRolCiudadActivaPlan = idRolCiudadActivaPlan;

            planRepo.Insert(planBanse);
            rolCiudadActivaPlanRepo.Insert(rolCiudadActivaPlanSet);
            return planBanse;
        }

        public static RolCiudadActivaSet GetRolCiudadActivaSet()
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<RolCiudadActivaSet> planRepo = unit.Repository<RolCiudadActivaSet>();
            return planRepo.Table.First();
        }

        public static RolAlumno GuardarRolAlumno(RolAlumno rolAlumno)
        {
            UnitOfWork unit = new UnitOfWork();
            Repository<RolAlumno> rolAlumnoRepo = unit.Repository<RolAlumno>();
            rolAlumnoRepo.Insert(rolAlumno);
            return rolAlumnoRepo.Table.OrderByDescending(e => e.IdRolAlumno).FirstOrDefault();
        }

        public static RolVendedor GetRolVendedorByPersona(Persona persona)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Repository<RolEmpleado> rolEmpleadoRepo = unit.Repository<RolEmpleado>();
                Repository<RolVendedor> rolVendedorRepo = unit.Repository<RolVendedor>();
                RolEmpleado rolEmpleado = rolEmpleadoRepo.Table.FirstOrDefault(e => e.IdPersona == persona.IdPersona);
                RolVendedor rolVendedor = rolVendedorRepo.Table.FirstOrDefault(e => e.IdRolEmpleado == rolEmpleado.IdRolEmpleado);
                return rolVendedor;
            };
        }

        public static RolAlumno GetRolAlumnoByIdPersona(Int64 idPersona)
        {
            using (UnitOfWork unit = new UnitOfWork())
            {
                Repository<RolAlumno> rolAlumnoRepo = unit.Repository<RolAlumno>();
                return rolAlumnoRepo.Table.FirstOrDefault(e => e.IdPersona == idPersona);
            };
        }

        public static PlanVendedorAlumnoSet GetPlanVendedorAlumnoByRolAlumno(RolAlumno rolAlumno)
        {
            if (rolAlumno != null)
            {
                using (UnitOfWork unit = new UnitOfWork())
                {
                    Repository<PlanVendedorAlumnoSet> planVendedorAlumnoRepo = unit.Repository<PlanVendedorAlumnoSet>();
                    return planVendedorAlumnoRepo.Table.FirstOrDefault(e => e.IdRolAlumno == rolAlumno.IdRolAlumno);
                };
            }
            return null;
        }

        public static AlumnoHorarioSet GetAlumnoHorario(RolAlumno rolAlumno)
        {
            if (rolAlumno != null)
            {
                using (UnitOfWork unit = new UnitOfWork())
                {
                    Repository<AlumnoHorarioSet> alumnoHorarioSetRepo = unit.Repository<AlumnoHorarioSet>();
                    return alumnoHorarioSetRepo.Table.FirstOrDefault(e => e.IdRolAlumno == rolAlumno.IdRolAlumno);
                };
            }
            return null;
        }

        //public static RolCiudadActivaHorarioSet GetRolCiudadActivaHoraio(RolAlumno rolAlumno)
        //{
        //    using (UnitOfWork unit = new UnitOfWork())
        //    {
        //        Repository<PlanVendedorAlumnoSet> planVendedorAlumnoRepo = unit.Repository<PlanVendedorAlumnoSet>();
        //        return planVendedorAlumnoRepo.Table.FirstOrDefault(e => e.IdRolAlumno == rolAlumno.IdRolAlumno);
        //    };
        //}
    }
}

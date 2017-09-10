using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCManager.Client.Business_Client.Tools.Helpers;
using ITCManager.Client.Entities_Client;

namespace ITCManager.Client.UI_Client.Forms
{
    public partial class FrmGerenteVendedor : Form
    {
        //bool _CargaPlanActivada = false;
        public FrmGerenteVendedor()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Cosiñas de carga de datos y demas
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.personaTableAdapter.Update(sqliteClientDataBaseDataSet.Persona);
            this.tableAdapterManager.UpdateAll(this.sqliteClientDataBaseDataSet);
            this.personaTableAdapter.Fill(this.sqliteClientDataBaseDataSet.Persona);
            //personaBindingSource.MoveLast();
            this.personaBindingSource.DataSource = personaTableAdapter.GetData();

            //Vars
            RolCiudadActivaSet rolCiudadActiva = FrmVendedorHelper.GetRolCiudadActivaSet();
            Persona personaActual = FrmVendedorHelper.GetUltimaPersona((DataRowView)personaBindingSource.Current);//pinche current siempre me trae el ultimo
            Int64 IdRolCiudadActivaPlan = (Int64)((DataRowView)rolCiudadActivaPlanSetBindingSource.Current)["IdRolCiudadActivaPlan"];

            //Guardando/Actualizando RolAlumno
            RolAlumno rolAlumno = FrmVendedorHelper.GetRolAlumnoByIdPersona(personaActual.IdPersona);
            if (rolAlumno == null || rolAlumno.IdRolAlumno == 0)
                rolAlumno = new RolAlumno() { IdRolAlumno = 0 };
            rolAlumno.IdCapacitacion = ((CapacitacionSet)cmbCapacitacion.SelectedItem).IdCapacitacion;
            rolAlumno.IdEstadoAlumno = ((EstadoAlumno)cmbEstadoAlumno.SelectedItem).IdEstadoAlumno;
            rolAlumno.IdPersona = Convert.ToInt32(idPersonaTextBox.Text);
            rolAlumno = FrmVendedorHelper.GuardarRolAlumno(rolAlumno);

            //Debo crear o actualizar un PlanVendedorAlumno
            PlanVendedorAlumnoSet planVendedorAlumno = FrmVendedorHelper.GetPlanVendedorAlumnoByRolAlumno(rolAlumno);
            if (planVendedorAlumno == null || planVendedorAlumno.IdPlanVendedorAlumno == 0)
                planVendedorAlumno = new PlanVendedorAlumnoSet() { IdPlanVendedorAlumno = 0};
            planVendedorAlumno.IdRolAlumno = rolAlumno.IdRolAlumno;
            planVendedorAlumno.IdRolCiudadActivaPlan = IdRolCiudadActivaPlan;
            planVendedorAlumno.IdRolVendedor = FrmVendedorHelper.GetRolVendedorByPersona((Persona)cmbVendedor.SelectedItem).IdRolVendedor;
            planVendedorAlumno.NroRecibo = txtNroRecibo.Text;
            planVendedorAlumno.ObservacionGerente = txtObservacionGerente.Text;
            planVendedorAlumno.ObservacionOficinaBaires = txtObservacionGerente.Text;
            planVendedorAlumno = FrmVendedorHelper.GuardarPlanvendedorAlumno(planVendedorAlumno);

            //Debo crear o actualizar un RolCiudadActivaHorario
            AlumnoHorarioSet alumnoHorario = FrmVendedorHelper.GetAlumnoHorario(rolAlumno);
            RolCiudadActivaHorarioSet rolCiudadActivaHorario;
            if (alumnoHorario == null)
            {
                rolCiudadActivaHorario = new RolCiudadActivaHorarioSet();
                alumnoHorario = new AlumnoHorarioSet();
            }
            else
                rolCiudadActivaHorario = FrmVendedorHelper.GetRolCiudadActivaHorarioById(alumnoHorario.IdRolCiudadActivaHorario);
            
            rolCiudadActivaHorario.IdDia = ((DiaSet)cmbDia.SelectedItem).IdDia;
            rolCiudadActivaHorario.IdHorario = ((HorarioSet)cmbHorario.SelectedItem).IdHorario;
            rolCiudadActivaHorario.IdRolCiudadActiva = rolCiudadActiva.IdRolCiudadActiva;
            //Debo crear o actualizar un AlumnoHorarioSet
            rolCiudadActivaHorario = FrmVendedorHelper.GuardarRolCiudadActivaHorarioSet(rolCiudadActivaHorario);
            alumnoHorario.IdRolAlumno = rolAlumno.IdRolAlumno;
            alumnoHorario.IdRolCiudadActivaHorario = rolCiudadActivaHorario.IdRolCiudadActivaHorario;
            alumnoHorario.TipoHorario = cmbTipoHorario.Text;
            alumnoHorario = FrmVendedorHelper.GuardarAlumnoHoraio(alumnoHorario);



            

            //planVendedorAlumnoSetTableAdapter.Insert(planVendedorAlumno.NroRecibo, planVendedorAlumno.IdRolCiudadActivaPlan, planVendedorAlumno.IdRolAlumno, 
            //                                            planVendedorAlumno.IdRolVendedor, planVendedorAlumno.ObservacionGerente, "");
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.RolCiudadActivaPlanSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaPlanSetTableAdapter.Fill(this.sqliteClientDataBaseDataSet.RolCiudadActivaPlanSet);
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.RolEmpleado' Puede moverla o quitarla según sea necesario.
            this.rolEmpleadoTableAdapter.Fill(this.sqliteClientDataBaseDataSet.RolEmpleado);
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.PlanVendedorAlumnoSet' Puede moverla o quitarla según sea necesario.
            this.planVendedorAlumnoSetTableAdapter.Fill(this.sqliteClientDataBaseDataSet.PlanVendedorAlumnoSet);
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.AlumnoHorarioSet' Puede moverla o quitarla según sea necesario.
            this.alumnoHorarioSetTableAdapter.Fill(this.sqliteClientDataBaseDataSet.AlumnoHorarioSet);
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.RolAlumno' Puede moverla o quitarla según sea necesario.
            this.rolAlumnoTableAdapter.Fill(this.sqliteClientDataBaseDataSet.RolAlumno);

            //Lleno el combo con los datos del personal
            cmbVendedor.DataSource = FrmVendedorHelper.GetPersonasRolEmpeados();
            cmbVendedor.DisplayMember = "DisplayNombre";
            cmbVendedor.ValueMember = "IdPersona";

            //Lleno combo de capacitacion
            cmbCapacitacion.DataSource = FrmVendedorHelper.GetCapacitaciones();
            cmbCapacitacion.DisplayMember = "NombreCapacitacion";
            cmbCapacitacion.ValueMember = "IdCapacitacion";

            //Lleno combo de dias
            cmbDia.DataSource = FrmVendedorHelper.GetDias();
            cmbDia.DisplayMember = "DetalleDia";
            cmbDia.ValueMember = "IdDia";

            //Lleno combo de horarios
            cmbHorario.DataSource = FrmVendedorHelper.GetHorarios();
            cmbHorario.DisplayMember = "DetalleHorario";
            cmbHorario.ValueMember = "IdHorario";

            //Lleno combo de planes
            cmbPlan.DataSource = new List<PlanBaseSet>();
            cmbPlan.DisplayMember = "DetallePlanBase";
            cmbPlan.ValueMember = "IdPlanBase";
            cmbPlan.DataSource = FrmVendedorHelper.GetPlanes();

            //Lleno combo EstadoAlumno
            cmbEstadoAlumno.DataSource = FrmVendedorHelper.GetEstadosAlumno();
            cmbEstadoAlumno.DisplayMember = "DetalleEstadoAlumno";
            cmbEstadoAlumno.ValueMember = "IdEstadoAlumno";

            //Preparo una query para filtrar solo los alumnos en el bindingSource de Persona
            List<Persona> personasAlumnos = FrmVendedorHelper.GetPersonasRolAlumnos();
            if (personasAlumnos.Count > 0)
            {
                String ids = "(";
                foreach (Persona p in personasAlumnos)
                {
                    ids += p.IdPersona + ",";
                }
                ids = ids.Substring(0, ids.Length - 1);
                ids += ")";
                this.personaBindingSource.Filter = "IdPersona in " + ids;
            }
            // TODO: esta línea de código carga datos en la tabla 'sqliteClientDataBaseDataSet.Persona' Puede moverla o quitarla según sea necesario.
            this.personaTableAdapter.Fill(this.sqliteClientDataBaseDataSet.Persona);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //En rolCiudadActivaPlanSet selecciono el que corresponde al combobox Planes
            var posPlanSeleccionado = 0;
            posPlanSeleccionado = rolCiudadActivaPlanSetBindingSource.Find("IdPlanBase", ((long)cmbPlan.SelectedValue));
            rolCiudadActivaPlanSetBindingSource.Position = posPlanSeleccionado;

            //Si es plan especial, Permito editar la Configuracion de rolCiudadActivaPlanSet
            bool esEspecial = cmbPlan.Text.ToUpper().Contains("ESPECIAL");
            panPlanEspecial.Enabled = esEspecial;
            
            if (esEspecial)
            {
                cmbPlan.DropDownStyle = ComboBoxStyle.DropDown;
                cmbPlan.Text = String.Empty;
                btnGuardarPlan.Visible = true;
            }
            else
            {
                cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
                btnGuardarPlan.Visible = false;
            }
        }

        private void btnGuardarPlan_Click(object sender, EventArgs e)
        {
            
            if (cmbPlan.Text.ToUpper().Contains("ESPECIAL"))
            {
                MessageBox.Show("El nombre del plan no puede contener la palabra ESPECIAL");
                return;
            }

            try
            {
                PlanBaseSet plaBase = new PlanBaseSet()
                {
                    IdPlanBase = 0, //Lo voy a crear al insertar, porque el autoincrement esta en off
                    DetallePlanBase = cmbPlan.Text
                };
                RolCiudadActivaPlanSet rolCiudadActivaPlanSet = new RolCiudadActivaPlanSet()
                {
                    IdRolCiudadActivaPlan = 0, //Lo voy a crear al insertar, porque el autoincrement esta en off
                    IdRolCiudadActiva = FrmVendedorHelper.GetRolCiudadActivaSet().IdRolCiudadActiva,
                    IdPlanBase = 0, //Lo voy a crear al insertar, porque el autoincrement esta en off
                    ValorMatricula = valorMatriculaTextBox.Text,
                    CantCuotas = cantCuotasTextBox.Text,
                    ValorCuota = valorCuotaTextBox.Text,
                    ValorDescuento = valorDescuentoTextBox.Text,
                    ValorCertificado = valorCertificadoTextBox.Text,
                    ComisionIda = comisionIdaTextBox.Text,
                    ComisionVuelta = comisionVueltaTextBox.Text,
                    ComisionCertificado = comisionCertificadoTextBox.Text
                };

                PlanBaseSet nuevoPlanBaseSet = FrmVendedorHelper.CrearNuevoPlan(plaBase, rolCiudadActivaPlanSet);

                btnGuardarPlan.Visible = false;
                panPlanEspecial.Enabled = false;
                cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbPlan.DataSource = FrmVendedorHelper.GetPlanes();
                cmbPlan.SelectedIndex = cmbPlan.FindString(nuevoPlanBaseSet.DetallePlanBase);
                this.rolCiudadActivaPlanSetTableAdapter.Fill(this.sqliteClientDataBaseDataSet.RolCiudadActivaPlanSet);
                var posPlanSeleccionado = rolCiudadActivaPlanSetBindingSource.Find("IdPlanBase", nuevoPlanBaseSet.IdPlanBase);
                rolCiudadActivaPlanSetBindingSource.Position = posPlanSeleccionado;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void personaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (personaBindingSource.Current != null)
            {
                Int64 idPersonaActual = (Int64)((DataRowView)personaBindingSource.Current)["IdPersona"];
                RolAlumno rolAlumnoActual = FrmVendedorHelper.GetRolAlumnoByIdPersona(idPersonaActual);
                //(Int64)((DataRowView)rolCiudadActivaPlanSetBindingSource.Current)["IdRolCiudadActivaPlan"]
                PlanVendedorAlumnoSet planVendedorAlumno = FrmVendedorHelper.GetPlanVendedorAlumnoByRolAlumno(rolAlumnoActual);

                AlumnoHorarioSet alumnoHorario = FrmVendedorHelper.GetAlumnoHorario(rolAlumnoActual);
                RolCiudadActivaHorarioSet rolCiudadActivaHorario = FrmVendedorHelper.GetRolCiudadActivaHorarioById(alumnoHorario.IdRolCiudadActivaHorario);
                RolVendedor rolVendedor = FrmVendedorHelper.GetRolVendedorById(planVendedorAlumno.IdRolVendedor);
                RolEmpleado rolEmpleadoVendedor = FrmVendedorHelper.GetRolEmpleadoById(rolVendedor.IdRolEmpleado);
                Persona personaVendedor = FrmVendedorHelper.GetPersonasRolEmpeados().FirstOrDefault(z => z.IdPersona == rolEmpleadoVendedor.IdPersona);
                RolCiudadActivaPlanSet rolCiudadActivaPlan = FrmVendedorHelper.GetRolCiudadActivaPlanByPlanVendedorAlumno(planVendedorAlumno);
                AlumnoHorarioSet alumnoHorarioSet = FrmVendedorHelper.GetAlumnoHorario(rolAlumnoActual);
                //RolCiudadActivaHorarioSet rolCiudadActivaHorarioSet 

                /*
                 para conmtinuar con esto me falta que se filtren bien los alumnos en el bindingsourcePersona
                 */

                //Updateo el UI
                cmbVendedor.SelectedValue = personaVendedor.IdPersona;
                txtNroRecibo.Text = planVendedorAlumno.NroRecibo;
                cmbEstadoAlumno.SelectedValue = rolAlumnoActual.IdEstadoAlumno;
                txtObservacionGerente.Text = planVendedorAlumno.ObservacionGerente;
                cmbCapacitacion.SelectedValue = rolAlumnoActual.IdCapacitacion;
                cmbDia.SelectedValue = rolCiudadActivaHorario.IdDia;
                cmbHorario.SelectedValue = rolCiudadActivaHorario.IdHorario;
                cmbTipoHorario.Text = alumnoHorario.TipoHorario;
                cmbPlan.SelectedValue = rolCiudadActivaPlan.IdPlanBase;
            }
        }
    }
}

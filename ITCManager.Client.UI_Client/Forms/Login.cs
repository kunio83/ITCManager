using ITCManager.Client.Business_Client.Tools;
using ITCManager.Client.Business_Client.Tools.Helpers;
using ITCManager.Client.Entities_Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Client.UI_Client.Forms
{
    public partial class Login : Form
    {
        RolEmpleado _empleadoActual;
        RolEmpleado _empleadoLogueado;
        PuestoSet _puestoEmpleadoActual;
        Aprovisionador _aprovisionador;
        Form _frm;

        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }

        private void VerificarUsuario()
        {
            lblMensaje.Visible = true;

            this._empleadoActual = LoginHelper.GetRolEmpleadoActual();
            this._empleadoLogueado = LoginHelper.GetRolEmpleadoLogueado(txtDni.Text + txtPass.Text);

            if (this._empleadoLogueado != null)
            {
                this._puestoEmpleadoActual = LoginHelper.GetPuesto(txtDni.Text + txtPass.Text, this._empleadoLogueado);
                //Si no hay usuario alguno, se aprovisiona segun el puesto
                if (this._empleadoActual == null)
                {
                    lblMensaje.Text = "Aprovisionando DB";
                    _aprovisionador = new Aprovisionador(txtDni.Text + txtPass.Text);

                    Aprovisionar(this._puestoEmpleadoActual.DetallePuesto);
                    AbrirForm(this._puestoEmpleadoActual.DetallePuesto);
                }
                else //Si ya hay un usuario logueado, se confirma, se hace un backup y se reaprovisiona
                {
                    if(this._empleadoLogueado.IdRolEmpleado == this._empleadoActual.IdRolEmpleado)
                    {
                        //Iniciar session
                        AbrirForm(this._puestoEmpleadoActual.DetallePuesto);
                    }
                    else
                    {
                        if((DialogResult)MessageBox.Show("Usuario distinto al anterior, Desea re-arpovisionar los datos?", "Confirmación re-aprovisionar", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            Aprovisionar(this._puestoEmpleadoActual.DetallePuesto);
                            AbrirForm(this._puestoEmpleadoActual.DetallePuesto);
                        }
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Usuario Incorrecto";
            }
        }

        private void Aprovisionar(string detallePuesto)
        {
            //Aca se debe aprovisionar, haciendo un clear db previo
            if (detallePuesto.ToUpper().Contains("GERENTE"))
                _aprovisionador.AprovisionarVendedor();
            else if (detallePuesto.ToUpper().Contains("DOCENTE"))
                _aprovisionador.AprovisionarDocente();
            else if (detallePuesto.ToUpper().Contains("COBRADOR"))
                _aprovisionador.AprovisionarCobrador();
        }

        private void AbrirForm(string detallePuesto)
        {
            this.Hide();

            //Aca se debe abrir el formulario segun el empleado
            if (detallePuesto.ToUpper().Contains("GERENTE"))
                this._frm = new FrmVendedor();
            else if (detallePuesto.ToUpper().Contains("DOCENTE"))
                this._frm = new FrmDocente();
            else if (detallePuesto.ToUpper().Contains("COBRADOR"))
                this._frm = new FrmCobrador();

            this._frm.Show();
        }
    }
}

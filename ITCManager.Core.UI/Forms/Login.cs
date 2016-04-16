using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCManager.Core.Business;
using ITCManager.Core.Entities;


namespace ITCManager.Core.UI.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Persona user = null;
        const string pass = "123";
        bool _isUserOk = false;
        bool _isPassOk = false;
        public Login()
        {
            InitializeComponent();
        }

        private void callAceptarClick()
        {
            EventHandler temp = btnAceptar_Click;
            if (temp != null)
            {
                temp(btnAceptar, EventArgs.Empty);
            }
               ;
        }

        private bool isUserOk()
        {
            if (txtUser.Text != String.Empty)
            {
                user = PersonaHelper.GetPersonaByDni(txtUser.Text);
                if (user != null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isPassOk()
        {
            if (txtPass.Text != String.Empty)
            {
                return txtPass.Text == pass;
            }
            return false;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                callAceptarClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (isUserOk())
            {
                SetPictureBox(pcbUser, true);
                _isUserOk = true;

            }
            else
            {
                SetPictureBox(pcbUser, false);
                return;
            }

            if (isPassOk())
            {
                SetPictureBox(pcbPass, true);
                _isPassOk = true;

            }
            else
            {
                SetPictureBox(pcbPass, false);
                return;
            }

            if (_isUserOk && _isPassOk)
            {
                this.Hide();
                new Contenedor().ShowDialog();
                this.Close();
                //FormRepository<Contenedor>.Open(null);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                callAceptarClick();
            }
        }

        private void SetPictureBox(PictureBox pcb,bool visible)
        {
            pcb.Visible = !visible;
        }
    }
}

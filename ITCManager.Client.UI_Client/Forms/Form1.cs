using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using MetroFramework.Forms;
using ITCManager.Client.Business_Client.Tools;
using ITCManager.Client.Entities_Client;
using ITCManager.Client.Business_Client.Tools.Helpers;

namespace ITCManager.Client.UI_Client.Forms
{
    public partial class Form1 : Base
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            GestorITCApi gestorItc = new GestorITCApi(Encrypto.GetSHA1(metroTextBox1.Text));

            var todos = gestorItc.Persona.TraerTodos();

            var persona = gestorItc.Persona.TraerPorId(1);
            persona.IdPersona = 0;
            persona.Nombres = "jjjjj";
            Persona newPersona = gestorItc.Persona.TraerPorId(gestorItc.Persona.Crear(persona));
            newPersona.Nombres = newPersona.Nombres + "2";
            gestorItc.Persona.Modificar(newPersona.IdPersona,newPersona);


        }
        
    }
}

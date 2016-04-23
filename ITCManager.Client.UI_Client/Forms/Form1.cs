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
using ITCManager.Client.Business;
using ITCManager.Client.Entities_Client;

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
            List<Persona> lstPersona =  Class1.traerPorFechNac(DateTime.Now);
        }
    }
}

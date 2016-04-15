using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class Contenedor : MetroForm
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepository<Principal>.Open(this);
        }

        private void mostrarFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //borrar esto, solo muestra los nombres de los formularios
            var ctrls = Application.OpenForms;
            string text = "";
            int cont = 0;
            foreach (var c in ctrls)
            {
                if (c is Form)
                {
                    text += ((Form)c).Name + "#" + cont++ + " \n\r";
                }
            }
            MessageBox.Show(text);
        }
    }
}

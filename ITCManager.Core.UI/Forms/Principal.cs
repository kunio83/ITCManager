using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class Principal : Base
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mtiCargarDatos_Click(object sender, EventArgs e)
        {
            FormRepository<FrmCargaDatos>.Open(this.MdiParent);
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            FormRepository<FrmCargaPersonal>.Open(this.MdiParent);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FormRepository<FrmCargaCiudad>.Open(this.MdiParent);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            FormRepository<FrmLineaCiudad>.Open(this.MdiParent);
        }
    }
}

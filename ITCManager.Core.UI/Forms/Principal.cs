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
            FormRepository<frmCargaDatos>.Open(this.MdiParent);
        }
    }
}

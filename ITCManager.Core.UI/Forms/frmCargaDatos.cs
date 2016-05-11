using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Windows.Forms;
using ITCManager.Core.Entities;
using ITCManager.Core.Business;

namespace ITCManager.Core.UI.Forms
{
    public partial class frmCargaDatos : Base
    {
        internal CargaDatosHelper _helper;

        public frmCargaDatos()
        {
            InitializeComponent();
        }

        private void frmCargaDatos_Load(object sender, EventArgs e)
        {
            this._helper = new CargaDatosHelper(this,iTC_DBPOwerDataSet);
            _helper.cargarComboTablas();
        }

        private void mtileAgregarGrid_Click(object sender, EventArgs e)
        {
            String nombreTabla = this._helper.getNombreTablaActual();

            if (!mtabCargaDatos.TabPages.ContainsKey("mtp" + nombreTabla))
                this._helper.armarNuevoTabPage(nombreTabla);

            mtabCargaDatos.SelectTab("mtp" + nombreTabla);
        }

        private void mtEliminar_Click(object sender, EventArgs e)
        {
            if(mtabCargaDatos.SelectedTab != null)
                mtabCargaDatos.TabPages.Remove(mtabCargaDatos.SelectedTab);
        }
    }
}

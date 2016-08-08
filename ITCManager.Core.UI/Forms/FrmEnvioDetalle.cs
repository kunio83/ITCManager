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
    public partial class FrmEnvioDetalle : Base
    {
        private int _idRolCiudadActiva;

        public FrmEnvioDetalle()
        {
            InitializeComponent();
        }
        public FrmEnvioDetalle(int idRolCiudadActiva)
        {
            this._idRolCiudadActiva = idRolCiudadActiva;
            InitializeComponent();
        }

        private void rolCiudadActivaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolCiudadActivaSetBindingSource.EndEdit();
            this.envioSetBindingSource.EndEdit();
            this.envioSetTableAdapter.Update(this.iTC_DBPOwerDataSet.EnvioSet);
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmEnvioDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.ProveedorSet' Puede moverla o quitarla según sea necesario.
            this.proveedorSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.ProveedorSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.LocalidadSet' Puede moverla o quitarla según sea necesario.
            this.localidadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LocalidadSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.EnvioSet' Puede moverla o quitarla según sea necesario.
            this.envioSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.EnvioSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if (this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);

            if (idEnvioTextBox.Text == String.Empty)
            {
                envioSetBindingSource.AddNew();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProveedorTextBox.Text = comboBox1.SelectedValue.ToString();
        }
    }
}

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
    public partial class FrmRolCiudadActivaGasto : Base
    {
        private int _idRolCiudadActiva;

        public FrmRolCiudadActivaGasto()
        {
            InitializeComponent();
        }

        public FrmRolCiudadActivaGasto(int idRolCiudadActiva)
        {
            InitializeComponent();
            this._idRolCiudadActiva = idRolCiudadActiva;
        }

        private void rolCiudadActivaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolCiudadActivaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmRolCiudadActivaGasto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.GastoBaseSet' Puede moverla o quitarla según sea necesario.
            this.gastoBaseSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.GastoBaseSet);

            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaGastosSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaGastosSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaGastosSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if (this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);

            if (rolCiudadActivaGastosSetDataGridView.Rows.Count <= 1)
            {
                CrearCopiaGastosBase();
            }
            LlenarDetalleGastos();

        }

        private void LlenarDetalleGastos()
        {
            foreach (DataGridViewRow r in rolCiudadActivaGastosSetDataGridView.Rows)
            {
                foreach (ITC_DBPOwerDataSet.GastoBaseSetRow g in this.iTC_DBPOwerDataSet.GastoBaseSet.Rows)
                {
                    if (g.IdGastoBase == Convert.ToInt32(r.Cells["dataGridViewTextBoxColumn3"].Value))
                    {
                        r.Cells["DetalleGasto"].Value = g.DetalleGastoBase;
                    }
                }


            }
        }

        private void CrearCopiaGastosBase()
        {
            int idGasto;
            foreach (ITC_DBPOwerDataSet.GastoBaseSetRow r in this.iTC_DBPOwerDataSet.GastoBaseSet.Rows)
            {
                idGasto = r.IdGastoBase;
                rolCiudadActivaGastosSetTableAdapter.Insert(this._idRolCiudadActiva, idGasto, "", "");

            }
            this.rolCiudadActivaGastosSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaGastosSet);
        }
    }
}

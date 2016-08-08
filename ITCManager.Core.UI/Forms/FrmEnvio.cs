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
    public partial class FrmEnvio : Base
    {
        private int _idRolCiudadActiva;

        public FrmEnvio()
        {
            InitializeComponent();
        }

        public FrmEnvio(int idRolCiudadActiva)
        {
            this._idRolCiudadActiva = idRolCiudadActiva;
            InitializeComponent();
        }

        private void rolCiudadActivaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolCiudadActivaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmEnvio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.ProveedorSet' Puede moverla o quitarla según sea necesario.
            this.proveedorSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.ProveedorSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.EnvioSet' Puede moverla o quitarla según sea necesario.
            this.envioSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.EnvioSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if (this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);
        }

        private void envioSetDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
                {
                    DateTime fechaActual;
                    if (envioSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || !DateTime.TryParse(envioSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out fechaActual))
                        fechaActual = DateTime.Today;

                    envioSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = FormRepository.GetCalendarDate(Cursor.Position, fechaActual);
                }

                if (e.Button == MouseButtons.Right && e.ColumnIndex == 4)
                {
                    FormRepository.CreateCellContMenuEditor(this.MdiParent, (DataGridView)sender, "Proveedor", e.Location);
                }
            }
        }
    }
}

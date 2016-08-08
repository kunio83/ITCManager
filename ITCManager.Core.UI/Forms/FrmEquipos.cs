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
    public partial class FrmEquipos : Base
    {
        private int _idRolCiudadActiva;
        public FrmEquipos()
        {
            InitializeComponent();
        }

        public FrmEquipos(int idRolCiudadActiva)
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

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.EstadoAsignacionEquipoSet' Puede moverla o quitarla según sea necesario.
            this.estadoAsignacionEquipoSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.EstadoAsignacionEquipoSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.AsignacionCiudadEquiposSet' Puede moverla o quitarla según sea necesario.
            this.asignacionCiudadEquiposSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.AsignacionCiudadEquiposSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if (this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);

        }

        private void asignacionCiudadEquiposSetDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime fechaActual;
            if (e.Button == MouseButtons.Right && e.ColumnIndex == 3)
            {
                FormRepository.CreateCellContMenuEditor(this.MdiParent, (DataGridView)sender, "EstadoAsignacionEquipo", e.Location);
            }
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 1)
            {
                if (!DateTime.TryParse(asignacionCiudadEquiposSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out fechaActual))
                {
                    fechaActual = DateTime.Today;
                }

                asignacionCiudadEquiposSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = FormRepository.GetCalendarDate(Cursor.Position, fechaActual);
            }
        }
    }
}

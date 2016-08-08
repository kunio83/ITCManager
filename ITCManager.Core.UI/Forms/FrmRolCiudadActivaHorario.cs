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
    public partial class FrmRolCiudadActivaHorario : Base
    {
        private int _idRolCiudadActiva;
        public FrmRolCiudadActivaHorario()
        {
            InitializeComponent();
        }

        public FrmRolCiudadActivaHorario(int idRolCiudadActiva)
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

        private void FrmRolCiudadActivaHorario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.HorarioSet' Puede moverla o quitarla según sea necesario.
            this.horarioSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.HorarioSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.DiaSet' Puede moverla o quitarla según sea necesario.
            this.diaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.DiaSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaHorarioSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaHorarioSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaHorarioSet);
            // TODO: esta línea de código carga datos en la tabla 'iTC_DBPOwerDataSet.RolCiudadActivaSet' Puede moverla o quitarla según sea necesario.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if (this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);

        }

        private void rolCiudadActivaHorarioSetDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                switch (e.ColumnIndex)
                {
                    case 2: {
                            FormRepository.CreateCellContMenuEditor(this.MdiParent, rolCiudadActivaHorarioSetDataGridView, "Dia", e.Location);
                        };break;
                    case 3: {
                            FormRepository.CreateCellContMenuEditor(this.MdiParent, rolCiudadActivaHorarioSetDataGridView, "Horario", e.Location);
                        }; break;
                }
                //FormRepository.CreateCellContMenuEditor(this.MdiParent, rolCiudadActivaHorarioSetDataGridView, "", Cursor.Position);
            }
        }
    }
}

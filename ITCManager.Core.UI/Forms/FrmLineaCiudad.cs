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
    public partial class FrmLineaCiudad : Base
    {
        public FrmLineaCiudad()
        {
            InitializeComponent();
        }

        private void lineaCiudadSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lineaCiudadSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmLineaCiudad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.getPersonal' table. You can move, or remove it, as needed.
            this.getPersonalTableAdapter.Fill(this.iTC_DBPOwerDataSet.getPersonal);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.CiudadPersonalSet' table. You can move, or remove it, as needed.
            this.ciudadPersonalSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadPersonalSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.LineaCiudadSet' table. You can move, or remove it, as needed.
            this.lineaCiudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LineaCiudadSet);

        }

        private void ciudadPersonalSetDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DateTime fechaActual;
                if (DateTime.TryParse(ciudadPersonalSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out fechaActual))
                {
                    ciudadPersonalSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    FormRepository.GetCalendarDate(Cursor.Position, fechaActual);
                }
                else
                {
                    ciudadPersonalSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    FormRepository.GetCalendarDate(e.Location, DateTime.Today);
                }
                
            }
        }
    }
}

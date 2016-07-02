using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class FrmCargaCiudadPersonal : Base
    {
        public FrmCargaCiudadPersonal()
        {
            InitializeComponent();
        }

        private void ciudadSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ciudadSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmCargaCiudadPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.getPersonal' table. You can move, or remove it, as needed.
            this.getPersonalTableAdapter.Fill(this.iTC_DBPOwerDataSet.getPersonal);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.CiudadPersonalSet' table. You can move, or remove it, as needed.
            this.ciudadPersonalSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadPersonalSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.CiudadSet' table. You can move, or remove it, as needed.
            this.ciudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadSet);

        }

        private void ciudadPersonalSetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ciudadPersonalSetDataGridView.Columns["dataGridViewTextBoxColumn8"].Index == e.ColumnIndex)
            {
                DateTime nuevaFecha;
                DateTime fechaActual;
                CultureInfo provider = CultureInfo.InvariantCulture;
                try
                {
                    if (!DateTime.TryParseExact(ciudadPersonalSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "yyMM", provider, DateTimeStyles.AssumeLocal, out fechaActual))
                        fechaActual = DateTime.ParseExact(DateTime.Today.ToString("yyMM"), "yyMM", provider);
                    nuevaFecha = DateTime.Parse(FormRepository.GetCalendarDate(Cursor.Position, fechaActual));
                    ciudadPersonalSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nuevaFecha.ToString("yyMM");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

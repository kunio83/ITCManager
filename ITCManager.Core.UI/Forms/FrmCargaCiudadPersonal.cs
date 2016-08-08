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
        CurrencyManager _currencyManager1;

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

            //Completo el comboBox de empleados
            this.metroComboBox1.DataSource = this.iTC_DBPOwerDataSet.getPersonal;
            this.metroComboBox1.DisplayMember = "Column1";
            this.metroComboBox1.ValueMember = "IdRolEmpleado";

            //Por defecto el 1er valor del numeric es el periodo actual
            numericUpDown1.Value = decimal.Parse(DateTime.Today.ToString("yyMM"));

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this._currencyManager1 == null)
                this._currencyManager1 = (CurrencyManager)BindingContext[ciudadPersonalSetDataGridView.DataSource];

            this._currencyManager1.SuspendBinding();
            if (numericUpDown1.Value != 0)
            {
                for (int i = 0; i < ciudadPersonalSetDataGridView.Rows.Count; i++)
                {
                    if (ciudadPersonalSetDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn8"].Value != null &&
                        ciudadPersonalSetDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn8"].Value.ToString() == numericUpDown1.Value.ToString())
                    {
                        ciudadPersonalSetDataGridView.Rows[i].Visible = true;
                    }
                    else
                    {
                        ciudadPersonalSetDataGridView.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ciudadPersonalSetDataGridView.Rows.Count; i++)
                {
                    ciudadPersonalSetDataGridView.Rows[i].Visible = true;
                }
            }
            this._currencyManager1.ResumeBinding();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem != null && metroTextBox1.Text != String.Empty)
            {
                int idCiudadActual = Convert.ToInt32(((DataRowView)ciudadSetBindingNavigator.BindingSource.Current)["IdCiudad"]);
                ciudadPersonalSetTableAdapter.Insert(metroTextBox1.Text, (int)metroComboBox1.SelectedValue, idCiudadActual);
            }
            this.ciudadPersonalSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadPersonalSet);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            string fechaSeleccionada = FormRepository.GetCalendarDate(new Point((int)(Cursor.Position.X * 0.7),Cursor.Position.Y), DateTime.Today);
            metroTextBox1.Text = Convert.ToDateTime(fechaSeleccionada).ToString("yyMM");
        }

        private void ciudadPersonalSetDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in ciudadPersonalSetDataGridView.Rows)
            {
                //r.Cells["Puesto"].Value = getPersonalBindingSource.curr
            }
            
        }
    }
}

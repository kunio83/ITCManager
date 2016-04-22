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
using ITCManager.Core.Entities;
using ITCManager.Core.Business;

namespace ITCManager.Core.UI.Forms
{
    public partial class frmCargaDatos : Base
    {
        public frmCargaDatos()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarDataGrid();
            mtabCargaDatos.SelectTab(tabFormu);
        }

        void cargarTabCargaDatos()
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.Persona' table. You can move, or remove it, as needed.
            //this.entityTableAdapter.Fill(this.iTC_DBPOwerDataSet.Persona);
            //// TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.Persona' table. You can move, or remove it, as needed.
            //this.entityTableAdapter.Fill(this.iTC_DBPOwerDataSet.Persona);
        }

        private void frmCargaDatos_Load(object sender, EventArgs e)
        {
            mtabCargaDatos.SelectTab("tabSelect");
            cargarComboTablas();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.entityBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void cargarComboTablas()
        {
            cmbTablas.DataSource = EntityRepository.GetAllEntities();
            cmbTablas.DisplayMember = "Name";
        }

        private void cargarDataGrid()
        {
            //Verifico el nombre por las pinches terminaciones SET hasta que los saquemos
            var tablaActual = getNombreTablaActual();
            var dataSet = BindingSouceHelper.ObtenerDataSet(tablaActual, iTC_DBPOwerDataSet);
            var tableAdapter = BindingSouceHelper.ObtenerTableAdapter(tablaActual + "TableAdapter", tableAdapterManager1);

            bindingSource1.DataSource = dataSet;
            dgvDatos.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            BindingSouceHelper.FillTableAdapter(tablaActual, tableAdapter, iTC_DBPOwerDataSet);

            dgvDatos.Refresh();
        }

        private String getNombreTablaActual()
        {
            var selected = cmbTablas.Text;

            if (iTC_DBPOwerDataSet.Tables.Contains(selected))
                return selected;
            else if (iTC_DBPOwerDataSet.Tables.Contains(selected + "Set"))
                return selected + "Set";

            return String.Empty;
        }
    }
}

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
            cargaInicio();


        }

        void cargaInicio()
        {
            mtabCargaDatos.SelectTab("tabSelect");
            cargarCombo();
        }

        void cargarCombo()
        {
            cmbTablas.DataSource = EntityRepository.GetAllEntities();
            cmbTablas.DisplayMember = "Name";
        }

        private void mtabCargaDatos_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarTabFormulario();
        }

        private void cargarTabFormulario()
        {
            var selectedType = (Type)cmbTablas.SelectedItem;
            var entity = Activator.CreateInstance(selectedType);
            mtabCargaDatos.SelectTab(tabFormu);
            cargarDatosDataGrid(entity);
        }

        private void cargarDatosDataGrid(Object entity)
        {
            var dataSource = new BindingList<Persona>(RolHelper.GetPersonaEmpleados().ToList());
            dgvCarga.DataSource = dataSource;
            dgvCarga.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

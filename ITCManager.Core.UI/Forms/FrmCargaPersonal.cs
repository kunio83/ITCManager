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
    public partial class FrmCargaPersonal : Base
    {
        private ContextMenu contextMenu;
        public FrmCargaPersonal()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            iTC_DBPOwerDataSet.RolDocenteSet.EndInit();
            this.personaBindingSource.EndEdit();
            this.rolEmpleadoBindingSource.EndEdit();
            this.rolDocenteSetBindingSource.EndEdit();
            this.rolEmpleadoTableAdapter.Update(iTC_DBPOwerDataSet.RolEmpleado);
            this.rolDocenteSetTableAdapter.Update(iTC_DBPOwerDataSet.RolDocenteSet);
            this.rolVendedorTableAdapter.Update(iTC_DBPOwerDataSet.RolVendedor);
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmCargaPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolVendedor' table. You can move, or remove it, as needed.
            this.rolVendedorTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolVendedor);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolDocenteSet' table. You can move, or remove it, as needed.
            this.rolDocenteSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolDocenteSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.PuestoSet' table. You can move, or remove it, as needed.
            this.puestoSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.PuestoSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolEmpleado' table. You can move, or remove it, as needed.
            this.rolEmpleadoTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolEmpleado);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.iTC_DBPOwerDataSet.Persona);

        }

        private void rolEmpleadoDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == rolEmpleadoDataGridView.Columns["dataGridViewTextBoxColumn3"].Index)
            {
                if (contextMenu == null)
                {
                    contextMenu = new ContextMenu();
                    MenuItem item = new MenuItem("Editar Valores");
                    item.Click += Item_Click;
                    contextMenu.MenuItems.Add(item);
                }
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(rolEmpleadoDataGridView, e.Location);
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            //Aca ser va a abrir el form de carga de datos, parametrizando la tabla que quiero editar
            FormRepository<FrmCargaDatos>.Open(this.MdiParent,new object[1] { "Puesto" });
        }

        private void rolEmpleadoDataGridView_MouseLeave(object sender, EventArgs e)
        {
            ((DataGridView)sender).ReadOnly = true;
        }

        private void rolEmpleadoDataGridView_MouseEnter(object sender, EventArgs e)
        {
            if(idPersonaTextBox.Text != "-1")
                ((DataGridView)sender).ReadOnly = false;
        }
    }
}

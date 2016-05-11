using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.ComponentModel;
using ITCManager.Core.Entities;
using ITCManager.Core.Business;
using ITCManager.Core.UI;

namespace ITCManager.Core.UI.Forms
{
    public class CargaDatosHelper //: //ICargaDatosHelper
    {
        MetroForm _frmCargaDatos;
        ITC_DBPOwerDataSet _dbDataSet;
        ITC_DBPOwerDataSetTableAdapters.TableAdapterManager _tableAdapterManager;
        MetroComboBox _cmbTablas;
        IContainer _components;


        public CargaDatosHelper(MetroForm frmCargaDatos, ITC_DBPOwerDataSet dataset)
        {
            this._frmCargaDatos = frmCargaDatos;
            this._cmbTablas = (MetroComboBox)frmCargaDatos.Controls.Find("cmbTablas", true)[0];
            this._dbDataSet = dataset;
            this._tableAdapterManager = new ITC_DBPOwerDataSetTableAdapters.TableAdapterManager();
        }

        public void cargarComboTablas()
        {
            this._cmbTablas.DataSource = EntityRepository.GetAllEntities();
            this._cmbTablas.DisplayMember = "Name";
        }

        #region Controles

        public void armarNuevoTabPage(String nombre)
        {
            //Agrego los Controles al tabPage
            MetroTabPage mtp = getNewMetroTabPage(nombre);
            TableLayoutPanel tlp = getNewTableLayoutPanel(nombre);
            BindingNavigator bn = getNewBindingNavigator(nombre);
            DataGridView dgv = getNewDataGridView(nombre);
            MetroTabControl mtc = (MetroTabControl)this._frmCargaDatos.Controls.Find("mtabCargaDatos", true)[0];
            BindingSource bs = getNewBindingSource(this._components);
            mtc.TabPages.Add(mtp);
            mtp.Controls.Add(tlp);
            tlp.Controls.Add(bn,1,0);
            tlp.Controls.Add(dgv,1,1);

            this.cargarDataGrid(dgv, bn, bs);
        }

        private MetroTabPage getNewMetroTabPage(String nombre)
        {
            MetroTabPage result = new MetroFramework.Controls.MetroTabPage();
            
            result.HorizontalScrollbarBarColor = true;
            result.Location = new System.Drawing.Point(4, 35);
            result.Name = "mtp" + nombre;
            result.Size = new System.Drawing.Size(892, 295);
            result.Style = MetroFramework.MetroColorStyle.Blue;
            result.TabIndex = 1;
            result.Text = nombre;
            result.Theme = MetroFramework.MetroThemeStyle.Dark;
            result.VerticalScrollbarBarColor = true;
            result.SuspendLayout();
            result.ResumeLayout(false);
            result.MouseDoubleClick += new MouseEventHandler(midClick);
            return result;
        }

        private void midClick(object sender, MouseEventArgs e)
        {
            
        }

        private DataGridView getNewDataGridView(String nombre)
        {
            DataGridView result = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(result)).BeginInit();
            result.AllowUserToOrderColumns = true;
            result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result.Dock = System.Windows.Forms.DockStyle.Fill;
            result.Location = new System.Drawing.Point(47, 26);
            result.Name = "dgv" + nombre;
            result.Size = new System.Drawing.Size(796, 250);
            result.TabIndex = 0;
            result.Dock = DockStyle.Fill;
            ((System.ComponentModel.ISupportInitialize)(result)).EndInit();
            return result;
        }

        private TableLayoutPanel getNewTableLayoutPanel(String nombre)
        {
            TableLayoutPanel result = new TableLayoutPanel();
            result.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            result.ColumnCount = 3;
            result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            
            result.Dock = System.Windows.Forms.DockStyle.Fill;
            result.Location = new System.Drawing.Point(0, 0);
            result.Name = "tlp" + nombre;
            result.RowCount = 3;
            result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            //result.Size = new System.Drawing.Size(892, 295);
            result.TabIndex = 2;
            return result;
        }

        private BindingNavigator getNewBindingNavigator(String nombre)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDatos));
            this._components = new System.ComponentModel.Container();
            BindingNavigator bindingNavigator = new System.Windows.Forms.BindingNavigator(this._components);
            ToolStripButton bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            ToolStripLabel bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            ToolStripButton bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ToolStripButton bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            ToolStripButton bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            ToolStripSeparator bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            ToolStripTextBox bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            ToolStripSeparator bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripButton bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            ToolStripButton bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            ToolStripSeparator bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripButton btnSave = new System.Windows.Forms.ToolStripButton();
            
            ((System.ComponentModel.ISupportInitialize)(bindingNavigator)).BeginInit();
            // 
            // bindingNavigator
            // 
            bindingNavigator.AddNewItem = bindingNavigatorAddNewItem;
            bindingNavigator.CountItem = bindingNavigatorCountItem;
            bindingNavigator.DeleteItem = bindingNavigatorDeleteItem;
            bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            bindingNavigatorMoveFirstItem,
            bindingNavigatorMovePreviousItem,
            bindingNavigatorSeparator,
            bindingNavigatorPositionItem,
            bindingNavigatorCountItem,
            bindingNavigatorSeparator1,
            bindingNavigatorMoveNextItem,
            bindingNavigatorMoveLastItem,
            bindingNavigatorSeparator2,
            bindingNavigatorAddNewItem,
            bindingNavigatorDeleteItem,
            btnSave});
            bindingNavigator.Location = new System.Drawing.Point(44, 0);
            bindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator.Name = "bn" + nombre;
            bindingNavigator.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator.Size = new System.Drawing.Size(802, 23);
            bindingNavigator.TabIndex = 1;
            bindingNavigator.Text = nombre;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 20);
            bindingNavigatorCountItem.Text = "of {0}";
            bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSave.Image = global::ITCManager.Core.UI.Properties.Resources.btnSave_Image;
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(23, 20);
            btnSave.Text = "toolStripButton1";
            btnSave.Click += new System.EventHandler(btnSave_Click);
            ((System.ComponentModel.ISupportInitialize)(bindingNavigator)).EndInit();
            bindingNavigator.ResumeLayout(false);
            bindingNavigator.PerformLayout();
            return bindingNavigator;
        }

        private BindingSource getNewBindingSource(IContainer components)
        {
            BindingSource bindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            return bindingSource;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._frmCargaDatos.Validate();
            //bindingSource.EndEdit();
            this._tableAdapterManager.UpdateAll(this._dbDataSet);
        }

        public String getNombreTablaActual()
        {
            var selected = _cmbTablas.Text;

            if (_dbDataSet.Tables.Contains(selected))
                return selected;
            else if (_dbDataSet.Tables.Contains(selected + "Set"))
                return selected + "Set";

            return String.Empty;
        }

        private void cargarDataGrid(DataGridView dgvDatos, BindingNavigator bindingNavigator, BindingSource bindingSource)
        {
            //Verifico el nombre por las pinches terminaciones SET hasta que los saquemos
            var tablaActual = this.getNombreTablaActual();
            var dataSet = BindingSouceHelper.ObtenerDataSet(tablaActual, this._dbDataSet);
            var tableAdapter = BindingSouceHelper.ObtenerTableAdapter(tablaActual + "TableAdapter", this._tableAdapterManager);

            bindingSource.DataSource = dataSet;
            dgvDatos.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
            BindingSouceHelper.FillTableAdapter(tablaActual, tableAdapter, this._dbDataSet);

            dgvDatos.Refresh();
        }
    }
}

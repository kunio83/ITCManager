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
    public partial class FrmCargaCiudad : Base
    {
        public FrmCargaCiudad()
        {
            InitializeComponent();
        }

        private void ciudadSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ciudadSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmCargaCiudad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.LocalidadSet' table. You can move, or remove it, as needed.
            this.localidadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LocalidadSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.LineaCiudadSet' table. You can move, or remove it, as needed.
            this.lineaCiudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LineaCiudadSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.CiudadSet' table. You can move, or remove it, as needed.
            this.ciudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadSet);

        }
    }
}

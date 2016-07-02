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
    public partial class FrmRolCiudadActivaPlan : Base
    {
        private int _idRolCiudadActiva = 0;

        public FrmRolCiudadActivaPlan()
        {
            InitializeComponent();
        }

        public FrmRolCiudadActivaPlan(int idRolCiudadActiva)
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

        private void FrmRolCiudadActivaPlan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.PlanBaseSet' table. You can move, or remove it, as needed.
            this.planBaseSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.PlanBaseSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolCiudadActivaPlanSet' table. You can move, or remove it, as needed.
            this.rolCiudadActivaPlanSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaPlanSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolCiudadActivaSet' table. You can move, or remove it, as needed.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);

            if(this._idRolCiudadActiva > 0)
                rolCiudadActivaSetBindingSource.Position = rolCiudadActivaSetBindingSource.Find("IdRolCiudadActiva", this._idRolCiudadActiva);

            if (rolCiudadActivaPlanSetDataGridView.Rows.Count <= 1)
            {
                CrearCopiaPlanesBase();
            }
            LlenarDetallePLan();

        }

        private void LlenarDetallePLan()
        {
            foreach (DataGridViewRow r in rolCiudadActivaPlanSetDataGridView.Rows)
            {
                foreach (ITC_DBPOwerDataSet.PlanBaseSetRow p in this.iTC_DBPOwerDataSet.PlanBaseSet.Rows)
                {
                    if (p.IdPlanBase == Convert.ToInt32(r.Cells["dataGridViewTextBoxColumn3"].Value))
                    {
                        r.Cells["DetallePlan"].Value = p.DetallePlanBase;
                    }
                }


            }

            foreach (ITC_DBPOwerDataSet.RolCiudadActivaPlanSetRow r in this.iTC_DBPOwerDataSet.RolCiudadActivaPlanSet.Rows)
            {
                
            }
        }
        

        private void CrearCopiaPlanesBase()
        {
            int idPlan;
            foreach (ITC_DBPOwerDataSet.PlanBaseSetRow r in this.iTC_DBPOwerDataSet.PlanBaseSet.Rows)
            {
                idPlan = r.IdPlanBase;
                rolCiudadActivaPlanSetTableAdapter.Insert(this._idRolCiudadActiva, idPlan, "", "", "", "", "", "", "", "");

            }
            this.rolCiudadActivaPlanSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaPlanSet);
        }
    }
}

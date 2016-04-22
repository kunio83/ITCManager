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
    public class CargaDatosHelper
    {
        MetroForm _frmCargaDatos;
        ITC_DBPOwerDataSet _dbDataSet;
        

        public CargaDatosHelper(MetroForm frmCargaDatos)
        {
            _frmCargaDatos = frmCargaDatos;
            _dbDataSet = frmCargaDatos.Controls["iTC_DBPOwerDataSet"];
        }

        public void cargarTabFormulario()
        {
            var comboBoxTablas = (MetroComboBox)_frmCargaDatos.Controls["cmbTablas"];
            var selectedType = (Type)comboBoxTablas.SelectedItem;
            var entity = Activator.CreateInstance(selectedType);
            
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.ComponentModel;
using ITCManager.Core.Entities;
using ITCManager.Core.Business;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    interface ICargaDatosHelper
    {
        String getNombreTablaActual();
        void cargarDataGrid(DataGridView dgvDatos, BindingNavigator bindingNavigator, BindingSource bindingSource);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms.Controles
{
    public partial class Calendar : Form
    {
        public String FechaSeleccionada { get; set; }
        FrmCargaCiudad _frm;
        public Calendar()
        {
            InitializeComponent();
        }

        public Calendar(FrmCargaCiudad frm)
        {
            InitializeComponent();
            this._frm = frm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                FechaSeleccionada = dateTimePicker1.Value.ToShortDateString();
            }
            catch (Exception ex)
            {
                FechaSeleccionada = DateTime.Now.ToShortDateString();
                throw new Exception(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this._frm.FechaCalendar = dateTimePicker1.Value.ToShortDateString();
            this.Hide();
            //this.Close();
        }
    }
}

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
        public String _FechaSeleccionada { get; set; }
        public DateTime _FechaActual { get; set; }

        public Calendar()
        {
            InitializeComponent();
        }

        public String GetCalendarDate()
        {
            return this._FechaSeleccionada;
        }

        private void Calendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this._FechaSeleccionada = dateTimePicker1.Value.ToShortDateString();
                this.Hide();
            }
        }

        private void Calendar_Shown(object sender, EventArgs e)
        {
            dateTimePicker1.Value = _FechaActual;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            this._FechaSeleccionada = dateTimePicker1.Value.ToShortDateString();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class Base : MetroForm
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form)sender).Dispose();
        }

        public virtual void CleanFormTextBoxs(Form frm)
        {
            var textbox = frm.Controls.OfType<TextBox>();
            foreach (var c in textbox)
            {
                c.Text = String.Empty;
            }
        }

        private void Base_Load(object sender, EventArgs e)
        {
            if (this.Name != "Base")
            {
                this.ControlBox = true;
                MessageBox.Show("soy: " + this.Name);
            }
        }
    }
}

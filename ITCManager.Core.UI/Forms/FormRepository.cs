using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    public class FormRepository<T> where T : Form
    {
        Form frm;
        public FormRepository(Form frmParent)
        {
            Type type;
            if (frm == null)
            {
                //var ret = new T();
                //frm = (Form)Activator.CreateInstance(type.Name);
                
            }
                frm.MdiParent = frmParent;
                frm.Show();
        }
    }
}

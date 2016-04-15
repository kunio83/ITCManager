using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing;

namespace ITCManager.Core.UI.Forms
{
    public static class FormRepository<T> where T : Form
    {
        public static void Open(Form mdiParent)
        {
            MetroForm frm;
            Type t = typeof(T);
            bool isOpen = mdiParent.MdiChildren.FirstOrDefault(z => z.GetType() == t) != null;
            if (!isOpen)
            {
                frm = (MetroForm)Activator.CreateInstance(t);
                frm.MdiParent = mdiParent;
                frm.Show();
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(mdiParent.Location.X + (mdiParent.Width - frm.Width) / 2,
                                            mdiParent.Location.Y + (mdiParent.Height - frm.Height) / 2);
            }
        }

    }
}

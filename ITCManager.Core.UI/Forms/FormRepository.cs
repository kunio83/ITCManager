using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing;
using MetroFramework.Controls;
using ITCManager.Core.UI.Forms.Controles;

namespace ITCManager.Core.UI.Forms
{
    public static class FormRepository<T> where T : Form
    {
        internal static void Open(Form mdiParent)
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
                //frm.WindowState = FormWindowState.Maximized;
                frm.ControlBox = true;

            }
        }

        internal static void Open(Form mdiParent, Object[] args)
        {
            MetroForm frm;
            Type t = typeof(T);
            bool isOpen = mdiParent.MdiChildren.FirstOrDefault(z => z.GetType() == t) != null;
            if (!isOpen)
            {
                frm = (MetroForm)Activator.CreateInstance(t,args);
                frm.MdiParent = mdiParent;
                frm.Show();
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(mdiParent.Location.X + (mdiParent.Width - frm.Width) / 2,
                                            mdiParent.Location.Y + (mdiParent.Height - frm.Height) / 2);
            }
        }
    }

    public static class FormRepository
    {
        private static ContextMenu _menu;
        private static Calendar _calendar;
        private static String _actualTable;

        internal static void CreateCellContMenuEditor(Form mdiParent, DataGridView dgv, String table, Point pos)
        {
            if (_menu == null || _actualTable != table)
            {
                _actualTable = table;
                _menu = new ContextMenu();
                MenuItem item = new MenuItem("Editar Valores");
                item.Click += (sender, e) => Item_Click(sender, e, mdiParent, table);
                _menu.MenuItems.Add(item);
            }
            _menu.Show(dgv, pos);
        }

        internal static String GetCalendarDate(Point pos,DateTime fechaActual)
        {
            if (_calendar == null) _calendar = new Calendar();
            _calendar.Location = pos;
            _calendar._FechaActual = fechaActual;
            _calendar.ShowDialog();
            
            return _calendar.GetCalendarDate();
        }

        private static void Item_Click(object sender, EventArgs e, Form mdiParent, String table)
        {
            //Aca ser va a abrir el form de carga de datos, parametrizando la tabla que quiero editar
            FormRepository<FrmCargaDatos>.Open(mdiParent, new object[1] { table });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Drawing;
using MetroFramework.Controls;

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
                frm.WindowState = FormWindowState.Maximized;
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
        //internal static void ColorearImagen(Control control, Color target)
        //{

        //    var lstImagenes = control.Controls.OfType<MetroTile>().Where(z => z.TileImage != null);
        //    Bitmap bmp2 = null;
        //    Rectangle rect;

        //    foreach (var i in lstImagenes)
        //    {
        //        ChangeColor(i.TileImage as Bitmap);
        //        //bmp2 = new Bitmap(i.TileImage.Width, i.TileImage.Height);
        //        //rect = new Rectangle(Point.Empty, i.TileImage.Size);
        //        //using (Graphics G = Graphics.FromImage(bmp2))
        //        //{
        //        //    G.Clear(target);
        //        //    G.DrawImageUnscaledAndClipped(i.TileImage, rect);
        //        //}
        //        //i.TileImage = bmp2;
        //    }
        //}

        public static void ChangeColor(Bitmap scrBitmap)
        {
            //You can change your new color here. Red,Green,LawnGreen any..
            Color newColor = Color.White;
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            scrBitmap=  newBitmap;
        }

        internal static void ConvertControlsToMetro(MetroForm form)
        {
            
        }
    }
}

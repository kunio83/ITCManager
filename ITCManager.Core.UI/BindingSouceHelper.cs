using ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using ITCManager.Core.UI.ITC_DBPOwerDataSetTableAdapters;

namespace ITCManager.Core.UI
{
    public static class BindingSouceHelper
    {
        public static Object ObtenerTableAdapter(String tableAdapter, TableAdapterManager tManager)
        {
            var result = new Object();
            foreach (Type t in tManager.GetType().Assembly.GetTypes())
            {
                if (t.Name.Equals(tableAdapter) && t.Name != "TableAdapterManager")
                {
                    object adapter = Activator.CreateInstance(t);
                    PropertyInfo pi = tManager.GetType().GetProperty(adapter.GetType().Name);
                    tManager.GetType().GetProperty(pi.Name).SetValue(tManager, adapter, null);
                    return Activator.CreateInstance(t);
                }
            }
            return null;
        }

        public static Boolean FillTableAdapter(String nombreTabla, Object tAdapter, ITC_DBPOwerDataSet ds)
        {
            try
            {
                Object dsType = ds.GetType().GetProperty(nombreTabla).GetValue(ds);
                var methodInfo = tAdapter.GetType().GetMethod("Fill");

                methodInfo.Invoke(tAdapter, new object[] { dsType });
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                
            }
        }

        public static Object ObtenerDataSet(String nombreDs, ITC_DBPOwerDataSet itcDs)
        {
            return itcDs.GetType().GetProperty(nombreDs).GetValue(itcDs, null);
        }
    }
}

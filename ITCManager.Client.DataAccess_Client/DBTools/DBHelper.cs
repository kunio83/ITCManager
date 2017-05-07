using ITCManager.Client.Entities_Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITCManager.Client.DataAccess_Client.DBTools
{
    public static class DBHelper<T> where T : class
    {
        public static void Clear()
        {
            using (var db = new SqliteClientDataBaseEntitiesFinal())
            {
                Type t = typeof(T);
                db.Database.ExecuteSqlCommand(@"DELETE FROM " + t.Name + ";");
            }
        }

        public static void InsertarRolEmpleado(RolEmpleado rol)
        {
            using (var db = new SqliteClientDataBaseEntitiesFinal())
            {
                db.RolEmpleado.Add(rol);
                db.SaveChanges();
            }
        }
    }

    public static class DBHelper
    {
        public static void ClearDb()
        {
            using (var db = new SqliteClientDataBaseEntitiesFinal())
            {
                //Hago un backup de la db actual
                string actualDbName = "SqliteClientDataBase.db";// db.Database.Connection.DataSource;
                string bkpDbName = "bkp_" + DateTime.Now.ToString("yyyyMMddhhmmss");

                File.Copy(actualDbName, bkpDbName, true);
                //traigo todas las tablas y las vacío
                var tables = db.Database.SqlQuery<string>("SELECT name FROM sqlite_master WHERE type='table' and name <> 'sqlite_sequence';").ToList();

                 foreach (var tabla in tables)
                {
                    db.Database.ExecuteSqlCommand(@"DELETE FROM " + tabla + ";");
                }
            }
        }



    }
}

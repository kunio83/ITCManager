using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;
namespace ITCManager.Client.DataAccess_Client
{
    public class SqliteConect
    {
        private SQLiteConnection con;
        private SQLiteCommand command;
        private SQLiteDataReader dataReader;

        public void Conectar()
        {
            //Data


            con = new SQLiteConnection("Data Source=ITCClientDb.db;Version=3;New=True;Compress=True;");
            con.Open();

            command = con.CreateCommand();
            command.CommandText = "CREATE TABLE Persona(IdPersona integer primary key,Nombres nvarchar(100));";
            command.ExecuteNonQuery();
        }

        public String GetNombreById(int idPersona)
        {
            String result = String.Empty;


            con = new SQLiteConnection("Data Source=ITCClientDb.db;Version=3;New=False;Compress=True;");
            con.Open();

            command = con.CreateCommand();
            command.CommandText = "SELECT Nombres from Persona where idPersona = '"+ idPersona + "';";
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                result = dataReader.GetString(0);
            }
            con.Close();
            return result;
        }
    }
}

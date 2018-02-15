using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capadbo
{
    public class DB_Login
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        public NpgsqlDataReader Buscar_Usuario_db(string cuenta, string clave)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;User Id=postgres;Password=Admin;Database=programacion;");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT cedula, nombre, clave, tipo FROM registros WHERE nombre = " + cuenta + " AND clave = MD5('" + clave + "');", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                return dr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return null;
            }
        }
    }
}

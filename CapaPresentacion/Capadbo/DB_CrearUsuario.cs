using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capadbo
{
    public class DB_CrearUsuario
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        /// <summary>
        /// Save the information in database
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <returns>And return true if is saved else if isn't saved return false</returns>
        public bool Guardar_Usuario_db(string cedula, string nombre, string clave)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO registros VALUES (" + cedula + ",'" + nombre + "',MD5('" + clave + "'),true);", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return false;
            }
        }
    }
}

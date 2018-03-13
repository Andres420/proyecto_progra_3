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
        /// <summary>
        /// This method search the user in the database
        /// </summary>
        /// <param name="cuenta"></param>
        /// <param name="clave"></param>
        /// <returns>And return the user</returns>
        public object[] Buscar_Usuario_db(string cuenta, string clave)
        {
            object[] arreglo = null;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT cedula, nombre, clave, tipo FROM registros WHERE cedula = " + cuenta + " AND clave = MD5('" + clave + "');", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dr.Read();
                    arreglo = new object[] {dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetBoolean(3) };
                }
                
                conn.Close();
                return arreglo;
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

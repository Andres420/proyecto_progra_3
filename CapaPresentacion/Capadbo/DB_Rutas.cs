using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Capadbo
{
    public class DB_Rutas
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;

        public List<string> Cargar_Combos_Paises()
        {
            List<string> list = new List<string>();
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT nombre_pais FROM paises;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        list.Add(dr.GetString(0));
                    }
                }
                conn.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return null;
            }
        }
    }
}

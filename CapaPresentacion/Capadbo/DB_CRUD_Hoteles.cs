using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capadbo
{
    public class DB_CRUD_Hoteles
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        
        /// <summary>
        /// This method search in database all places of country
        /// </summary>
        /// <returns>And return a list with places name</returns>
        public List<string> Info_Combo_Lugares()
        {
            List<string> list = new List<string>();
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
            conn.Open();
            cmd = new NpgsqlCommand("SELECT nombre FROM lugares;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetString(0));
                    }
                    conn.Close();
                    return list;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }

        }
        /// <summary>
        /// This method search all countries name
        /// </summary>
        /// <returns>And return a list with countries name</returns>
        public List<string> Info_Combo_Pais()
        {
            List<string> list = new List<string>();
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
            conn.Open();
            cmd = new NpgsqlCommand("SELECT nombre_pais FROM paises;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetString(0));
                    }
                    conn.Close();
                    return list;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }
    }
}

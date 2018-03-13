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
        /// <summary>
        /// This method search countries in the database
        /// </summary>
        /// <returns>And return a list with them</returns>
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
        /// <summary>
        /// This method delete a route in the database
        /// </summary>
        /// <param name="cod_ruta"></param>
        /// <returns>And return a boolean if it's delete</returns>
        public bool Eliminar_Ruta(int cod_ruta)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("DELETE FROM rutas WHERE id_rutas = " + cod_ruta + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("erge" + ex);
                conn.Close();
                return false;
            }
            
        }
        /// <summary>
        /// This method add a route in the database
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="duracion"></param>
        /// <returns>And return a boolean if it's save</returns>
        public bool Agregar_Rutas(string origen, string destino, string duracion)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO  rutas(pais_origenfk,pais_destinofk,duracion) VALUES((SELECT id_paises FROM paises WHERE nombre_pais = '" + origen + "'), " +
                    "(SELECT id_paises FROM paises WHERE nombre_pais = '" + destino + "'),'" + duracion + "');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine("edrh" + ex);
                return false;
            }
        }
        /// <summary>
        /// This method update a route in the database
        /// </summary>
        /// <param name="cod_ruta"></param>
        /// <param name="pais_origen"></param>
        /// <param name="pais_destino"></param>
        /// <param name="duracion"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool Modificar_Ruta(int cod_ruta, string pais_origen, string pais_destino, string duracion)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("UPDATE rutas SET pais_origenfk = (SELECT id_paises FROM paises WHERE nombre_pais = '" + pais_origen + "')," +
                    " pais_destinofk = (SELECT id_paises FROM paises WHERE nombre_pais = '" + pais_destino + "'),duracion = '" + duracion + "' WHERE id_rutas = " + cod_ruta + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine("edrh" + ex);
                return false;
            }
        }
    }
}

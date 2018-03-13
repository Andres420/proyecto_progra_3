using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capadbo
{
    public class DB_Vuelos
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        /// <summary>
        /// This method search the routes in the database
        /// </summary>
        /// <returns>And return them</returns>
        public List<int> Id_Rutas()
        {
            List<int> list = new List<int>();
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT id_rutas FROM rutas;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetInt32(0));
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
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return null;
            }
        }
        /// <summary>
        /// This method add a new route in the database
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="precio"></param>
        /// <returns>And return a boolean if it's save</returns>
        public bool Agregar_Vuelo(int ruta, int precio)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO tarifas_vuelos(ruta_fk,precio) VALUES(" + ruta + "," + precio + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return false;
            }
        }
        /// <summary>
        /// This method delete a route in the database
        /// </summary>
        /// <param name="cod_tarifa_vuelo"></param>
        /// <returns>And return a boolean if it's delete</returns>
        public bool Eliminar_Vuelo_Precio(int cod_tarifa_vuelo)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("DELETE FROM tarifas_vuelos WHERE id_tarifa_vuelo = " + cod_tarifa_vuelo + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return false;
            }
        }
        /// <summary>
        /// This method update a route in the database
        /// </summary>
        /// <param name="cod_tarifa_vuelo"></param>
        /// <param name="ruta"></param>
        /// <param name="precio"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool Modificar_Vuelo_Precio(int cod_tarifa_vuelo, string ruta, string precio)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("UPDATE tarifas_vuelos SET ruta_fk = " + ruta + ", precio = " + precio + " WHERE id_tarifa_vuelo = " + cod_tarifa_vuelo + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return false;
            }
        }
        /// <summary>
        /// This method compare the flights
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>And return a boolean if it's equal</returns>
        public bool Comparar_Rutas(int ruta)
        {
            bool Rut = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT id_tarifa_vuelo FROM tarifas_vuelos WHERE ruta_fk = " + ruta +" ;", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Rut = true;
                }
                conn.Close();
                return Rut;  
            }
            catch
            {
                conn.Close();
                return false;
            }
           
        }
    }
}

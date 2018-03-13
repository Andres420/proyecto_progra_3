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
                Console.WriteLine("efwe" + ex);
                conn.Close();
                return null;
            }

        }
        /// <summary>
        /// This method make a conection with the database
        /// </summary>
        /// <returns>And return the conection</returns>
        public NpgsqlConnection Conexion()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
            return conn;
        }
        /// <summary>
        /// This method insert all information of a hotel in a database
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="imagen"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="cod_tarifa"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Hotel(string nombre, string imagen, string lugar, string habitaciones, int cod_tarifa)
        {
            bool agregado = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO hoteles(nombre_hotel, foto_hotel, lugar_fk, habitaciones, preciohab_fk)" +
                    " VALUES ('" + nombre + "', '" + imagen + "', ( SELECT id_lugar FROM lugares WHERE nombre = '" + lugar + "'), " + habitaciones + ", " + cod_tarifa + ");", conn);
                cmd.ExecuteNonQuery();
                agregado = true;
                return agregado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return agregado;
            }
        }
        /// <summary>
        /// This method insert a price in database and check the room price code
        /// </summary>
        /// <param name="costo"></param>
        /// <returns>And returns the code</returns>
        public int Agregar_Tarifa(string costo)
        {
            int cod = 0;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO tarifas_hoteles(precio) VALUES(" + costo + ");", conn);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT id_tarifa FROM tarifas_hoteles WHERE precio = " + costo + ";", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cod = dr.GetInt32(0);
                    conn.Close();
                    return cod;
                }
                else
                {
                    conn.Close();
                    return cod;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return cod;
            }
        }
        /// <summary>
        /// This method update a hotel in the database
        /// </summary>
        /// <param name="cod_hotel"></param>
        /// <param name="imagen"></param>
        /// <param name="nombre_hotel"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="precio"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool Modificar_Hotel(int cod_hotel, string imagen, string nombre_hotel , string lugar, string habitaciones, string precio)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("UPDATE hoteles SET nombre_hotel = '" + nombre_hotel + "', foto_hotel = '" + imagen + "'," +
                    " lugar_fk = (SELECT id_lugar FROM lugares WHERE nombre = '" + lugar + "'), habitaciones = " + habitaciones + ", preciohab_fk = (SELECT id_tarifa FROM tarifas_hoteles WHERE precio = " + precio + ") " +
                    " WHERE id_hotel = " + cod_hotel + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("hewrt" + ex);
                conn.Close();
                return false;
            }
        }
        /// <summary>
        /// This method search a hotel
        /// </summary>
        /// <param name="codigo_hotel"></param>
        /// <returns>And return a list with it</returns>
        public List<object> Buscar_Hotel(string codigo_hotel)
        {
            List<object> list = new List<object>();
           try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT ho.id_hotel, ho.nombre_hotel, ho.foto_hotel, lu.nombre, ho.habitaciones, pre.precio FROM hoteles AS ho INNER JOIN lugares AS lu" +
                " ON lu.id_lugar = ho.lugar_fk INNER JOIN tarifas_hoteles AS pre ON pre.id_tarifa " +
                " = ho.preciohab_fk WHERE ho.id_hotel = "+codigo_hotel+";", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    list.Add(dr.GetInt32(0));
                    list.Add(dr.GetString(1));
                    list.Add(dr.GetString(2));
                    list.Add(dr.GetString(3));
                   // list.Add(dr.GetString(4));
                    list.Add(dr.GetInt32(4));
                    list.Add(dr.GetInt32(5));
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
                Console.WriteLine(ex);
                conn.Close();
                return null;
            }
        }
        /// <summary>
        /// This method delete a hotel in the database
        /// </summary>
        /// <param name="codigo_hotel"></param>
        /// <returns>And return a boolean if it's delete</returns>
        public bool Eliminar_Hotel(int codigo_hotel)
        {
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("DELETE FROM hoteles WHERE id_hotel = " + codigo_hotel + "; ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("hewrt" + ex);
                conn.Close();
                return false;
            }
            
        }
        /// <summary>
        /// This method check the room price code
        /// </summary>
        /// <param name="costo"></param>
        /// <returns>And returns the code</returns>
        public int Buscar_Tarifa(string costo)
        {
            int cod = 0;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("SELECT id_tarifa FROM tarifa_hoteles WHERE precio = " + costo + ";", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    cod = dr.GetInt32(0);
                    conn.Close();
                    return cod;
                }
                else
                {
                    conn.Close();
                    return cod;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return cod;
            }
        }    
    }
}

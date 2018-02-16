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
        /// <param name="pais"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="cod_tarifa"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Hotel(string nombre, string imagen, string pais, string lugar, string habitaciones, int cod_tarifa)
        {
            bool agregado = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO hoteles(nombre_hotel, foto_hotel,pais_fk,lugar_fk,habitaciones, preciohab_fk)" +
                    " VALUES('" + nombre + "', '" + imagen + "', (SELECT id_paises WHERE nombre_pais = +'" + pais + "'), (SELECT id_lugar WHERE nombre = '" + lugar + "'), " + habitaciones + ", " + cod_tarifa + ");", conn);
                cmd.ExecuteNonQuery();
                agregado = true;
                return agregado;
            }
            catch (Exception ex)
            {
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
                cmd = new NpgsqlCommand("INSERT INTO tarifa_hoteles(precio) VALUES(" + costo + ");", conn);
                cmd.ExecuteNonQuery();
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
                conn.Close();
                return cod;
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
                conn.Close();
                return cod;
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

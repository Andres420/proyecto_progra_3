using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Objetos;

namespace Capadbo
{
    public class DB_CRUD_Aeropuertos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;


        /// <summary>
        /// This method make the connection to the database
        /// </summary>
        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            int clave = 1;
            string baseDatos = "programacion";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        /// <summary>
        /// This method insert all information of the airports in a database
        /// </summary>
        /// <param name="nombre_aeropuerto"></param>
        /// <param name="fk_idlugar"></param>
        /// <param name="iata"></param>
        public bool InsertarDatos(string nombre_aeropuerto, int fk_idlugar, string iata)
        {
            bool agregado = false;
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO aeropuertos (nombre_aeropuerto,fk_idlugar,iata) VALUES ('" + nombre_aeropuerto + "', '" + fk_idlugar + "', '" + iata + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                agregado = true;
                return agregado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return agregado;
            }
        }

        /// <summary>
        /// This method update all information of the airports in a database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre_aeropuerto"></param>
        /// <param name="fk_idlugar"></param>
        /// <param name="iata"></param>
        public void ModificarDatos(int id, string nombre_aeropuerto, int fk_idlugar, string iata)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre_aeropuerto = '" + nombre_aeropuerto + "', fk_idlugar = '" + fk_idlugar + "', iata = '" + iata + "' WHERE id_aeropuerto = '" + id + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method delete all information of the airports in a database
        /// </summary>
        /// <param name="id"></param>
        public void EliminarDatos(int id)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuertos WHERE id_aeropuerto = '" + id + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        /// <summary>
        /// This method charge the information of the airports in the combobox
        /// </summary>
        public List<object> Combo_Lugar()
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_lugar, nombre FROM lugares;", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                }
            }
            conexion.Close();
            return lista;
        }

        /// <summary>
        /// This method search in database all airports
        /// </summary>
        public BindingList<Aeropuertos> Cargar_Grid()
        {     
            BindingList<Aeropuertos> lista = new BindingList<Aeropuertos>();
            {
                Conexion();
                conexion.Open();
                  string query = "SELECT a.id_aeropuerto,a.nombre_aeropuerto,l.nombre,a.iata from aeropuertos AS a" +
                       " INNER JOIN lugares AS l ON a.fk_idlugar = l.id_lugar ORDER BY a.id_aeropuerto;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Aeropuertos aero = new Aeropuertos();
                    aero.ID_Aero = dr[0].ToString();
                    aero.Nombre = dr[1].ToString();
                    aero.ID_Lugar = dr[2].ToString();
                    aero.IATA = dr[3].ToString();
                    lista.Add(aero);
                }
                BindingList<Aeropuertos> result = new BindingList<Aeropuertos>(lista);
                conexion.Close();
                return result;
            }
        }
    }
}

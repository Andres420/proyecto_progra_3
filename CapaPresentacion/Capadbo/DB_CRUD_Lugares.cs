using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Capadbo
{
    public class DB_CRUD_Lugares
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        /// <summary>
        /// This method insert the information of places in a database
        /// </summary>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Lugar(string nombre_lugar,string pais)
        {
            bool agregado = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO lugares (nombre,id_paisfk) VALUES ('" + nombre_lugar + "',(SELECT id_paises FROM paises WHERE nombre_pais = '" + pais + "'));", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                agregado = true;
                return agregado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return agregado;
            }
        }
        /// <summary>
        /// This method delete a place of database
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Eliminar_Lugar(int cod_lugar)
        {
            bool eliminado = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("DELETE FROM lugares WHERE id_lugar = " + cod_lugar + "; ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                eliminado = true;
                return eliminado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return eliminado;
            }
        }
        /// <summary>
        /// This method update a information of a place
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Modificar_Lugar(int cod_lugar, string nombre_lugar,string nombre_pais)
        {
            bool modificado = false;
            try
            {
                conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
                conn.Open();
                cmd = new NpgsqlCommand("UPDATE lugares SET nombre = '"+nombre_lugar+"',id_paisfk = (SELECT id_paises FROM paises WHERE nombre_pais = '"+nombre_pais+"') WHERE id_lugar = "+cod_lugar+";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                modificado = true;
                return modificado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conn.Close();
                return modificado;
            }
        }
    }
}

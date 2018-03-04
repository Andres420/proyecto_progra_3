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

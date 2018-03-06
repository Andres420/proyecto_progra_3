using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using Objetos;

namespace Capadbo
{
    public class DB_Interfaz_Vuelo
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;

        public DB_Interfaz_Vuelo()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
        }

        public void Cargar_TextBox(TextBox txtBuscador_Origen,TextBox txtBuscador_Destino)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT concat(lu.nombre,',',aero.nombre_aeropuerto) AS nombre FROM aeropuertos AS aero INNER JOIN lugares AS lu ON aero.fk_idlugar = lu.id_lugar;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtBuscador_Origen.AutoCompleteCustomSource.Add(dr[0].ToString());
                        txtBuscador_Destino.AutoCompleteCustomSource.Add(dr[0].ToString());
                    }
                }
                
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                //dr.Close();
                conn.Close();
            }
        }

        public List<Vuelo> Cargar_Vuelos(string origen, string destino)
        {
            List<Vuelo> lista = new List<Vuelo>();
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("",conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                conn.Close();
            }
            //Buscar con el lugar el pais origen
            //Buscar con el lugar el pais destino

            try
            {
                conn.Open();
                
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                //dr.Close();
                conn.Close();
            }

            try
            {
                conn.Open();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                //dr.Close();
                conn.Close();
            }
            return lista;
        }
    }
}
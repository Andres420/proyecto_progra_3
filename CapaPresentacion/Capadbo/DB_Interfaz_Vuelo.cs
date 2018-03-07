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
            string pais_or = "";
            int cod_pais_or = 0;
            string pais_des = "";
            int cod_pais_des = 0;
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT pa.id_paises, pa.nombre_pais FROM lugares AS lu INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk WHERE lu.nombre = '" + origen+"';", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                cod_pais_or = (int)dr[0];
                pais_or = dr[1].ToString();
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                dr.Close();
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT pa.id_paises, pa.nombre_pais FROM lugares AS lu INNER JOIN" +
                    " paises AS pa ON pa.id_paises = lu.id_paisfk WHERE lu.nombre = '" + destino + "';", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                cod_pais_des = (int)dr[0];
                pais_des = dr[1].ToString();
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                dr.Close();
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT ru.id_rutas,(SELECT nombre_pais FROM paises AS pa WHERE pa.id_paises = ru.pais_origenfk)," +
                    "(SELECT nombre_pais FROM paises AS pa WHERE pa.id_paises = ru.pais_destinofk)" +
                    ",ru.duracion, tv.precio FROM rutas AS ru INNER JOIN tarifas_vuelos AS tv ON tv.ruta_fk = ru.id_rutas; ", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vuelo vuelo = new Vuelo((int)dr[0], dr[1].ToString(), dr[2].ToString(), "", dr[3].ToString(), (int)dr[4]);
                        lista.Add(vuelo);
                    }
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("asd" + ex);
                dr.Close();
                conn.Close();
            }

            List<Vuelo> lista_vuelos = new List<Vuelo>();
            foreach (Vuelo vuelo_directo in lista)
            {
                if (vuelo_directo.pais_origen.Equals(pais_or) && vuelo_directo.pais_destino.Equals(pais_des))
                {
                    lista_vuelos.Add(vuelo_directo);
                }
            }
            foreach (Vuelo vuelo_escal in lista)
            {
                if (vuelo_escal.pais_origen.Equals(pais_or))
                {
                    foreach (Vuelo vuelo_escala in lista)
                    {
                        if (vuelo_escal.pais_origen.Equals(pais_or) && vuelo_escal.pais_destino.Equals(vuelo_escala.pais_origen) && vuelo_escala.pais_destino.Equals(pais_des))
                        {
                            string[] horas_es1 = vuelo_escal.duracion.Split(':');
                            string[] horas_es2 = vuelo_escala.duracion.Split(':');
                            int horas = (int.Parse(horas_es1[0]) + int.Parse(horas_es2[0]));
                            int min = (int.Parse(horas_es1[1]) + int.Parse(horas_es2[1]));
                            while (min >= 60)
                            {
                                horas += 1;
                                min -= 60;
                            }
                            Vuelo vuelo_esca = new Vuelo(0, vuelo_escal.pais_origen, vuelo_escala.pais_destino, vuelo_escal.pais_destino, horas + ":" + min, (vuelo_escal.precio + vuelo_escala.precio));
                            lista_vuelos.Add(vuelo_esca);
                        }
                    }
                }
            }
            return lista_vuelos;
        }
    }
}
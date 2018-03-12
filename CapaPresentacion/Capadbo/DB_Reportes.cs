using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capadbo
{
    public class DB_Reportes
    {
        static NpgsqlConnection conexion;


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
        /// This method search in database each of the times hotels have been reserved
        /// </summary>
        /// <returns>And return a list with hotels have been reserved name</returns>
        public ArrayList reporte1()
        {
            ArrayList rep1 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT h.nombre_hotel,COUNT(h.nombre_hotel) FROM reservas_compras AS c" +
                " INNER JOIN hoteles AS h on c.id_hotelfk = h.id_hotel WHERE c.reser_comp = true AND id_hotelfk IS NOT NULL GROUP BY  h.nombre_hotel" +
                " ORDER BY h.nombre_hotel; ", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep1.Add(reader.GetString(0));
                    rep1.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep1;
            }
        }


        /// <summary>
        /// This method search in database the number of people by hotel
        /// </summary>
        /// <returns>And return a list with the number of people by hotel</returns>
        public ArrayList reporte2()
        {
            ArrayList rep2 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT  h.nombre_hotel, SUM(COALESCE(c.adultos,0) + " +
                                " COALESCE(c.ninos, 0)) AS p_total FROM reservas_compras AS c INNER JOIN hoteles AS h on" +
                                " c.id_hotelfk = h.id_hotel WHERE c.reser_comp = true AND id_hotelfk IS NOT NULL GROUP BY  h.nombre_hotel ORDER BY h.nombre_hotel", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep2.Add(reader.GetString(0));
                    rep2.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep2;
            }
        }
        /// <summary>
        /// This method search in database the number of people by country
        /// </summary>
        /// <returns>And return a list with the number of people by country</returns>
        public ArrayList reporte3()
        {
            ArrayList rep3 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT  p.nombre_pais, (SUM(COALESCE(c.adultos,0) + " +
                          "COALESCE(c.ninos, 0)) * 100 / (SELECT SUM(COALESCE(c.adultos, 0) + COALESCE(c.ninos, 0)) " +
                          "FROM reservas_compras AS c Where reser_comp = true) )AS promedio FROM reservas_compras AS c " +
                          "INNER JOIN paises AS p on c.pais_destinofk = p.id_paises WHERE c.reser_comp = true " +
                          "GROUP BY p.nombre_pais ORDER BY p.nombre_pais", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep3.Add(reader.GetString(0));
                    rep3.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep3;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep3;
            }
        }

        /// <summary>
        /// This method search in database the number of adults who have traveled in a range of dates
        /// </summary>
        /// <param name="fechainicio"></param>
        /// <param name="fecha_final"></param>
        /// <returns>And return a list with the number of adults who have traveled in a range of dates</returns>
        public ArrayList reporte4(string fechainicio, string fecha_final)
        {
            ArrayList rep4 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(adultos) AS t_adult, (SELECT SUM(COALESCE(c.adultos, 0)) AS total " +
                        "FROM reservas_compras AS c Where reser_comp = true) FROM reservas_compras WHERE reser_comp = true " +
                        "AND fecha_inicio BETWEEN '" + fechainicio + "' AND '" + fecha_final + "';", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep4.Add(reader.GetString(0));
                    rep4.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep4;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep4;
            }
        }
        /// <summary>
        /// This method search in database the number of children who have traveled in a range of dates
        /// </summary>
        /// <param name="fechainicio"></param>
        /// <param name="fecha_final"></param>
        /// <returns>And return a list with the number of children who have traveled in a range of dates</returns>
        public ArrayList reporte5(string fechainicio, string fecha_final)
        {
            ArrayList rep5 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(ninos) AS t_ninos, (SELECT SUM(COALESCE(c.ninos, 0)) AS total " +
                        "FROM reservas_compras AS c Where reser_comp = true) FROM reservas_compras WHERE reser_comp = true " +
                        "AND fecha_inicio BETWEEN '" + fechainicio + "' AND '" + fecha_final + "';", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep5.Add(reader.GetString(0));
                    rep5.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep5;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep5;
            }
        }
        /// <summary>
        /// This method search in database the brands of the most rented vehicles.
        /// </summary>
        /// <returns>And return a list with the brands of the most rented vehicles.</returns>
        public ArrayList reporte6()
        {
            ArrayList rep6 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT v.marca_veh,COUNT(v.marca_veh) AS total " +
                "FROM reservas_compras as c INNER JOIN vehiculos AS v ON c.id_vehiculofk = v.id_vehiculos " +
                "WHERE c.reser_comp = true GROUP BY v.marca_veh ORDER BY total DESC LIMIT 3", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep6.Add(reader.GetString(0));
                    rep6.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep6;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep6;
            }
        }
        /// <summary>
        /// This method search in database the names of the countries that have been scaled
        /// </summary>
        /// <returns>And return a list with the names of the countries that have been scaled</returns>
        public ArrayList reporte7()
        {
            ArrayList rep7 = new ArrayList();
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT p.nombre_pais,COUNT(p.nombre_pais) FROM reservas_compras AS c "+
                " INNER JOIN paises AS p ON c.idpais_escalafk = p.id_paises" +
                " WHERE c.reser_comp = true GROUP BY p.nombre_pais", conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rep7.Add(reader.GetString(0));
                    rep7.Add(reader.GetString(1));
                }
                conexion.Close();
                return rep7;
            }
            catch (Exception ex)
            {
                Console.WriteLine("sdasd" + ex);
                conexion.Close();
                return rep7;
            }
        }
    }
}

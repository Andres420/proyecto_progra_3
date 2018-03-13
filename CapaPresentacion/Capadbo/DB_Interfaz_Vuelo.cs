using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using Objetos;
using System.ComponentModel;

namespace Capadbo
{
    public class DB_Interfaz_Vuelo
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        /// <summary>
        /// Save the connection with the database
        /// </summary>
        public DB_Interfaz_Vuelo()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
        }
        /// <summary>
        /// This method charge in the textbox the places and airports
        /// </summary>
        /// <param name="txtBuscador_Origen"></param>
        /// <param name="txtBuscador_Destino"></param>
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
                dr.Close();
                conn.Close();
            }
        }
        /// <summary>
        /// Search the fligths in the database
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <returns>And return them</returns>
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
                if (vuelo_directo.pais_origen.Equals(pais_or) && vuelo_directo.pais_destino.Equals(pais_des) || vuelo_directo.pais_origen.Equals(pais_des) && vuelo_directo.pais_destino.Equals(pais_or))
                {
                    lista_vuelos.Add(vuelo_directo);
                }
            }
            foreach (Vuelo vuelo_escal in lista)
            {
                if (vuelo_escal.pais_origen.Equals(pais_or) || vuelo_escal.pais_origen.Equals(pais_des))
                {
                    foreach (Vuelo vuelo_escala in lista)
                    {
                        if (vuelo_escal.pais_origen.Equals(pais_or) && vuelo_escal.pais_destino.Equals(vuelo_escala.pais_origen) && vuelo_escala.pais_destino.Equals(pais_des) ||
                            vuelo_escal.pais_origen.Equals(pais_des) && vuelo_escal.pais_destino.Equals(vuelo_escala.pais_origen) && vuelo_escala.pais_destino.Equals(pais_or))
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
        /// <summary>
        /// Search the hotels in the database
        /// </summary>
        /// <param name="ciudad"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return them</returns>
        public List<Hotel> Cargar_Buscar_HotelesCiudad(string ciudad, int habitaciones)
        {
            List<Hotel> lista_hoteles = new List<Hotel>();
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT ho.id_hotel, pa.nombre_pais, lu.nombre, ho.nombre_hotel,ho.foto_hotel, ho.habitaciones, th.precio, COALESCE((SELECT AVG(pu.puntuacion) FROM puntuacion AS pu WHERE pu.id_hotelfk = ho.id_hotel),0) AS puntuacion " +
                    "FROM hoteles AS ho INNER JOIN tarifas_hoteles AS th ON ho.preciohab_fk = th.id_tarifa " +
                    "INNER JOIN lugares AS lu ON ho.lugar_fk = lu.id_lugar " +
                    "INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk WHERE lu.nombre LIKE '%" + ciudad + "%' AND ho.habitaciones >= " + habitaciones + " ORDER BY puntuacion DESC;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Hotel hotel_ = new Hotel(dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetInt32(5),
                            dr.GetInt32(6),
                            dr.GetInt32(7));
                        lista_hoteles.Add(hotel_);
                    }

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fre" + ex);
                dr.Close();
                conn.Close();
            }
            return lista_hoteles;
        }
        /// <summary>
        /// Search the hotels in the database
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return them</returns>
        public List<Hotel> Cargar_Buscar_Hoteles(string hotel, int habitaciones)
        {
            List<Hotel> lista_hoteles = new List<Hotel>();
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT ho.id_hotel, pa.nombre_pais, lu.nombre, ho.nombre_hotel,ho.foto_hotel, ho.habitaciones, th.precio, COALESCE((SELECT AVG(pu.puntuacion) FROM puntuacion AS pu WHERE pu.id_hotelfk = ho.id_hotel),0) AS puntuacion " +
                    "FROM hoteles AS ho INNER JOIN tarifas_hoteles AS th ON ho.preciohab_fk = th.id_tarifa " +
                    "INNER JOIN lugares AS lu ON ho.lugar_fk = lu.id_lugar " +
                    "INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk WHERE ho.nombre_hotel LIKE '%" + hotel + "%' AND ho.habitaciones >= " + habitaciones + " ORDER BY puntuacion DESC;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Hotel hotel_ = new Hotel(dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetInt32(5),
                            dr.GetInt32(6),
                            dr.GetInt32(7));
                        lista_hoteles.Add(hotel_);
                    }

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fre" + ex);
                dr.Close();
                conn.Close();
            }
            return lista_hoteles;
        }
        /// <summary>
        /// Save a travel reservation with a hotel
        /// </summary>
        /// <param name="compra_reserva"></param>
        /// <returns></returns>
        public bool Agregar_Compra_Reserva(Compra_Reserva compra_reserva)
        {
            bool compra_reserv = false;
            try
            {
                if (compra_reserva.hotel_cod == "null")
                {
                    if (compra_reserva.reserva_compra)
                    {
                        InsertCompraSinHotel(compra_reserva);
                    }
                    else
                    {
                        InsertReservaSinHotel(compra_reserva);
                    }
                }
                else
                {
                    if (compra_reserva.reserva_compra)
                    {
                        InsertCompraHotel(compra_reserva);
                    }
                    else
                    {
                        InsertReservaHotel(compra_reserva);
                    }
                }
                compra_reserv = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                compra_reserv = false;
            }
            
            return compra_reserv;
        }
        /// <summary>
        /// Save a purchase with a hotel
        /// </summary>
        /// <param name="compra_reserva"></param>
        private void InsertCompraHotel(Compra_Reserva compra_reserva)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO reservas_compras(cedulafk, pais_origenfk, pais_destinofk, idpais_escalafk, duracion, precio_vuelo," +
                    " fecha_inicio, fecha_final, adultos, ninos, habitaciones, id_hotelfk, id_vehiculofk, reser_comp, precio_vehiculo, precio_hotel)" +
                    " VALUES (" + compra_reserva.id_usuario + "," +
                    "" + compra_reserva.pais_origen_cod + "," +
                    "" + compra_reserva.pais_destino_cod + "," +
                    "" + compra_reserva.pais_escala + "," +
                    "" + compra_reserva.duracion + "," +
                    "" + compra_reserva.precio_vuelo + "," +
                    "'" + compra_reserva.fecha_inicio + "'," +
                    "'" + compra_reserva.fecha_final + "'," +
                    "" + compra_reserva.adultos + "," +
                    "" + compra_reserva.ninos + "," +
                    "" + compra_reserva.habitaciones + "," +
                    "" + compra_reserva.hotel_cod + "," +
                    "" + compra_reserva.vehiculo_cod + "," +
                    "true," +
                    "" + compra_reserva.precio_vehiculo + "," +
                    "" + compra_reserva.precio_hotel + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
            }
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO puntuacion(cedulafk, id_hotelfk, puntuacion) VALUES(" + compra_reserva.id_usuario + "," + compra_reserva.hotel_cod + ", " + compra_reserva.puntuacion + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Save a travel reservation without a hotel
        /// </summary>
        /// <param name="compra_reserva"></param>
        private void InsertReservaHotel(Compra_Reserva compra_reserva)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO reservas_compras(cedulafk, pais_origenfk, pais_destinofk, idpais_escalafk, duracion, precio_vuelo," +
                    " fecha_inicio, fecha_final, adultos, ninos, habitaciones, id_hotelfk, id_vehiculofk, reser_comp, precio_vehiculo, precio_hotel)" +
                    " VALUES (" + compra_reserva.id_usuario + "," +
                    "" + compra_reserva.pais_origen_cod + "," +
                    "" + compra_reserva.pais_destino_cod + "," +
                    "" + compra_reserva.pais_escala + "," +
                    "" + compra_reserva.duracion + "," +
                    "" + compra_reserva.precio_vuelo + "," +
                    "'" + compra_reserva.fecha_inicio + "'," +
                    "'" + compra_reserva.fecha_final + "'," +
                    "" + compra_reserva.adultos + "," +
                    "" + compra_reserva.ninos + "," +
                    "" + compra_reserva.habitaciones + "," +
                    "" + compra_reserva.hotel_cod + "," +
                    "" + compra_reserva.vehiculo_cod + "," +
                    "false," +
                    "" + compra_reserva.precio_vehiculo + "," +
                    "" + compra_reserva.precio_hotel + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Bajar_Cantidades(compra_reserva);
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Save a purchase without a hotel
        /// </summary>
        /// <param name="compra_reserva"></param>
        private void InsertCompraSinHotel(Compra_Reserva compra_reserva)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO reservas_compras(cedulafk, pais_origenfk, pais_destinofk, idpais_escalafk, duracion, precio_vuelo," +
                    " fecha_inicio, fecha_final, adultos, ninos, habitaciones, id_hotelfk, id_vehiculofk, reser_comp, precio_vehiculo, precio_hotel)" +
                    " VALUES (" + compra_reserva.id_usuario + "," +
                    "" + compra_reserva.pais_origen_cod + "," +
                    "" + compra_reserva.pais_destino_cod + "," +
                    "" + compra_reserva.pais_escala + "," +
                    "" + compra_reserva.duracion + "," +
                    "" + compra_reserva.precio_vuelo + "," +
                    "'" + compra_reserva.fecha_inicio + "'," +
                    "'" + compra_reserva.fecha_final + "'," +
                    "" + compra_reserva.adultos + "," +
                    "" + compra_reserva.ninos + "," +
                    "" + compra_reserva.habitaciones + "," +
                    "" + compra_reserva.hotel_cod + "," +
                    "" + compra_reserva.vehiculo_cod + "," +
                    "true," +
                    "" + compra_reserva.precio_vehiculo + "," +
                    "" + compra_reserva.precio_hotel + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
        /// <summary>
        /// Save a travel reservation without a hotel
        /// </summary>
        /// <param name="compra_reserva"></param>
        private void InsertReservaSinHotel(Compra_Reserva compra_reserva)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO reservas_compras(cedulafk, pais_origenfk, pais_destinofk, idpais_escalafk, duracion, precio_vuelo," +
                    " fecha_inicio, fecha_final, adultos, ninos, habitaciones, id_hotelfk, id_vehiculofk, reser_comp, precio_vehiculo, precio_hotel)" +
                    " VALUES (" + compra_reserva.id_usuario + "," +
                    "" + compra_reserva.pais_origen_cod + "," +
                    "" + compra_reserva.pais_destino_cod + "," +
                    "" + compra_reserva.pais_escala + "," +
                    "" + compra_reserva.duracion + "," +
                    "" + compra_reserva.precio_vuelo + "," +
                    "'" + compra_reserva.fecha_inicio + "'," +
                    "'" + compra_reserva.fecha_final + "'," +
                    "" + compra_reserva.adultos + "," +
                    "" + compra_reserva.ninos + "," +
                    "" + compra_reserva.habitaciones + "," +
                    "" + compra_reserva.hotel_cod + "," +
                    "" + compra_reserva.vehiculo_cod + "," +
                    "false," +
                    "" + compra_reserva.precio_vehiculo + "," +
                    "" + compra_reserva.precio_hotel + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Bajar_Cantidades(compra_reserva);
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Reduces the number of rooms and cars in the database
        /// </summary>
        /// <param name="compra_reserva"></param>
        private void Bajar_Cantidades(Compra_Reserva compra_reserva)
        {
            if (!compra_reserva.hotel_cod.Equals("null"))
            {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand("UPDATE hoteles SET habitaciones = (habitaciones - " + compra_reserva.habitaciones + ") WHERE id_hotel = " + compra_reserva.hotel_cod + "; ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    Console.WriteLine(ex.Message);
                }
            }
            if (!compra_reserva.vehiculo_cod.Equals("null"))
            {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand("UPDATE vehiculos SET cantidad_veh = (cantidad_veh - 1) WHERE id_vehiculos = " + compra_reserva.vehiculo_cod + "; ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    Console.WriteLine(ex.Message);
                }
            }

        }
        /// <summary>
        /// Search the cars in the database
        /// </summary>
        /// <param name="personas"></param>
        /// <returns>And return the cars</returns>
        public List<Vehiculos> Cargar_Vehiculos(int personas)
        {
            List<Vehiculos> lista_vehiculos = new List<Vehiculos>();
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT id_vehiculos,marca_veh,modelo_veh, capacidad_veh, precio_veh, cantidad_veh FROM vehiculos WHERE capacidad_veh >= " + personas + ";", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vehiculos vehiculo = new Vehiculos(dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetInt32(3),
                            dr.GetInt32(4),
                            dr.GetInt32(5));
                        lista_vehiculos.Add(vehiculo);
                    }

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fre" + ex);
                dr.Close();
                conn.Close();
            }
            return lista_vehiculos;
        }
        /// <summary>
        /// Search the hotels in the database
        /// </summary>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return the hotels</returns>
        public List<Hotel> Cargar_Hoteles(string lugar,int habitaciones)
        {
            int pais = 0;
            List<Hotel> lista_hoteles = new List<Hotel>();
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT pa.id_paises FROM paises AS pa INNER JOIN lugares AS lu ON lu.id_paisfk = pa.id_paises WHERE lu.nombre = '" + lugar+"'; ", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    pais = (int)dr[0];
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fre" + ex);
                dr.Close();
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT ho.id_hotel, pa.nombre_pais, lu.nombre, ho.nombre_hotel,ho.foto_hotel, ho.habitaciones, th.precio, COALESCE((SELECT AVG(pu.puntuacion) FROM puntuacion AS pu WHERE pu.id_hotelfk = ho.id_hotel),0) AS puntuacion " +
                    "FROM hoteles AS ho INNER JOIN tarifas_hoteles AS th ON ho.preciohab_fk = th.id_tarifa " +
                    "INNER JOIN lugares AS lu ON ho.lugar_fk = lu.id_lugar " +
                    "INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk WHERE pa.id_paises = " + pais + " AND ho.habitaciones >= " + habitaciones + " ORDER BY puntuacion DESC;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Hotel hotel = new Hotel(dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetInt32(5),
                            dr.GetInt32(6),
                            dr.GetInt32(7));
                        lista_hoteles.Add(hotel);
                    }
                    
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fre" + ex);
                dr.Close();
                conn.Close();
            }
            return lista_hoteles;
        }
    }
}
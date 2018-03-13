using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;
using System.Windows.Forms;
using System.Data;

namespace Capadbo
{
    public class DB_Ventana_Reservas
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        string select = "SELECT rc.id_rc, rc.cedulafk, (SELECT nombre_pais FROM paises WHERE id_paises = pais_origenfk), (SELECT nombre_pais FROM paises WHERE id_paises = pais_destinofk)," +
                "(SELECT nombre_pais FROM paises WHERE id_paises = idpais_escalafk), rc.duracion, rc.precio_vuelo," +
                "rc.fecha_inicio, rc.fecha_final, rc.adultos, rc.ninos, rc.habitaciones, rc.id_hotelfk, rc.id_vehiculofk," +
                "rc.precio_vehiculo, rc.precio_hotel FROM reservas_compras AS rc WHERE rc.reser_comp = false AND cedulafk = ";
        /// <summary>
        /// This method change the status of reservation to purchase in the database
        /// </summary>
        /// <param name="id_reserva"></param>
        /// <returns></returns>
        public bool CambiarEstado(string id_reserva)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("UPDATE reservas_compras SET reser_comp = true WHERE id_rc = " + id_reserva + ";", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }
        /// <summary>
        /// This method change the status of reservation to purchase
        /// </summary>
        /// <param name="id_hotel"></param>
        /// <param name="habitaciones"></param>
        /// <param name="cedula"></param>
        /// <param name="puntuacion"></param>
        public void CambiarHotel(string id_hotel, string habitaciones, int cedula, int puntuacion)
        {
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("INSERT INTO puntuacion(cedulafk, id_hotelfk, puntuacion) VALUES(" + cedula + "," + id_hotel + ", " + puntuacion + ");", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Subir_Cantidades_Hotel(id_hotel,habitaciones);
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
        /// <summary>
        /// This method save the connection to the database
        /// </summary>
        public DB_Ventana_Reservas()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Admin;Database=programacion");
        }
        /// <summary>
        /// This method charge a datagridview with reservations
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="cedula"></param>
        public void Cargar_Reservas(DataGridView dataGridView1,int cedula)
        {
            try
            {
                conn.Open();
                DataSet dataSet = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(select + cedula + ";", conn);
                adapter.Fill(dataSet, "Lugar");
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "Id reserva";
                dataGridView1.Columns[1].HeaderCell.Value = "Cedula";
                dataGridView1.Columns[2].HeaderCell.Value = "Origen";
                dataGridView1.Columns[3].HeaderCell.Value = "Destino";
                dataGridView1.Columns[4].HeaderCell.Value = "Escala";
                dataGridView1.Columns[5].HeaderCell.Value = "Duracion";
                dataGridView1.Columns[6].HeaderCell.Value = "Precio vuelo";
                dataGridView1.Columns[7].HeaderCell.Value = "Fecha inicio";
                dataGridView1.Columns[8].HeaderCell.Value = "Fecha final";
                dataGridView1.Columns[9].HeaderCell.Value = "Adultos";
                dataGridView1.Columns[10].HeaderCell.Value = "Niños";
                dataGridView1.Columns[11].HeaderCell.Value = "Habitaciones";
                dataGridView1.Columns[12].HeaderCell.Value = "Id hotel";
                dataGridView1.Columns[13].HeaderCell.Value = "Id vehiculo";
                dataGridView1.Columns[14].HeaderCell.Value = "Precio vehiculo";
                dataGridView1.Columns[15].HeaderCell.Value = "Precio hotel";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
            }
        }
        /// <summary>
        /// this method increases the number of rooms
        /// </summary>
        /// <param name="id_hotel"></param>
        /// <param name="habitaciones"></param>
        private void Subir_Cantidades_Hotel(string id_hotel,string habitaciones)
        {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand("UPDATE hoteles SET habitaciones = (habitaciones + " + habitaciones + ") WHERE id_hotel = " + id_hotel + "; ", conn);
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
        /// this method increases the number of cars
        /// </summary>
        /// <param name="id_vehiculo"></param>
        public void Subir_Cantidades_Vehiculo(string id_vehiculo)
        {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand("UPDATE vehiculos SET cantidad_veh = (cantidad_veh + 1) WHERE id_vehiculos = " + id_vehiculo + "; ", conn);
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
}

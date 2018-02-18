using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Capadbo
{
    public class DB_CRUD_Vehiculos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
        DataSet datos = new DataSet();

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
        /// This method search in database the information of the Vehicles
        /// </summary>
        /// /// <param name="id"></param>
        /// <returns>And return the list</returns>
        public List<object> ConsultarDatos(int id)
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from vehiculos WHERE id_vehiculos = '" + id + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetString(2));
                    lista.Add(dr.GetString(3));
                    lista.Add(dr.GetString(4));
                    lista.Add(dr.GetString(5));
                }
            }
            conexion.Close();
            return lista;
        }

        /// <summary>
        /// This method search in database all Vehicles
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar(DataGridView dataGridView1)
        {
            Conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR" + error.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            string query1 = "SELECT * from vehiculos ORDER BY id_vehiculos ASC";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query1, conexion);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Marca";
            dataGridView1.Columns[2].HeaderCell.Value = "Modelo";
            dataGridView1.Columns[3].HeaderCell.Value = "Capacidad";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio";
            dataGridView1.Columns[5].HeaderCell.Value = "Cantidad";
            conexion.Close();
        }



        /// <summary>
        /// This method insert all information of the vehicles in a database
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="capacidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public void InsertarDatos(string marca, string modelo, int capacidad, int precio, int cantidad)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO vehiculos (marca_veh,modelo_veh,capacidad_veh,precio_veh,cantidad_veh) VALUES ('" + marca + "', '" + modelo + "', '" + capacidad + "', '" + precio + "', '" + cantidad +"')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method update all information of the vehicles in a database
        /// </summary>
        /// <param name="id_vehiculo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="capacidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public void ModificarDatos(int id_vehiculo, string marca, string modelo, int capacidad, int precio, int cantidad)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca_veh = '" + marca + "', modelo_veh = '" + modelo +"', capacidad_veh = '"+ capacidad + "', precio_veh = '"+ precio + "',cantidad_veh = '"+ cantidad +"'  WHERE id_vehiculos = '" + id_vehiculo + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method delete all information of the vehicles in a database
        /// </summary>
        /// <param name="id_vehiculo"></param>
        public void EliminarDatos(int id_vehiculo)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vehiculos WHERE id_vehiculos = '" + id_vehiculo + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
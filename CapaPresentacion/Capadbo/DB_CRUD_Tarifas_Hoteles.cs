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
   public class DB_CRUD_Tarifas_Hoteles
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
        /// This method search in database the information of the hotel tariffs
        /// </summary>
        /// /// <param name="id"></param>
        /// <returns>And return the list</returns>
        public List<object> ConsultarDatos(int id)
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from tarifas_hoteles WHERE id_tarifa = '" + id + "'", conexion);
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
        /// This method search in database all hotel tariffs
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
            string query1 = "SELECT * from tarifas_hoteles ORDER BY id_tarifa ASC";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query1, conexion);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Precio de Habitacion";
            conexion.Close();
        }



        /// <summary>
        /// This method insert all information of the hotel tariffs in a database
        /// </summary>
        /// <param name="precio"></param>
        public void InsertarDatos(int precio)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO tarifas_hoteles (precio) VALUES ('" + precio + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method update all information of the hotel tariffs in a database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="precio"></param>
        public void ModificarDatos(int id, int precio)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifas_hoteles SET precio = '" + precio + "'  WHERE id_tarifa = '" + id + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method delete all information of the hotel tariffs in a database
        /// </summary>
        /// <param name="id"></param>
        public void EliminarDatos(int id)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM tarifas_hoteles WHERE id_tarifa = '" + id + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}


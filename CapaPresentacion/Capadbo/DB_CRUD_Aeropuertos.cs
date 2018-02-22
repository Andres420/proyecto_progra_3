using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

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
        /// This method search in database all airports
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar(DataGridView dataGridView1)
        {
            DataSet datos = new DataSet();

            datos.Clear();
            Conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR" + error.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
                                                                            //l.nombre
      //      string query = "SELECT a.id_aeropuerto,a.nombre_aeropuerto,a.iata,l.nombre from aeropuertos AS a ORDER BY a.id_aeropuerto "+
                      //  " INNER JOIN lugares AS l ON a.fk_idlugar = l.id_lugar ORDER BY a.id_aeropuerto;";

            string query2 = "SELECT a.id_aeropuerto,a.nombre_aeropuerto,l.nombre,a.iata from aeropuertos AS a" +
                        " INNER JOIN lugares AS l ON a.fk_idlugar = l.id_lugar ORDER BY a.id_aeropuerto;";
            try
            {
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(query2, conexion);
                datos.Tables.Clear();
                dataGridView1.Columns.Clear();
                add.Fill(datos);
                dataGridView1.DataSource = datos.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Nombre";
                dataGridView1.Columns[3].HeaderCell.Value = "IATA";
                dataGridView1.Columns[2].HeaderCell.Value = "Lugar";
               // DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
               // combo.HeaderText = "Lugar";
               // combo.Name = "Lugar";
               // ArrayList row = new ArrayList();
               
                //combo.Items.AddRange(row.ToArray());
                //dataGridView1.Columns.Add(combo); */
                conexion.Close();
               // List<object> lista = new List<Object>();
               /* lista = Combo_Lugar();
                for (int i = 0; i < lista.Count; i+=2)
                {
                    combo.Items.Add(lista[i+1]);
                }
                dataGridView1.Columns.Add(combo); */
            }
            catch
            {

            }
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
    }
}

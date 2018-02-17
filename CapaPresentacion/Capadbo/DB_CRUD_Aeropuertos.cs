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
    public class DB_CRUD_Aeropuertos
    {
        static NpgsqlConnection conexion;
        //static NpgsqlCommand cmd;
        DataSet datos = new DataSet();

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
            string query = "SELECT a.id_aeropuerto,a.nombre_aeropuerto,l.nombre,a.iata from aeropuertos AS a"
                        + " INNER JOIN lugares AS l ON a.fk_idlugar = l.id_lugar;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conexion);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Nombre";
            dataGridView1.Columns[2].HeaderCell.Value = "Lugar";
            dataGridView1.Columns[3].HeaderCell.Value = "IATA";
            conexion.Close();

        }
        public void Modificar(int cedula)
        {
        }
    }
}

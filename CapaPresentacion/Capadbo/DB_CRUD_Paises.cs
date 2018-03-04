using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Drawing;

namespace Capadbo
{
    public class DB_CRUD_Paises
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
        /// This method search in database the information of the country
        /// </summary>
        /// <returns>And return the list</returns>
        public List<object> ConsultarDatos(int id)
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from paises WHERE id_paises = '" + id + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetString(2));
                }
            }
            conexion.Close();
            return lista;
        }

        /// <summary>
        /// This method search in database all countries
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
            string query1 = "SELECT id_paises,nombre_pais from paises ORDER BY nombre_pais ASC";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query1, conexion);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Nombre";
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Bandera";
            imgCol.Name = "Bandera";
            dataGridView1.Columns.Add(imgCol);
            conexion.Close();
        }

        /// <summary>
        /// This method search in database the flags of each country
        /// </summary>
        /// <returns>And return the list of the flags</returns>
        public List<object> CargarBandera()
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT bandera from paises ORDER BY nombre_pais ASC", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                }
            }
            conexion.Close();
            return lista;
        }

        /// <summary>
        /// This method insert all information of the countries in a database
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="bandera"></param>
        public void InsertarDatos(string nombre_pais, string bandera)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO paises (nombre_pais, bandera) VALUES ('" + nombre_pais + "', '" + bandera + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method update all information of the countries in a database
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="nombre"></param>
        /// <param name="bandera"></param>
        public void ModificarDatos(int id_pais, string nombre,string bandera)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE paises SET nombre_pais = '" + nombre + "', bandera = '" + bandera + "' WHERE id_paises = '" + id_pais + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// This method delete all information of the countries in a database
        /// </summary>
        /// <param name="id_pais"></param>
        public void EliminarDatos(int id_pais)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM paises WHERE id_paises = '" + id_pais + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

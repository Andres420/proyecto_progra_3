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
            string query1 = "SELECT id_paises,nombre_pais from paises";
           // string query2 = "SELECT bandera from paises";

            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query1, conexion);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Nombre";
            //dataGridView1.Columns[2].HeaderCell.Value = "Bandera";

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Bandera";
            imgCol.Name = "Bandera";
            dataGridView1.Columns.Add(imgCol);
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // dataGridView1.CurrentRow.Cells("Bandera").Value = Image.FromFile("C:\LaCarpeta\LaImagen.jpg");

            //Image img = Image.FromFile("C:/imagenes/bandera - de - costa - rica.png");
            // object imagen = "C:/imagenes/bandera - de - costa - rica.png";
            // dataGridView1.Rows.Add(imagen);

            //String ruta = "Documents....imagen";
            //magen = Image.FromFile(ruta);


            //Agregar la imagen en la fila 1 (posición 0) columna Imagen
            //dataGridView1.Rows[0].Cells["Foto"].Value = img;

            conexion.Close();
        }

        public void InsertarDatos(string nombre_pais, string bandera)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO paises (nombre_pais, bandera) VALUES ('" + nombre_pais + "', '" + bandera + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Npgsql;

namespace CapaNegocio
{
    public class Codigo_CRUD_Lugares
    {
        string select = "SELECT id_lugar, nombre FROM lugares ORDER BY nombre ASC;";
        /// <summary>
        /// This method send the name of a place for other method
        /// </summary>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Lugar(string nombre_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool agregado = db_lugares.Agregar_Lugar(nombre_lugar);
            return agregado;
        }

        public void Cargar_Data_Grid(DataGridView dataGridView1)
        {
                DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
                NpgsqlConnection conn = db_hoteles.Conexion();
                conn.Open();
                DataSet dataSet = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(select, conn);
                adapter.Fill(dataSet, "Lugar");
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[0].HeaderCell.Value = "Identificacion Lugar";
                dataGridView1.Columns[1].HeaderCell.Value = "Nombre Lugar";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView1.Rows.RemoveAt((dataGridView1.RowCount - 1));
                conn.Close();
        }

        /// <summary>
        /// This method send information of a place for other method
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Eliminar_Lugar(int cod_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool eliminado = db_lugares.Eliminar_Lugar(cod_lugar) ;
            return eliminado;
        }
        /// <summary>
        /// This method send information of a place for other method
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Modifcar_Lugar(int cod_lugar, string nombre_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool modificado = db_lugares.Modificar_Lugar(cod_lugar , nombre_lugar);
            return modificado;
        }
    }
}

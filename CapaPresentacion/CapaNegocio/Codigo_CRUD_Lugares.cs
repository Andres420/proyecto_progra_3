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
        NpgsqlCommand cmd;
        string select = "SELECT lu.id_lugar,lu.nombre, pa.nombre_pais FROM lugares AS lu INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk ORDER BY lu.id_lugar ASC;";
        /// <summary>
        /// This method send the name of a place for other method
        /// </summary>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Lugar(string nombre_lugar,string pais)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool agregado = db_lugares.Agregar_Lugar(nombre_lugar,pais);
            return agregado;
        }
        /// <summary>
        /// This method charge the datagridview with places
        /// </summary>
        /// <param name="dataGridView1"></param>
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
                dataGridView1.Columns[2].HeaderCell.Value = "Pais";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
        }
        /// <summary>
        /// This method charge with countries the combobox
        /// </summary>
        /// <param name="cbPaises"></param>
        public void Cargar_Combobox(ComboBox cbPaises)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            NpgsqlConnection conn = db_hoteles.Conexion();
            NpgsqlDataReader dr = null;
            try
            {
                
                conn.Open();
                cmd = new NpgsqlCommand("SELECT nombre_pais FROM paises;", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbPaises.Items.Add(dr[0].ToString());
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                dr.Close();
                conn.Close();
                Console.WriteLine("asa" + ex);
            }
            
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
        public bool Modifcar_Lugar(int cod_lugar, string nombre_lugar,string nombre_pais)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool modificado = db_lugares.Modificar_Lugar(cod_lugar , nombre_lugar, nombre_pais);
            return modificado;
        }
    }
}

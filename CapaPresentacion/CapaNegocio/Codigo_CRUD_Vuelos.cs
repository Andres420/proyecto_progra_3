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
    public class Codigo_CRUD_Vuelos
    {
        string select = "SELECT id_tarifa_vuelo, ruta_fk, precio FROM tarifas_vuelos;";
        /// <summary>
        /// This method charge with flights the datagridview
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
            dataGridView1.Columns[0].HeaderCell.Value = "Identificacion Tarifa Vuelo";
            dataGridView1.Columns[1].HeaderCell.Value = "Ruta del vuelo";
            dataGridView1.Columns[2].HeaderCell.Value = "Precio";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dataGridView1.Rows.RemoveAt((dataGridView1.RowCount - 1));
            conn.Close();
        }
        /// <summary>
        /// This method charge with places the combobox
        /// </summary>
        /// <param name="cbRuta"></param>
        public void Cargar_Combos(ComboBox cbRuta)
        {
            cbRuta.Items.Clear();
            DB_Vuelos db_vuelos = new DB_Vuelos();
            List<int> list = db_vuelos.Id_Rutas();
            foreach (int ruta in list)
            {
                cbRuta.Items.Add(ruta);
            }
            cbRuta.SelectedIndex = 0;
        }
        /// <summary>
        /// This method add a new flight in the database
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="precio"></param>
        /// <returns>And return if it's save</returns>
        public bool Agregar_Vuelo(int ruta, int precio)
        {
            DB_Vuelos db_vuelos = new DB_Vuelos();
            return db_vuelos.Agregar_Vuelo(ruta, precio);
        }
        /// <summary>
        /// This method delete a fly
        /// </summary>
        /// <param name="cod_tarifa_vuelo"></param>
        /// <returns>And return a boolean if it's delete</returns>
        public bool Eliminar_Vuelo_Precio(int cod_tarifa_vuelo)
        {
            DB_Vuelos db_vuelos = new DB_Vuelos();
            return db_vuelos.Eliminar_Vuelo_Precio(cod_tarifa_vuelo);
        }
        /// <summary>
        /// This method update a fly
        /// </summary>
        /// <param name="cod_tarifa_vuelo"></param>
        /// <param name="ruta"></param>
        /// <param name="precio"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool Modificar_Vuelo_Precio(int cod_tarifa_vuelo, string ruta, string precio)
        {
            DB_Vuelos db_vuelos = new DB_Vuelos();
            return db_vuelos.Modificar_Vuelo_Precio(cod_tarifa_vuelo, ruta, precio);
        }

        public bool comparar(int ruta)
        {
            DB_Vuelos db_vuelos = new DB_Vuelos();
            return db_vuelos.Comparar_Rutas(ruta);
        }
    }
}

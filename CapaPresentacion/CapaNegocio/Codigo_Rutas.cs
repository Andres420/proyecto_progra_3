using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Objetos;
using Npgsql;
using System.Data;

namespace CapaNegocio
{
    public class Codigo_Rutas
    {
        string select = "SELECT ru.id_rutas, (SELECT nombre_pais FROM paises AS pa WHERE ru.pais_origenfk = pa.id_paises)," +
            " (SELECT nombre_pais FROM paises AS pa WHERE ru.pais_destinofk = pa.id_paises), duracion FROM rutas AS ru;";
        /// <summary>
        /// This method charge the comboboxs with countries
        /// </summary>
        /// <param name="cb_Origen"></param>
        /// <param name="cb_Destino"></param>
        public void Cargar_Combos(ComboBox cb_Origen, ComboBox cb_Destino)
        {
            DB_Rutas db_rutas = new DB_Rutas();
            List<string> paises = db_rutas.Cargar_Combos_Paises();
            if (paises.Count() > 0)
            {
                foreach (string pais in paises)
                {
                    cb_Origen.Items.Add(pais);
                    cb_Destino.Items.Add(pais);
                }
                cb_Origen.SelectedItem = 0;
                cb_Destino.SelectedItem = 0;
            }
        }
        /// <summary>
        /// This method charge the datagridview with routes
        /// </summary>
        /// <param name="dataGridView1"></param>
        public void Cargar_Data_Grid(DataGridView dataGridView1)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            NpgsqlConnection conn = db_hoteles.Conexion();
            conn.Open();
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(select, conn);
            adapter.Fill(dataSet, "Rutas");
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "Identificacion Ruta";
            dataGridView1.Columns[1].HeaderCell.Value = "Pais Origen";
            dataGridView1.Columns[2].HeaderCell.Value = "Pais Destino";
            dataGridView1.Columns[3].HeaderCell.Value = "Duracion";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }
        /// <summary>
        /// This method add a route
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="duracion"></param>
        /// <returns>And return a boolean if it's save</returns>
        public bool Agregar_Ruta(string origen, string destino, string duracion)
        {
            DB_Rutas db_rutas = new DB_Rutas();
            return db_rutas.Agregar_Rutas(origen, destino, duracion);
        }
        /// <summary>
        /// This method delete a route
        /// </summary>
        /// <param name="cod_ruta"></param>
        /// <returns>And return a boolean if it's delete</returns>
        public bool Eliminar_Ruta(int cod_ruta)
        {
            DB_Rutas db_rutas = new DB_Rutas();
            return db_rutas.Eliminar_Ruta(cod_ruta);
        }
        /// <summary>
        /// This method update a route
        /// </summary>
        /// <param name="cod_ruta"></param>
        /// <param name="pais_origen"></param>
        /// <param name="pais_destino"></param>
        /// <param name="duracion"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool ModificarRutas(int cod_ruta, string pais_origen, string pais_destino, string duracion)
        {
            DB_Rutas db_rutas = new DB_Rutas();
            return db_rutas.Modificar_Ruta(cod_ruta, pais_origen, pais_destino, duracion);
        }
    }
}

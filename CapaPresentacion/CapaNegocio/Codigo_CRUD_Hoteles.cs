using Capadbo;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace CapaNegocio
{
    public class Codigo_CRUD_Hoteles
    {
        string select = "SELECT ho.id_hotel, ho.nombre_hotel, ho.foto_hotel, pa.nombre_pais, lu.nombre, pre.precio FROM hoteles AS ho INNER JOIN lugares AS lu" +
" ON lu.id_lugar = ho.lugar_fk INNER JOIN paises AS pa ON pa.id_paises = ho.pais_fk INNER JOIN tarifas_hoteles AS pre ON pre.id_tarifa "+
" = ho.preciohab_fk;";
        /// <summary>
        /// This method charge information of the combobox of countries and places
        /// </summary>
        /// <param name="cBox_Pais"></param>
        /// <param name="cBox_Lugar"></param>
        public void Cargar_Combos(ComboBox cBox_Pais, ComboBox cBox_Lugar)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            List<string> lista_paises = db_hoteles.Info_Combo_Pais();
            foreach (string name in lista_paises)
            {
                cBox_Pais.Items.Add(name);
            }
            List<string> lista_lugar = db_hoteles.Info_Combo_Lugares();
            foreach (string name in lista_lugar)
            {
                cBox_Pais.Items.Add(name);
            }
        }
        /// <summary>
        /// This method charge all information of database in datagridview
        /// </summary>
        /// <param name="dataGridView1"></param>
        public void Cargar_Data_Grid(DataGridView dataGridView1)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            NpgsqlConnection conn = db_hoteles.Conexion();
            conn.Open();
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(select, conn);
            adapter.Fill(dataSet, "Hoteles");
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "Identificacion Hotel";
            dataGridView1.Columns[1].HeaderCell.Value = "Nombre Hotel";
            dataGridView1.Columns[2].HeaderCell.Value = "Foto Hotel";
            dataGridView1.Columns[3].HeaderCell.Value = "Pais";
            dataGridView1.Columns[4].HeaderCell.Value = "Lugar";
            dataGridView1.Columns[5].HeaderCell.Value = "Habitaciones";
            dataGridView1.Columns[6].HeaderCell.Value = "Precio";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows.RemoveAt((dataGridView1.RowCount - 1));
            conn.Close();
        }
        /// <summary>
        /// This method send the information of a hotel and insert in a database
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="imagen"></param>
        /// <param name="pais"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="costo"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Hotel(string nombre, string imagen, string pais, string lugar, string habitaciones,  string costo)
        {
            bool agregado;
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            int cod_tarifa = db_hoteles.Buscar_Tarifa(costo);
            if (cod_tarifa == 0)
            {
                cod_tarifa = db_hoteles.Agregar_Tarifa(costo);
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, pais, lugar, habitaciones, cod_tarifa);
            }
            else
            {
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, pais, lugar, habitaciones, cod_tarifa);
            }
            return agregado;
        }
    }
}

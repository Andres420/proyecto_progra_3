using Capadbo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace CapaNegocio
{
    public class Codigo_CRUD_Hoteles
    {
        string select = "SELECT ho.id_hotel, ho.nombre_hotel, lu.nombre, ho.habitaciones, pre.precio FROM hoteles AS ho INNER JOIN lugares AS lu" +
" ON lu.id_lugar = ho.lugar_fk INNER JOIN tarifas_hoteles AS pre ON pre.id_tarifa "+
" = ho.preciohab_fk ORDER BY id_hotel ASC;";
        /// <summary>
        /// This method charge information of the combobox of countries and places
        /// </summary>
        /// <param name="cBox_Lugar"></param>
        public void Cargar_Combos(ComboBox cBox_Lugar)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            List<string> lista_lugar = db_hoteles.Info_Combo_Lugares();
            foreach (string nombre_lugar in lista_lugar)
            {
                cBox_Lugar.Items.Add(nombre_lugar);
            }
        }
        /// <summary>
        /// This method search the flags of the countries
        /// </summary>
        /// <returns>And return them</returns>
        public List<object> Cargar_Bandera()
        {
            List<object> list = new List<object>();
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            NpgsqlConnection conn = db_hoteles.Conexion();
            NpgsqlDataReader dr;
            NpgsqlCommand cmd;
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand("SELECT foto_hotel FROM hoteles ORDER BY id_hotel ASC;", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetString(0));
                    }
                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                conn.Close();
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
            dataGridView1.Columns[2].HeaderCell.Value = "Lugar";
            dataGridView1.Columns[3].HeaderCell.Value = "Habitaciones";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio";
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Foto Hotel";
            imgCol.Name = "Foto Hotel";
            dataGridView1.Columns.Add(imgCol);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.Rows.RemoveAt((dataGridView1.RowCount - 1));
            conn.Close();
        }
        /// <summary>
        /// This method send the information of a hotel and insert in a database
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="imagen"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="costo"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Hotel(string nombre, string imagen, string lugar, string habitaciones,  string costo)
        {
            bool agregado;
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            int cod_tarifa = db_hoteles.Buscar_Tarifa(costo);
            if (cod_tarifa == 0)
            {
                int tarifa = db_hoteles.Agregar_Tarifa(costo);
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, lugar, habitaciones, tarifa);
            }
            else
            {
                agregado = db_hoteles.Agregar_Hotel(nombre, imagen, lugar, habitaciones, cod_tarifa);
            }
            return agregado;
        }
        /// <summary>
        /// This method update a hotel
        /// </summary>
        /// <param name="cod_hotel"></param>
        /// <param name="imagen"></param>
        /// <param name="nombre_hotel"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <param name="precio"></param>
        /// <returns>And return a boolean if it's update</returns>
        public bool Modificar_Hotel(int cod_hotel, string imagen, string nombre_hotel, string lugar, string habitaciones, string precio)
        {
            DB_CRUD_Hoteles db_hotel = new DB_CRUD_Hoteles();
            return db_hotel.Modificar_Hotel(cod_hotel, imagen,nombre_hotel,lugar,habitaciones,precio);
        }
        /// <summary>
        /// This method delete a hotel
        /// </summary>
        /// <param name="codigo_hotel"></param>
        /// <returns>And return a boolean if it's elimated</returns>
        public bool Eliminar_Hotel(int codigo_hotel)
        {
            DB_CRUD_Hoteles db_hoteles = new DB_CRUD_Hoteles();
            bool eliminado = db_hoteles.Eliminar_Hotel(codigo_hotel);
            return eliminado;
        }
        /// <summary>
        /// This method search hotels in the database
        /// </summary>
        /// <param name="codigo_hotel"></param>
        /// <returns>And return a list with them</returns>
        public List<object> Buscar_Info(string codigo_hotel)
        {
            DB_CRUD_Hoteles db_hotel = new DB_CRUD_Hoteles();
            List<object> list = db_hotel.Buscar_Hotel(codigo_hotel);
            return list;
        }
    }
}

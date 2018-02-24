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
    
    public class Codigo_Pre_Compra_Vuelo
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        string select = "SELECT * FROM vehiculos WHERE cantidad_evh > 0 AND capacidad_veh >= ";

        public void Insertar_Info_Data(DataGridView dataGridView1, int pasajeros)
        {
            DB_CRUD_Hoteles ccrud_hoteles = new DB_CRUD_Hoteles();
            conn = ccrud_hoteles.Conexion();
            conn.Open();
            cmd = new NpgsqlCommand(select,conn);
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter((select + pasajeros + ";"), conn);
            adapter.Fill(dataSet, "Vehiculos");
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "Identificacion Vehiculos";
            dataGridView1.Columns[1].HeaderCell.Value = "Marca Vehiculo";
            dataGridView1.Columns[2].HeaderCell.Value = "Modelo Vehiculo";
            dataGridView1.Columns[3].HeaderCell.Value = "Capacidad Vehiculo";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio Vehiculo";
            dataGridView1.Columns[5].HeaderCell.Value = "Cantidad Vehiculos";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows.RemoveAt((dataGridView1.RowCount - 1));
            conn.Close();
        }
    }
}

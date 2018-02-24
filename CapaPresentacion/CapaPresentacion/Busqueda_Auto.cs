using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Busqueda_Auto : Form
    {
        Pre_Compra_Vuelos pre_vuelo = null;
        int pasajeros = 0;
        int cod_vehiculo = 0;
        public Busqueda_Auto(int pasajeros, Pre_Compra_Vuelos pre_vuelo)
        {
            InitializeComponent();
            if (pasajeros > 0)
            {
                this.pasajeros = pasajeros;
                this.pre_vuelo = pre_vuelo;
                Cargar_Data_Grid();
            }
            else
            {
                MessageBox.Show("La cantidad de pasajeros es poca o es cero");
                this.Dispose();
            }
        }

        private void Cargar_Data_Grid()
        {
            dataGridView1.Columns.Clear();
            Codigo_Pre_Compra_Vuelo pcpv = new Codigo_Pre_Compra_Vuelo();
            pcpv.Insertar_Info_Data(dataGridView1, pasajeros);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            cod_vehiculo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnAgregar_Carro_Click(object sender, EventArgs e)
        {
            if (cod_vehiculo != 0)
            {
                pre_vuelo.vehiculo = cod_vehiculo;
                Cargar_Data_Grid();
                MessageBox.Show("Se ha agregado el vehiculo");
            }
            else
            {
                MessageBox.Show("Seleccione algún vehiculo");
            }
        }
    }
}

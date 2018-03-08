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
    public partial class Interfaz_Vuelos : Form
    {
        Usuario usuario;

        public Interfaz_Vuelos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Hotel();
        }

        private void spAdultos_ValueChanged(object sender, EventArgs e)
        {
            Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
            txtHabitaciones.Text = civ.Cantidad_Habitaciones(Decimal.ToInt32(spAdultos.Value), Decimal.ToInt32(spNinos.Value));
            Cambiar_Vehiculos();
        }

        private void spNinos_ValueChanged(object sender, EventArgs e)
        {
            Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
            txtHabitaciones.Text = civ.Cantidad_Habitaciones(Decimal.ToInt32(spAdultos.Value), Decimal.ToInt32(spNinos.Value));
            Cambiar_Vehiculos();
        }

        private void Interfaz_Vuelos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Interfaz_Vuelos_Load(object sender, EventArgs e)
        {
            Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
            civ.Cargar_AutoCompletar(txtOrigen, txtDestino);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtOrigen.Text.Equals(String.Empty) && !txtDestino.Text.Equals(String.Empty) && txtOrigen.Text != txtDestino.Text)
            {
                Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                civ.Buscar_Vuelos(dataAeropuertos, txtOrigen.Text.ToString(), txtDestino.Text.ToString());
            }
            else
            {
                MessageBox.Show("Rellene los espacios");
            }
            
        }

        public void Hotel()
        {
            string[] lugar = txtDestino.Text.Split(',');
            if (chbHotel.Checked && !lugar[0].Equals(String.Empty) && !txtHabitaciones.Text.Equals(String.Empty))
            {
                Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                civ.Cargar_AutoCompletar_Hoteles(dataHoteles, lugar[0], int.Parse(txtHabitaciones.Text));
            }
            else
            {
                dataHoteles.Columns.Clear();
            }
        }

        private void chbHotel_CheckedChanged(object sender, EventArgs e)
        {
            Hotel();
        }

        public void Cambiar_Vehiculos()
        {
            if (chbVehiculo.Checked)
            {
                Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                civ.Buscar_Vehiculos(dataVehiculo, (decimal.ToInt32(spAdultos.Value)+ decimal.ToInt32(spNinos.Value)));
            }
            else
            {
                dataVehiculo.Columns.Clear();
            }
        }

        private void chbVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            Cambiar_Vehiculos();
        }

    }
}

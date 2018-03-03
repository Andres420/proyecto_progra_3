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

        }

        private void spAdultos_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void spAdultos_ValueChanged(object sender, EventArgs e)
        {
            Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
            txtHabitaciones.Text = civ.Cantidad_Habitaciones(Decimal.ToInt32(spAdultos.Value), Decimal.ToInt32(spNinos.Value));
            //hacer el cambio en el vehiculo
        }

        private void spNinos_ValueChanged(object sender, EventArgs e)
        {
            Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
            txtHabitaciones.Text = civ.Cantidad_Habitaciones(Decimal.ToInt32(spAdultos.Value), Decimal.ToInt32(spNinos.Value));
            //hacer el cambio en el vehiculo
        }
    }
}

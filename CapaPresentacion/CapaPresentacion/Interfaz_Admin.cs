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

namespace CapaPresentacion
{
    public partial class Interfaz_Admin : Form
    {
        public Interfaz_Admin(Usuario usuario)
        {
            InitializeComponent();
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

        private void btnPaises_Click(object sender, EventArgs e)
        {
            CRUD_Paises paises = new CRUD_Paises();
            paises.ShowDialog();
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            CRUD_Lugares lugares = new CRUD_Lugares();
            lugares.ShowDialog();
        }

        private void btnAeropuertos_Click(object sender, EventArgs e)
        {
            CRUD_Aeropuertos aeropuertos = new CRUD_Aeropuertos();
            aeropuertos.ShowDialog();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            CRUD_Rutas rutas = new CRUD_Rutas();
            rutas.ShowDialog();
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            CRUD_Hoteles hoteles = new CRUD_Hoteles();
            hoteles.ShowDialog();
        }

        private void btnTarifa_Hoteles_Click(object sender, EventArgs e)
        {
            CRUD_Tarifas_Hoteles tarifa_hoteles = new CRUD_Tarifas_Hoteles();
            tarifa_hoteles.ShowDialog();
        }

        private void btnTarifa_Vuelos_Click(object sender, EventArgs e)
        {
            CRUD_Vuelos vuelos = new CRUD_Vuelos();
            vuelos.ShowDialog();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            CRUD_Vehiculos vehiculos = new CRUD_Vehiculos();
            vehiculos.ShowDialog();
        }
    }
}

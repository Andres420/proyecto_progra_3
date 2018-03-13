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
            this.Dispose();
            lg.ShowDialog();
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

        private void btn_Paises_Click(object sender, EventArgs e)
        {
            CRUD_Paises paises = new CRUD_Paises();
            paises.ShowDialog();
        }

        private void Interfaz_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRutas_MouseHover(object sender, EventArgs e)
        {
            this.btnRutas.BackColor = Color.Blue;
        }

        private void btnRutas_MouseLeave(object sender, EventArgs e)
        {
            this.btnRutas.BackColor = Color.DodgerBlue;
        }

        private void btn_Paises_MouseHover(object sender, EventArgs e)
        {
            this.btn_Paises.BackColor = Color.Blue;
        }

        private void btn_Paises_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Paises.BackColor = Color.DodgerBlue;
        }

        private void btnTarifa_Vuelos_MouseHover(object sender, EventArgs e)
        {
            this.btnTarifa_Vuelos.BackColor = Color.Blue;
        }

        private void btnLugares_MouseHover(object sender, EventArgs e)
        {
            this.btnLugares.BackColor = Color.Blue;
        }

        private void btnLugares_MouseLeave(object sender, EventArgs e)
        {
            this.btnLugares.BackColor = Color.DodgerBlue;
        }

        private void btnAeropuertos_MouseHover(object sender, EventArgs e)
        {
            this.btnAeropuertos.BackColor = Color.Blue;
        }

        private void btnAeropuertos_MouseLeave(object sender, EventArgs e)
        {
            this.btnAeropuertos.BackColor = Color.DodgerBlue;
        }

        private void btnHoteles_MouseHover(object sender, EventArgs e)
        {
            this.btnHoteles.BackColor = Color.Blue;
        }

        private void btnHoteles_MouseLeave(object sender, EventArgs e)
        {
            this.btnHoteles.BackColor = Color.DodgerBlue;
        }

        private void btnTarifa_Hoteles_MouseHover(object sender, EventArgs e)
        {
            this.btnTarifa_Hoteles.BackColor = Color.Blue;
        }

        private void btnTarifa_Hoteles_MouseLeave(object sender, EventArgs e)
        {
            this.btnTarifa_Hoteles.BackColor = Color.DodgerBlue;
        }

        private void btnVehiculos_MouseHover(object sender, EventArgs e)
        {
            this.btnVehiculos.BackColor = Color.Blue;
        }

        private void btnVehiculos_MouseLeave(object sender, EventArgs e)
        {
            this.btnVehiculos.BackColor = Color.DodgerBlue;
        }

        private void btnTarifa_Vuelos_MouseLeave(object sender, EventArgs e)
        {
            this.btnTarifa_Vuelos.BackColor = Color.DodgerBlue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Interfaz_Admin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            rep.ShowDialog();
        }
    }
}

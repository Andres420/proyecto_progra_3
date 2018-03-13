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
        List<Hotel> hoteles = new List<Hotel>();
        Usuario usuario;
        Hotel hotel = new Hotel(0, "", "", "", "", 1, 0, 1);
        Vehiculos vehiculo = new Vehiculos(0, "", "", 0, 0, 0);
        Vuelo aeropuerto = new Vuelo(0, "", "", "", "", 0);
        public Interfaz_Vuelos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.CenterToScreen();
            cbTipo.SelectedIndex = 0;
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
        /// <summary>
        /// This method looks for hotels
        /// </summary>
        public void Hotel()
        {
            string[] lugar = txtDestino.Text.Split(',');
            if (chbHotel.Checked && !lugar[0].Equals(String.Empty) && !txtHabitaciones.Text.Equals(String.Empty))
            {
                Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                hoteles = civ.Cargar_AutoCompletar_Hoteles(dataHoteles, lugar[0], int.Parse(txtHabitaciones.Text));

            }
            pbHotel.Image = null;
        }

        private void chbHotel_CheckedChanged(object sender, EventArgs e)
        {
            Hotel();
        }
        /// <summary>
        /// This method looks for cars
        /// </summary>
        public void Cambiar_Vehiculos()
        {
            if (chbVehiculo.Checked)
            {
                Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                civ.Buscar_Vehiculos(dataVehiculo, (decimal.ToInt32(spAdultos.Value) + decimal.ToInt32(spNinos.Value)));
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
        /// <summary>
        /// Check if is a purchase or reservation and send to the database
        /// </summary>
        /// <param name="compra_reserva"></param>
        /// <returns>A boolean for know if it is a purchase or reservation</returns>
        private bool Comprar_Reservar(bool compra_reserva)
        {
            bool comprado_reservado = false;
            string datestart = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DateTime fecha_ini = DateTime.Parse(datestart);
            string datefinal = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            DateTime fecha_fin = DateTime.Parse(datefinal);
            if (dataAeropuertos.SelectedRows.Count > 0 && chVuelo.Checked)
            {
                if (dataHoteles.SelectedRows.Count > 0 && chbHotel.Checked)
                {
                    if (dataVehiculo.SelectedRows.Count > 0 && chbVehiculo.Checked)
                    {
                        hotel = (Hotel)dataHoteles.CurrentRow.DataBoundItem;
                        aeropuerto = (Vuelo)dataAeropuertos.CurrentRow.DataBoundItem;
                        vehiculo = (Vehiculos)dataVehiculo.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            true,
                            true,
                            true,
                            compra_reserva
                            );
                        if (compra_reserva_.reserva_compra)
                        {
                            Puntuacion_Hotel ph = new Puntuacion_Hotel(compra_reserva_);
                            ph.ShowDialog();
                        }
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                    else
                    {
                        hotel = (Hotel)dataHoteles.CurrentRow.DataBoundItem;
                        aeropuerto = (Vuelo)dataAeropuertos.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            true,
                            true,
                            false,
                            compra_reserva
                            );
                        if (compra_reserva_.reserva_compra)
                        {
                            Puntuacion_Hotel ph = new Puntuacion_Hotel(compra_reserva_);
                            ph.ShowDialog();
                        }
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                }
                else
                {
                    if (dataVehiculo.SelectedRows.Count > 0 && chbVehiculo.Checked)
                    {
                        aeropuerto = (Vuelo)dataAeropuertos.CurrentRow.DataBoundItem;
                        vehiculo = (Vehiculos)dataVehiculo.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            true,
                            false,
                            true,
                            compra_reserva
                            );
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                    else
                    {
                        aeropuerto = (Vuelo)dataAeropuertos.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            true,
                            false,
                            false,
                            compra_reserva
                            );
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                }
            }
            else
            {
                if (dataHoteles.SelectedRows.Count > 0 && chbHotel.Checked)
                {
                    if (dataVehiculo.SelectedRows.Count > 0 && chbVehiculo.Checked)
                    {
                        hotel = (Hotel)dataHoteles.CurrentRow.DataBoundItem;
                        vehiculo = (Vehiculos)dataVehiculo.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            false,
                            true,
                            true,
                            compra_reserva
                            );
                        if (compra_reserva_.reserva_compra)
                        {
                            Puntuacion_Hotel ph = new Puntuacion_Hotel(compra_reserva_);
                            ph.ShowDialog();
                        }
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                }
                else
                {
                    if (dataVehiculo.SelectedRows.Count > 0 && chbVehiculo.Checked)
                    {
                        vehiculo = (Vehiculos)dataVehiculo.CurrentRow.DataBoundItem;
                        Compra_Reserva compra_reserva_ = new Compra_Reserva(0,
                            usuario.getCedula,
                            aeropuerto.pais_origen,
                            aeropuerto.pais_destino,
                            aeropuerto.escala,
                            aeropuerto.duracion,
                            aeropuerto.precio,
                            fecha_ini,
                            fecha_fin,
                            (int)spAdultos.Value,
                            (int)spNinos.Value,
                            int.Parse(txtHabitaciones.Text),
                            hotel.id_hotel,
                            hotel.precio,
                            vehiculo.id_vehiculo,
                            vehiculo.precio,
                            false,
                            false,
                            true,
                            compra_reserva
                            );
                        Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                        comprado_reservado = civ.Agregar_Compra_Reserva(compra_reserva_);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione algun vuelo o hotel o vehiculo");
                    }
                }
            }
            return comprado_reservado;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Esta seguro de la compra?", "Compra de vuelo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boton == DialogResult.OK)
            {
                DateTime fecha_ini = dateTimePicker1.Value;
                DateTime fecha_fin = dateTimePicker2.Value;
                if (fecha_ini.CompareTo(fecha_fin) == -1 || fecha_ini.CompareTo(fecha_fin) == 0)
                {
                    bool comprado = Comprar_Reservar(true);
                    if (comprado)
                    {
                        MessageBox.Show("Se ha realizado la compra\nMuchas gracias por preferirnos");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la compra");
                    }
                }
                else
                {
                    MessageBox.Show("La segunda fecha es menor");
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Esta seguro de la reserva?", "Reserva de vuelo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boton == DialogResult.OK)
            {
                DateTime fecha_ini = dateTimePicker1.Value;
                DateTime fecha_fin = dateTimePicker2.Value;
                if (fecha_ini.CompareTo(fecha_fin) == -1 || fecha_ini.CompareTo(fecha_fin) == 0)
                {
                    bool comprado = Comprar_Reservar(false);
                    if (comprado)
                    {
                        MessageBox.Show("Se ha realizado la reserva");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la reserva");
                    }
                }
                else
                {
                    MessageBox.Show("La segunda fecha es menor");
                }
            }
        }

        private void verReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Reservas vr = new Ventana_Reservas(usuario);
            vr.ShowDialog();
        }

        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            if (chbHotel.Checked)
            {
                if (cbTipo.SelectedItem.Equals("Ciudad"))
                {
                    Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                    hoteles = civ.Cargar_Buscar_HotelesCiudad(dataHoteles, txtBuscar.Text, int.Parse(txtHabitaciones.Text));
                    this.dataHoteles.Columns["foto_hotel"].Visible = false;
                    pbHotel.Image = null;
                }
                else
                {
                    Codigo_Interfaz_Vuelo civ = new Codigo_Interfaz_Vuelo();
                    hoteles = civ.Cargar_Buscar_Hotel(dataHoteles, txtBuscar.Text, int.Parse(txtHabitaciones.Text));
                    this.dataHoteles.Columns["foto_hotel"].Visible = false;
                    pbHotel.Image = null;
                }

            }
            else
            {
                MessageBox.Show("Coloque el check de agregar hotel");
            }
        }

        private void dataHoteles_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            if (grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            Sort(grid.Columns[e.ColumnIndex].Name, so);
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }
        /// <summary>
        /// This method sort the coulmns price and place of datahoteles
        /// </summary>
        /// <param name="column"></param>
        /// <param name="sortOrder"></param>
        private void Sort(string column, SortOrder sortOrder)
        {
            switch (column)
            {
                case "precio_h":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dataHoteles.DataSource = hoteles.OrderBy(x => x.precio).ToList();
                        }
                        else
                        {
                            dataHoteles.DataSource = hoteles.OrderByDescending(x => x.precio).ToList();
                        }
                        CambiarImagen();
                        break;
                    }
                case "lugar":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dataHoteles.DataSource = hoteles.OrderBy(x => x.nombre_lugar).ToList();
                        }
                        else
                        {
                            dataHoteles.DataSource = hoteles.OrderByDescending(x => x.nombre_lugar).ToList();
                        }
                        CambiarImagen();
                        break;
                    }
                case "puntuacion":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            dataHoteles.DataSource = hoteles.OrderBy(x => x.puntuacion).ToList();
                        }
                        else
                        {
                            dataHoteles.DataSource = hoteles.OrderByDescending(x => x.puntuacion).ToList();
                        }
                        CambiarImagen();
                        break;
                    }
            }

        }
        /// <summary>
        /// This method change the image of the picturebox
        /// </summary>
        public void CambiarImagen()
        {
            hotel = (Hotel)dataHoteles.CurrentRow.DataBoundItem;
            pbHotel.Image = Image.FromFile(hotel.foto_hotel);
        }

        private void dataHoteles_MouseClick_1(object sender, MouseEventArgs e)
        {
            CambiarImagen();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Objetos;

namespace CapaNegocio
{
    public class Codigo_Interfaz_Vuelo
    {
        /// <summary>
        /// This method verifies how many rooms you need
        /// </summary>
        /// <param name="adultos"></param>
        /// <param name="ninos"></param>
        /// <returns>And return the amount</returns>
        public string Cantidad_Habitaciones(int adultos, int ninos)
        {
            int habitaciones = 0;
            int personas = (adultos + ninos);
            while(true)
            {
                if (personas <= 0)
                {
                    break;
                }
                else if (personas > 0)
                {
                    habitaciones += 1;
                    personas -= 4;
                }
            }
            return habitaciones.ToString();
        }
        /// <summary>
        /// This method loads the places and airports in the textbox
        /// </summary>
        /// <param name="txtBuscador_Origen"></param>
        /// <param name="txtBuscador_Destino"></param>
        public void Cargar_AutoCompletar(TextBox txtBuscador_Origen, TextBox txtBuscador_Destino)
        {
            DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
            db_vuelo.Cargar_TextBox(txtBuscador_Origen, txtBuscador_Destino);
        }
        /// <summary>
        /// This method looks for the flight routes
        /// </summary>
        /// <param name="dataAeropuertos"></param>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        public void Buscar_Vuelos(DataGridView dataAeropuertos, string origen, string destino)
        {
            DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
            String[] origen_db = origen.Split(',');
            String[] destino_db = destino.Split(',');
            List<Vuelo> list =db_vuelo.Cargar_Vuelos(origen_db[0].ToString(),destino_db[0].ToString());
            dataAeropuertos.DataSource = list;
            if (list.Count() > 0)
            {
                dataAeropuertos.CurrentRow.Selected = false;
            }
        }
        /// <summary>
        /// This method searches for hotels
        /// </summary>
        /// <param name="dataHoteles"></param>
        /// <param name="lugar"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return the hotels</returns>
        public List<Hotel> Cargar_AutoCompletar_Hoteles(DataGridView dataHoteles, string lugar, int habitaciones)
        {
            List<Hotel> hoteles = new List<Hotel>();
            if (!lugar.Equals(String.Empty))
            {
                DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
                hoteles = db_vuelo.Cargar_Hoteles(lugar,habitaciones);
                dataHoteles.DataSource = hoteles;
                dataHoteles.Columns[dataHoteles.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
                if (hoteles.Count() > 0)
                {
                    dataHoteles.CurrentRow.Selected = false;
                }
            }
            return hoteles;
        }
        /// <summary>
        /// This method searches for cars
        /// </summary>
        /// <param name="dataVehiculo"></param>
        /// <param name="personas"></param>
        public void Buscar_Vehiculos(DataGridView dataVehiculo, int personas)
        {
            DB_Interfaz_Vuelo db_vuelo = new DB_Interfaz_Vuelo();
            List<Vehiculos> vehiculos = db_vuelo.Cargar_Vehiculos(personas);
            dataVehiculo.DataSource = vehiculos;
            if (vehiculos.Count() > 0)
            {
                dataVehiculo.CurrentRow.Selected = false;
            }
        }
        /// <summary>
        /// This method send the purchase or reservation to the database
        /// </summary>
        /// <param name="compra_reserva"></param>
        /// <returns>And it returns a boolean if it's saved</returns>
        public bool Agregar_Compra_Reserva(Compra_Reserva compra_reserva)
        {
            DB_Interfaz_Vuelo dB_Interfaz_Vuelo = new DB_Interfaz_Vuelo();
            int total = 0;
            try {
                int vuelo = int.Parse(compra_reserva.precio_vuelo);
                total = total + vuelo;
            } catch (Exception ex)
            {
            }
            try
            {
                int hotel = int.Parse(compra_reserva.precio_hotel);
                total = total + hotel;
            }
            catch (Exception ex)
            {
            }
            try
            {
                int vehiculo = int.Parse(compra_reserva.precio_vehiculo);
                total = total + vehiculo;
            }
            catch (Exception ex)
            {
            }
            MessageBox.Show("El total es de: " + total);
            return dB_Interfaz_Vuelo.Agregar_Compra_Reserva(compra_reserva);
        }
        /// <summary>
        /// This method searches for hotels using the name
        /// </summary>
        /// <param name="dataHoteles"></param>
        /// <param name="hotel"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return the hotels</returns>
        public List<Hotel> Cargar_Buscar_Hotel(DataGridView dataHoteles, string hotel, int habitaciones)
        {
            DB_Interfaz_Vuelo dB_Interfaz_Vuelo = new DB_Interfaz_Vuelo();
            List<Hotel> hoteles = dB_Interfaz_Vuelo.Cargar_Buscar_Hoteles(hotel, habitaciones);
            dataHoteles.DataSource = hoteles;
            dataHoteles.Columns[dataHoteles.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            if (hoteles.Count() > 0)
            {
                dataHoteles.CurrentRow.Selected = false;
            }
            return hoteles;
        }
        /// <summary>
        /// This method searches for hotels using the place or country
        /// </summary>
        /// <param name="dataHoteles"></param>
        /// <param name="ciudad"></param>
        /// <param name="habitaciones"></param>
        /// <returns>And return the hotels</returns>
        public List<Hotel> Cargar_Buscar_HotelesCiudad(DataGridView dataHoteles, string ciudad, int habitaciones)
        {
            DB_Interfaz_Vuelo dB_Interfaz_Vuelo = new DB_Interfaz_Vuelo();
            List<Hotel> hoteles = dB_Interfaz_Vuelo.Cargar_Buscar_HotelesCiudad(ciudad,habitaciones);
            dataHoteles.DataSource = hoteles;
            dataHoteles.Columns[dataHoteles.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            if (hoteles.Count() > 0)
            {
                dataHoteles.CurrentRow.Selected = false;
            }
            return hoteles;
        }
    }
}

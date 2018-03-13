using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Objetos;

namespace CapaNegocio
{
    public class Codigo_Ventana_Reservas
    {
        /// <summary>
        /// This method charge the datagridview with reservations
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="cedula"></param>
        public void Cargar_Data(DataGridView dataGridView1, int cedula)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.Cargar_Reservas(dataGridView1, cedula);
        }
        /// <summary>
        /// This method change the status of reservation to purchase
        /// </summary>
        /// <param name="id_reserva"></param>
        /// <returns>And return a boolean if this worked</returns>
        public bool CambiarEstado(string id_reserva)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            return dB_ventana_reservas.CambiarEstado(id_reserva);
        }
        /// <summary>
        /// This method change the rooms of hotel and set a new score in the database
        /// </summary>
        /// <param name="id_hotel"></param>
        /// <param name="habitaciones"></param>
        /// <param name="cedula"></param>
        /// <param name="puntuacion"></param>
        public void CambiarHotel(string id_hotel, string habitaciones, int cedula, int puntuacion)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.CambiarHotel(id_hotel,habitaciones,cedula,puntuacion);
        }
        /// <summary>
        /// This method change the amount of cars
        /// </summary>
        /// <param name="id_vehiculo"></param>
        public void Cambiar_Vehiculo(string id_vehiculo)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.Subir_Cantidades_Vehiculo(id_vehiculo);
        }
        /// <summary>
        /// This method delete a reservation
        /// </summary>
        /// <param name="value"></param>
        /// <returns>And return a boolean if it's eliminated</returns>
        public bool Eliminar_Reserva(string cod_reserva)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            return dB_ventana_reservas.Eliminar_Reserva(cod_reserva);
        }
    }
}

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
        public void Cargar_Data(DataGridView dataGridView1, int cedula)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.Cargar_Reservas(dataGridView1, cedula);
        }

        public bool CambiarEstado(string id_reserva)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            return dB_ventana_reservas.CambiarEstado(id_reserva);
        }

        public void CambiarHotel(string id_hotel, string habitaciones, int cedula, int puntuacion)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.CambiarHotel(id_hotel,habitaciones,cedula,puntuacion);
        }

        public void Cambiar_Vehiculo(string id_vehiculo)
        {
            DB_Ventana_Reservas dB_ventana_reservas = new DB_Ventana_Reservas();
            dB_ventana_reservas.Subir_Cantidades_Vehiculo(id_vehiculo);
        }
    }
}

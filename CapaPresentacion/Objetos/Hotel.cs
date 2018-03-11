using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Hotel
    {
        public Hotel(int id_hotel, string nombre_pais, string nombre_lugar, string nombre_hotel, string foto_hotel, int habitaciones, int precio, int puntuacion)
        {
            this.id_hotel = id_hotel;
            this.nombre_pais = nombre_pais;
            this.nombre_lugar = nombre_lugar;
            this.nombre_hotel = nombre_hotel;
            this.foto_hotel = foto_hotel;
            this.habitaciones = habitaciones;
            this.precio = precio;
            this.puntuacion = puntuacion;
        }

        public int id_hotel { get; set; }
        public string nombre_pais { get; set; }
        public string nombre_lugar { get; set; }
        public string nombre_hotel { get; set; }
        public string foto_hotel { get; set; }
        public int habitaciones { get; set; }
        public int precio { get; set; }
        public int puntuacion { get; set; }

        

        
    }
}

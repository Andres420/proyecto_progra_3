using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Pre_Compra_Vuelos
    {
        public int id_vuelo { get; set; }
        public string pais_origen { get; set; }
        public string paisdestino { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
        public int pasajeros { get; set; }
        public int vehiculo { get; set; }

        public Pre_Compra_Vuelos(int id_vuelo, string pais_origen, string paisdestino, DateTime fecha_inicio, DateTime fecha_final, int pasajeros, int vehiculo)
        {
            this.id_vuelo = id_vuelo;
            this.pais_origen = pais_origen;
            this.paisdestino = paisdestino;
            this.fecha_inicio = fecha_inicio;
            this.fecha_final = fecha_final;
            this.pasajeros = pasajeros;
            this.vehiculo = vehiculo;
        }
    }
}

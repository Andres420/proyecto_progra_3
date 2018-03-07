using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Vuelo
    {
        public Vuelo(int id_ruta, string pais_origen, string pais_destino, string escala, string duracion, int precio)
        {
            this.id_ruta = id_ruta;
            this.pais_origen = pais_origen;
            this.pais_destino = pais_destino;
            this.escala = escala;
            this.duracion = duracion;
            this.precio = precio;
        }

        public int id_ruta { get; set; }
        public string pais_origen { get; set; }
        public string pais_destino { get; set; }
        public string escala { get; set; }
        public string duracion { get; set; }
        public int precio { get; set; }
        
    }
}

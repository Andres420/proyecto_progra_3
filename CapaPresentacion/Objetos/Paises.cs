using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Paises
    {
        public int getCod_Pais { get; set; }
        public int getNombre_Origen { get; set; }
        public int getNombre_Destino { get; set; }
        public int getDuracion { get; set; }

        public Paises(int pais, int origen, int destino, int duracion)
        {
            getCod_Pais = pais;
            getNombre_Origen = origen;
            getNombre_Destino = destino;
            getDuracion = duracion;
        }
    }
}

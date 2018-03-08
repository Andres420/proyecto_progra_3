using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Vehiculos
    {
        public Vehiculos(int id_vehiculo, string marca, string modelo, int capacidad, int precio, int cantidad)
        {
            this.id_vehiculo = id_vehiculo;
            this.marca = marca;
            this.modelo = modelo;
            this.capacidad = capacidad;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int id_vehiculo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int capacidad { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
    }
}

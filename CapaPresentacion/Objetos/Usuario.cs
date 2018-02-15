using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Usuario
    {
        public int getCedula { get; set; }
        public string getClave { get; set; }
        public string getNombre { get; set; }
        public bool getTipo { get; set; }
        /// <summary>
        /// This create a user object
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <param name="tipo"></param>
        public Usuario(int cedula, string nombre, string clave, bool tipo)
        {
            getCedula = cedula;
            getClave = clave;
            getNombre = nombre;
            getTipo = tipo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadbo;
namespace CapaNegocio
{
    public class Codigo_CrearUsuario
    {
        /// <summary>
        /// This method send the information for save in database
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <returns>And it returns a Boolean if is saved or not</returns>
        public bool Guardar_Usuario(string cedula, string nombre, string clave)
        {
            DB_CrearUsuario db_cu = new DB_CrearUsuario();
            bool registrado = db_cu.Guardar_Usuario_db(cedula,nombre,clave);
            return registrado;       
        }
    }
}

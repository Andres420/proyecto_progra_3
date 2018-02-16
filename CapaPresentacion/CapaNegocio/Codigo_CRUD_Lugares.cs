using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_CRUD_Lugares
    {
        /// <summary>
        /// This method send the name of a place for other method
        /// </summary>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Agregar_Lugar(string nombre_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool agregado = db_lugares.Agregar_Lugar(nombre_lugar);
            return agregado;
        }
        /// <summary>
        /// This method send information of a place for other method
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Eliminar_Lugar(int cod_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool eliminado = db_lugares.Eliminar_Lugar(cod_lugar) ;
            return eliminado;
        }
        /// <summary>
        /// This method send information of a place for other method
        /// </summary>
        /// <param name="cod_lugar"></param>
        /// <param name="nombre_lugar"></param>
        /// <returns>And return a boolean</returns>
        public bool Modifcar_Lugar(int cod_lugar, string nombre_lugar)
        {
            DB_CRUD_Lugares db_lugares = new DB_CRUD_Lugares();
            bool modificado = db_lugares.Modificar_Lugar(cod_lugar , nombre_lugar);
            return modificado;
        }
    }
}

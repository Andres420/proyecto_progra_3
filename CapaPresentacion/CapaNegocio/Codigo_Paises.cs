using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_Paises
    {

        /// <summary>
        /// This method charge the the information of the country in textbox
        /// </summary>
        /// <returns>And return a list</returns>
        public List<object> Consulta_Datos(int id)
        {
            List<object> lista = new List<object>();
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            lista = a.ConsultarDatos(id);
            return lista;
        }

        /// <summary>
        /// This method charge all information of database in datagridview
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar_Grid(DataGridView dataGridView)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.Cargar(dataGridView);
        }

        /// <summary>
        /// This method send the information of the flags
        /// </summary>
        /// <returns>And return a list</returns>
        public List<object> Cargar_Bandera()
        {
            List<object> lista = new List<object>();
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            lista = a.CargarBandera();
            return lista;
        }

        /// <summary>
        /// This method send the information of the country and insert in a database
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="bandera"></param>
        public void Agregar_Registro(string nombre, string bandera)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.InsertarDatos(nombre, bandera);
        }

        /// <summary>
        /// This method change the information of the country in a database
        /// </summary>
        /// <param name="id_pais"></param>
        /// <param name="nombre"></param>
        /// <param name="bandera"></param>
        public void ModificarDatos(int id_pais, string nombre, string bandera)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.ModificarDatos(id_pais, nombre, bandera);
        }

        /// <summary>
        /// This method delete the information of the country in a database
        /// </summary>
        /// <param name="id_pais"></param>
        public void EliminarDatos(int id_pais)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.EliminarDatos(id_pais);
        }



    }
}

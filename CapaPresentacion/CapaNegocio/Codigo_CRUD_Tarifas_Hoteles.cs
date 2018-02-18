using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_CRUD_Tarifas_Hoteles
    {
        /// <summary>
        /// This method charge the the information of the hotel tariffs in textbox
        /// </summary>
        /// /// <param name="id"></param>
        /// <returns>And return a list</returns>
        public List<object> Consulta_Datos(int id)
        {
            List<object> lista = new List<object>();
            DB_CRUD_Tarifas_Hoteles a = new DB_CRUD_Tarifas_Hoteles();
            lista = a.ConsultarDatos(id);
            return lista;
        }

        /// <summary>
        /// This method charge all information of database in datagridview
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar_Grid(DataGridView dataGridView)
        {
            DB_CRUD_Tarifas_Hoteles a = new DB_CRUD_Tarifas_Hoteles();
            a.Cargar(dataGridView);
        }

        /// <summary>
        /// This method send the information of the hotel tariffs and insert in a database
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="capacidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public void Agregar_Registro(int precio)
        {
            DB_CRUD_Tarifas_Hoteles a = new DB_CRUD_Tarifas_Hoteles();
            a.InsertarDatos(precio);
        }

        /// <summary>
        /// This method change the information of the hotel tariffs in a database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="precio"></param>
        public void ModificarDatos(int id, int precio)
        {
            DB_CRUD_Tarifas_Hoteles a = new DB_CRUD_Tarifas_Hoteles();
            a.ModificarDatos(id, precio);
        }

        /// <summary>
        /// This method delete the information of the hotel tariffs in a database
        /// </summary>
        /// <param name="id"></param>
        public void EliminarDatos(int id)
        {
            DB_CRUD_Tarifas_Hoteles a = new DB_CRUD_Tarifas_Hoteles();
            a.EliminarDatos(id);
        }
    }
}

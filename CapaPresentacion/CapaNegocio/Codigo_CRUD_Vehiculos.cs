using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_CRUD_Vehiculos
    {
        /// <summary>
        /// This method charge the the information of the vehicles in textbox
        /// </summary>
        /// /// <param name="id"></param>
        /// <returns>And return a list</returns>
        public List<object> Consulta_Datos(int id)
        {
            List<object> lista = new List<object>();
            DB_CRUD_Vehiculos a = new DB_CRUD_Vehiculos();
            lista = a.ConsultarDatos(id);
            return lista;
        }

        /// <summary>
        /// This method charge all information of database in datagridview
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar_Grid(DataGridView dataGridView)
        {
            DB_CRUD_Vehiculos a = new DB_CRUD_Vehiculos();
            a.Cargar(dataGridView);
        }

        /// <summary>
        /// This method send the information of the vehicles and insert in a database
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="capacidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public void Agregar_Registro(string marca, string modelo, int capacidad, int precio, int cantidad)
        {
            DB_CRUD_Vehiculos a = new DB_CRUD_Vehiculos();
            a.InsertarDatos(marca, modelo,capacidad,precio,capacidad);
        }

        /// <summary>
        /// This method change the information of the vehicles in a database
        /// </summary>
        /// <param name="id_vehiculo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="capacidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public void ModificarDatos(int id_vehiculo, string marca, string modelo, int capacidad, int precio, int cantidad)
        {
            DB_CRUD_Vehiculos a = new DB_CRUD_Vehiculos();
            a.ModificarDatos(id_vehiculo,marca, modelo, capacidad, precio, capacidad);
        }

        /// <summary>
        /// This method delete the information of the vehicles in a database
        /// </summary>
        /// <param name="id_vehiculo"></param>
        public void EliminarDatos(int id_vehiculo)
        {
            DB_CRUD_Vehiculos a = new DB_CRUD_Vehiculos();
            a.EliminarDatos(id_vehiculo);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;

namespace CapaNegocio
{
    public class Codigo_CRUD_Aeropuertos
    {
        /// <summary>
        /// This method charge all information of database in datagridview
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Cargar_buscar(DataGridView dataGridView)
        {
            DB_CRUD_Aeropuertos carg = new DB_CRUD_Aeropuertos();
            carg.Cargar(dataGridView);
        }

        /// <summary>
        /// This method send the information of the airports and insert in a database
        /// </summary>
        /// <param name="nombre_aeropuerto"></param>
        /// <param name="fk_idlugar"></param>
        /// <param name="iata"></param>
        public bool Agregar_Registro(string nombre_aeropuerto, int fk_idlugar, string iata)
        {
            DB_CRUD_Aeropuertos ca = new DB_CRUD_Aeropuertos();
            bool guardado = ca.InsertarDatos(nombre_aeropuerto,fk_idlugar,iata);
            return guardado;
        }

        /// <summary>
        /// This method change the information of the airports in a database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre_aeropuerto"></param>
        /// <param name="fk_idlugar"></param>
        /// <param name="iata"></param>
        public void ModificarDatos(int id, string nombre_aeropuerto, int fk_idlugar, string iata)
        {
            DB_CRUD_Aeropuertos ca = new DB_CRUD_Aeropuertos();
            ca.ModificarDatos(id, nombre_aeropuerto, fk_idlugar, iata);
        }

        /// <summary>
        /// This method delete the information of the airports in a database
        /// </summary>
        /// <param name="id"></param>
        public void EliminarDatos(int id)
        {
            DB_CRUD_Aeropuertos ca = new DB_CRUD_Aeropuertos();
            ca.EliminarDatos(id);
        }

        public List<object> Cargar_Combo_Lugar()
        {
            DB_CRUD_Aeropuertos ca = new DB_CRUD_Aeropuertos();
            List<object> lista = ca.Combo_Lugar();
            return lista;
        }
    }
}

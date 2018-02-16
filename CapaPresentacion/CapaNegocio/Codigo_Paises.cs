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
        public void Cargar_Grid(DataGridView dataGridView)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.Cargar(dataGridView);
        }

        public void Agregar_Registro(string nombre, string bandera)
        {
            DB_CRUD_Paises a = new DB_CRUD_Paises();
            a.InsertarDatos(nombre, bandera);
        }
    }
}

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
        public void Cargar_buscar(DataGridView dataGridView)
        {
            DB_CRUD_Aeropuertos carg = new DB_CRUD_Aeropuertos();
            carg.Cargar(dataGridView);
        }
    }
}

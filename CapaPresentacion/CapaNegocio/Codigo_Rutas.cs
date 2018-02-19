using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capadbo;
using Objetos;

namespace CapaNegocio
{
    public class Codigo_Rutas
    {
        public void Cargar_Combos(ComboBox cb_Origen, ComboBox cb_Destino)
        {
            DB_Rutas db_rutas = new DB_Rutas();
            List<string> paises = db_rutas.Cargar_Combos_Paises();
            if (paises.Count() > 0)
            {
                foreach (string pais in paises)
                {
                    cb_Origen.Items.Add(pais);
                    cb_Destino.Items.Add(pais);
                }
                cb_Origen.SelectedItem = 0;
                cb_Destino.SelectedItem = 0;
            }
        }
    }
}

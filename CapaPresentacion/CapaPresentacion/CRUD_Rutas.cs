using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CRUD_Rutas : Form
    {
        public CRUD_Rutas()
        {
            InitializeComponent();
            Cargar_Combos();
            Cargar_Data_Grid();
        }

        private void Cargar_Data_Grid()
        {
            throw new NotImplementedException();
        }

        private void Cargar_Combos()
        {
            Codigo_Rutas cr = new Codigo_Rutas();
            cr.Cargar_Combos(cb_Origen,cb_Destino);
        }
    }
}

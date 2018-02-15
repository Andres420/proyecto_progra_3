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
    public partial class CRUD_Aeropuertos : Form
    {
        public CRUD_Aeropuertos()
        {
            InitializeComponent();
        }

        private void CRUD_Aeropuertos_Load(object sender, EventArgs e)
        {
            Cargar_datagrid();
        }

        public void Cargar_datagrid()
        {
            Codigo_CRUD_Aeropuertos cargar = new Codigo_CRUD_Aeropuertos();
            cargar.Cargar_buscar(dataGridView1);
        }
    }
}

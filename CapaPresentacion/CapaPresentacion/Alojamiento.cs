using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;

namespace CapaPresentacion
{
    public partial class Alojamiento : Form
    {
        Usuario usuario;
        public Alojamiento(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Alojamiento_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Interfaz_Usuario : Form
    {
        Usuario usuario;
        public Interfaz_Usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Dispose();
        }
    }
}

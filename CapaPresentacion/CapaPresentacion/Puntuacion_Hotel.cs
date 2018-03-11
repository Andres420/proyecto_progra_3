using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Puntuacion_Hotel : Form
    {
        public Puntuacion_Hotel()
        {
            InitializeComponent();
        }

        private void btn_Votar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (r1.Checked == true)
            {
                numero = 1;
            }
            if (r2.Checked == true)
            {
                numero = 2;
            }
            if (r3.Checked == true)
            {
                numero = 3;
            }
            if (r4.Checked == true)
            {
                numero = 4;
            }
            if (r5.Checked == true)
            {
                numero = 5;
            }
            if (numero == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna opcion");
            }
            MessageBox.Show("" + numero);
        }
    }
}

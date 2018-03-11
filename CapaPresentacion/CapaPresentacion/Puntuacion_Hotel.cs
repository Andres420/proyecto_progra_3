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
    public partial class Puntuacion_Hotel : Form
    {
        Compra_Reserva cr;
        public Puntuacion_Hotel(Compra_Reserva cr)
        {
            InitializeComponent();
            this.cr = cr;

        }

        private void btn_Votar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (r1.Checked == true)
            {
                numero = 1;
                cr.puntuacion = 1;
            }
            if (r2.Checked == true)
            {
                numero = 1;
                cr.puntuacion = 2;
            }
            if (r3.Checked == true)
            {
                numero = 1;
                cr.puntuacion = 3;
            }
            if (r4.Checked == true)
            {
                numero = 1;
                cr.puntuacion = 4;
            }
            if (r5.Checked == true)
            {
                numero = 1;
                cr.puntuacion = 5;
            }
            if (numero == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna opcion");
            }
            this.Dispose();
        }
    }
}

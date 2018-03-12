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
    public partial class Puntuacion : Form
    {
        Puntuacion_obj puntuacion;
        public Puntuacion(Puntuacion_obj puntuacion)
        {
            InitializeComponent();
            this.puntuacion = puntuacion;
        }

        private void btn_Votar_Click(object sender, EventArgs e)
        {
            
            if (r1.Checked == true)
            {
                puntuacion.puntuacion = 1;
            }
            if (r2.Checked == true)
            {
                puntuacion.puntuacion = 2;
            }
            if (r3.Checked == true)
            {
                puntuacion.puntuacion = 3;
            }
            if (r4.Checked == true)
            {
                puntuacion.puntuacion = 4;
            }
            if (r5.Checked == true)
            {
                puntuacion.puntuacion = 5;
            }
            this.Dispose();
        }
    }
}

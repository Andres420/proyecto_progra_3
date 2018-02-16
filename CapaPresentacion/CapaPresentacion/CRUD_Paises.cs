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
    public partial class CRUD_Paises : Form
    {
        string direccion;
        public CRUD_Paises()
        {
            InitializeComponent();
        }

        private void Btn_Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    PBox1.Image = Image.FromFile(imagen);
                    direccion = imagen;
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido"+ ex);
            }
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            Codigo_Paises cp = new Codigo_Paises();
            cp.Agregar_Registro(Txt_Nombre1.Text,direccion);
            MessageBox.Show("Se ha agregado el registro");
        }

        public void Cargar_Dta_Grid()
        {
            Codigo_Paises cp = new Codigo_Paises();
            cp.Cargar_Grid(dataGridView1);
            String ruta1 = "C:/imagenes/Francia1.jpg";
            String ruta2 = "C:/imagenes/Japon1.jpg";
            String ruta3 = "C:/imagenes/bandera-de-costa-rica1.jpg";
            String ruta4 = "C:/imagenes/Singapur1.jpg";
            String ruta5 = "C:/imagenes/USA1.jpg";
            Image img1 = Image.FromFile(ruta1);
            Image img2 = Image.FromFile(ruta2);
            Image img3 = Image.FromFile(ruta3);
            Image img4 = Image.FromFile(ruta4);
            Image img5 = Image.FromFile(ruta5);
            //Agregar la imagen en la fila 1 (posición 0) columna Imagen
            dataGridView1.Rows[0].Cells["Bandera"].Value = img1;
            dataGridView1.Rows[1].Cells["Bandera"].Value = img2;
            dataGridView1.Rows[2].Cells["Bandera"].Value = img3;
            dataGridView1.Rows[3].Cells["Bandera"].Value = img4;
            dataGridView1.Rows[4].Cells["Bandera"].Value = img5;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void CRUD_Paises_Load(object sender, EventArgs e)
        {
            Cargar_Dta_Grid();
        }

        private void PBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CRUD_Hoteles : Form
    {
        string imagen;
        public CRUD_Hoteles()
        {
            InitializeComponent();
            Cargar_Combos();
            Cargar_Data_Grid();
        }

        private void Cargar_Data_Grid()
        {
            Codigo_CRUD_Hoteles ccrud_hoteles = new Codigo_CRUD_Hoteles();
            ccrud_hoteles.Cargar_Data_Grid(dataGridView1);
        }

        /// <summary>
        /// This method send combobox to other method
        /// </summary>
        private void Cargar_Combos()
        {
            Codigo_CRUD_Hoteles ccrud_comb = new Codigo_CRUD_Hoteles();
            //ccrud_comb.Cargar_Combos(CBox_Pais,CBox_Lugar);
            CBox_Pais.SelectedIndex = 0;
            CBox_Lugar.SelectedIndex = 0;
        }
        private void Limpiar_Ventana()
        {
            Txt_Nombre.Clear();
            Txt_Habitaciones.Clear();
            txtCosto.Clear();
        }
        private void Txt_Habitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    PBImagen.Image = Image.FromFile(imagen);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("ihenrgoebgiurl " + ex);
            }
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            Codigo_CRUD_Hoteles ccrud_hotel = new Codigo_CRUD_Hoteles();
            if (!Txt_Nombre.Text.Equals("") && !Txt_Habitaciones.Text.Equals("") && !txtCosto.Text.Equals("") && !imagen.Equals(""))
            {
                bool registrado = ccrud_hotel.Agregar_Hotel(Txt_Nombre.Text, imagen, CBox_Pais.SelectedIndex.ToString(), CBox_Lugar.SelectedIndex.ToString(), Txt_Habitaciones.Text, txtCosto.Text);
                if (registrado)
                {
                    MessageBox.Show("Se ha registrado un nuevo hotel");
                    Limpiar_Ventana();
                }
                else
                {
                    MessageBox.Show("No se puedo registrar el hotel");
                    Limpiar_Ventana();
                }
            }
            else
            {
                MessageBox.Show("Queda algún campo en blanco");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}

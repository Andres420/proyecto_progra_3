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
            ccrud_comb.Cargar_Combos(CBox_Pais,CBox_Lugar);
            CBox_Pais.SelectedIndex = 0;
            CBox_Lugar.SelectedIndex = 0;
        }
        private void Limpiar_Ventana()
        {
            Txt_Nombre.Clear();
            Txt_Habitaciones.Clear();
            Cargar_Combos();
            txtCosto.Clear();
            imagen = "";
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
                }
                else
                {
                    MessageBox.Show("No se puedo registrar el hotel");
                }
            }
            else
            {
                MessageBox.Show("Queda algún campo en blanco");
            }
            Limpiar_Ventana();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Ventana();
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            int cod_hotel = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Codigo_CRUD_Hoteles ccrud_hoteles = new Codigo_CRUD_Hoteles();
            //bool modificado = ccrud_hoteles.Modificar_Hotel(cod_hotel, Txt_Nombre, CBox_Pais.SelectedIndex,CBox_Lugar.SelectedIndex,Txt_Habitaciones.Text,txtCosto.Text);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_CRUD_Hoteles ccrud_hoteles = new Codigo_CRUD_Hoteles();
            bool eliminado = ccrud_hoteles.Eliminar_Hotel(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            if (eliminado)
            {
                MessageBox.Show("El hotel fue eliminado");
            }
            else
            {
                MessageBox.Show("El hotel no pudo ser eliminado");
            }
        }

        private void CRUD_Hoteles_Load(object sender, EventArgs e)
        {

        }
    }
}

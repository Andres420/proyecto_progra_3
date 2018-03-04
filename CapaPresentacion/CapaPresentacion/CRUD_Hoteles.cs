﻿using System;
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
        int cod_hotel = 0;
        string imagen;
        public CRUD_Hoteles()
        {
            InitializeComponent();
            Limpiar_Ventana();
        }

        public void Cargar_Data_Grid()
        {
            dataGridView1.Columns.Clear();
            Codigo_CRUD_Hoteles ccrud_hoteles = new Codigo_CRUD_Hoteles();
            ccrud_hoteles.Cargar_Data_Grid(dataGridView1);
            Cargar_Foto();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void Cargar_Foto()
        {
            Codigo_CRUD_Hoteles ccrudhotel = new Codigo_CRUD_Hoteles();
            List<object> lista = new List<object>();
            lista = ccrudhotel.Cargar_Bandera();
            String ruta1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                ruta1 = Convert.ToString(lista[i]);
                Image img1 = Image.FromFile(ruta1);
                dataGridView1.Rows[i].Cells["Foto Hotel"].Value = img1;
            }
            
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
            CBox_Pais.Items.Clear();
            CBox_Lugar.Items.Clear();
            Btn_Reg.Enabled = true;
            Btn_mod.Enabled = false;
            Btn_Limpiar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Txt_Nombre.Clear();
            Txt_Habitaciones.Clear();
            Cargar_Combos();
            txtCosto.Clear();
            imagen = "";
            PBImagen.Image = null;
            Cargar_Data_Grid();
            cod_hotel = 0;
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
                bool registrado = ccrud_hotel.Agregar_Hotel(Txt_Nombre.Text, imagen, CBox_Pais.SelectedItem.ToString(), CBox_Lugar.SelectedItem.ToString(), Txt_Habitaciones.Text, txtCosto.Text);
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
            if (!Txt_Nombre.Text.Equals(String.Empty) && !Txt_Habitaciones.Text.Equals(String.Empty) && !txtCosto.Text.Equals(String.Empty))
            {
                Codigo_CRUD_Hoteles ccrud_hoteles = new Codigo_CRUD_Hoteles();
                bool modificado = ccrud_hoteles.Modificar_Hotel(cod_hotel, imagen, Txt_Nombre.Text, CBox_Pais.SelectedItem.ToString(), CBox_Lugar.SelectedItem.ToString(), Txt_Habitaciones.Text, txtCosto.Text);
                if (modificado)
                {
                    MessageBox.Show("El hotel ha sido modificado");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el hotel");
                }
                Limpiar_Ventana();
            }
            else
            {
                MessageBox.Show("Algun campo se encuentra vacio");
            }
            
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
            Limpiar_Ventana();
        }

        private void CRUD_Hoteles_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Reg.Enabled = false;
            Btn_mod.Enabled = true;
            Btn_Limpiar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Codigo_CRUD_Hoteles ccrud_hotel = new Codigo_CRUD_Hoteles();
            List<object> list = ccrud_hotel.Buscar_Info(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cod_hotel = (int) list[0];
            Txt_Nombre.Text = (string) list[1];
            imagen = (string) list[2];
            PBImagen.Image = Image.FromFile(imagen);
            CBox_Pais.SelectedItem = list[3];
            CBox_Lugar.SelectedItem = list[4];
            Txt_Habitaciones.Text = list[5].ToString();
            txtCosto.Text = (string) list[6].ToString();
        }

        private void CRUD_Hoteles_Load_1(object sender, EventArgs e)
        {
            Limpiar_Ventana();
        }
    }
}

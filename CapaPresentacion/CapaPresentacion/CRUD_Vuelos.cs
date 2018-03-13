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
    public partial class CRUD_Vuelos : Form
    {
        int cod_tarifa_vuelo = 0;
        public CRUD_Vuelos()
        {
            InitializeComponent();
            Cargar_Combo();
            cod_tarifa_vuelo = 0;
            Cargar_Data_Grid();
        }
        /// <summary>
        /// This method charge with flights the datagridview
        /// </summary>
        private void Cargar_Data_Grid()
        {
            dataGridView1.Columns.Clear();
            Codigo_CRUD_Vuelos ccrud_vuelos = new Codigo_CRUD_Vuelos();
            ccrud_vuelos.Cargar_Data_Grid(dataGridView1);
        }
        /// <summary>
        /// This method charge with places the combobox
        /// </summary>
        private void Cargar_Combo()
        {
            Codigo_CRUD_Vuelos ccrud_vuelos = new Codigo_CRUD_Vuelos();
            ccrud_vuelos.Cargar_Combos(CBox_Ruta);
        }
        /// <summary>
        /// This method clean the textboxs and datagridview
        /// </summary>
        private void Limpiar_Ventana()
        {
            Cargar_Combo();
            Cargar_Data_Grid();
            cod_tarifa_vuelo = 0;
            txt_Precio.Clear();
            Btn_Limpiar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Reg.Enabled = true;
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Ventana();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            int ruta = Convert.ToInt32(CBox_Ruta.SelectedItem.ToString());
            Codigo_CRUD_Vuelos ccrud_vuelos = new Codigo_CRUD_Vuelos();
            bool rut = ccrud_vuelos.comparar(ruta);     
            if (!txt_Precio.Text.Equals(""))
            {
                if (rut == false)
                {
                    
                    bool agregado = ccrud_vuelos.Agregar_Vuelo(ruta, Convert.ToInt32(txt_Precio.Text));
                    if (agregado)
                    {
                        MessageBox.Show("Se ha agregado el precio a la ruta");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el precio a la ruta");
                    }
                    Limpiar_Ventana();
                }
                else
                {
                    MessageBox.Show("Esa ruta ya contiene un precio");
                }
            }
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (cod_tarifa_vuelo != 0 && !txt_Precio.Text.Equals(""))
            {
                Codigo_CRUD_Vuelos ccrud_vuelos = new Codigo_CRUD_Vuelos();
                bool modificado = ccrud_vuelos.Modificar_Vuelo_Precio(cod_tarifa_vuelo, CBox_Ruta.SelectedItem.ToString(), txt_Precio.Text);
                if (modificado)
                {
                    MessageBox.Show("Se ha modificado el precio de la ruta");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el precio de la ruta");
                }
                Limpiar_Ventana();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cod_tarifa_vuelo != 0)
            {
                Codigo_CRUD_Vuelos ccrud_vuelos = new Codigo_CRUD_Vuelos();
                bool eliminado = ccrud_vuelos.Eliminar_Vuelo_Precio(cod_tarifa_vuelo);
                if (eliminado)
                {
                    MessageBox.Show("Se ha eliminado el precio de la ruta");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el precio de la ruta");
                }
                Limpiar_Ventana();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Limpiar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Reg.Enabled = false;
            cod_tarifa_vuelo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            CBox_Ruta.SelectedItem = this.dataGridView1.CurrentRow.Cells[1].Value;
            txt_Precio.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}

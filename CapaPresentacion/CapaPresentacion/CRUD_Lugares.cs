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
    public partial class CRUD_Lugares : Form
    {
        int cod_lugar = 0;
        public CRUD_Lugares()
        {
            InitializeComponent();
            Cargar_Data_Grid();
        }
        private void Cargar_Data_Grid()
        {
            dataGridView1.Columns.Clear();
            Codigo_CRUD_Lugares ccrud_hoteles = new Codigo_CRUD_Lugares();
            ccrud_hoteles.Cargar_Data_Grid(dataGridView1);
        }
        /// <summary>
        /// This method clean the textboxs
        /// </summary>
        private void Limpiar_Ventanas()
        {
            Btn_Eliminar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Limpiar.Enabled = false;
            Btn_Reg.Enabled = true;
            Txt_Nombre.Clear();
            cod_lugar = 0;
            dataGridView1.Columns.Clear();
            Cargar_Data_Grid();
        }
        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            string nombre_lugar = Txt_Nombre.Text;
            if (!nombre_lugar.Equals(""))
            {
                Codigo_CRUD_Lugares ccrud_lugares = new Codigo_CRUD_Lugares();
                bool agregado = ccrud_lugares.Agregar_Lugar(nombre_lugar);
                if (agregado)
                {
                    MessageBox.Show("Lugar registrado");
                    Limpiar_Ventanas();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el lugar");
                    Limpiar_Ventanas();
                }
            }
            else
            {
                MessageBox.Show("Escriba en el cuadro");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Eliminar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Limpiar.Enabled = true;
            Btn_Reg.Enabled = false;
            cod_lugar = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Txt_Nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_CRUD_Lugares ccrud_lugares = new Codigo_CRUD_Lugares();
            bool eliminado = ccrud_lugares.Eliminar_Lugar(cod_lugar);
            Limpiar_Ventanas();
            if (eliminado)
            {
                MessageBox.Show("El lugar fue eliminado");
            }
            else
            {
                MessageBox.Show("El lugar no pudo ser eliminado");
            }
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (cod_lugar != 0 && !Txt_Nombre.Text.Equals(""))
            {
                Codigo_CRUD_Lugares ccrud_lugares = new Codigo_CRUD_Lugares();
                bool modificado = ccrud_lugares.Modifcar_Lugar(cod_lugar, Txt_Nombre.Text);
                Limpiar_Ventanas();
                if (modificado)
                {
                    MessageBox.Show("El lugar fue modificado");
                }
                else
                {
                    MessageBox.Show("El lugar no pudo ser modificado");
                }
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Ventanas();
        }
    }
}

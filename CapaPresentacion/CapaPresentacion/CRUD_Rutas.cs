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
    public partial class CRUD_Rutas : Form
    {
        int cod_ruta = 0;
        public CRUD_Rutas()
        {
            InitializeComponent();
            Cargar_Combos();
            Cargar_Data_Grid();
        }
        private void Limpiar_Campos()
        {
            cb_Destino.Items.Clear();
            cb_Origen.Items.Clear();
            Btn_Eliminar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Limpiar.Enabled = false;
            Btn_Reg.Enabled = true;
            Txt_Duracion.Clear();
            Cargar_Combos();
            cod_ruta = 0;
            dataGridView1.Columns.Clear();
            Cargar_Data_Grid();

        }
        private void Cargar_Data_Grid()
        {
            dataGridView1.Columns.Clear();
            Codigo_Rutas cr = new Codigo_Rutas();
            cr.Cargar_Data_Grid(dataGridView1);
        }

        private void Cargar_Combos()
        {
            Codigo_Rutas cr = new Codigo_Rutas();
            cr.Cargar_Combos(cb_Origen,cb_Destino);
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (!Txt_Duracion.Text.Equals(""))
            {
                Codigo_Rutas cr = new Codigo_Rutas();
                bool agregado = cr.Agregar_Ruta(cb_Origen.SelectedItem.ToString(), cb_Destino.SelectedItem.ToString(), Txt_Duracion.Text);
                if (agregado)
                {
                    MessageBox.Show("Ruta agregada");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la ruta");
                }
                Limpiar_Campos();
            }
            
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_Rutas c_rutas = new Codigo_Rutas();
            bool eliminado = c_rutas.Eliminar_Ruta(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
            if (eliminado)
            {
                MessageBox.Show("La ruta fue eliminada");
            }
            else
            {
                MessageBox.Show("La ruta no pudo ser eliminada");
            }
            Limpiar_Campos();
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (cod_ruta != 0 && !Txt_Duracion.Text.Equals(""))
            {
                Codigo_Rutas cr = new Codigo_Rutas();
                bool modificado = cr.ModificarRutas(cod_ruta,cb_Origen.SelectedItem.ToString(),cb_Destino.SelectedItem.ToString(),Txt_Duracion.Text);
                if (modificado)
                {
                    MessageBox.Show("Ruta modificada");
                    Limpiar_Campos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la ruta");
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Eliminar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Limpiar.Enabled = true;
            Btn_Reg.Enabled = false;
            cod_ruta = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            cb_Origen.SelectedItem = this.dataGridView1.CurrentRow.Cells[1].Value;
            cb_Destino.SelectedItem = this.dataGridView1.CurrentRow.Cells[2].Value;
            Txt_Duracion.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

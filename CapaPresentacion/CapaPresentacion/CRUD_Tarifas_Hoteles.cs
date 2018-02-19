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
    public partial class CRUD_Tarifas_Hoteles : Form
    {
        public CRUD_Tarifas_Hoteles()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            Txt_Precio.Clear();
            Btn_Limpiar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Reg.Enabled = true;
            dataGridView1.CurrentRow.Selected = false;
        }

        public void Cargar_Dta_Grid()
        {
            Codigo_CRUD_Tarifas_Hoteles ch = new Codigo_CRUD_Tarifas_Hoteles();
            dataGridView1.Columns.Clear();
            ch.Cargar_Grid(dataGridView1);
            dataGridView1.CurrentRow.Selected = false;
        }

        private void CRUD_Tarifas_Hoteles_Load(object sender, EventArgs e)
        {
            Cargar_Dta_Grid();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Precio.Clear();
            Btn_Limpiar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Reg.Enabled = true;
            dataGridView1.CurrentRow.Selected = false;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (Txt_Precio.Text == String.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_CRUD_Tarifas_Hoteles ch = new Codigo_CRUD_Tarifas_Hoteles();
                ch.Agregar_Registro(Convert.ToInt32(Txt_Precio.Text));
                MessageBox.Show("Se ha agregado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (Txt_Precio.Text == String.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_CRUD_Tarifas_Hoteles ch = new Codigo_CRUD_Tarifas_Hoteles();
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                ch.ModificarDatos(id, Convert.ToInt32(Txt_Precio.Text));
                MessageBox.Show("Se ha modificado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_CRUD_Tarifas_Hoteles ch = new Codigo_CRUD_Tarifas_Hoteles();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            ch.EliminarDatos(id);
            MessageBox.Show("Se ha eliminado el registro");
            Cargar_Dta_Grid();
            Limpiar();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Limpiar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Reg.Enabled = false;
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Codigo_CRUD_Tarifas_Hoteles ch = new Codigo_CRUD_Tarifas_Hoteles();
            List<object> lista = ch.Consulta_Datos(id);
            Txt_Precio.Text = Convert.ToString(lista[1]);
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
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

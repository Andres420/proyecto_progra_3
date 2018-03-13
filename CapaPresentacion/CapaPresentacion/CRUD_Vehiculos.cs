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
    public partial class CRUD_Vehiculos : Form
    {
        public CRUD_Vehiculos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method charge the datagrid with cars
        /// </summary>
        public void Cargar_Dta_Grid()
        {
            Codigo_CRUD_Vehiculos cv = new Codigo_CRUD_Vehiculos();
            dataGridView1.Columns.Clear();
            cv.Cargar_Grid(dataGridView1);
            //dataGridView1.CurrentRow.Selected = false;
        }

        private void CRUD_Vehiculos_Load(object sender, EventArgs e)
        {
            Cargar_Dta_Grid();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (Txt_Modelo.Text == String.Empty || Txt_Marca.Text == String.Empty || Txt_Tipo.Text == String.Empty || Txt_Cantidad.Text == String.Empty || Txt_Precio.Text == String.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_CRUD_Vehiculos cv = new Codigo_CRUD_Vehiculos();
                cv.Agregar_Registro(Txt_Marca.Text,Txt_Modelo.Text,Convert.ToInt32(Txt_Tipo.Text), Convert.ToInt32(Txt_Precio.Text), Convert.ToInt32(Txt_Cantidad.Text));
                MessageBox.Show("Se ha agregado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }
        /// <summary>
        /// This method clean the textboxs and other things
        /// </summary>
        public void Limpiar()
        {
            Txt_Cantidad.Clear();
            Txt_Marca.Clear();
            Txt_Modelo.Clear();
            Txt_Precio.Clear();
            Txt_Tipo.Clear();
            Btn_Limpiar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Reg.Enabled = true;
            dataGridView1.CurrentRow.Selected = false;
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (Txt_Modelo.Text == String.Empty || Txt_Marca.Text == String.Empty || Txt_Tipo.Text == String.Empty || Txt_Cantidad.Text == String.Empty || Txt_Precio.Text == String.Empty)
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_CRUD_Vehiculos cv = new Codigo_CRUD_Vehiculos();
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                cv.ModificarDatos(id,Txt_Marca.Text, Txt_Modelo.Text, Convert.ToInt32(Txt_Tipo.Text), Convert.ToInt32(Txt_Precio.Text), Convert.ToInt32(Txt_Cantidad.Text));
                MessageBox.Show("Se ha modificado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_CRUD_Vehiculos cv = new Codigo_CRUD_Vehiculos();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            cv.EliminarDatos(id);
            MessageBox.Show("Se ha eliminado el registro");
            Cargar_Dta_Grid();
            Limpiar();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Limpiar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Reg.Enabled = false;
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Codigo_CRUD_Vehiculos cv = new Codigo_CRUD_Vehiculos();
            List<object> lista = cv.Consulta_Datos(id);
            Txt_Marca.Text = Convert.ToString(lista[1]);
            Txt_Modelo.Text = Convert.ToString(lista[2]);
            Txt_Tipo.Text = Convert.ToString(lista[3]);
            Txt_Precio.Text = Convert.ToString(lista[4]);
            Txt_Cantidad.Text = Convert.ToString(lista[5]);
        }

        private void Txt_Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

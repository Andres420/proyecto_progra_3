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
        string direccion = "";
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
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre1.Text == String.Empty || direccion == "")
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_Paises cp = new Codigo_Paises();
                cp.Agregar_Registro(Txt_Nombre1.Text, direccion);
                MessageBox.Show("Se ha agregado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }

        public void Cargar_Dta_Grid()
        {
            Codigo_Paises cp = new Codigo_Paises();
            dataGridView1.Columns.Clear();
            cp.Cargar_Grid(dataGridView1);
            Cargar_Bandera();
            //dataGridView1.CurrentRow.Selected = false;
        }

        public void Cargar_Bandera()
        {
            Codigo_Paises cp = new Codigo_Paises();
            List<object> lista = new List<object>();
            lista = cp.Cargar_Bandera();
            String ruta1;
            for(int i= 0; i < dataGridView1.RowCount; i++ )
            {
                ruta1 = Convert.ToString(lista[i]);
                Image img1 = Image.FromFile(ruta1);
                dataGridView1.Rows[i].Cells["Bandera"].Value = img1;
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

            private void CRUD_Paises_Load(object sender, EventArgs e)
        {
            Cargar_Dta_Grid();
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre1.Text == String.Empty || direccion == "")
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Codigo_Paises cp = new Codigo_Paises();
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                cp.ModificarDatos(id, Txt_Nombre1.Text, direccion);
                MessageBox.Show("Se ha modificado el registro");
                Cargar_Dta_Grid();
                Limpiar();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Codigo_Paises cp = new Codigo_Paises();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            cp.EliminarDatos(id);
            MessageBox.Show("Se ha eliminado el registro");
            Cargar_Dta_Grid();
            Limpiar();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        public void Limpiar()
        {
            Txt_Nombre1.Clear();
            direccion = "";
            PBox1.Image = null;
            Btn_Limpiar.Enabled = false;
            Btn_mod.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Reg.Enabled = true;
            dataGridView1.CurrentRow.Selected = false;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Limpiar.Enabled = true;
            Btn_mod.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Reg.Enabled = false;
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Codigo_Paises cp = new Codigo_Paises();
            List<object> lista = cp.Consulta_Datos(id);
            Txt_Nombre1.Text = Convert.ToString(lista[1]);
            PBox1.Image = Image.FromFile(Convert.ToString(lista[2]));
            direccion = Convert.ToString(lista[2]);
        }

        private void Txt_Nombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

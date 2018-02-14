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
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtClave.Text == txtClave_Conf.Text && !txtClave.Text.Equals(""))
            {
                if (!txtCedula.Text.Equals("") && !txtNombre.Equals(""))
                {
                    Codigo_CrearUsuario ccu = new Codigo_CrearUsuario();
                    bool guardado = ccu.Guardar_Usuario(txtCedula.Text, txtNombre.Text, txtClave.Text);
                    if (guardado)
                    {
                        MessageBox.Show("Cuenta creada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la cuenta");
                        Limpiar_Ventanas();
                    }
                }
                else
                {
                    MessageBox.Show("Algunos de los campos se encuentra vacio");
                }
            }
            else
            {
                MessageBox.Show("La contraseña no es la misma");
            }
        }
        /// <summary>
        /// This method clean all textboxs
        /// </summary>
        private void Limpiar_Ventanas()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtClave.Clear();
            txtClave_Conf.Clear();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}

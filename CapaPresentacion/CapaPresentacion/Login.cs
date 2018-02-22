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
using Objetos;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Usuario cu = new Crear_Usuario();
            cu.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") && !txtClave.Text.Equals(""))
            {
                Codigo_Login cl = new Codigo_Login();
                Usuario usuario =  cl.Buscar_Usuario(txtUsuario.Text, txtClave.Text);
                if (usuario != null)
                {
                    if (usuario.getTipo)
                    {
                        //Abrir la ventana usuario
                        Console.WriteLine("usuario");
                    }
                    else
                    {
                        Interfaz_Admin ia = new Interfaz_Admin(usuario);
                        ia.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no coinciden");
                    Limpiar_Textbox();
                }
            }
            else
            {
                MessageBox.Show("Escriba en los cuadros");
            }
        }
        /// <summary>
        /// This method clean the textboxs
        /// </summary>
        private void Limpiar_Textbox()
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}

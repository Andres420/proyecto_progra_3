using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Ventana_Reservas : Form
    {
        Usuario usuario;
        public Ventana_Reservas(Usuario usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.usuario = usuario;
            CargarDataGrid();
        }
        /// <summary>
        /// This method charge the datagrid with reservations
        /// </summary>
        private void CargarDataGrid()
        {
            Codigo_Ventana_Reservas cvr = new Codigo_Ventana_Reservas();
            cvr.Cargar_Data(dataGridView1,usuario.getCedula);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            bool comprado = false;
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int total = 0;
                if(!dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals(String.Empty))
                {
                    try { total = total + (int)dataGridView1.CurrentRow.Cells[6].Value; } catch (Exception ex) { }
                }
                if(!dataGridView1.CurrentRow.Cells[14].Value.ToString().Equals(String.Empty))
                {
                    try { total = total + (int)dataGridView1.CurrentRow.Cells[14].Value; } catch (Exception ex) { }
                }
                if(!dataGridView1.CurrentRow.Cells[15].Value.ToString().Equals(String.Empty))
                {
                    try { total = total + (int)dataGridView1.CurrentRow.Cells[15].Value; } catch (Exception ex) { }
                }
                MessageBox.Show("El total es de: " + total);
                Codigo_Ventana_Reservas cvr = new Codigo_Ventana_Reservas();
                comprado = cvr.CambiarEstado(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (!dataGridView1.CurrentRow.Cells[12].Value.ToString().Equals(String.Empty))
                {
                    Console.WriteLine(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                    Puntuacion_obj puntuacion = new Puntuacion_obj(0);
                    Puntuacion ventana_puntuacion = new Puntuacion(puntuacion);
                    ventana_puntuacion.ShowDialog();
                    Console.WriteLine(puntuacion.puntuacion);
                    cvr.CambiarHotel(dataGridView1.CurrentRow.Cells[12].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString(),usuario.getCedula,puntuacion.puntuacion);
                }
                if (!dataGridView1.CurrentRow.Cells[13].Value.ToString().Equals(String.Empty))
                {
                    Console.WriteLine(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    cvr.Cambiar_Vehiculo(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                }
                if (comprado)
                {
                    MessageBox.Show("Reserva comprada");
                }
                else
                {
                    MessageBox.Show("No se pudo comprar la reserva");
                }
                CargarDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione alguna reserva");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool eliminado = false;
                Codigo_Ventana_Reservas cvr = new Codigo_Ventana_Reservas();
                eliminado = cvr.Eliminar_Reserva(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (eliminado)
                {
                    MessageBox.Show("Reserva eliminada");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la reserva");
                }
                cvr.Cargar_Data(dataGridView1, usuario.getCedula);
            }
            else
            {
                MessageBox.Show("Seleccione alguna reserva");
            }
        }
    }
}
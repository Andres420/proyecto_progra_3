using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Capadbo;
using CapaNegocio;
using Objetos;

namespace CapaPresentacion
{
    public partial class CRUD_Aeropuertos : Form
    {
        List<object> lista;
        string valor;

        string lugar_a = "";
        int fk_lug;
        string nombre_a = "";
        string iata_a = "";
        bool p = false;
        bool s = false;
        bool t = false;

        public CRUD_Aeropuertos()
        {
            InitializeComponent();
        }

        private void CRUD_Aeropuertos_Load(object sender, EventArgs e)
        {
            Cargar_datagrid(dataGridView1);
            Codigo_CRUD_Aeropuertos cargar = new Codigo_CRUD_Aeropuertos();
            lista = cargar.Cargar_Combo_Lugar();
            for (int i = 0; i < lista.Count; i += 2)
            {
               LugarA.Items.Add(lista[i + 1]);
            }
        }

        public void Cargar_datagrid(DataGridView dt)
        {
            try
            {
                Codigo_CRUD_Aeropuertos cargar = new Codigo_CRUD_Aeropuertos();
                BindingList<Aeropuertos> lista = cargar.Cargar_Grid();
                dt.DataSource = lista;
            }
            catch
            {
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    Cargar_datagrid(dataGridView1);
                    dataGridView4.Rows.Clear();
                    dataGridView4.Refresh();
                }
                catch
                {
                }         
            }
            if (tabControl1.SelectedIndex == 1)
            {
                Codigo_CRUD_Aeropuertos cargar = new Codigo_CRUD_Aeropuertos();
                lista = cargar.Cargar_Combo_Lugar();
                for (int i = 0; i < lista.Count; i += 2)
                {
                    Lugar2.Items.Add(lista[i + 1]);
                }
                Cargar_datagrid(dataGridView2);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                Cargar_datagrid(dataGridView3);
            }
        }

        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void Agregar(string val_col1, int val_col2, string val_col3)
        {
            try
            {
                Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                bool ingreso = ca.Agregar_Registro(val_col1, val_col2, val_col3);
                if (ingreso == true)
                {
                    MessageBox.Show("Se ha registrado el aeropuerto");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar, ID repetido");
                }  
            }
            catch
            {
            }
        }

        public void Eliminar(int id)
        {
            Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
            ca.EliminarDatos(id);
            MessageBox.Show("Se ha eliminado el registro");
            Cargar_datagrid(dataGridView3);
        }

        public void Modificar(int id, string nombre, int fk_idlugar, string iata)
        {
            Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
            ca.ModificarDatos(id, nombre, fk_idlugar, iata);
            MessageBox.Show("Se ha modificado el registro");
            Cargar_datagrid(dataGridView2);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar ese registro?", "Eliminar", MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    Eliminar(Convert.ToInt32(this.dataGridView3.CurrentRow.Cells[0].Value));
                    break;
                case DialogResult.No:
                    dataGridView3.CurrentRow.Selected = false;
                    break;
                case DialogResult.Cancel:
                    dataGridView3.CurrentRow.Selected = false;
                    break;
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (p == true || s == true || t == true)
            {
                try
                {
                    int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                    string nombre = Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value);
                    string lugar = Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value);
                    string iat = Convert.ToString(this.dataGridView2.CurrentRow.Cells[3].Value);
                    Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                    List<object> lista = ca.Cargar_Combo_Lugar();
                    for (int i = 0; i < lista.Count; i += 2)
                    {
                        if (Convert.ToString(lista[i + 1]) == lugar)
                        {
                            fk_lug = Convert.ToInt32(lista[i]);
                            break;
                        }
                    }
                    Modificar(id, nombre, fk_lug, iat);
                    p = false;
                    s = false;
                    t = false;
                }
                catch
                {
                }
            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.Columns[0].ReadOnly = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                p = true;
            }

            if (e.ColumnIndex == 2)
            {
                s = true;
            }

            if (e.ColumnIndex == 3)
            {
                t = true;
            }
        }
        
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            valor = dataGridView4.CurrentRow.Index.ToString();
        }

        private void dataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (valor == "0")
            {
                if (dataGridView4.CurrentCell.ColumnIndex == 0)
                {
                    nombre_a = Convert.ToString(this.dataGridView4.CurrentRow.Cells[0].Value);
                    p = true;
                }
                if (dataGridView4.CurrentCell.ColumnIndex == 1)
                {
                    lugar_a = Convert.ToString(this.dataGridView4.CurrentRow.Cells[1].Value);
                    for (int i = 0; i < lista.Count; i += 2)
                    {
                        if (Convert.ToString(lista[i + 1]) == lugar_a)
                        {
                            fk_lug = Convert.ToInt32(lista[i]);
                            break;
                        }
                    }
                    s = true;
                }
                if (dataGridView4.CurrentCell.ColumnIndex == 2)
                {
                    iata_a = Convert.ToString(this.dataGridView4.CurrentRow.Cells[2].Value);
                    t = true;
                }
                if (p == true & s == true & t == true)
                {
                    try
                    {
                        Agregar(nombre_a, fk_lug, iata_a);
                        p = false;
                        s = false;
                        t = false;
                        dataGridView4.DataSource = null;
                        dataGridView4.Rows.Clear();
                        dataGridView4.Refresh();
                        Cargar_datagrid(dataGridView1);
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                try
                {
                    MessageBox.Show("Se debe agregar solo en la primer linea");
                    dataGridView1.CurrentRow.Selected = false;
                    dataGridView4.Rows.Clear();
                    dataGridView4.Refresh();
                    p = false;
                    s = false;
                    t = false;
                }
                catch
                {               
                }
            }
        }

        private void dataGridView4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView4.CurrentCell.ColumnIndex == 0 || dataGridView4.CurrentCell.ColumnIndex == 2)
            {
                DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
                dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 1 || dataGridView2.CurrentCell.ColumnIndex == 3)
            {
                DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
                dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
            }
        }
    }
}
    

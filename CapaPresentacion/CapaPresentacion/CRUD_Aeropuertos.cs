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
    public partial class CRUD_Aeropuertos : Form
    {
        ComboBox combo;

        string combotext = "";
        int fk_lug;
        string val_col1 = "";
        string val_col2 = "";
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
        }

        public void Cargar_datagrid(DataGridView dt)
        {
            try
            {
                Codigo_CRUD_Aeropuertos cargar = new Codigo_CRUD_Aeropuertos();
                cargar.Cargar_buscar(dt);
            }
            catch
            {

            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                Cargar_datagrid(dataGridView1);
            }
            if (tabControl1.SelectedIndex == 1)
            {
                Cargar_datagrid(dataGridView2);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                Cargar_datagrid(dataGridView3);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = false;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = false;

                string valor = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                if (valor == String.Empty)
                {
                }
                else
                {
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[2].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
            }
            catch
            {
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    val_col1 = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
                }

                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    val_col2 = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);

                    if (combotext != String.Empty)
                    {
                        Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                        List<object> lista = ca.Cargar_Combo_Lugar();
                        for (int i = 0; i < lista.Count; i += 2)
                        {
                            if (Convert.ToString(lista[i + 1]) == combotext)
                            {
                                fk_lug = Convert.ToInt32(lista[i]);
                                break;
                            }
                        }
                    }

                    if (p == true & s == true & t == true)
                    {
                        Agregar(val_col1, fk_lug, val_col2);
                        p = false;
                        s = false;
                        t = false;
                        combotext = "";
                    }
                }
            }

            catch
            {

            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);

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
                dataGridView1.Columns.Clear();
                Cargar_datagrid(dataGridView1);
                dataGridView1.CurrentRow.Selected = false;
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
            //id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
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
            if (dataGridView2.CurrentCell.ColumnIndex == 1)
            {
                if (p == true)
                {

                    try
                    {
                        int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                        string lugar = Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value);
                      //  MessageBox.Show(lugar);
                        Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                        List<object> lista = ca.Cargar_Combo_Lugar();
                        for (int i = 0; i < lista.Count; i += 2)
                        {
                            if (Convert.ToString(lista[i + 1]) == lugar)
                            {
                                fk_lug = Convert.ToInt32(lista[i]);
                                // MessageBox.Show(lugar);
                                break;
                            }
                        }
                        Modificar(id, Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value), fk_lug, Convert.ToString(this.dataGridView2.CurrentRow.Cells[3].Value));
                    }
                    catch
                    {

                    }

                }
            }

            if (dataGridView2.CurrentCell.ColumnIndex == 3)
            {
                if (t == true)
                {
                    try
                    {
                        int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                        string lugar = Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value);
                       // MessageBox.Show(lugar);
                        Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                        List<object> lista = ca.Cargar_Combo_Lugar();
                        for (int i = 0; i < lista.Count; i += 2)
                        {
                            if (Convert.ToString(lista[i + 1]) == lugar)
                            {
                                fk_lug = Convert.ToInt32(lista[i]);
                                // MessageBox.Show(lugar);
                                break;
                            }
                        }
                        Modificar(id, Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value), fk_lug, Convert.ToString(this.dataGridView2.CurrentRow.Cells[3].Value));
                        p = false;
                    }
                    catch
                    {

                    }
                }

               
            }

            /* if(String.IsNullOrEmpty(combo.Text))
             {

                 MessageBox.Show("dsdsd");
                 int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

                 Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                 List<object> lista = ca.Cargar_Combo_Lugar();
                 for (int i = 0; i < lista.Count; i += 2)
                 {
                     if (Convert.ToString(lista[i + 1]) == combotext)
                     {
                         fk_lug = Convert.ToInt32(lista[i]);
                         MessageBox.Show(combotext + "" + fk_lug);
                         break;
                     }
                 }
                 Modificar(id, Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value), 1, Convert.ToString(this.dataGridView2.CurrentRow.Cells[3].Value));
             }*/

            
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.Columns[0].ReadOnly = true;
        }

        private void Combo_OnTextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = combo.Text.ToString();
        }

        private void Combo_CloseUp(object sender, EventArgs e)
        {
            combo.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                string valor = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                if (valor != String.Empty)
                {
                }
                else
                {
                    combo = new ComboBox();
                    Cargar_combo(combo);
                    dataGridView1.Controls.Add(combo);
                    Rectangle oRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    combo.Size = new Size(oRectangle.Width, oRectangle.Height);
                    combo.Location = new Point(oRectangle.X, oRectangle.Y);
                    combo.DropDownClosed += new EventHandler(Combo_CloseUp);
                    combo.TextChanged += new EventHandler(Combo_OnTextChange);
                }
            }
        }

        public void Cargar_combo(ComboBox cb)
        {
            Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
            List<object> lista = ca.Cargar_Combo_Lugar();
            for (int i = 0; i < lista.Count; i += 2)
            {
                cb.Items.Add(lista[i + 1]);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    combotext = combo.SelectedItem.ToString();

                    s = true;
                }
                catch
                {

                }
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                p = true;
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                if (combotext != String.Empty)
                {
                    combotext = combo.SelectedItem.ToString();
                }
                t = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
           //     string v_viejo = Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value);

                //string valor = Convert.ToString(this.dataGridView2.CurrentRow.Cells[0].Value);
                //   if (valor != String.Empty)
                //  {
                try
                {
                    combo = new ComboBox();
                    Cargar_combo(combo);
                    dataGridView2.Controls.Add(combo);
                    Rectangle oRectangle = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    combo.Size = new Size(oRectangle.Width, oRectangle.Height);
                    combo.Location = new Point(oRectangle.X, oRectangle.Y);
                    combo.DropDownClosed += new EventHandler(Combo_CloseUp);
                    combo.TextChanged += new EventHandler(Combo_OnTextChange);
                   // combotext = combo.SelectedItem.ToString();

                 /*   if (v_viejo != combotext)
                    {
                        MessageBox.Show("cambio");
                    }*/
                }
                catch
                {

                }

             //   combotext = combo.SelectedItem.ToString();
                //     }
                //  else
                //   {

                // }
            }
        }


        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                   // combotext = combo.SelectedItem.ToString();

                    s = true;
                }
                catch
                {

                }
            }

            if (dataGridView2.CurrentCell.ColumnIndex == 1)
            {
                p = true;
            }

            if (dataGridView2.CurrentCell.ColumnIndex == 3)
            {
              /*  if (combotext != String.Empty)
                {
                    combotext = combo.SelectedItem.ToString();
                }*/
                t = true;
            }
            /*int fk_l = 0;
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
               
                Codigo_CRUD_Aeropuertos ca = new Codigo_CRUD_Aeropuertos();
                List<object> lista = ca.Cargar_Combo_Lugar();
                for (int i = 0; i < lista.Count; i += 2)
                {
                    if (Convert.ToString(lista[i + 1]) == Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value))
                    {
                        fk_l = Convert.ToInt32(lista[i]);
                        MessageBox.Show(combotext + "" + fk_l);
                        break;
                    }
                }
                Modificar(id, Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value), fk_l, Convert.ToString(this.dataGridView2.CurrentRow.Cells[3].Value));
            }*/
        }

       
    }
}
    

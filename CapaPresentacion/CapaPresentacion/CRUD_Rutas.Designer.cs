namespace CapaPresentacion
{
    partial class CRUD_Rutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rutas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Duracion_Minutos = new System.Windows.Forms.TextBox();
            this.cb_Destino = new System.Windows.Forms.ComboBox();
            this.cb_Origen = new System.Windows.Forms.ComboBox();
            this.Txt_Duracion_Horas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_mod = new System.Windows.Forms.Button();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Rutas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pais Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pais Destino";
            // 
            // Rutas
            // 
            this.Rutas.Controls.Add(this.label6);
            this.Rutas.Controls.Add(this.label5);
            this.Rutas.Controls.Add(this.label1);
            this.Rutas.Controls.Add(this.Txt_Duracion_Minutos);
            this.Rutas.Controls.Add(this.cb_Destino);
            this.Rutas.Controls.Add(this.cb_Origen);
            this.Rutas.Controls.Add(this.Txt_Duracion_Horas);
            this.Rutas.Controls.Add(this.label4);
            this.Rutas.Controls.Add(this.label2);
            this.Rutas.Controls.Add(this.label3);
            this.Rutas.Location = new System.Drawing.Point(12, 12);
            this.Rutas.Name = "Rutas";
            this.Rutas.Size = new System.Drawing.Size(331, 222);
            this.Rutas.TabIndex = 28;
            this.Rutas.TabStop = false;
            this.Rutas.Text = "Rutas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = ":";
            // 
            // Txt_Duracion_Minutos
            // 
            this.Txt_Duracion_Minutos.Location = new System.Drawing.Point(148, 137);
            this.Txt_Duracion_Minutos.Name = "Txt_Duracion_Minutos";
            this.Txt_Duracion_Minutos.Size = new System.Drawing.Size(24, 20);
            this.Txt_Duracion_Minutos.TabIndex = 33;
            this.Txt_Duracion_Minutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Duracion_Minutos_KeyPress);
            // 
            // cb_Destino
            // 
            this.cb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Destino.FormattingEnabled = true;
            this.cb_Destino.Location = new System.Drawing.Point(102, 81);
            this.cb_Destino.Name = "cb_Destino";
            this.cb_Destino.Size = new System.Drawing.Size(121, 21);
            this.cb_Destino.TabIndex = 32;
            // 
            // cb_Origen
            // 
            this.cb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Origen.FormattingEnabled = true;
            this.cb_Origen.Location = new System.Drawing.Point(102, 33);
            this.cb_Origen.Name = "cb_Origen";
            this.cb_Origen.Size = new System.Drawing.Size(121, 21);
            this.cb_Origen.TabIndex = 31;
            // 
            // Txt_Duracion_Horas
            // 
            this.Txt_Duracion_Horas.Location = new System.Drawing.Point(102, 137);
            this.Txt_Duracion_Horas.Name = "Txt_Duracion_Horas";
            this.Txt_Duracion_Horas.Size = new System.Drawing.Size(24, 20);
            this.Txt_Duracion_Horas.TabIndex = 30;
            this.Txt_Duracion_Horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Duracion_Horas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Duracion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(17, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 183);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Rutas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Limpiar);
            this.groupBox2.Controls.Add(this.Btn_Eliminar);
            this.groupBox2.Controls.Add(this.Btn_mod);
            this.groupBox2.Controls.Add(this.Btn_Reg);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 222);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(58, 36);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 31;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(58, 157);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 30;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_mod
            // 
            this.Btn_mod.Location = new System.Drawing.Point(58, 114);
            this.Btn_mod.Name = "Btn_mod";
            this.Btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Btn_mod.TabIndex = 29;
            this.Btn_mod.Text = "Modificar";
            this.Btn_mod.UseVisualStyleBackColor = true;
            this.Btn_mod.Click += new System.EventHandler(this.Btn_mod_Click);
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(58, 74);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reg.TabIndex = 28;
            this.Btn_Reg.Text = "Registrar";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Minutos";
            // 
            // CRUD_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(557, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rutas);
            this.Name = "CRUD_Rutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.Rutas.ResumeLayout(false);
            this.Rutas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Rutas;
        private System.Windows.Forms.TextBox Txt_Duracion_Horas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_mod;
        private System.Windows.Forms.Button Btn_Reg;
        private System.Windows.Forms.ComboBox cb_Destino;
        private System.Windows.Forms.ComboBox cb_Origen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Duracion_Minutos;
        private System.Windows.Forms.Label label6;
    }
}
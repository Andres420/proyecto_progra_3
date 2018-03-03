namespace CapaPresentacion
{
    partial class Interfaz_Vuelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataAeropuertos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.chbHotel = new System.Windows.Forms.CheckBox();
            this.chbVehiculo = new System.Windows.Forms.CheckBox();
            this.dataHoteles = new System.Windows.Forms.DataGridView();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.dataVehiculo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aeropuerto de origen";
            // 
            // dataAeropuertos
            // 
            this.dataAeropuertos.AllowUserToAddRows = false;
            this.dataAeropuertos.AllowUserToDeleteRows = false;
            this.dataAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAeropuertos.Location = new System.Drawing.Point(15, 194);
            this.dataAeropuertos.Name = "dataAeropuertos";
            this.dataAeropuertos.ReadOnly = true;
            this.dataAeropuertos.Size = new System.Drawing.Size(472, 237);
            this.dataAeropuertos.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReservasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // verReservasToolStripMenuItem
            // 
            this.verReservasToolStripMenuItem.Name = "verReservasToolStripMenuItem";
            this.verReservasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verReservasToolStripMenuItem.Text = "Ver Reservas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aeropuerto de destino";
            // 
            // chbHotel
            // 
            this.chbHotel.AutoSize = true;
            this.chbHotel.Location = new System.Drawing.Point(523, 52);
            this.chbHotel.Name = "chbHotel";
            this.chbHotel.Size = new System.Drawing.Size(91, 17);
            this.chbHotel.TabIndex = 7;
            this.chbHotel.Text = "Agregar Hotel";
            this.chbHotel.UseVisualStyleBackColor = true;
            // 
            // chbVehiculo
            // 
            this.chbVehiculo.AutoSize = true;
            this.chbVehiculo.Location = new System.Drawing.Point(620, 52);
            this.chbVehiculo.Name = "chbVehiculo";
            this.chbVehiculo.Size = new System.Drawing.Size(107, 17);
            this.chbVehiculo.TabIndex = 8;
            this.chbVehiculo.Text = "Agregar Vehiculo";
            this.chbVehiculo.UseVisualStyleBackColor = true;
            // 
            // dataHoteles
            // 
            this.dataHoteles.AllowUserToAddRows = false;
            this.dataHoteles.AllowUserToDeleteRows = false;
            this.dataHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoteles.Location = new System.Drawing.Point(523, 77);
            this.dataHoteles.Name = "dataHoteles";
            this.dataHoteles.ReadOnly = true;
            this.dataHoteles.Size = new System.Drawing.Size(476, 206);
            this.dataHoteles.TabIndex = 9;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(126, 38);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(119, 20);
            this.txtOrigen.TabIndex = 10;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(368, 36);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(119, 20);
            this.txtDestino.TabIndex = 11;
            // 
            // dataVehiculo
            // 
            this.dataVehiculo.AllowUserToAddRows = false;
            this.dataVehiculo.AllowUserToDeleteRows = false;
            this.dataVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculo.Location = new System.Drawing.Point(523, 289);
            this.dataVehiculo.Name = "dataVehiculo";
            this.dataVehiculo.ReadOnly = true;
            this.dataVehiculo.Size = new System.Drawing.Size(472, 142);
            this.dataVehiculo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de llegada";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(102, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adultos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(433, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Niños";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(433, 101);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 19;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Enabled = false;
            this.txtHabitaciones.Location = new System.Drawing.Point(433, 127);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(54, 20);
            this.txtHabitaciones.TabIndex = 21;
            this.txtHabitaciones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Habitaciones";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(284, 475);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(183, 69);
            this.btnComprar.TabIndex = 22;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(473, 475);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(183, 69);
            this.btnReservar.TabIndex = 22;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // Interfaz_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 583);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataVehiculo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.dataHoteles);
            this.Controls.Add(this.chbVehiculo);
            this.Controls.Add(this.chbHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAeropuertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Enabled = false;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz_Vuelos";
            this.Text = "Interfaz Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataAeropuertos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbHotel;
        private System.Windows.Forms.CheckBox chbVehiculo;
        private System.Windows.Forms.DataGridView dataHoteles;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.DataGridView dataVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnReservar;
    }
}
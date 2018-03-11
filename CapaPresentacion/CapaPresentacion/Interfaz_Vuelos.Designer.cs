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
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.chbHotel = new System.Windows.Forms.CheckBox();
            this.chbVehiculo = new System.Windows.Forms.CheckBox();
            this.dataHoteles = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.dataVehiculo = new System.Windows.Forms.DataGridView();
            this.id_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_ve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.spAdultos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.spNinos = new System.Windows.Forms.NumericUpDown();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbHotel = new System.Windows.Forms.PictureBox();
            this.chVuelo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotel)).BeginInit();
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
            this.dataAeropuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAeropuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ruta,
            this.Pais_Origen,
            this.Pais_Destino,
            this.Escala,
            this.Duracion,
            this.Precio});
            this.dataAeropuertos.Location = new System.Drawing.Point(12, 194);
            this.dataAeropuertos.MultiSelect = false;
            this.dataAeropuertos.Name = "dataAeropuertos";
            this.dataAeropuertos.ReadOnly = true;
            this.dataAeropuertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAeropuertos.Size = new System.Drawing.Size(588, 365);
            this.dataAeropuertos.TabIndex = 2;
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "id_ruta";
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Pais_Origen
            // 
            this.Pais_Origen.DataPropertyName = "pais_origen";
            this.Pais_Origen.HeaderText = "Pais Origen";
            this.Pais_Origen.Name = "Pais_Origen";
            this.Pais_Origen.ReadOnly = true;
            // 
            // Pais_Destino
            // 
            this.Pais_Destino.DataPropertyName = "pais_destino";
            this.Pais_Destino.HeaderText = "Pais Destino";
            this.Pais_Destino.Name = "Pais_Destino";
            this.Pais_Destino.ReadOnly = true;
            // 
            // Escala
            // 
            this.Escala.DataPropertyName = "escala";
            this.Escala.HeaderText = "Escala";
            this.Escala.Name = "Escala";
            this.Escala.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "duracion";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
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
            this.verReservasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verReservasToolStripMenuItem.Text = "Ver Reservas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
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
            this.chbHotel.Location = new System.Drawing.Point(609, 54);
            this.chbHotel.Name = "chbHotel";
            this.chbHotel.Size = new System.Drawing.Size(91, 17);
            this.chbHotel.TabIndex = 7;
            this.chbHotel.Text = "Agregar Hotel";
            this.chbHotel.UseVisualStyleBackColor = true;
            this.chbHotel.CheckedChanged += new System.EventHandler(this.chbHotel_CheckedChanged);
            // 
            // chbVehiculo
            // 
            this.chbVehiculo.AutoSize = true;
            this.chbVehiculo.Location = new System.Drawing.Point(706, 54);
            this.chbVehiculo.Name = "chbVehiculo";
            this.chbVehiculo.Size = new System.Drawing.Size(107, 17);
            this.chbVehiculo.TabIndex = 8;
            this.chbVehiculo.Text = "Agregar Vehiculo";
            this.chbVehiculo.UseVisualStyleBackColor = true;
            this.chbVehiculo.CheckedChanged += new System.EventHandler(this.chbVehiculo_CheckedChanged);
            // 
            // dataHoteles
            // 
            this.dataHoteles.AllowUserToAddRows = false;
            this.dataHoteles.AllowUserToDeleteRows = false;
            this.dataHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre_pais,
            this.lugar,
            this.nombre_hotel,
            this.foto_hotel,
            this.habitaciones,
            this.precio_h,
            this.puntuacion});
            this.dataHoteles.Location = new System.Drawing.Point(609, 77);
            this.dataHoteles.MultiSelect = false;
            this.dataHoteles.Name = "dataHoteles";
            this.dataHoteles.ReadOnly = true;
            this.dataHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHoteles.Size = new System.Drawing.Size(576, 206);
            this.dataHoteles.TabIndex = 9;
            this.dataHoteles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataHoteles_MouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_hotel";
            this.id.HeaderText = "Id_hotel";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre_pais
            // 
            this.nombre_pais.DataPropertyName = "nombre_pais";
            this.nombre_pais.HeaderText = "Pais";
            this.nombre_pais.Name = "nombre_pais";
            this.nombre_pais.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.DataPropertyName = "nombre_lugar";
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // nombre_hotel
            // 
            this.nombre_hotel.DataPropertyName = "nombre_hotel";
            this.nombre_hotel.HeaderText = "Hotel";
            this.nombre_hotel.Name = "nombre_hotel";
            this.nombre_hotel.ReadOnly = true;
            // 
            // foto_hotel
            // 
            this.foto_hotel.DataPropertyName = "foto_hotel";
            this.foto_hotel.HeaderText = "Foto Hotel";
            this.foto_hotel.Name = "foto_hotel";
            this.foto_hotel.ReadOnly = true;
            this.foto_hotel.Visible = false;
            // 
            // habitaciones
            // 
            this.habitaciones.DataPropertyName = "habitaciones";
            this.habitaciones.HeaderText = "Habitaciones";
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.ReadOnly = true;
            // 
            // precio_h
            // 
            this.precio_h.DataPropertyName = "precio";
            this.precio_h.HeaderText = "Precio";
            this.precio_h.Name = "precio_h";
            this.precio_h.ReadOnly = true;
            // 
            // puntuacion
            // 
            this.puntuacion.DataPropertyName = "puntuacion";
            this.puntuacion.HeaderText = "Puntuacion";
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.ReadOnly = true;
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOrigen.Location = new System.Drawing.Point(126, 38);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(119, 20);
            this.txtOrigen.TabIndex = 10;
            // 
            // txtDestino
            // 
            this.txtDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDestino.Location = new System.Drawing.Point(368, 36);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(119, 20);
            this.txtDestino.TabIndex = 11;
            // 
            // dataVehiculo
            // 
            this.dataVehiculo.AllowUserToAddRows = false;
            this.dataVehiculo.AllowUserToDeleteRows = false;
            this.dataVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vehiculo,
            this.marca,
            this.modelo,
            this.capacidad,
            this.precio_ve,
            this.cantidad});
            this.dataVehiculo.Location = new System.Drawing.Point(609, 289);
            this.dataVehiculo.MultiSelect = false;
            this.dataVehiculo.Name = "dataVehiculo";
            this.dataVehiculo.ReadOnly = true;
            this.dataVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVehiculo.Size = new System.Drawing.Size(382, 270);
            this.dataVehiculo.TabIndex = 12;
            // 
            // id_vehiculo
            // 
            this.id_vehiculo.DataPropertyName = "id_vehiculo";
            this.id_vehiculo.HeaderText = "Placa";
            this.id_vehiculo.Name = "id_vehiculo";
            this.id_vehiculo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.DataPropertyName = "capacidad";
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // precio_ve
            // 
            this.precio_ve.DataPropertyName = "precio";
            this.precio_ve.HeaderText = "Precio";
            this.precio_ve.Name = "precio_ve";
            this.precio_ve.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
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
            this.label4.Location = new System.Drawing.Point(14, 130);
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
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adultos";
            // 
            // spAdultos
            // 
            this.spAdultos.Location = new System.Drawing.Point(493, 75);
            this.spAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spAdultos.Name = "spAdultos";
            this.spAdultos.ReadOnly = true;
            this.spAdultos.Size = new System.Drawing.Size(54, 20);
            this.spAdultos.TabIndex = 19;
            this.spAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spAdultos.ValueChanged += new System.EventHandler(this.spAdultos_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Niños";
            // 
            // spNinos
            // 
            this.spNinos.Location = new System.Drawing.Point(493, 99);
            this.spNinos.Name = "spNinos";
            this.spNinos.ReadOnly = true;
            this.spNinos.Size = new System.Drawing.Size(54, 20);
            this.spNinos.TabIndex = 19;
            this.spNinos.ValueChanged += new System.EventHandler(this.spNinos_ValueChanged);
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Enabled = false;
            this.txtHabitaciones.Location = new System.Drawing.Point(493, 125);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(54, 20);
            this.txtHabitaciones.TabIndex = 21;
            this.txtHabitaciones.Text = "1";
            this.txtHabitaciones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Habitaciones";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(1002, 524);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(183, 35);
            this.btnComprar.TabIndex = 22;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(1002, 483);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(183, 35);
            this.btnReservar.TabIndex = 22;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(493, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbHotel
            // 
            this.pbHotel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbHotel.Location = new System.Drawing.Point(1002, 289);
            this.pbHotel.Name = "pbHotel";
            this.pbHotel.Size = new System.Drawing.Size(175, 133);
            this.pbHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHotel.TabIndex = 24;
            this.pbHotel.TabStop = false;
            // 
            // chVuelo
            // 
            this.chVuelo.AutoSize = true;
            this.chVuelo.Location = new System.Drawing.Point(13, 171);
            this.chVuelo.Name = "chVuelo";
            this.chVuelo.Size = new System.Drawing.Size(93, 17);
            this.chVuelo.TabIndex = 25;
            this.chVuelo.Text = "Agregar Vuelo";
            this.chVuelo.UseVisualStyleBackColor = true;
            // 
            // Interfaz_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 583);
            this.Controls.Add(this.chVuelo);
            this.Controls.Add(this.pbHotel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spNinos);
            this.Controls.Add(this.spAdultos);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz_Vuelos";
            this.Text = "Interfaz Vuelos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Interfaz_Vuelos_FormClosed);
            this.Load += new System.EventHandler(this.Interfaz_Vuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAeropuertos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotel)).EndInit();
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
        private System.Windows.Forms.NumericUpDown spAdultos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spNinos;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Escala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.PictureBox pbHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_ve;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto_hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntuacion;
        private System.Windows.Forms.CheckBox chVuelo;
    }
}
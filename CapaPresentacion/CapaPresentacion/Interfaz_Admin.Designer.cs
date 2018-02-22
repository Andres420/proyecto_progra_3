namespace CapaPresentacion
{
    partial class Interfaz_Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaises = new System.Windows.Forms.Button();
            this.btnLugares = new System.Windows.Forms.Button();
            this.btnAeropuertos = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.btnTarifa_Hoteles = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnTarifa_Vuelos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
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
            // btnPaises
            // 
            this.btnPaises.Location = new System.Drawing.Point(62, 49);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(75, 23);
            this.btnPaises.TabIndex = 1;
            this.btnPaises.Text = "Paises";
            this.btnPaises.UseVisualStyleBackColor = true;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnLugares
            // 
            this.btnLugares.Location = new System.Drawing.Point(224, 49);
            this.btnLugares.Name = "btnLugares";
            this.btnLugares.Size = new System.Drawing.Size(75, 23);
            this.btnLugares.TabIndex = 2;
            this.btnLugares.Text = "Lugares";
            this.btnLugares.UseVisualStyleBackColor = true;
            this.btnLugares.Click += new System.EventHandler(this.btnLugares_Click);
            // 
            // btnAeropuertos
            // 
            this.btnAeropuertos.Location = new System.Drawing.Point(386, 49);
            this.btnAeropuertos.Name = "btnAeropuertos";
            this.btnAeropuertos.Size = new System.Drawing.Size(75, 23);
            this.btnAeropuertos.TabIndex = 3;
            this.btnAeropuertos.Text = "Aeropuertos";
            this.btnAeropuertos.UseVisualStyleBackColor = true;
            this.btnAeropuertos.Click += new System.EventHandler(this.btnAeropuertos_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Location = new System.Drawing.Point(62, 135);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(75, 23);
            this.btnRutas.TabIndex = 4;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Location = new System.Drawing.Point(224, 135);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(75, 23);
            this.btnHoteles.TabIndex = 5;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // btnTarifa_Hoteles
            // 
            this.btnTarifa_Hoteles.Location = new System.Drawing.Point(386, 135);
            this.btnTarifa_Hoteles.Name = "btnTarifa_Hoteles";
            this.btnTarifa_Hoteles.Size = new System.Drawing.Size(81, 23);
            this.btnTarifa_Hoteles.TabIndex = 6;
            this.btnTarifa_Hoteles.Text = "Tarifa Hoteles";
            this.btnTarifa_Hoteles.UseVisualStyleBackColor = true;
            this.btnTarifa_Hoteles.Click += new System.EventHandler(this.btnTarifa_Hoteles_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(307, 217);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculos.TabIndex = 7;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnTarifa_Vuelos
            // 
            this.btnTarifa_Vuelos.Location = new System.Drawing.Point(143, 217);
            this.btnTarifa_Vuelos.Name = "btnTarifa_Vuelos";
            this.btnTarifa_Vuelos.Size = new System.Drawing.Size(81, 23);
            this.btnTarifa_Vuelos.TabIndex = 8;
            this.btnTarifa_Vuelos.Text = "Tarifa Vuelos";
            this.btnTarifa_Vuelos.UseVisualStyleBackColor = true;
            this.btnTarifa_Vuelos.Click += new System.EventHandler(this.btnTarifa_Vuelos_Click);
            // 
            // Interfaz_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 266);
            this.Controls.Add(this.btnTarifa_Vuelos);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.btnTarifa_Hoteles);
            this.Controls.Add(this.btnHoteles);
            this.Controls.Add(this.btnRutas);
            this.Controls.Add(this.btnAeropuertos);
            this.Controls.Add(this.btnLugares);
            this.Controls.Add(this.btnPaises);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz_Admin";
            this.Text = "Interfaz Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Button btnLugares;
        private System.Windows.Forms.Button btnAeropuertos;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button btnTarifa_Hoteles;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnTarifa_Vuelos;
    }
}
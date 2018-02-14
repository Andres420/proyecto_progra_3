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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ID1 = new System.Windows.Forms.TextBox();
            this.Txt_Origen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rutas = new System.Windows.Forms.GroupBox();
            this.Txt_Duracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Destino = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_mod = new System.Windows.Forms.Button();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.Rutas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Identificador";
            // 
            // Txt_ID1
            // 
            this.Txt_ID1.Location = new System.Drawing.Point(102, 26);
            this.Txt_ID1.Name = "Txt_ID1";
            this.Txt_ID1.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID1.TabIndex = 21;
            // 
            // Txt_Origen
            // 
            this.Txt_Origen.Location = new System.Drawing.Point(102, 68);
            this.Txt_Origen.Name = "Txt_Origen";
            this.Txt_Origen.Size = new System.Drawing.Size(100, 20);
            this.Txt_Origen.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pais Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pais Destino";
            // 
            // Rutas
            // 
            this.Rutas.Controls.Add(this.Txt_Duracion);
            this.Rutas.Controls.Add(this.label4);
            this.Rutas.Controls.Add(this.Txt_Destino);
            this.Rutas.Controls.Add(this.label1);
            this.Rutas.Controls.Add(this.Txt_ID1);
            this.Rutas.Controls.Add(this.Txt_Origen);
            this.Rutas.Controls.Add(this.label2);
            this.Rutas.Controls.Add(this.label3);
            this.Rutas.Location = new System.Drawing.Point(12, 12);
            this.Rutas.Name = "Rutas";
            this.Rutas.Size = new System.Drawing.Size(331, 222);
            this.Rutas.TabIndex = 28;
            this.Rutas.TabStop = false;
            this.Rutas.Text = "Rutas";
            // 
            // Txt_Duracion
            // 
            this.Txt_Duracion.Location = new System.Drawing.Point(102, 151);
            this.Txt_Duracion.Name = "Txt_Duracion";
            this.Txt_Duracion.Size = new System.Drawing.Size(100, 20);
            this.Txt_Duracion.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Duracion";
            // 
            // Txt_Destino
            // 
            this.Txt_Destino.Location = new System.Drawing.Point(102, 112);
            this.Txt_Destino.Name = "Txt_Destino";
            this.Txt_Destino.Size = new System.Drawing.Size(100, 20);
            this.Txt_Destino.TabIndex = 28;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 147);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(58, 157);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 30;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_mod
            // 
            this.Btn_mod.Location = new System.Drawing.Point(58, 114);
            this.Btn_mod.Name = "Btn_mod";
            this.Btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Btn_mod.TabIndex = 29;
            this.Btn_mod.Text = "Modificar";
            this.Btn_mod.UseVisualStyleBackColor = true;
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(58, 74);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reg.TabIndex = 28;
            this.Btn_Reg.Text = "Registrar";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            // 
            // CRUD_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rutas);
            this.Name = "CRUD_Rutas";
            this.Text = "Rutas";
            this.Rutas.ResumeLayout(false);
            this.Rutas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ID1;
        private System.Windows.Forms.TextBox Txt_Origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Rutas;
        private System.Windows.Forms.TextBox Txt_Destino;
        private System.Windows.Forms.TextBox Txt_Duracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_mod;
        private System.Windows.Forms.Button Btn_Reg;
    }
}
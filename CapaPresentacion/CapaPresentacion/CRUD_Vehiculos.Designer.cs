﻿namespace CapaPresentacion
{
    partial class CRUD_Vehiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ID1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_mod = new System.Windows.Forms.Button();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Cantidad);
            this.groupBox1.Controls.Add(this.Txt_Precio);
            this.groupBox1.Controls.Add(this.Txt_Tipo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Txt_Marca);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_ID1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Identificador";
            // 
            // Txt_ID1
            // 
            this.Txt_ID1.Location = new System.Drawing.Point(89, 22);
            this.Txt_ID1.Name = "Txt_ID1";
            this.Txt_ID1.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID1.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Limpiar);
            this.groupBox2.Controls.Add(this.Btn_Eliminar);
            this.groupBox2.Controls.Add(this.Btn_mod);
            this.groupBox2.Controls.Add(this.Btn_Reg);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 247);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(26, 48);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 35;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(26, 169);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 34;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_mod
            // 
            this.Btn_mod.Location = new System.Drawing.Point(26, 126);
            this.Btn_mod.Name = "Btn_mod";
            this.Btn_mod.Size = new System.Drawing.Size(75, 23);
            this.Btn_mod.TabIndex = 33;
            this.Btn_mod.Text = "Modificar";
            this.Btn_mod.UseVisualStyleBackColor = true;
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(26, 86);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reg.TabIndex = 32;
            this.Btn_Reg.Text = "Registrar";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 184);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro de Vehiculos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cantidad";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(89, 55);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(100, 20);
            this.Txt_Marca.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(89, 111);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Tipo.TabIndex = 42;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(89, 141);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.Txt_Precio.TabIndex = 43;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(89, 172);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cantidad.TabIndex = 44;
            // 
            // CRUD_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CRUD_Vehiculos";
            this.Text = "CRUD_Vehiculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ID1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_mod;
        private System.Windows.Forms.Button Btn_Reg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Precio;
    }
}
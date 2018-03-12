namespace CapaPresentacion
{
    partial class Puntuacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puntuacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.btn_Votar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r5);
            this.groupBox1.Controls.Add(this.r4);
            this.groupBox1.Controls.Add(this.r3);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Location = new System.Drawing.Point(225, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 243);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(1, 207);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(72, 17);
            this.r5.TabIndex = 12;
            this.r5.TabStop = true;
            this.r5.Text = "Excelente";
            this.r5.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(0, 157);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(78, 17);
            this.r4.TabIndex = 11;
            this.r4.TabStop = true;
            this.r4.Text = "Muy bueno";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(1, 106);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(56, 17);
            this.r3.TabIndex = 10;
            this.r3.TabStop = true;
            this.r3.Text = "Bueno";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(1, 60);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(62, 17);
            this.r2.TabIndex = 9;
            this.r2.TabStop = true;
            this.r2.Text = "Regular";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Location = new System.Drawing.Point(1, 12);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(48, 17);
            this.r1.TabIndex = 8;
            this.r1.TabStop = true;
            this.r1.Text = "Malo";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // btn_Votar
            // 
            this.btn_Votar.Location = new System.Drawing.Point(15, 301);
            this.btn_Votar.Name = "btn_Votar";
            this.btn_Votar.Size = new System.Drawing.Size(101, 36);
            this.btn_Votar.TabIndex = 20;
            this.btn_Votar.Text = "Votar";
            this.btn_Votar.UseVisualStyleBackColor = true;
            this.btn_Votar.Click += new System.EventHandler(this.btn_Votar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Danos tu opinion sobre el servicio en el hotel";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(15, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 243);
            this.panel1.TabIndex = 18;
            // 
            // Puntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Votar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Puntuacion";
            this.Text = "Puntuacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Button btn_Votar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
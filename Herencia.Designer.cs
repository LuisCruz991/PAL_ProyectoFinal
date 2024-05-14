namespace PruebaPrograma
{
    partial class Herencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Herencia));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.herencias = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LegadoJuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LegadoRosa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LegadoLuis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpiar.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(739, 582);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(205, 115);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.BackgroundImage")));
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalcular.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnCalcular.Location = new System.Drawing.Point(739, 454);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(205, 115);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.BackColor = System.Drawing.Color.Transparent;
            this.LblEnunciado.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.Location = new System.Drawing.Point(42, 35);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(807, 69);
            this.LblEnunciado.TabIndex = 0;
            this.LblEnunciado.Text = "Division de una herencia";
            // 
            // herencias
            // 
            this.herencias.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.herencias.Location = new System.Drawing.Point(90, 201);
            this.herencias.Name = "herencias";
            this.herencias.Size = new System.Drawing.Size(324, 34);
            this.herencias.TabIndex = 10;
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.BackColor = System.Drawing.Color.Transparent;
            this.LblX.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.Location = new System.Drawing.Point(49, 171);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(446, 27);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "Ingrese el valor total de la herencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legado de Juan (1/3 del Total)";
            // 
            // LegadoJuan
            // 
            this.LegadoJuan.BackColor = System.Drawing.Color.White;
            this.LegadoJuan.Enabled = false;
            this.LegadoJuan.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegadoJuan.ForeColor = System.Drawing.Color.Black;
            this.LegadoJuan.Location = new System.Drawing.Point(55, 336);
            this.LegadoJuan.Name = "LegadoJuan";
            this.LegadoJuan.Size = new System.Drawing.Size(360, 34);
            this.LegadoJuan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Legado de Rosa (Mitad que Luis)";
            // 
            // LegadoRosa
            // 
            this.LegadoRosa.BackColor = System.Drawing.Color.White;
            this.LegadoRosa.Enabled = false;
            this.LegadoRosa.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegadoRosa.ForeColor = System.Drawing.Color.Black;
            this.LegadoRosa.Location = new System.Drawing.Point(55, 515);
            this.LegadoRosa.Name = "LegadoRosa";
            this.LegadoRosa.Size = new System.Drawing.Size(360, 34);
            this.LegadoRosa.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Legado de Luis (4/3 del total)";
            // 
            // LegadoLuis
            // 
            this.LegadoLuis.BackColor = System.Drawing.Color.White;
            this.LegadoLuis.Enabled = false;
            this.LegadoLuis.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegadoLuis.ForeColor = System.Drawing.Color.Black;
            this.LegadoLuis.Location = new System.Drawing.Point(55, 425);
            this.LegadoLuis.Name = "LegadoLuis";
            this.LegadoLuis.Size = new System.Drawing.Size(360, 34);
            this.LegadoLuis.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "$";
            // 
            // Herencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LegadoLuis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LegadoRosa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LegadoJuan);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.herencias);
            this.Controls.Add(this.LblEnunciado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnLimpiar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Herencia";
            this.Text = "Herencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.TextBox herencias;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LegadoJuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LegadoRosa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LegadoLuis;
        private System.Windows.Forms.Label label4;
    }
}
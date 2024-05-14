namespace PruebaPrograma
{
    partial class Angulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angulos));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAnguloC = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.txtCatetoMenor = new System.Windows.Forms.TextBox();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatetoMayor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHipotenusa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAnguloB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.BackgroundImage")));
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalcular.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnCalcular.Location = new System.Drawing.Point(739, 454);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(205, 115);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
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
            this.BtnLimpiar.TabIndex = 14;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor del angulo C:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtAnguloC
            // 
            this.TxtAnguloC.BackColor = System.Drawing.Color.White;
            this.TxtAnguloC.Enabled = false;
            this.TxtAnguloC.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnguloC.ForeColor = System.Drawing.Color.Black;
            this.TxtAnguloC.Location = new System.Drawing.Point(29, 550);
            this.TxtAnguloC.Name = "TxtAnguloC";
            this.TxtAnguloC.Size = new System.Drawing.Size(360, 34);
            this.TxtAnguloC.TabIndex = 16;
            this.TxtAnguloC.TextChanged += new System.EventHandler(this.LegadoJuan_TextChanged);
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.BackColor = System.Drawing.Color.White;
            this.LblX.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.Black;
            this.LblX.Location = new System.Drawing.Point(24, 148);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(416, 27);
            this.LblX.TabIndex = 17;
            this.LblX.Text = "Ingrese el valor del cateto menor:\r\n";
            // 
            // txtCatetoMenor
            // 
            this.txtCatetoMenor.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCatetoMenor.Location = new System.Drawing.Point(30, 178);
            this.txtCatetoMenor.Name = "txtCatetoMenor";
            this.txtCatetoMenor.Size = new System.Drawing.Size(410, 34);
            this.txtCatetoMenor.TabIndex = 19;
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.BackColor = System.Drawing.Color.Transparent;
            this.LblEnunciado.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.ForeColor = System.Drawing.Color.White;
            this.LblEnunciado.Location = new System.Drawing.Point(216, 9);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(535, 69);
            this.LblEnunciado.TabIndex = 18;
            this.LblEnunciado.Text = "Ángulos Agudos";
            this.LblEnunciado.Click += new System.EventHandler(this.LblEnunciado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ingrese el valor del cateto mayor:\r\n";
            // 
            // txtCatetoMayor
            // 
            this.txtCatetoMayor.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCatetoMayor.Location = new System.Drawing.Point(30, 264);
            this.txtCatetoMayor.Name = "txtCatetoMayor";
            this.txtCatetoMayor.Size = new System.Drawing.Size(410, 34);
            this.txtCatetoMayor.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor de la hipotenusa:";
            // 
            // TxtHipotenusa
            // 
            this.TxtHipotenusa.BackColor = System.Drawing.Color.White;
            this.TxtHipotenusa.Enabled = false;
            this.TxtHipotenusa.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHipotenusa.ForeColor = System.Drawing.Color.Black;
            this.TxtHipotenusa.Location = new System.Drawing.Point(29, 638);
            this.TxtHipotenusa.Name = "TxtHipotenusa";
            this.TxtHipotenusa.Size = new System.Drawing.Size(360, 34);
            this.TxtHipotenusa.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Valor del angulo B:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtAnguloB
            // 
            this.TxtAnguloB.BackColor = System.Drawing.Color.White;
            this.TxtAnguloB.Enabled = false;
            this.TxtAnguloB.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnguloB.ForeColor = System.Drawing.Color.Black;
            this.TxtAnguloB.Location = new System.Drawing.Point(29, 462);
            this.TxtAnguloB.Name = "TxtAnguloB";
            this.TxtAnguloB.Size = new System.Drawing.Size(360, 34);
            this.TxtAnguloB.TabIndex = 25;
            this.TxtAnguloB.TextChanged += new System.EventHandler(this.TxtAnguloB_TextChanged);
            // 
            // Angulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAnguloB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtHipotenusa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCatetoMayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAnguloC);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.txtCatetoMenor);
            this.Controls.Add(this.LblEnunciado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Angulos";
            this.Text = "Angulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAnguloC;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.TextBox txtCatetoMenor;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatetoMayor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHipotenusa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAnguloB;
    }
}
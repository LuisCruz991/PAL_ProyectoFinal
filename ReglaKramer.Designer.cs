namespace PruebaPrograma
{
    partial class ReglaKramer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReglaKramer));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.TxtSolucionY = new System.Windows.Forms.TextBox();
            this.TxtSolucionX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.BackgroundImage")));
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalcular.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnCalcular.Location = new System.Drawing.Point(739, 453);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(739, 581);
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
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Coeficiente A1:";
            // 
            // txtA1
            // 
            this.txtA1.BackColor = System.Drawing.Color.White;
            this.txtA1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1.ForeColor = System.Drawing.Color.Black;
            this.txtA1.Location = new System.Drawing.Point(53, 169);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(193, 34);
            this.txtA1.TabIndex = 24;
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.BackColor = System.Drawing.Color.White;
            this.LblEnunciado.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.ForeColor = System.Drawing.Color.Black;
            this.LblEnunciado.Location = new System.Drawing.Point(41, 30);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(560, 69);
            this.LblEnunciado.TabIndex = 25;
            this.LblEnunciado.Text = "Regla de Kramer";
            // 
            // txtC1
            // 
            this.txtC1.BackColor = System.Drawing.Color.White;
            this.txtC1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1.ForeColor = System.Drawing.Color.Black;
            this.txtC1.Location = new System.Drawing.Point(52, 328);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(193, 34);
            this.txtC1.TabIndex = 26;
            // 
            // txtB1
            // 
            this.txtB1.BackColor = System.Drawing.Color.White;
            this.txtB1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.ForeColor = System.Drawing.Color.Black;
            this.txtB1.Location = new System.Drawing.Point(52, 246);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(193, 34);
            this.txtB1.TabIndex = 27;
            // 
            // txtA2
            // 
            this.txtA2.BackColor = System.Drawing.Color.White;
            this.txtA2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA2.ForeColor = System.Drawing.Color.Black;
            this.txtA2.Location = new System.Drawing.Point(429, 169);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(193, 34);
            this.txtA2.TabIndex = 28;
            // 
            // txtC2
            // 
            this.txtC2.BackColor = System.Drawing.Color.White;
            this.txtC2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2.ForeColor = System.Drawing.Color.Black;
            this.txtC2.Location = new System.Drawing.Point(429, 328);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(193, 34);
            this.txtC2.TabIndex = 29;
            // 
            // txtB2
            // 
            this.txtB2.BackColor = System.Drawing.Color.White;
            this.txtB2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.ForeColor = System.Drawing.Color.Black;
            this.txtB2.Location = new System.Drawing.Point(429, 246);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(193, 34);
            this.txtB2.TabIndex = 30;
            // 
            // TxtSolucionY
            // 
            this.TxtSolucionY.BackColor = System.Drawing.Color.White;
            this.TxtSolucionY.Enabled = false;
            this.TxtSolucionY.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSolucionY.ForeColor = System.Drawing.Color.Black;
            this.TxtSolucionY.Location = new System.Drawing.Point(429, 493);
            this.TxtSolucionY.Name = "TxtSolucionY";
            this.TxtSolucionY.Size = new System.Drawing.Size(290, 34);
            this.TxtSolucionY.TabIndex = 31;
            // 
            // TxtSolucionX
            // 
            this.TxtSolucionX.BackColor = System.Drawing.Color.White;
            this.TxtSolucionX.Enabled = false;
            this.TxtSolucionX.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSolucionX.ForeColor = System.Drawing.Color.Black;
            this.TxtSolucionX.Location = new System.Drawing.Point(53, 493);
            this.TxtSolucionX.Name = "TxtSolucionX";
            this.TxtSolucionX.Size = new System.Drawing.Size(323, 34);
            this.TxtSolucionX.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(424, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Coeficiente A2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(424, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Coeficiente A2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Coeficiente C1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Coeficiente B1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(424, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "Coeficiente A2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 38;
            this.label7.Text = "Solucion X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(424, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 39;
            this.label8.Text = "Solucion Y:";
            // 
            // ReglaKramer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 709);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSolucionX);
            this.Controls.Add(this.TxtSolucionY);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.LblEnunciado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReglaKramer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReglaKrammer";
            this.Load += new System.EventHandler(this.ReglaKramer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox TxtSolucionY;
        private System.Windows.Forms.TextBox TxtSolucionX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
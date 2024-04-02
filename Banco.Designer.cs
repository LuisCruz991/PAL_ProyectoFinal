namespace PruebaPrograma
{
    partial class Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblX = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt100 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.BackgroundImage")));
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalcular.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(739, 451);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCalcular.Size = new System.Drawing.Size(205, 115);
            this.BtnCalcular.TabIndex = 15;
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
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(739, 579);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(205, 115);
            this.BtnLimpiar.TabIndex = 16;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "$";
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.BackColor = System.Drawing.Color.Black;
            this.LblX.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.White;
            this.LblX.Location = new System.Drawing.Point(38, 137);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(332, 27);
            this.LblX.TabIndex = 17;
            this.LblX.Text = "Ingrese el monto a retirar:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtMonto.Location = new System.Drawing.Point(83, 167);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(324, 34);
            this.TxtMonto.TabIndex = 19;
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.BackColor = System.Drawing.Color.Transparent;
            this.LblEnunciado.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.ForeColor = System.Drawing.Color.White;
            this.LblEnunciado.Location = new System.Drawing.Point(26, 26);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(537, 69);
            this.LblEnunciado.TabIndex = 18;
            this.LblEnunciado.Text = "Retiro de dinero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Billetes de $100:";
            // 
            // Txt100
            // 
            this.Txt100.BackColor = System.Drawing.Color.White;
            this.Txt100.Enabled = false;
            this.Txt100.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt100.ForeColor = System.Drawing.Color.Black;
            this.Txt100.Location = new System.Drawing.Point(43, 273);
            this.Txt100.Name = "Txt100";
            this.Txt100.Size = new System.Drawing.Size(193, 34);
            this.Txt100.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Billetes de $20:";
            // 
            // Txt20
            // 
            this.Txt20.BackColor = System.Drawing.Color.White;
            this.Txt20.Enabled = false;
            this.Txt20.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt20.ForeColor = System.Drawing.Color.Black;
            this.Txt20.Location = new System.Drawing.Point(339, 273);
            this.Txt20.Name = "Txt20";
            this.Txt20.Size = new System.Drawing.Size(193, 34);
            this.Txt20.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Billetes de $10:";
            // 
            // Txt10
            // 
            this.Txt10.BackColor = System.Drawing.Color.White;
            this.Txt10.Enabled = false;
            this.Txt10.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt10.ForeColor = System.Drawing.Color.Black;
            this.Txt10.Location = new System.Drawing.Point(43, 361);
            this.Txt10.Name = "Txt10";
            this.Txt10.Size = new System.Drawing.Size(193, 34);
            this.Txt10.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(333, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Billetes de $5:";
            // 
            // Txt5
            // 
            this.Txt5.BackColor = System.Drawing.Color.White;
            this.Txt5.Enabled = false;
            this.Txt5.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt5.ForeColor = System.Drawing.Color.Black;
            this.Txt5.Location = new System.Drawing.Point(339, 361);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(193, 34);
            this.Txt5.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 27);
            this.label6.TabIndex = 29;
            this.label6.Text = "Billetes de $1:";
            // 
            // Txt1
            // 
            this.Txt1.BackColor = System.Drawing.Color.White;
            this.Txt1.Enabled = false;
            this.Txt1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.ForeColor = System.Drawing.Color.Black;
            this.Txt1.Location = new System.Drawing.Point(43, 451);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(193, 34);
            this.Txt1.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 27);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad de dinero retirado:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.White;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtTotal.Location = new System.Drawing.Point(43, 632);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(349, 34);
            this.TxtTotal.TabIndex = 32;
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 709);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.LblEnunciado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}
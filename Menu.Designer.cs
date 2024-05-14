namespace PruebaPrograma
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblFecha = new System.Windows.Forms.Label();
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelBase.SuspendLayout();
            this.PanelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVolver.Location = new System.Drawing.Point(12, 598);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(198, 98);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver al inicio";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 708);
            this.panel1.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(12, 433);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 64);
            this.button7.TabIndex = 7;
            this.button7.Text = " Plano\r\n Cartesiano";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(12, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 64);
            this.button6.TabIndex = 8;
            this.button6.Text = " Creditos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(12, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = " Herencia";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(12, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = " Promedio de\r\n Vendas [ADOC]";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(12, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = " Ordenamiento";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = " Cajero de\r\n Banco";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = " Determinante\r\n Regla Kramer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Black;
            this.Btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn1.BackgroundImage")));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(12, 13);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(198, 64);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = " Ángulos\r\n Agudos";
            this.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.Color.Black;
            this.PanelBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelBase.BackgroundImage")));
            this.PanelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelBase.Controls.Add(this.PanelDatos);
            this.PanelBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelBase.Location = new System.Drawing.Point(216, -1);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(956, 709);
            this.PanelBase.TabIndex = 3;
            this.PanelBase.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBase_Paint);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Tai Le", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.Black;
            this.LblHora.Location = new System.Drawing.Point(18, 13);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(238, 107);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(26, 140);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(150, 60);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // PanelDatos
            // 
            this.PanelDatos.BackColor = System.Drawing.Color.Transparent;
            this.PanelDatos.Controls.Add(this.LblHora);
            this.PanelDatos.Controls.Add(this.LblFecha);
            this.PanelDatos.Location = new System.Drawing.Point(8, 14);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(936, 229);
            this.PanelDatos.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.PanelBase.ResumeLayout(false);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel PanelDatos;
    }
}


namespace PruebaPrograma
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.White;
            this.BtnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIngresar.BackgroundImage")));
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIngresar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(786, 426);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(260, 141);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblNombre.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.LblNombre.Location = new System.Drawing.Point(673, 149);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(487, 207);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Programacion \r\nde \r\nAlgoritmos";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 708);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblNombre;
    }
}
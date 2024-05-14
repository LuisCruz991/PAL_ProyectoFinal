using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPrograma
{
    public partial class Angulos : Form
    {
        public Angulos()
        {
            InitializeComponent();
        }

        double catetoMenor, catetoMayor;

        private void LblEnunciado_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCatetoMenor.Text, out catetoMenor) && double.TryParse(txtCatetoMayor.Text, out catetoMayor))
            {
                double anguloC = Math.Atan(catetoMenor / catetoMayor) * (180 / Math.PI);
                double anguloB = 90 - anguloC;
                double hipotenusa = Math.Sqrt(Math.Pow(catetoMenor, 2) + Math.Pow(catetoMayor, 2));

                TxtAnguloC.Text = $"" + Math.Round(anguloC, 2) + "°";
                TxtAnguloB.Text = $"" + Math.Round(anguloB, 2) + "°";
                TxtHipotenusa.Text = $"" + Math.Round(hipotenusa, 2) + "°";

                // Dibujar el triángulo rectángulo
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, 350, 350, 350, 450); // Lado vertical
                g.DrawLine(pen, 350, 450, 450, 450); // Lado horizontal
                g.DrawLine(pen, 350, 350, 450, 450); // Hipotenusa
            }
            else
            {
                MessageBox.Show("No hay datos ingresados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LegadoJuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtAnguloB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar los campos?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCatetoMenor.Text = "";
                txtCatetoMayor.Text = "";
                TxtAnguloC.Text = "";
                TxtAnguloB.Text = "";
                TxtHipotenusa.Text = "";
                MessageBox.Show("Se han limpiado los datos correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

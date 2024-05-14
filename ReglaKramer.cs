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
    public partial class ReglaKramer : Form
    {
        public ReglaKramer()
        {
            InitializeComponent();

        }

        private void ReglaKramer_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            // Obtener coeficientes de las ecuaciones
            double a1 = double.Parse(txtA1.Text);
            double b1 = double.Parse(txtB1.Text);
            double c1 = double.Parse(txtC1.Text);
            double a2 = double.Parse(txtA2.Text);
            double b2 = double.Parse(txtB2.Text);
            double c2 = double.Parse(txtC2.Text);

            // Calcular determinante principal
            double determinantePrincipal = a1 * b2 - a2 * b1;

            if (determinantePrincipal != 0)
            {
                // Calcular determinante de la matriz X
                double determinanteX = c1 * b2 - c2 * b1;

                // Calcular determinante de la matriz Y
                double determinanteY = a1 * c2 - a2 * c1;

                // Calcular las soluciones
                double solucionX = determinanteX / determinantePrincipal;
                double solucionY = determinanteY / determinantePrincipal;

                // Mostrar soluciones
                TxtSolucionX.Text = "X = " + Math.Round(solucionX, 2);
                TxtSolucionY.Text = "Y = " + Math.Round(solucionY, 2);
            }
            else
            {
                MessageBox.Show("El determinante principal es cero. El sistema no tiene solución única.");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar los campos?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Limpiar los campos de entrada y las soluciones
                txtA1.Clear();
                txtB1.Clear();
                txtC1.Clear();
                txtA2.Clear();
                txtB2.Clear();
                txtC2.Clear();
                TxtSolucionX.Text = "";
                TxtSolucionY.Text = "";
                MessageBox.Show("Se han limpiado los datos correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

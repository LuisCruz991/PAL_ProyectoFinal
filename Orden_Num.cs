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
    public partial class Orden_Num : Form
    {
        public Orden_Num()
        {
            InitializeComponent();
        }

        private void LblEnunciado_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "" && TxtN3.Text != "") 
            {
                int num1 = Convert.ToInt32(TxtN1.Text);
                int num2 = Convert.ToInt32(TxtN2.Text);
                int num3 = Convert.ToInt32(TxtN3.Text);

                int mayor = Math.Max(num1, Math.Max(num2, num3));
                int menor = Math.Min(num1, Math.Min(num2, num3));
                int medio = num1 + num2 + num3 - mayor - menor;

                TxtMayor.Text = $"{mayor}";
                TxtCentral.Text = $"{medio}";
                TxtMenor.Text = $"{menor}";
            }
            else
            {
                MessageBox.Show("No hay datos ingresados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar los campos?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtN1.Text = "";
                TxtN2.Text = "";
                TxtN3.Text = "";
                MessageBox.Show("Se han limpiado los datos correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

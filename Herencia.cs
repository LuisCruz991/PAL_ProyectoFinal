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
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        //Declaracion de variables
        double dinero, juan, luis, rosa;

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas limpiar los campos?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                herencias.Text = "";
                LegadoJuan.Text = "";
                LegadoLuis.Text = "";
                LegadoRosa.Text = "";
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (herencias.Text != "")
            {
                dinero = Convert.ToDouble(herencias.Text);

                juan = dinero / 3;
                luis = 4 * dinero / 9;
                rosa = 2 * dinero / 9;

                string ParteJuan = Convert.ToString(juan);
                LegadoJuan.Text = ("$ " + Math.Round(juan, 2));

                string ParteLuis = Convert.ToString(luis);
                LegadoLuis.Text = ("$ " + Math.Round(luis, 2));

                string ParteRosa = Convert.ToString(rosa);
                LegadoRosa.Text = ("$ " + Math.Round(rosa, 2));
            }
            else
            {
                MessageBox.Show("No hay datos ingresados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}

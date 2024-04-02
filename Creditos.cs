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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void BtnLuis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Luis Enrique Cruz Ramírez " +
                "\nConozco sobre la programación y puedo jugar futbol " +
                "\nAun tengo cosas que aprender y mejorar de mi vida", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNatanael_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Jose Natanael Cordoba Magaña" +
                "\nMe gusta jugar al fútbol es mi mayor hobby y me gusta el ambiente de los carros" +
                "\nNo me preocupo por los fracasos, me preocupo por las oportunidades que pierdo cuando ni siquiera lo intento", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnArturo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Arturo Moisés Rodríguez Arias" +
                "\nSe muy poco de programación, pero sigo intentando y vamos a seguir aprendiendo.", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNorman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Norman Enmanuel Quijano Amaya" +
                "\nMe gusta la programación pero tengo muchas cosas más por aprender y corregir ", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMendoza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Manuel Alfredo Mendoza Ramirez" +
                "\nConozco demasiado sobre la música, y puedo tocar distintos instrumentos" +
                "\nTengo muchas cosas que aprender en la programación y en la vida", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas volver al inicio?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio ventana = new Inicio();
                ventana.Show();
                this.Hide();
            }
        }

        private void MantenerFormularioFijo(object FormularioFijo)
        {
            if(this.PanelBase.Controls.Count > 0)
                this.PanelBase.Controls.RemoveAt(0);
            Form Proceso = FormularioFijo as Form;
            Proceso.TopLevel = false;
            Proceso.Dock = DockStyle.Fill;
            this.PanelBase.Controls.Add(Proceso);
            this.PanelBase.Tag = Proceso;
            Proceso.Show();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            MantenerFormularioFijo(new Angulos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MantenerFormularioFijo(new Herencia());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenerFormularioFijo(new ReglaKramer());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MantenerFormularioFijo(new Creditos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MantenerFormularioFijo(new Banco());
        }
    }
}

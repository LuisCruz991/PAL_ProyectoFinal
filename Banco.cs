using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPrograma
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        //Declaracion de variables
        int monto, cien, veinte, diez, cinco, uno, total;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtMonto.Text != "")
            {
                monto = (int)Convert.ToInt64(TxtMonto.Text);

                cien = monto / 100;
                veinte = (monto - (cien*100)) / 20;
                diez = (monto - ((cien * 100) + (veinte * 20))) / 10;
                cinco = (monto - ((cien * 100) + (veinte * 20) + (diez * 10))) / 5;
                uno = (monto - ((cien * 100) + (veinte * 20) + (diez * 10) + (cinco * 5))) / 1;
                total = (cien * 100) + (veinte * 20) + (diez * 10) + (cinco * 5) + uno;
                Txt100.Text = ($"" + cien);
                Txt20.Text = ($"" + veinte);
                Txt10.Text = ($"" + diez);
                Txt5.Text = ($"" + cinco);
                Txt1.Text = ($"" + uno);
                TxtTotal.Text = ("$" + total); 
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
                TxtMonto.Text = "";
                Txt100.Text = $"";
                Txt20.Text = $"";
                Txt10.Text = $"";
                Txt5.Text = $"";
                Txt1.Text = $"";
                TxtTotal.Text = $"";
            }
        }
    }
}

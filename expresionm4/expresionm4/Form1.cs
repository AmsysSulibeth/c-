using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expresionm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            TxtA.Clear();
            TxtB.Clear();
            TxtC.Clear();
            TxtD.Clear();
            Txtresultado.Clear();
            TxtA.Focus();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            double a1, b1, c1, d1, resultado = 0;

            a1 = Convert.ToDouble(TxtA.Text);
            b1 = Convert.ToDouble(TxtB.Text);
            c1 = Convert.ToDouble(TxtC.Text);
            d1 = Convert.ToDouble(TxtD.Text);


            resultado = (a1 + b1) / (c1 + d1);

            Txtresultado.Text = Convert.ToString(resultado);
        }
    }
}

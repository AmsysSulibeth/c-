using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecuacion2g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtresultado.Clear();
            txta.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x;

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            x = Math.Sqrt((b * b + 4.0 * a * c) / 2.0 * a);

            txtresultado.Text = Convert.ToString(x);

        }
    }
}

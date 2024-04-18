using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinconotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta1.Clear();
            txta2.Clear();
            txta3.Clear();
            txta4.Clear();
            txta5.Clear();
            txtas1.Clear();
            txtas2.Clear();
            txtas3.Clear();
            txtas4.Clear();
            txtas5.Clear();
            txtat1.Clear();
            txtat2.Clear();
            txtat3.Clear();
            txtat4.Clear();
            txtat5.Clear();
            txtalto.Clear();
            txtcualquiera.Clear();
            txtultimo.Clear();
            txta1.Focus();

        }
    }
}

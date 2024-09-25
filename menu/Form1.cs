using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cuentaTotal = Convert.ToDouble(txtBoxCuentaTotal.Text);
            double propina = Convert.ToDouble(numPropina.Value);
            double pagoDolares = cuentaTotal / 19.99;
            double pesos = cuentaTotal +((cuentaTotal / 100) * propina);
            double dolares = pagoDolares + ((pagoDolares / 100) * propina);
            label10.Text = pagoDolares.ToString();
            label11.Text = pesos.ToString();
            label12.Text = dolares.ToString();
        }

        private void txtBoxCuentaTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}

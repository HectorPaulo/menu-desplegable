using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDesplegable
{
    public partial class ventana1 : Form
    {
        public ventana1()
        {
            InitializeComponent();
        }

        private void ventana1_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal ventana = new principal();
            ventana.Show();
            this.Hide();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana1 ventana = new ventana1();
            ventana.Show();
            this.Hide();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana2 ventana = new ventana2();
            ventana.Show();
            this.Hide();

        }

        private void verListadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ventana3 ventana3 = new ventana3();
            ventana3.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana1 ventana1 = new ventana1();
            ventana1.Show();
            this.Hide();
        }
    }
}

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
    public partial class ventanaModificarAlumno : Form
    {
        public ventanaModificarAlumno()
        {
            InitializeComponent();
        }

        private void ventanaModificarAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal ventana = new principal();
            ventana.Show();
            this.Hide();
        }
    }
}

﻿using System;
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
    public partial class ventana3 : Form
    {
        public ventana3()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventana3_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal ventana = new principal();
            ventana.Show();
            this.Hide();
        }
    }
}

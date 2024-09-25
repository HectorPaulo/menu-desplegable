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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana1 ventana1 = new ventana1();
            ventana1.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaEliminarProfesor ventanaEliminarProfesor = new ventanaEliminarProfesor();
            ventanaEliminarProfesor.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaEliminarAlumno ventanaEliminarAlumno = new ventanaEliminarAlumno();
            ventanaEliminarAlumno.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaModificarAlumno ventanaModificarAlumno = new ventanaModificarAlumno();
            ventanaModificarAlumno.Show();
            this.Hide();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaVerAlumno ventanaVerAlumno = new ventanaVerAlumno();
            ventanaVerAlumno.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaModificarProfesor ventanaModificarProfesor = new ventanaModificarProfesor();
            ventanaModificarProfesor.Show();
            this.Hide();
        }

        private void verListadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaVerProfesores ventanaVerProfesores = new ventanaVerProfesores();
            ventanaVerProfesores.Show();
            this.Hide();
        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void verListadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ventanaVerAdministrativos ventanaVerAdministrativos = new ventanaVerAdministrativos();
            ventanaVerAdministrativos.Show();
            this.Hide();
        }
    }
}

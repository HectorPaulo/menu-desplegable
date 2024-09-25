using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practica2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form calcu = new calculadora();
            calcu.Show();
            this.Hide();
        }

        private void btnImprimirConsola_Click(object sender, EventArgs e)
        {
            alumno alumno1 = new alumno();
            alumno1.IdAlumno = Convert.ToInt32(txtId.Text);
            alumno1.NombreAlumno = textBox1.Text;
            alumno1.ApellidoPat = textBox3.Text;
            alumno1.ApellidoMat = textBox4.Text;
            alumno1.FechaNacimiento = textBox5.Text;
            alumno1.CURP = textBox6.Text;
            alumno1.Matricula = textBox7.Text;
            alumno1.Direccion = textBox8.Text;
            alumno1.Celular = textBox9.Text;
            alumno1.Email = textBox10.Text;

            Console.WriteLine("Datos del alumno:");
            Console.WriteLine("ID: " + alumno1.IdAlumno);
            Console.WriteLine("Nombre: " + alumno1.NombreAlumno);
            Console.WriteLine("Apellido Paterno: " + alumno1.ApellidoPat);
            Console.WriteLine("Apellido Materno: " + alumno1.ApellidoMat);
            Console.WriteLine("Fecha de Nacimiento: " + alumno1.FechaNacimiento);
            Console.WriteLine("CURP: " + alumno1.CURP);
            Console.WriteLine("Matrícula: " + alumno1.Matricula);
            Console.WriteLine("Dirección: " + alumno1.Direccion);
            Console.WriteLine("Celular: " + alumno1.Celular);
            Console.WriteLine("Email: " + alumno1.Email);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimirMensaje_Click(object sender, EventArgs e)
        {
            alumno alumno1 = new alumno();
            alumno1.IdAlumno = Convert.ToInt32(txtId.Text);
            alumno1.NombreAlumno = textBox1.Text; 
            alumno1.ApellidoPat = textBox3.Text;
            alumno1.ApellidoMat = textBox4.Text;
            alumno1.FechaNacimiento = textBox5.Text;
            alumno1.CURP = textBox6.Text;
            alumno1.Matricula = textBox7.Text;
            alumno1.Direccion = textBox8.Text;
            alumno1.Celular = textBox9.Text;
            alumno1.Email = textBox10.Text;

            string cadena = alumno1.IdAlumno.ToString() + "\n" + alumno1.NombreAlumno + "\n" +
                alumno1.ApellidoPat + "\n" + alumno1.ApellidoMat + "\n" +
                alumno1.FechaNacimiento + "\n" + alumno1.CURP + "\n" +
                alumno1.Matricula + "\n" + alumno1.Direccion + "\n" +
                alumno1.Celular + "\n" + alumno1.Email;

            MessageBox.Show("Datos del alumno: " + cadena, "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
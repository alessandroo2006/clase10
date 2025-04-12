using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clases;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {

        Crud miCrud = new Crud();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {






        }

        private void hola(object sender, EventArgs e)
        {
            MessageBox.Show("HOla te saludo desde el formulario, saludos compañeros ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBoxEstudiante.Text;
            string carnet = textBoxCarnet.Text;
            string email = textBoxEmail.Text;
            string seccion = textBoxSeccion.Text;
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBoxEstudiante.Text = miCrud.MostrarInformacion(textBoxCarnet.Text);
            textBoxNotas.Text = miCrud.MostrarTareas(textBoxCarnet.Text);
            textBoxSeccion.Text = miCrud.MostrarInformacionSeccion(textBoxCarnet.Text);
            textBoxEmail.Text = miCrud.MostrarInformacionCorreo(textBoxCarnet.Text);
        }
    }
}

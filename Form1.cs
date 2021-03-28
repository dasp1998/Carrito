using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrito
{
    public partial class Form1 : Form
    {
        DSAutomovil carrito;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Crear carro
            carrito = new DSAutomovil("Corolla",150 );
            carrito.color = "Azul Policramado";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            labelDatos.Text = respuesta;
        }

        private void button3Acelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstadoEncendido())
            {
                label1Velocidad.Text = carrito.Acelerar();
            }
            else
            {
                MessageBox.Show($"Lo Lamento el Vehiculo {carrito.marca} esta apagado");
            }
        }

        private void button4Frenar_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.Frenar();
            label1Frenar.Text = respuesta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.Apagado();
            label1Apagar.Text = respuesta;
        }
    }
}

using System;

namespace Carrito
{
    internal class DSAutomovil
    {
        public DSAutomovil()
        {
        }

        public string marca { get; }

        public int vel_max { get; }

        private int velocidadActual { get; set; }

        private bool encendido = false;

        public string color { get; set; }

        public int frenar { get; }

        private bool apagar = false;

        public string Apagado()
        {
            if (apagar)
            {
                return $"El vehiculo {marca} se a apagado";
            }
            else
            {
                apagar = true;
                return $"Vehiculo {marca} {color} procedera apagarse";
            }
        }
        public string Frenar()
        {
            velocidadActual = frenar - 5;
            if (vel_max < frenar)
            {
                return "Disminuyendo Velocidad";
            }
            else
            {
                return $"Se esta reducuendo Velocidad";
            }
        }
        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Lo Lamento llegaste a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadActual} KM/H";
            }
        }
        public bool EstadoEncendido()
        {
            return encendido;
        }
        public DSAutomovil(string marcaCarro, int velocidadMX)
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMX;
        } 
        public string EncenderMotor()
        {
            if (encendido)
            {
                return "El vehiculo ya esta encendido";

            } else
            {
                encendido = true;
                velocidadActual = 0;
                return "Excelete!!! Vehiculo encendido";
            }          
        }
    }
}
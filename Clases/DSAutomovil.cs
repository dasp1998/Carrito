using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Clases
{
    class DSAutomovil
    {
        public String marca { get; }

        public int vel_max { get;  }

        private int velocidadactual { get; set; }

        private bool encendido = false;

        public String color { get; set; }

        public string Acelerar()
        {
            velocidadactual = velocidadactual + 10;
            if (velocidadactual > vel_max)
            {
                return "lo lamento, llegaste a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadactual} KPH";
            }

        }

        


            
        



    }
}

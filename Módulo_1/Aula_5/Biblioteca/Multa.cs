using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Multa
    {
        public double valorMultaDia { get; set; } = 2;
        public bool valorPendente { get; set; } = false;
        public double valorMulta { get; set; } = 0;
       
        public Multa() { }
        
        public void CalcularMulta(int diasAtraso)
        {
            valorMulta = diasAtraso * valorMultaDia;
            valorPendente = true;
        }

        public void PagarMulta()
        {
            valorPendente = false;
        }
    }
}

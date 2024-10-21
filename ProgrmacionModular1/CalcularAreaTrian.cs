using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrmacionModular1
{
    internal class CalcularAreaTrian
    {
        public class triangulo
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public triangulo (double baseT, double alturaT)
            {
                Base = baseT;
                Altura = alturaT;
            }

            public double CalcularArea()
            {
                return (Base*Altura) / 2;
            }
        }
    }
}


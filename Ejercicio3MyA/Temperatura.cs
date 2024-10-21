using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3MyA
{
    internal class Temperatura
    {

        public List<double> Celsius { get; private set; }

        public Temperatura()
        {
            Celsius = new List<double>();
        }

        public void AgregarTemperatura(double temperatura)
        {
            Celsius.Add(temperatura);
        }

        public void MostrarTemperaturas()
        {
            Console.WriteLine("Temperaturas en Celsius:");
            foreach (var temp in Celsius)
            {
                Console.WriteLine(temp);
            }
        }
    }

}

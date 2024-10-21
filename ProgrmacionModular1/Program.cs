using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrmacionModular1.CalcularAreaTrian;

namespace ProgrmacionModular1
    //Programa que calcula el aerea de un triangulo 
    //Ejercicio de la guia 1 

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la base del triangulo");
            double baseT= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite la altura del triangulo");
            double alturaT=Convert.ToDouble(Console.ReadLine());


            triangulo triangulo = new triangulo(baseT,alturaT);
            double area = triangulo.CalcularArea();

            Console.WriteLine($"El área del triángulo es: {area}");
            Console.ReadKey();

        }
    }
}

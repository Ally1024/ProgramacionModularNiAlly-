using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3MyA
    //Programa que calcula y muestra la temperatura en sus diistintas medidas
    //Ejercicio3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temperatura = new Temperatura();
            var conversion = new Conversion();
            string continuar;

            do
            {
                Console.Write("Ingrese una temperatura en Celsius: ");
                double tempCelsius = Convert.ToDouble(Console.ReadLine());
                temperatura.AgregarTemperatura(tempCelsius);

                temperatura.MostrarTemperaturas();

                var temperaturasFahrenheit = conversion.ConvertirAFahrenheit(temperatura.Celsius);
                var temperaturasKelvin = conversion.ConvertirAKelvin(temperatura.Celsius);

                conversion.MostrarTemperaturas(temperaturasFahrenheit, "Fahrenheit");
                conversion.MostrarTemperaturas(temperaturasKelvin, "Kelvin");

                Console.Write("¿Desea eliminar una temperatura en Fahrenheit? (escriba -1 para no eliminar): ");
                double tempAEliminar = Convert.ToDouble(Console.ReadLine());

                if (tempAEliminar != -1)
                {
                    conversion.EliminarTemperatura(temperaturasFahrenheit, tempAEliminar);
                    conversion.MostrarTemperaturas(temperaturasFahrenheit, "Fahrenheit actualizadas");
                }

                Console.Write("¿Desea continuar? (s/n): ");
                continuar = Console.ReadLine();
            } while (continuar.ToLower() == "s");

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
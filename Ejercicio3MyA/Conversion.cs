using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3MyA
{
    internal class Conversion
    {

           public List<double> ConvertirAFahrenheit(List<double> celsius)
    {
        var fahrenheit = new List<double>();
        foreach (var temp in celsius)
        {
            fahrenheit.Add((temp * 9 / 5) + 32);
        }
        return fahrenheit;
    }

    public List<double> ConvertirAKelvin(List<double> celsius)
    {
        var kelvin = new List<double>();
        foreach (var temp in celsius)
        {
            kelvin.Add(temp + 273.15);
        }
        return kelvin;
    }

    public void MostrarTemperaturas(List<double> temperaturas, string tipo)
    {
        Console.WriteLine($"Temperaturas en {tipo}:");
        foreach (var temp in temperaturas)
        {
            Console.WriteLine(temp);
        }
    }

    public void EliminarTemperatura(List<double> temperaturas, double temperaturaAEliminar)
    {
        temperaturas.Remove(temperaturaAEliminar);
    }
    }
}

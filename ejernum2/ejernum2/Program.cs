using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejernum2.ventasDiarias;

namespace ejernum2
{
    internal class Program
    {



        static void Main(string[] args)
        {
                // este progarama que Permite mostrar las ventas, calcular el total vendido
                // y encontrar el día con más ventas de un negocio:)
                //llamo a todos mis metodos 

                // Llamo al metodo de inicio
                VentasDiariasManager.ImprimeInicio();

               // instancia del manager de ventas y mostrar las ventas
                VentasDiariasManager manager = new VentasDiariasManager();
                manager.ImprimirVentas();

               // llamo mi metodo que calcula y muestra el total vendido
                int total = manager.TotalVendido();
               Console.WriteLine($"El total vendido es: {total}.");

               //llamo a mi metodo  que encuentra y muestra el día con más ventas
                 string diaMasVentas = manager.DiaMas();
                 Console.WriteLine($"El día con más ventas es: {diaMasVentas}");
                
                Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejernum2
{
    internal class ventasDiarias
    {
        // struct de ventas diarias
        public struct VentasDiarias
        {
            public string Dia;
            public string Producto;
            public int Cantidad;
            public int Precio;

            // Constructor para inicializar
            public VentasDiarias(string dia, string producto, int cantidad, int precio)
            {
                Dia = dia;
                Producto = producto;
                Cantidad = cantidad;
                Precio = precio;
            }

            // Método para mostrar la información de la venta
            public void Mostrar()
            {
                Console.WriteLine($"Día: {Dia}");
                Console.WriteLine($"Producto: {Producto}");
                Console.WriteLine($"Cantidad: {Cantidad}");
                Console.WriteLine($"Precio: {Precio}");
            }
        }

        // Clase para gestionar las ventas
        internal class VentasDiariasManager
        {
            // Arreglo para almacenar las ventas
            private VentasDiarias[] ventas;

            // Constructor para inicializar las ventas
            public VentasDiariasManager()
            {
                ventas = new VentasDiarias[4];
                ventas[0] = new VentasDiarias("Martes", "Short", 3, 7);
                ventas[1] = new VentasDiarias("Miércoles", "Camisa polo", 4, 10);
                ventas[2] = new VentasDiarias("Jueves", "Pantalón", 2, 20);
                ventas[3] = new VentasDiarias("Viernes", "Falda corta", 6, 10);
            }

            // Método para imprimir las ventas diarias
            public void ImprimirVentas()
            {
                Console.WriteLine();
                Console.WriteLine("Ventas diarias de los productos:");
                foreach (var venta in ventas)
                {
                    venta.Mostrar();
                    Console.WriteLine(); // Espacio entre ventas
                }
            }

            //metodo para calcualr el total vendido 
            public int TotalVendido()
            {
                int total = 0;

                // Recorre el arreglo de ventas y suma (Cantidad * Precio)
                foreach (var venta in ventas)
                {
                    total += venta.Cantidad * venta.Precio;
                }

                return total;

            }
            // Método para encontrar el día con la mayor cantidad de ventas
            public string DiaMas()
            {
                int mayorCantidad = 0; // Almacena la mayor cantidad encontrada
                string diaConMasVentas = ""; // Almacena el día correspondiente

                // Recorre el arreglo de ventas
                foreach (var venta in ventas)
                {
                    if (venta.Cantidad > mayorCantidad)
                    {
                        mayorCantidad = venta.Cantidad; // Actualiza la mayor cantidad
                        diaConMasVentas = venta.Dia;    // Actualiza el día correspondiente
                    }
                }

                return diaConMasVentas;
            }


            // Método estático de inicio
            public static void ImprimeInicio()
            {
                Console.WriteLine("Sistema de ventas diarias.");
            }
        }

      
       

    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MyA
{
    //Programa que guarda ty registra a persosnas
    // Ejercicio1
    internal class Program
    {
        static void Main(string[] args)
        {
            Registro registro = new Registro();
            string opcion;

            // Solicitar datos hasta que el usuario decida
            do
            {
                Console.WriteLine("Ingrese los datos de la persona:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();
                Console.Write("Teléfono: ");
                string telefono = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                registro.AgregarPersona(nombre, direccion, telefono, edad);

                Console.WriteLine("¿Desea agregar otra persona? (s/n)");
                opcion = Console.ReadLine();
            } while (opcion.ToLower() == "s");

            // Menú de opciones
            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Mostrar la lista de todos los nombres.");
                Console.WriteLine("2. Mostrar las personas de una cierta edad.");
                Console.WriteLine("3. Mostrar las personas que coincidan con un nombre.");
                Console.WriteLine("4. Salir.");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        registro.MostrarNombres();
                        break;
                    case "2":
                        Console.Write("Ingrese la edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        registro.MostrarPorEdad(edad);
                        break;
                    case "3":
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscado = Console.ReadLine();
                        registro.MostrarPorNombre(nombreBuscado);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;

                }
                // Espera a que el usuario presione una tecla antes de continuar
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != "4");
        }
    }
}
        
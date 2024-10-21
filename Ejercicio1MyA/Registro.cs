using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MyA
{
    internal class Registro
    {
        public struct Persona
        {
            public string Nombre;
            public string Direccion;
            public string Telefono;
            public int Edad;

            public Persona(string nombre, string direccion, string telefono, int edad)
            {
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Edad = edad;
            }
        }

        private Persona[] personas = new Persona[10];
        private int contador = 0;

        public void AgregarPersona(string nombre, string direccion, string telefono, int edad)
        {
            if (contador < 10)
            {
                personas[contador] = new Persona(nombre, direccion, telefono, edad);
                contador++;
            }
            else
            {
                Console.WriteLine("Se ha alcanzado el límite de 10 personas.");
            }
        }

        public void MostrarNombres()
        {
            Console.WriteLine("\nLista de nombres:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(personas[i].Nombre);
            }
        }

        public void MostrarPorEdad(int edad)
        {
            Console.WriteLine($"\nPersonas de {edad} años:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].Edad == edad)
                {
                    Console.WriteLine(personas[i].Nombre);
                }
            }
        }

        public void MostrarPorNombre(string nombre)
        {
            Console.WriteLine($"\nPersonas con el nombre {nombre}:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Nombre: {personas[i].Nombre}, Dirección: {personas[i].Direccion}, Teléfono: {personas[i].Telefono}, Edad: {personas[i].Edad}");
                }
            }
        }
    }
}

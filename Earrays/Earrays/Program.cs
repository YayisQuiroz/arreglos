using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un arreglo de cadenas
            string[] nombres = new string[] { "Juan", "María", "Pedro", "Luisa" };

            // Imprimir el arreglo en la consola
            Console.WriteLine("Los nombres en el arreglo son:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.ReadKey();
        }
    }
}

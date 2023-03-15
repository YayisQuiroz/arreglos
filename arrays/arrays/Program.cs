using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main()
        {
            // Arreglo multidimensional 
            int[,] matrix = new int[3, 3] {
            {1, 2, 3},
            {4, 5, 5},
            {7, 3, 9}
        };

            // Arreglo unidimensional
            int[] filasumas = new int[3];

            // Calcula la suma de cada fila y la guarda en el arreglo unidimensional
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sumafila = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumafila += matrix[i, j];
                }
                filasumas[i] = sumafila;
            }

            // Imprime la matriz y la suma de cada fila
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada fila:");
            for (int i = 0; i < filasumas.Length; i++)
            {
                Console.WriteLine("Fila " + (i + 1) + ": " + filasumas[i]);
            }
            Console.ReadKey();
        }
    }
   
}

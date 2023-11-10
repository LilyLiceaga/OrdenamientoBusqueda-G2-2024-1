using System;
using System.Diagnostics;
using System.Threading;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Stopwatch stopwatch = Stopwatch.StartNew();

            //int[] A = { 5, 7, 1, 3, 12, 20, 8 };
            int[] A = { 1, 3, 5, 7, 8, 12, 20 };
            int x = 9;
            //int i = Busqueda.Lineal(A, 8);
            int i = Busqueda.Binario(A, 0, A.Length, x);
            if (i != -1)
            {
                Console.WriteLine("El valor {0} está en la posición {1}", x, i+1);
            }
            else
            {
                Console.WriteLine("Número no encontrado");
            }
          //int[] A = Ordenamiento.Generar(1000);

          /*Console.WriteLine("******** Matriz Original ********");
            Ordenamiento.Imprime(A);

            //Midiendo el tiempo de ejecución
            stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();

            Console.WriteLine("\n\n******** Matriz Ordenada ********");
            Ordenamiento.Imprime(A);

            Console.WriteLine("\n\nTiempo de ejecución: {0} [ms]", stopwatch.ElapsedMilliseconds);
          */
            Console.ReadLine();

        }
    }
}

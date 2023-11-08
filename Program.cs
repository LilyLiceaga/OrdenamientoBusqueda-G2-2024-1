using System;
using System.Diagnostics;
using System.Threading;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            //int[] A = { 5, 7, 1, 12, 20, 8 };
            int[] A = Ordenamiento.Generar(1000);

            Console.WriteLine("******** Matriz Original ********");
            Ordenamiento.Imprime(A);

            //Midiendo el tiempo de ejecución
            stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();

            Console.WriteLine("\n\n******** Matriz Ordenada ********");
            Ordenamiento.Imprime(A);

            Console.WriteLine("\n\nTiempo de ejecución: {0} [ms]", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}

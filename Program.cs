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

            //int[] A = { 5, 7, 1, 3, 12, 20, 8 };
            #region BUSQUEDA
            /*int[] A = { 1, 3, 5, 7, 8, 12, 20 };
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
            */
            #endregion

            int[] A = Ordenamiento.Generar(1000);

            #region BURBUJA
            /*Console.WriteLine("\n\n\n--------- BURBUJA ---------");
            Console.WriteLine("\n\n******** Matriz Original ********\nSIN IMPRIMIR");
            //Ordenamiento.Imprime(A);

            //Midiendo el tiempo de ejecución
            stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();

            Console.WriteLine("\n\n******** Matriz Ordenada ********\nSIN IMPRIMIR");
            //Ordenamiento.Imprime(A);

            Console.WriteLine("\n\nTiempo de ejecución: {0} [ms]", stopwatch.ElapsedMilliseconds);*/
            #endregion
            
            #region BARAJA
            /*
            Console.WriteLine("\n\n\n--------- BARAJA ---------");
            Console.WriteLine("\n\n******** Matriz Original ********\nSIN IMPRIMIR");
            //Ordenamiento.Imprime(A);


            stopwatch.Start();
            Ordenamiento.Baraja(A);
            stopwatch.Stop();

            Console.WriteLine("\n\n******** Matriz Ordenada ********\nSIN IMPRIMIR");
            //Ordenamiento.Imprime(A);

            Console.WriteLine("\n\nTiempo de ejecución: {0} [ms]", stopwatch.ElapsedMilliseconds);
            */
            #endregion


            #region QUICKSORT
            Console.WriteLine("\n\n\n--------- QUCKSORT ---------");
            Console.WriteLine("\n\n******** Matriz Original ********\nSIN IMPRIMIR");
            //Ordenamiento.Imprime(A);

            stopwatch.Start();
            Ordenamiento.QuickSort(A, 0, A.Length - 1);
            stopwatch.Stop();

            Console.WriteLine("\n\n******** Matriz Ordenada ********\nSIN IMPRIMIR"); 
            //Ordenamiento.Imprime(A);
            Console.WriteLine("\n\nTiempo de ejecución: {0} [ms]", stopwatch.ElapsedMilliseconds);
            
            #endregion


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 5, 7, 1, 12, 20, 8 };
            int[] A = Ordenamiento.Generar(100);

            Console.WriteLine("******** Matriz Original ********");
            Ordenamiento.Imprime(A);
            Ordenamiento.Burbuja(A);
            Console.WriteLine("\n******** Matriz Ordenada ********");
            Ordenamiento.Imprime(A);

            Console.ReadLine();
        }
    }
}

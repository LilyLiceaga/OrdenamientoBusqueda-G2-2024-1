using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Ordenamiento
    {
        internal static void Imprime(int[]A)
        {
            foreach (int a in A)
            {
                Console.Write("{0} ", a);
            }
        }
        internal static void Burbuja(int [] A)
        {
            int N = A.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (!(A[j] < A[j + 1 ]))
                    {
                        int Aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1 ] = Aux;
                    }
                }
            }
        }
    }
}

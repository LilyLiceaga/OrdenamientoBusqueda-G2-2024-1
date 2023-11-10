using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Ordenamiento
    {
        internal static int[] Generar(int N) //generamos un vector aleatorio
        {

            Random aleatorio = new Random();
            int [] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = (int)(aleatorio.NextDouble() * 10000);
            }

            return A;
        }

        internal static void Imprime(int[]A)
        {
            foreach (int a in A)
            {
                Console.Write("{0} ", a);
            }
        }

        internal static void Burbuja(int [] A) //BUBBLE SORT
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
        
        internal static void Baraja (int [] A) //SHELL SORT
        {
            int N = A.Length;
            int b = N / 2;

            while (b > 0)
            {
                for (int i = b; i < N; i++)
                {
                    int temp = A[i];
                    int j = i;

                    while (j >= b && A[j - b] > temp)
                    {
                        A[j] = A[j - b];
                        j -= b;
                    }

                    A[j] = temp;
                }

                b /= 2;
            }
        }
        internal static void QuickSort (int [] A, int IZQ, int DER) //SHELL SORT
        {
            if (IZQ < DER)
            {
                int indiceParticion = Particionar(A, IZQ, DER);

                QuickSort(A, IZQ, indiceParticion - 1);
                QuickSort(A, indiceParticion + 1, DER);
            }

        }

        static int Particionar(int[] A, int IZQ, int DER)
        {
            int pivot = A[DER];
            int indiceMenor = IZQ - 1;

            for (int i = IZQ; i < DER; i++)
            {
                if (A[i] < pivot)
                {
                    indiceMenor++;
                    Intercambiar(A, indiceMenor, i);
                }
            }

            Intercambiar(A, indiceMenor + 1, DER);
            return indiceMenor + 1;
        }

        static void Intercambiar(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }    
}


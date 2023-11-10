using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBusqueda_G2_2024_1
{
    internal class Busqueda
    {
        internal static int Lineal(int[] A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
        internal static int Binario(int[] A, int IZQ, int DER, int x)
        {
            if (DER <= IZQ)
            {
                return -1;
            }
            else
            {
                int CEN = (IZQ + DER) / 2;

                if ( A[CEN] == x )
                {
                    return CEN;
                }
                else if ( x < A[CEN] )
                {
                    return Binario(A, IZQ, CEN, x);
                }
                else if (x > A[CEN])
                {
                    return Binario(A, CEN, DER, x);
                }
            }

            return 0;
        }
    }
}

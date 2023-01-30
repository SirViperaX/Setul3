using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema7
    {
        public static void P7()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            for (int i = 0; i < Testing.n / 2; i++)
            {
                int aux = A[i];
                A[i] = A[Testing.n - 1 - i];
                A[Testing.n - 1 - i] = aux;
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
            {
                Console.Write($"{A[i]} ");
            }
        }
    }
}

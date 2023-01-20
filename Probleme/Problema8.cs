using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema8
    {
        public static void p8()
        {

            int[] A = Testing.GenerateRandomNumbersInArray();
            int k = A[0];
            for (int i = 0; i < Testing.n - 1; i++)
            {
                A[i] = A[i + 1];
            }
            A[Testing.n - 1] = k;
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
            {
                Console.Write($"{A[i]} ");
            }
        }
    }
}

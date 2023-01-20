using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema11
    {
        public static void P11()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            for (int i = 0; i < Testing.n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Testing.n; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }

                int temp = A[min];
                A[min] = A[i];
                A[i] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}

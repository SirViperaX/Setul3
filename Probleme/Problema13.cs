using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema13
    {
        public static void P13()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            for (int i = 1; i < Testing.n; ++i)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}

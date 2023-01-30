using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema6
    {
        public static void P6()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.ReadArrayFromKb();*/
            Console.WriteLine("Introduceti valoarea lui k:");
            int k = int.Parse(Console.ReadLine());
            int[] B = new int[Testing.n - 1];
            for (int i = 0, j = 0; i < A.Length && j < B.Length; i++, j++)
            {
                if (k != i)
                    B[j] = A[i];
                else
                {
                    i++;
                    B[j] = A[i];
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
    }
}

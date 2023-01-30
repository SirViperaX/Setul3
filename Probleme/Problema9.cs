using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema9
    {
        public static void P9()
        {    
            int[] A = Testing.GenerateRandomNumbersInArray();
            Console.WriteLine("Introduceti valoarea lui k:");
            int k = int.Parse(Console.ReadLine());
            int[] B = new int[Testing.n];
            int temp = Testing.n - k;
            int j = 0;
            for (int i = k; i < Testing.n; i++)
            {
                B[j] = A[i];
                j++;
            }
            for (int i = 0; i < k; i++)
            {
                B[j] = A[i];
                j++;
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
    }
}

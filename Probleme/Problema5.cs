using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema5
    {
        public static void P5()
        {
            Console.WriteLine("Introduceti valoarea lui e:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k:");
            int k = int.Parse(Console.ReadLine());
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.ReadArrayFromKb();*/
            int[] B = new int[Testing.n +1];
            for(int i = 0, j = 0; i < Testing.n && j <= Testing.n; i++, j++) 
            {
                if (k != i)
                    B[j] = A[i];
                else
                {
                    B[j] = e;
                    j++;
                    B[j] = A[i];
                }
            }
            for (int i = 0; i <= Testing.n; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
    }
}

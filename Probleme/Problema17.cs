using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema17
    {
        public static void P17()
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b:");
            int b = int.Parse(Console.ReadLine());
            int[] A = new int[32];
            int i = 0;
            while (n > 0)
            {
                A[i] = n % b;
                n /= b;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.Write($"{A[j]} ");
        }
    }
}

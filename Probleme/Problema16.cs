using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema16
    {
       public static void P16()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            int a = A[0];
            int b, r;
            for (int i = 1; i < Testing.n; i++)
            {
                r = a % A[i];
                while (r > 0)
                {
                    a = A[i];
                    A[i] = r;
                    r = a % A[i];
                }
                a = A[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Cmmdc al vectorului este {a}");

        }
    }
}

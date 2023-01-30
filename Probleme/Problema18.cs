using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema18
    {
        public static void P18()
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            Console.WriteLine("Introduceti valoarea lui x: ");
            int x = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result = result + A[i] * (int)Math.Pow(x, i);
            }
            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {result}");

        }
    }
}

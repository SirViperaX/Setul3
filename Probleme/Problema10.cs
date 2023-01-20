using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema10
    {
        public static void P10()
        {
            int[] A = Testing.GenerateAscendingOrderedArray();
            Console.WriteLine("Introduceti valoarea lui k:");
            int k = int.Parse(Console.ReadLine());
            int left = 0;
            int right = A.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (k == A[mid])
                {
                    Console.WriteLine($"Pozitia lui k este:{mid}");
                    return;
                }
                else if (k < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine(-1);
        }
    }
}

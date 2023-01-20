using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema2
    {
        public static void p2()
        {
            Console.WriteLine("Introduceti valoarea cautata:");
            int k = int.Parse(Console.ReadLine());
            int pozitie = -1;
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.GenerateArray();*/
            for (int i = 0; i < Testing.n; i++)
            {
                if (A[i] == k)
                    pozitie = i;
            }
            Console.WriteLine($"Prima pozitie pe care k( {k} ) este {pozitie}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema1
    {
        public static void p1()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.GenerateArray();*/
            Console.WriteLine("Introduceti valori in vector:");
            string[] t = Console.ReadLine().Split(' ');
            int s = 0;
            for (int i = 0; i < Testing.n; i++)
            {
                A[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < Testing.n; i++)
            {
                s += A[i];
            }
            Console.WriteLine($"Suma elementelor este {s}");
        }
    }
}

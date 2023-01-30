using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema14
    {
        public static void P14()
        {
            int[] A = Testing.ReadArrayFromKb();
            int nonZeroPointer = 0;
            for (int i = 0; i < Testing.n; i++)
            {
                if (A[i] != 0)
                {
                    int temp = A[nonZeroPointer];
                    A[nonZeroPointer] = A[i];
                    A[i] = temp;
                    nonZeroPointer++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}

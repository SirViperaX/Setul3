using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema15
    {
        public static void P15()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            for(int i = 0; i < Testing.n - 1; i++)
            {
                for(int j = i + 1; j < Testing.n; j++)
                {
                    if (A[i] == A[j])
                    {
                        int counter = 0;
                        for (int k = j; k < Testing.n; k++)
                            if (A[j] == A[k])
                                counter++;
                            else
                                break;
                        while (counter > 0)
                        {
                            for (int k = j; k < Testing.n - 1; k++)
                                A[k] = A[k + 1];
                            counter--;
                            Testing.n--;
                        }
                        
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < Testing.n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema3
    {
        public static void p3()
        {
            int i;
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.GenerateArray();*/
            int max, min, poz_max, poz_min;
            int comparatii = 0;
            if (Testing.n % 2 == 0)
            {
                if (A[0] > A[1])
                {
                    max = A[0];
                    min = A[1];
                    poz_max = 0;
                    poz_min = 1;
                }
                else
                {
                    min = A[0];
                    max = A[1];
                    poz_min = 0;
                    poz_max = 1;
                }
                i = 2;
                comparatii+=2;
            }
            else
            {
                min = A[0];
                max = A[0];
                poz_min = 0;
                poz_max = 0;
                i = 1;
                comparatii++;
            }

            while (i < Testing.n - 1)
            {
                if (A[i] > A[i + 1])
                {
                    if (A[i] > max)
                    {
                        max = A[i];
                        poz_max = i;
                    }
                    if (A[i + 1] < min)
                    {
                        min = A[i + 1];
                        poz_min = i + 1;
                    }
                    comparatii+=3;
                }
                else
                {
                    if (A[i + 1] > max)
                    {
                        max = A[i + 1];
                        poz_max = i + 1;
                    }
                    if (A[i] < min)
                    {
                        min = A[i];
                        poz_min = i;
                    }
                    comparatii+=3;
                }
                i += 2;
            }
            Console.WriteLine($"Pozitia minimului este {poz_min}(valoarea: {min}), iar pozitia maximului este {poz_max}(valoarea: {max})");
            Console.WriteLine($"Numarul de comparatii este {comparatii}");
        }
       
    }
}


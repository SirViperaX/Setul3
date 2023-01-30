using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema4
    {
        public static void P4()
        {
            int i = 0;
            int[] A = Testing.GenerateRandomNumbersInArray();
            /*int[] A = Testing.ReadArrayFromKb();*/
            int max, min, apar_max, apar_min;
            min = A[0];
            max = A[1];

            if (max == min)
                apar_min = apar_max = 2;
            else
                apar_min = apar_max = 1;

            while (i < Testing.n)
            {
                if (A[i] == max)
                    apar_max++;
                if (A[i] == min)
                    apar_min++;
                if (A[i] > max)
                {
                    max = A[i];
                    apar_max = 1;
                }
                if (A[i] < min)
                {
                    min = A[i];
                    apar_min = 1;
                }
                i++;
            }
            Console.WriteLine($"Minimul apare de {apar_min}(valoarea: {min})de ori, iar maximul apare de {apar_max}(valoarea: {max})de ori");
        }
    }
}


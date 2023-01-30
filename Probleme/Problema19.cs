using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema19
    {
        public static void P19()
        {
            int[] S = Testing.ReadArrayFromKb();
            int[] P = Testing.ReadArrayFromKb();
            int nr = 0;
            for (int i = 0; i < S.Length - P.Length + 1; i++)
            {
                if (S[i] == P[0])
                {
                    bool ok = true;
                    for (int j = 1; j < P.Length; j++)
                        if (P[j] != S[i + j])
                            ok = false;
                    if (ok) nr++;
                }
            }
            Console.WriteLine();
            Console.Write($"p apare in s de {nr} ori");
        }
    }
}

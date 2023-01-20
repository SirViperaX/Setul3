using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Problema26
    {
        public static void P26()
        {
            Console.WriteLine("Introduceti un numar mare:");
            string number1 = Console.ReadLine();
            int[] num1 = new int[number1.Length];
            int i = 0;
            foreach (char c in number1)
            {
                num1[i] = c - '0';
                i++;
            }
            Console.WriteLine("Introduceti un numar mare:");
            string number2 = Console.ReadLine();
            int[] num2 = new int[number1.Length];
            i = 0;
            foreach (char c in number1)
            {
                num2[i] = c - '0';
                i++;
            }
            //adunare
            int j;    
        }
    }
}

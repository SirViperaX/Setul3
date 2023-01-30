using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    public class Testing
    {
        public static int n;

        public static int[] GenerateRandomNumbersInArray()
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            Testing.n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vectorul de {n} elemente");
            Random rnd = new Random();
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(1, 100);
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
            return A;
        }

        public static int[] GenerateAscendingOrderedArray()
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            Testing.n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vectorul de {n} elemente");
            Random rnd = new Random();
            int[] A = new int[n];
            A[0] = rnd.Next(1, n);
            Console.Write($"{A[0]} ");
            for (int i = 1; i < n; i++)
            {
                A[i] = rnd.Next(A[i-1]+1, A[i-1]+30);
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
            return A;
        }

        public static int[] ReadArrayFromKb()
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            Testing.n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Introduceti valori in vector:");
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(t[i]);
            }
            return A;
        }

    }
}

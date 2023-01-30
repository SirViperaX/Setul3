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
            int[] num2 = new int[number2.Length];
            i = 0;
            foreach (char c in number2)
            {
                num2[i] = c - '0';
                i++;
            }
            int[] suma = Suma(num1, num2);
            Console.WriteLine("Suma");
            foreach(int x in suma)
                Console.Write(x);
            int[] dif = Diferenta(num1, num2);
            Console.WriteLine();
            Console.WriteLine("Diferenta");
            foreach (int x in dif)
                Console.Write(x);
            Console.WriteLine();
            Console.WriteLine("Produsul");
            int[] produs = new int[num1.Length + num2.Length];
            for (int n1 = 0; n1 < num1.Length; n1++) 
            {
                produs = Suma(Produs(num1, num2, n1), produs);
            }
            foreach (int x in produs)
                Console.Write(x);
        }
        static int[] Suma(int[] num1, int[] num2)
        {
            int n = Math.Max(num1.Length, num2.Length);
            int min = Math.Min(num1.Length, num2.Length);
            int[] suma = new int[n + 1];
            int k = n;
            for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (num1[i] + num2[j] + suma[k] > 9)
                {
                    int s = num1[i] + num2[j];
                    suma[k] += s % 10;
                    suma[k - 1]++;
                    k--;
                    if (suma[k+1]==10)
                        suma[k+1] = 0;
                }
                else if(num1[i] + num2[j] + suma[k] <= 9)
                {
                    suma[k] = num1[i] + num2[j] + suma[k];
                    k--;
                }
            }
            if (n == num2.Length)
                for (int i = k-1; i >= 0; i--, k--)
                    suma[k] += num2[i];
            else
                for (int i = k-1; i >= 0; i--, k--)
                    suma[k] += num1[i];

            return suma;
        }

        static int[] Produs(int[] num1, int[] num2, int n1)
        {
            int[] X = new int[num1.Length + num2.Length];
            int j = n1;
            for (int i = num2.Length - 1; i >= 0; i--)
            {
                if(num1[n1] * num2[i] + X[j]>9)
                {
                    X[j] = (num1[n1] * num2[i])%10 + X[j];
                    j++;
                }
            }
            return X;
                
        }
        static int[] Diferenta(int[] num1, int[] num2)
        {
            int n = Math.Max(num1.Length, num2.Length);
            int cond = Math.Max(num1[0], num2[0]);
            int[] diferenta = new int[n];
            int k = n - 1;
            if (n == num1.Length && cond == num1[0])
            {
                for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (num1[i] - num2[j] >= 0)
                    {
                        diferenta[k] = num1[i] - num2[j];
                        k--;
                    }
                    else
                    {
                        num1[i] += 10;
                        diferenta[k] = num1[i] - num2[j];
                        int aux = i - 1;
                        while (num1[aux] == 0)
                        {
                            num1[aux] = 9;
                            aux--;
                        }
                        num1[aux]--;
                        k--;
                    }
                }
            }
            else if (n == num2.Length && cond == num2[0])
            {
                for (int i = num2.Length - 1, j = num1.Length - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (num2[i] - num1[j] >= 0)
                    {
                        diferenta[k] = num2[i] - num1[j];
                        k--;
                    }
                    else
                    {
                        num2[i] += 10;
                        diferenta[k] = num2[i] - num1[j];
                        int aux = i - 1;
                        while (num2[aux] == 0)
                        {
                            num2[aux] = 9;
                            aux--;
                        }
                        num2[aux]--;
                        k--;
                    }
                }
                
            }
            if (n == num2.Length && cond == num2[0])
            {
                for (int i = k; i >= 0; i--, k--)
                    diferenta[k] += num2[i];
                diferenta[k + 1] *= -1;
            }
            else if(n == num1.Length && cond == num1[0])
                for (int i = k; i >= 0; i--, k--)
                    diferenta[k] += num1[i];
                
            return diferenta;
        }
    }
}

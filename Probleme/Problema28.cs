using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3.Probleme
{
    public class Problema28
    {
        public static void p28()
        {
            int[] A = Testing.GenerateRandomNumbersInArray();
            QuickSort(A, 0, Testing.n - 1);
            Console.WriteLine();
            foreach(int i in A)
                Console.Write(i);
        }

        static int Partition(int[] A, int low, int high)
        {
            int pivot = A[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (A[j] <= pivot)
                {
                    i++;
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            int temp1 = A[i + 1]; 
            A[i + 1] = A[high];
            A[high] = temp1;
            return i + 1;
        }
        static void QuickSort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int part = Partition(A, low, high);
                QuickSort(A, low, part - 1);
                QuickSort(A, part + 1, high);
            }
        }
    }
}

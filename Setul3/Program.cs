using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int[] ints = InitArray(10);
            PrintArray(ints);
            Console.WriteLine();
            QuickSort(ints);
            PrintArray(ints);
        }
        private static int Partition(int[] ints, int st, int dr)
        {
            int k = st;
            for (int i = st + 1; i <= dr; i++)
                if (ints[i] < ints[st])
                {
                    k++;
                    (ints[i], ints[k]) = (ints[k], ints[i]);
                }
            (ints[st], ints[k]) = (ints[k], ints[st]);
            return k;
        }
        private static void QuickSort(int[] ints)
        {
            QuickSortHelper(ints, 0, ints.Length - 1);
        }

        private static void QuickSortHelper(int[] ints, int st, int dr)
        {
            if (st < dr)
            {
                int idx = r.Next(st, dr + 1);
                (ints[st], ints[idx]) = (ints[idx], ints[st]);
                int k = Partition(ints, st, dr);

                QuickSortHelper(ints, st, k - 1);
                QuickSortHelper(ints, k + 1, dr);
            }
        }
        private static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
        private static int[] InitArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-99, 100);
            }
            return arr;
        }
    }
}

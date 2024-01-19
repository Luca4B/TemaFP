using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = InitArray(10);
            
            SelectionSort(ints);
            foreach (int element in ints)
                Console.WriteLine(element + ' ');
        }
        private static int[] InitArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            return arr;
        }
        private static void SelectionSort(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < ints.Length; j++)
                    if (ints[j] < ints[k])
                        k = j;
                int aux;
                aux = ints[i];
                ints[i] = ints[k]; ;
                ints[k] = aux;
            }
        }
    }
}

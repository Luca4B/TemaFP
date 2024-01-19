using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n");
            int n = int.Parse(Console.ReadLine());
            
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu pe k");
            int k = int.Parse(Console.ReadLine());

            RotateLeft(vector, k);

            Console.WriteLine($"Vectorul rotit la stanga cu {k} elemente este");
            foreach(int element in vector)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        private static void RotateLeft(int[] vector, int k)
        {
            int n = vector.Length;
            k %= vector.Length;

            ReverseArray(vector, 0, k - 1);
            ReverseArray(vector, k, n - 1);
            ReverseArray(vector, 0, n - 1);

        }

        private static void ReverseArray(int[] vector, int start, int end)
        {
            while (start < end)
            {
                int temp = vector[start];
                vector[start] = vector[end];
                vector[end] = temp;
                start++;
                end--;
            }
        }
    }
}

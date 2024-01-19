using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
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

            for (int i = 0; i < vector.Length / 2; i++)
            {
                int aux = vector[i];
                vector[i] = vector[vector.Length - i - 1];
                vector[vector.Length - i - 1] = aux;
            }

            Console.WriteLine("Vectorul dupa schimbare");
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
        }
    }
}

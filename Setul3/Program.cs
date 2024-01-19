using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
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

            int aux = vector[0];
            for (int i = 1; i < vector.Length; i++)
                vector[i - 1] = vector[i];
            vector[vector.Length - 1] = aux;

            Console.WriteLine("Vectorul dupa modificare");
            for (int i = 0;i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
        }
    }
}

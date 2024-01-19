using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 2, 3, 4, 5 };
            int[] v2 = { 3, 4, 5, 6, 7 };

            var intersectie = v1.Intersect(v2);
            Console.WriteLine($"Intersectia: " + intersectie);
            foreach (int element in intersectie)
                Console.Write(element + " ");
            Console.WriteLine();

            var reuniune = v1.Union(v2);
            Console.WriteLine($"Reuniunea: " + reuniune);
            foreach (int element in reuniune)
                Console.Write(element + " ");
            Console.WriteLine();

            var diferentav1v2 = v1.Except(v2);
            Console.WriteLine($"Diferenta v1 - v2: " + diferentav1v2);
            foreach (int element in diferentav1v2)
                Console.Write(element + " ");
            Console.WriteLine();

            var diferentav2v1 = v2.Except(v1);
            Console.WriteLine($"Diferenta v2 - v1: " + diferentav2v1);
            foreach (int element in diferentav2v1)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}

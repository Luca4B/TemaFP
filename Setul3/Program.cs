using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele");
            for(int i = 0; i < n; i++)            
                vector[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < vector.Length; i++)
                suma += vector[i];
            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }
    }
}

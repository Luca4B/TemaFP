using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu pe k:");
            int k = int.Parse(Console.ReadLine());
            int d = -1;
            for (int i = 0; i < vector.Length; i++)
                if (vector[i] == k)
                {
                    d = vector[i];
                    break;
                }
            Console.WriteLine($"Numarul {k} apare pe pozitia {d}");
        }
    }
}

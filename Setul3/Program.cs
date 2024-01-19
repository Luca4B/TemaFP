using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
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
            Console.WriteLine("Introdu pe e:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu pe K:");
            int k = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)           
                if (vector[i] == k)
                {
                    vector[i] = e;
                    break;
                }
            Console.WriteLine("Secventa dupa schimbare:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(vector[i] + " ");
        }
    }
}

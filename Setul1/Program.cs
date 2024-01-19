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
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introdu pe a: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Introdu pe b: ");
            int b = int.Parse(Console.ReadLine());
            int contor = 0;
            for(int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    contor++;
            }
            Console.WriteLine($"In intervalul [{a},{b}] se afla {contor} nummer divizibile cu {n}");
        }
    }
}

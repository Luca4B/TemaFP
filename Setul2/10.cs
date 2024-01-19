using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele");
            int d1 = int.Parse(Console.ReadLine());
            int scurrent = 1;
            int smax = 1;
            for(int i = 1; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d == d1)
                    scurrent++;
                else
                {
                    if (scurrent > smax)
                        smax = scurrent;
                    scurrent = 1;
                }
                d1 = d;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {smax}");
        }
    }
}

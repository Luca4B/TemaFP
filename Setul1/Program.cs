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
            int x;
            Console.Write("Introdu numarul: ");
            x=int.Parse(Console.ReadLine());
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    Console.Write($"{i}, ");
            }
        }
    }
}

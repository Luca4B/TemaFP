using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n=int.Parse(Console.ReadLine());
            int ogl=0;
            int c = n;
            while(c>0)
            {
                ogl = ogl * 10 + c%10;
                c/=10;
            }
            if (n == ogl)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul nu {n} este palindrom");

        }
    }
}

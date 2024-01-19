using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introdu numarul: ");
            n=int.Parse(Console.ReadLine());
            while(n>0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
            Console.WriteLine();
        }
    }
}

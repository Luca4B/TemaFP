using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n: ");
            int n=int.Parse(Console.ReadLine());
            int p;
            int d=2;
            while (n > 1)
            {
                p = 0;
                while(n%d==0)
                {
                    n = n / d;
                    p++;
                }
                if(p!=0)
                {
                    Console.Write($"{d}^{p}");
                }
                if(n>1)
                {
                    Console.Write("*");
                }
                d++;
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
        }
    }
}

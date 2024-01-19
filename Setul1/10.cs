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
            int n;
            Console.Write("Inrodu numarul n: ");
            n= int.Parse(Console.ReadLine());
            int ok = 1;
            if (n == 0 || n == 1)
                ok = 0;
            else
                if (n != 2 && n % 2 == 0)
                ok = 0;
            else
                for (int i = 3; i < n; i += 2)
                    if (n % i == 0)
                        ok = 0;
            if (ok == 1)
                Console.WriteLine($"Numarul {n} este prim");
            else
                Console.WriteLine($"Numarul NU {n} este prim");
        }
    }
}

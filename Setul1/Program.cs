using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            Console.Write($"introdu numarul: ");
            int n = int.Parse( Console.ReadLine());
            int n1 = n;
            int a = n % 10;
            n /= 10;
            while (a == n%10)            
                n /= 10;                            
            int b = n % 10;
            n /= 10;
            while ( n > 0 )
            {
                if(n % 10 != a && n % 10 != b )
                    ok = false;
                n /= 10;
            }
            if (ok)
                Console.WriteLine($"Numarul {n1} este format din cel mult doua cifre distincte");
            else
                Console.WriteLine($"Numarul {n1} este format din mai mult de doua cifre distincte");
        }
    }
}

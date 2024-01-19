using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introdu pe a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele");
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if(d == a)
                {
                    Console.WriteLine($"Numarul a se afla pe pozitia {i}");
                    ok = true;                }
            }
            if (ok == false)
                Console.WriteLine($"Numarul se afla pe pozitia -1");
        }
    }
}

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
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele:");
            int d1 = int.Parse(Console.ReadLine());
            bool ok1 = true;
            bool ok2 = true;
            for (int i = 1; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d < d1)
                    ok1 = false;
                if (d > d1)
                    ok2 = false;
                d1 = d;
            }
            if (ok1 == true || ok2 == true)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa NU este monotona");
        }
    }
}

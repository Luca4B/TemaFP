using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=1; i <= n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d % 2 == 0)
                    cnt++;
            }
            Console.WriteLine($"In aceasta secventa se afla {cnt} numere pare");
        }
    }
}

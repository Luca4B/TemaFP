using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            int cnt=0;
            for(int i = 0; i < n; i++)
            {
                int d = int .Parse(Console.ReadLine());
                if (d == i)
                    cnt++;
            }
            Console.WriteLine($"Sunt {cnt} elemente care sunt egale cu pozitia lor");
        }
    }
}

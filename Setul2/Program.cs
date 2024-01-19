using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele: ");
            int d1 = int.Parse(Console.ReadLine());
            int cnt=0;
            for(int i = 1; i < n;i ++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d1 != 0 && d ==0)
                    cnt++;
                d1 = d;
            }
            if (d1 != 0)
                cnt++;
            Console.WriteLine($"se afla {cnt} grupuri consecutive diferite de 0");
        }
    }
}

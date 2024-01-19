using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 1;
            int z = 0;
            for(int i = 3;i<= n;i++)
            {
                z = x + y;
                x = y;
                y= z;
            }
            Console.WriteLine($"Al {n}-lea termen este {z}");
        }
    }
}

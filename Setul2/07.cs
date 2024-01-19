using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele:");
            int d = int.Parse(Console.ReadLine());
            int max = d;
            int min = d;
            for(int i = 1; i < n; i++)
            {
                d = int.Parse(Console.ReadLine());
                if (d > max) 
                    max = d;
                if(d < min)
                    min = d;
            }
            Console.WriteLine($"cea mai mica valoare: {min} ; cea mai mare valoare: {max}");
        }
    }
}

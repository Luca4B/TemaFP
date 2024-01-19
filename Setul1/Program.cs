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
            int x;
            Console.Write("Introduceti numarul: ");
            x=int.Parse(Console.ReadLine());
            int k;
            Console.Write("Introduceti k: ");
            k = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<k)
            {
                x /= 10;
                i++;
            }
            Console.WriteLine($"A {k}-a cifra a numarului este: {x % 10}");
        }
    }
}

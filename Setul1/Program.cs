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
            int a, b;
            Console.Write("INtrodu pe a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introdu pe b: ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} ; b = {b}");
        }
    }
}

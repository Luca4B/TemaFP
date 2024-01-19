using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Introdu pe a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Introdu pe b: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Introdu pe c: ");
            c=int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < b + c) 
                Console.WriteLine("Laturile pot forma un triunghi.");
            else
                Console.WriteLine("Laturile nu pot forma un triunghi.");
        }
    }
}

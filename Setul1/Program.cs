using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdu cele 5 numere:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int temp;
            if(a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if(b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(c > d)
            {
                temp = c;
                c = d;
                d = temp;
            }
            if(d > e)
            {
                temp = d;
                d = e;
                e = temp;
            }
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (c > d)
            {
                temp = c;
                c = d;
                d = temp;
            }
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(a > b)
            {
                temp= a;
                a = b;
                b = temp;
            }
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}");
        }
    }
}

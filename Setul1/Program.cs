using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ok = 0;
            int k;
            var range = 1024;
            Random rand =new Random();
            int x =rand.Next(range);
            Console.Write("Introdu un numar din intervalul [1,1024]: ");
            while(ok == 0)
            {
                k=int.Parse(Console.ReadLine());
                if (k == x)
                {
                    Console.WriteLine("Ati ghicit numarul");
                    ok = 1;
                }
                else
                if (k < x)
                    Console.WriteLine("Numarul introdus este prea mic");
                else
                    Console.WriteLine("Numarul instrodus este prea mare");
            }
           
        }
    }
}

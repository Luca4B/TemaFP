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
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele");
            int d1 = int.Parse(Console.ReadLine());
            bool ok = true;
            for(int i = 1; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                if(d1 >= d)
                    ok = false;
                d1 = d;
            }
            if (ok)
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele NU sunt in ordine crescatoare");
        }
    }
}

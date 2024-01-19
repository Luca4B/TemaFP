using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n= int.Parse(Console.ReadLine());
            int poz = 0;
            int neg = 0;
            int zero = 0;
            for(int i = 1;i <= n;i++)
            {
                int d = int.Parse(Console.ReadLine());
                if (d < 0)
                    neg++;
                else if (d > 0)
                    poz++;
                else zero++;
            }
            Console.WriteLine($"Sunt: {neg} negative, {zero} egale cu zero, {poz} pozitive");
        }
    }
}

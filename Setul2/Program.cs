using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numerele: ");
            int suma = 0;
            for(int i = 0;i < n;i ++)
            {
                int d = int.Parse(Console.ReadLine());
                suma += Inv(d);
            }
            Console.WriteLine($"Suma inverselor numerelor este: {suma}");
        }

        private static int Inv(int d)
        {
            int i = 0;
            while (d > 0)
            {
                i = i * 10 + d % 10;
                d /= 10;
            }
            return i;
        }
    }
}

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
            double suma = 0;
            for(int i = 0;i < n;i ++)
            {
                double d = int.Parse(Console.ReadLine());
                suma += 1 / d;
            }
            Console.WriteLine($"Suma inverselor numerelor este: {suma}");
        }        
    }
}

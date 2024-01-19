using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti coeficientii ecuatie de gradul 1.");

            Console.Write("a = ");
            double a= Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b= Convert.ToDouble(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Datele nu sunt bine introduse");
            else
            {
                double x = (-b) / a;
                Console.WriteLine($"Ecuatia are radacina egala cu: {x}");
            }
        }
    }
}

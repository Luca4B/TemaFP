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
            Console.WriteLine("Introduceti coeficientii ecuatie de gradul 2.");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);

            if (a != 0)
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                    double x2 = (-b - Math.Sqrt(delta) / (2 * a));

                    Console.WriteLine($"Ecuatia are doua radacini reale distincte: {x1} si {x2}");
                }
                else if (delta == 0)
                {
                    double x = (-b) / (2 * a);

                    Console.WriteLine($"Ecuatia are o singura radacina reala: {x}");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are radacini reale.");
                }
            else if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Numere nu sunt bine introduse.");
                else
                    Console.WriteLine($"Ecuatia are o singura radacina: {(-c) / b}.");
            }
        }
    }
}

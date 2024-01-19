using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu pe b");
            int b = int.Parse(Console.ReadLine());

            if (b < 2 || b > 16)
                throw new ArgumentException("Baza b trebuie sa se afle in intervalul [2,16]");

            
            string litera = string .Empty;
            int temp = n;
            string result = string.Empty;
            while (temp > 0)
            {
                int r = temp % b;
                temp /= b;
                if (r > 9)
                {
                    if (r == 10)
                        litera = "A";
                    else if (r == 11)
                        litera = "B";
                    else if (r == 12) 
                        litera = "C";
                    else if (r == 13)
                        litera = "D";
                    else if (r == 14)
                        litera = "E";
                    else if (r == 15)
                        litera = "F";
                    result = litera + result;
                }
                else
                    result = r + result;
            }
            Console.WriteLine($"Numarul {n}, in baza {b} se scrie {result}");
        }
    }
}

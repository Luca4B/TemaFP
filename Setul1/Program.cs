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
            int cmmdc;
            Console.Write("Introdu pe x: ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Introdu pe y: ");
            int y=int.Parse(Console.ReadLine());
            if(x > y)
            {
                if (x % y == 0)
                    cmmdc = y;
                else
                    cmmdc = x%y;
            }
            else
            {
                if(y% x == 0)
                    cmmdc = x;
                else
                    cmmdc = y%x;
            }
            Console.WriteLine($"Cel mai mare divizor comun este: {cmmdc}");
            int cmmmc=(x*y)/cmmdc;
            Console.WriteLine($"Cel mai mic multiplu comun este: {cmmmc}");
        }
    }
}

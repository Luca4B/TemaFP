using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce y2: ");
            int y2 = int.Parse(Console.ReadLine());
            int contor = 0;
            for(int i = y1;i<= y2;i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    contor++;                                    
            }
            Console.WriteLine($"Intre anii {y1} si {y2} se afla {contor} ani bisecti");
        }
    }
}

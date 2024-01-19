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
            Console.WriteLine("Ghiciti un numar intre 1 si 1024.");
            GhicesteNumarul();
        }

        static void GhicesteNumarul()
        {
            int limitaInferioara = 1;
            int limitaSuperioara = 1024;

            while (limitaInferioara <= limitaSuperioara)
            {
                int ghicit = (limitaInferioara + limitaSuperioara) / 2;

                Console.Write($"Numarul este mai mare sau egal decat {ghicit}? (da/nu): ");
                string raspuns = Console.ReadLine().ToLower();

                if (raspuns == "da")                
                    limitaInferioara = ghicit + 1;                
                else if (raspuns == "nu")                
                    limitaSuperioara = ghicit - 1;                
                else                
                    Console.WriteLine("Raspuns invalid. Va rugam sa raspundeti cu 'da' sau 'nu'.");                
            }

            Console.WriteLine($"Numarul ghicit este: {limitaSuperioara}");
        }    
    }
}

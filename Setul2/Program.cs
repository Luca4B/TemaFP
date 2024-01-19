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
            Console.WriteLine("Introdu pe n:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele:");
            for(int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            VerificareSecventa(vector);
        }

        private static void VerificareSecventa(int[] vector)
        {
            int nivelMaxim = 0;
            int nivelCurent = 0;
            bool esteCorecta = true;
            foreach (int paranteza in vector)
            {
                if (paranteza == 0)
                {
                    nivelCurent++;
                    nivelMaxim = Math.Max(nivelMaxim, nivelCurent);
                }
                else if (paranteza == 1)
                {
                    nivelCurent--;
                    if (nivelCurent < 0)
                    {
                        esteCorecta = false;
                        break;
                    }
                }
            }
            if (nivelCurent != 0)            
                esteCorecta = false;            
            if (esteCorecta)
            {
                Console.WriteLine("Secventa este corecta.");
                Console.WriteLine($"Nivelul maxim de incuibare al parantezelor este: {nivelMaxim}");
            }
            else            
                Console.WriteLine("Secventa NU este corecta.");            
        }
    }
}
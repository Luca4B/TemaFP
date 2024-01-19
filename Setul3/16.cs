using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu lungimea vectorului");
            int lungime = int.Parse(Console.ReadLine());

            int[] vector = new int[lungime];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < lungime; i++)
                vector[i] = int.Parse(Console.ReadLine());
            int c = 0;
            int var = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                c = Cmmdc(vector[i], var);
            }
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este {c}");
        }

        private static int Cmmdc(int a, int b)
        {            
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}

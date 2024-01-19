using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
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

            int element = ElementMajoritate(vector);
            if (element != 0)
                Console.WriteLine($"Elementul majoritate este: {element}");
            else
                Console.WriteLine("Nu exita element majoritate");
        }

        private static int ElementMajoritate(int[] vector)
        {
            int[] vfrec = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
                vfrec[vector[i]]++;
            int nrtotal = 1;
            int max = vfrec[0];
            int nrmax = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                nrtotal++;
                if (vfrec[i] > max)
                {
                    max = vfrec[i];
                    nrmax = vector[i];                    
                }
            }
            if (max / 2 > nrtotal)
                return nrmax;
            else
                return 0;
        }
    }
}

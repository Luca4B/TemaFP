using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu lungimea vectorului:");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu elementele vectorului:");
            int[] vector = new int[lungime];
            for (int i = 0; i < lungime; i++)
                vector[i] = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introdu indexul:");
            int index = int.Parse(Console.ReadLine());

            int valoare = ValoareDupaSortare(vector, index);
            Console.WriteLine($"Valoarea care va fi pe pozitia index dupa sortare este {valoare}");
        }

        private static int ValoareDupaSortare(int[] vector, int index)
        {
            int[] vectorsortat = vector.ToArray();
            Array.Sort(vectorsortat);
            int valoare = vectorsortat[index];
            return valoare;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            int min = vector[0];
            int max = vector[0];
            int countMin = 1;
            int countMax = 1;
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                    countMin = 1;
                }
                else if (vector[i] == min)                
                        countMin++;                

                if (vector[i] > max)
                {
                    max = vector[i];
                    countMax = 1;
                }
                else if (vector[i] == max)                
                        countMax++;                
            }

            Console.WriteLine($"Cea mai mică valoare: {min}, apărută de {countMin} ori.");
            Console.WriteLine($"Cea mai mare valoare: {max}, apărută de {countMax} ori.");
        }
    }
}

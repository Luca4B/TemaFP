using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] vector = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            
            int min = 0, max = 0;
            for (int i = 1; i < vector.Length; i += 2)
            {
                int smallerIndex = i - 1;
                int largeerIndex = i;
                if (vector[i] < vector[i - 1])
                {
                    smallerIndex = i;
                    largeerIndex = i - 1;
                }
                if (vector[smallerIndex] < vector[min])
                    min = smallerIndex;
                if (vector[largeerIndex] > vector[max])
                    max = largeerIndex;
            }
            Console.WriteLine($"Cel mai mic element se află la pozitia: {min}");
            Console.WriteLine($"Cel mai mare element se află la pozitia: {max}");
        }
    }
}

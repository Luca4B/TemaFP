using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n");
            int lungime = int.Parse(Console.ReadLine());

            int[] vector = new int[lungime];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < lungime; i++)
                vector[i] = int.Parse(Console.ReadLine());

            int cnt = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                bool diferitZero = true;
                if (vector[i] == 0)                
                    diferitZero = false;                
                if (diferitZero)
                {
                    int aux = vector[cnt];
                    vector[cnt] = vector[i];
                    vector[i] = aux;
                    cnt++;

                }
            }

            Console.WriteLine("Vectorul dupa modificare");
            foreach (int element in vector)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}

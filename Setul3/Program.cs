using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
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
           
            int lungimeNoua = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                bool esteDuplicat = false;
                for (int j = 0; j < lungimeNoua; j++)                
                    if (vector[i] == vector[j])
                    {
                        esteDuplicat = true;
                        break;
                    }                
                if (!esteDuplicat)
                {
                    vector[lungimeNoua] = vector[i];
                    lungimeNoua++;
                }
            }
            Array.Resize(ref vector, lungimeNoua);

            Console.WriteLine("Vectorul fara elemente duplicate");
            foreach(int element in vector)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}

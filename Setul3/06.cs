using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n");
            int n = int.Parse(Console.ReadLine());            
            int[] vector = new int[n];
            
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
                vector[i] = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introdu pe k");
            int k = int.Parse(Console.ReadLine());
            
            for (int i = k - 1; i < vector.Length - 1; i++)            
                vector[i] = vector[i + 1];            

            Array.Resize(ref vector, n - 1);

            Console.WriteLine("Noul vector este");            
            for(int i = 0;i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
        }
    }
}

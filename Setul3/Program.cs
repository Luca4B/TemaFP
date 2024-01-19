using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu pe n");
            int n = int.Parse(Console.ReadLine());

            CirulLuiEratostene(n);
        }

        private static void CirulLuiEratostene(int n)
        {
            bool[] estePrim = new bool[n + 1];

        for (int i = 2; i <= n; i++)        
            estePrim[i] = true;        

        for (int i = 2; i * i <= n; i++)        
            if (estePrim[i])            
                for (int j = i * i; j <= n; j += i)                
                    estePrim[j] = false;                                    

        Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
        for (int i = 2; i <= n; i++)        
            if (estePrim[i])            
                Console.Write(i + " ");                    
        Console.WriteLine();
        }
    }
}
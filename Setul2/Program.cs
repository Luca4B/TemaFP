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
            Console.WriteLine("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele:");
            for(int i= 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            if (SecventaBitonica(v))
                Console.WriteLine("Secventa este una bitonica.");
            else
                Console.WriteLine("Secventa NU este una bitonica.");
        }

        private static bool SecventaBitonica(int[] v)
        {
            bool ok = true;
            int i;
            for(i = 0;i < v.Length - 1;i++)
            {
                if ((v[i] > v[i+1]) && (ok == true))                                    
                    ok = false;                
                
                if (v[i] < v[i+1] && ok == false)
                        return false;                
            }
            if (v[i-1] < v[i])
                return false;

            return true;
        }
    }
}

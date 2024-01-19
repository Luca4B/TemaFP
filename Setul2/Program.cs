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
            Console.WriteLine("Introdu pe n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele:");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            int[] v1 = new int[v.Length];
            Array.Copy(v,v1,v.Length);
            while(SecventaBitonica(v1) == false)
            {
                Rotire(v1);
                if (SecventaBitonica(v1))
                    break;
                if (v.SequenceEqual(v1))
                    break;
            }
            
            if (SecventaBitonica(v1))
                Console.WriteLine("Secventa este una bitonica rotita.");
            else
                Console.WriteLine("Secventa NU este una bitonica rotita.");
        }

        private static int[] Rotire(int[] v)
        {
            int d = v[0];
            for (int i = 0; i < v.Length - 1; i++)
                v[i] = v[i + 1];
            v[v.Length - 1] = d;
            return v; 
        }

        private static bool SecventaBitonica(int[] v)
        {
            bool ok = true;
            int i;
            for (i = 0; i < v.Length - 1; i++)
            {
                if ((v[i] > v[i + 1]) && (ok == true))
                    ok = false;

                if (v[i] < v[i + 1] && ok == false)
                    return false;
            }
            if (v[i - 1] < v[i])
                return false;

            return true;
        }
    }
}

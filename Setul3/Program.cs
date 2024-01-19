using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10
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

            bool ok = false; 
            int st = 0, dr = n;
            int mij, poz = -1;
            while(st <= dr && ok == false)
            {
                mij = (st + dr) / 2;
                if (k == vector[mij])
                {
                    poz = mij;
                    ok = true;
                }
                else
                    if (k < vector[mij])
                    dr = mij - 1;
                else
                    st = mij + 1;
            }

            if (ok)
                Console.WriteLine($"Pozitia elementului k este: {poz}");
            else
                Console.WriteLine("Pozitia elementului k este: -1");
        }
    }
}

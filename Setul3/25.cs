using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 3, 5, 7, 9 };
            int[] v2 = { 2, 4, 6, 8, 10 };

            int[] rezultat = Interclasare(v1, v2);
            Console.WriteLine("Vectorul interclasat: " + string.Join(", ", rezultat));
            Console.WriteLine();
        }

        private static int[] Interclasare(int[] v1, int[] v2)
        {
            int lungime1 = v1.Length;
            int lungime2 = v2.Length;

            int[] rezultat = new int[lungime1 + lungime2];

            int i = 0, j = 0, k = 0;

            while (i < lungime1 && j < lungime2)
            {
                if (v1[i] < v2[j])
                {
                    rezultat[k] = v1[i];
                    i++;
                }
                else
                {
                    rezultat[k] = v2[j];
                    j++;
                }
                k++;
            }
            while (i < lungime1)
            {
                rezultat[k] = v1[i];
                i++;
                k++;
            }

            while (j < lungime2)
            {
                rezultat[k] = v2[j];
                j++;
                k++;
            }
            return rezultat;
        }
    }
}

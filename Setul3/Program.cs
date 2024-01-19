using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 9, 9, 9, 9, 9 };
            int[] v2 = { 1, 2, 3, 4, 5 };

            int[] suma = Aduna(v1, v2);
            Console.WriteLine("Suma: " + string.Join("", suma));

            int[] diferenta = Scade(v1, v2);
            Console.WriteLine("Diferenta: " + string.Join("", diferenta));

            int[] produs = Inmulteste(v1, v2);
            Console.WriteLine("Produs: " + string.Join("", produs));

            Console.WriteLine();
        }

        private static int[] Aduna(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>();
            int carry = 0;

            for (int i = Math.Max(v1.Length, v2.Length) - 1; i >= 0; i--)
            {
                int digit1;
                if (i < v1.Length)
                    digit1 = v1[i]; 
                else
                    digit1 = 0;

                int digit2;
                if (i < v2.Length)
                    digit2 = v2[i];
                else
                    digit2 = 0;

                int sumaCifrelor = digit1 + digit2 + carry;
                carry = sumaCifrelor / 10;

                rezultat.Insert(0, sumaCifrelor % 10);
            }

            if (carry > 0)            
                rezultat.Insert(0, carry);            

            return rezultat.ToArray();
        }

        private static int[] Scade(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>();
            int borrow = 0;

            for (int i = Math.Max(v1.Length, v2.Length); i >= 0; i--)
            {
                int digit1;
                if (i < v1.Length)
                    digit1 = v1[i];
                else
                    digit1 = 0;

                int digit2;
                if (i < v2.Length)
                    digit2 = v2[i];
                else
                    digit2 = 0;

                int difcifrelor = digit1 - digit2 - borrow;

                if (difcifrelor < 0)
                {
                    difcifrelor += 10;
                    borrow = 1;
                }
                else
                    borrow = 0;
                
                rezultat.Insert(0, difcifrelor);
            }
            while (rezultat.Count > 1 && rezultat[0] == 0)
                rezultat.RemoveAt(0);
            
            return rezultat.ToArray();
        }

        private static int[] Inmulteste(int[] v1, int[] v2)
        {
            List<int> rezultat = new List<int>(new int[v1.Length + v2.Length]);
            
            for (int i = Math.Max(v1.Length, v2.Length) - 1; i >= 0; i--) 
            {
                int carry = 0;
                for (int j = Math.Max(v1.Length,v2.Length) - 1; j >= 0; j--)
                {
                    int produscifre = v1[i] * v2[j] + rezultat[i + j + 1] + carry;
                    carry = produscifre / 10;
                    rezultat[i + j + 1] = produscifre % 10;
                }
                rezultat[i] += carry;
            }
            while (rezultat.Count > 1 && rezultat[0] == 0)
                rezultat.RemoveAt(0);

            return rezultat.ToArray();
        }
    }
}

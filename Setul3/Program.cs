using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introdu lungimea vectorului s");
            //int lungimes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introdu lungimea vectorului p");
            //int lungimep = int.Parse(Console.ReadLine());
            //int[] s = new int[lungimes];
            //int[] p = new int[lungimep];
            //for (int i = 0; i < lungimes; i++)
            //    s[i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < lungimep; i++)
            //    p[i] = int.Parse(Console.ReadLine());

            int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
            int[] p = { 1, 2, 1 };


            Console.WriteLine($"Vectorul p apare in vectorul s de {NumarApariti(s, p)}");
            Console.WriteLine();
        }

        private static object NumarApariti(int[] s, int[] p)
        {
            int count = 0;
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                int j;
                for (j = 0; j < p.Length; j++)
                    if (s[i + j] != p[j])
                        break;
                if (j == p.Length)
                    count++;
            }
            return count;
        }
    }
}

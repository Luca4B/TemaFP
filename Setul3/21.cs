using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu lungimea lui s1");
            int lungimes1 = int.Parse(Console.ReadLine());
            int[] s1 = new int[lungimes1];
            Console.WriteLine("Introdu elementele vectorului s1");
            for (int i = 0; i < lungimes1; i++)
                s1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu lungimea lui s2");
            int lungimes2 = int.Parse(Console.ReadLine());
            int[] s2 = new int[lungimes2];
            Console.WriteLine("Introdu elementele vectorului s1");
            for (int i = 0; i < lungimes2; i++)
                s2[i] = int.Parse(Console.ReadLine());

            int order = LexicographicOrder(s1, s2);
            if (order < 0)            
                Console.WriteLine("Vectorul s1 apare primul în ordine lexicografică.");            
            else if (order > 0)            
                Console.WriteLine("Vectorul s2 apare primul în ordine lexicografică.");            
            else            
                Console.WriteLine("Vectorii sunt identici în ordine lexicografică.");           
        }
        static int LexicographicOrder(int[] arr1, int[] arr2)
        {
            int minLength = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < minLength; i++)            
                if (arr1[i] < arr2[i])                
                    return -1;                
                else if (arr1[i] > arr2[i])                
                    return 1;                        

            if (arr1.Length < arr2.Length)            
                return -1;            
            else if (arr1.Length > arr2.Length)            
                return 1;            

            return 0;
        }
    }
}

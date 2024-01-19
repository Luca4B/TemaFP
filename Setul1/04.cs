using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int an;
            Console.Write("Introduceti anul:");
            an = int.Parse(Console.ReadLine());
            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)            
                Console.WriteLine("an bisect");                        
            else            
                Console.WriteLine("an normal");            
        }
    }
}

using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int lungimeSecventa = int.Parse(Console.ReadLine());

            int[] secventa = new int[lungimeSecventa];

            Console.WriteLine("Introduceti elementele secventei:");

            for (int i = 0; i < lungimeSecventa; i++)
                secventa[i] = int.Parse(Console.ReadLine());

            if (EsteSecventaMonotonaRotita(secventa))
                Console.WriteLine("Secventa este o secventa monotona rotita.");
            else
                Console.WriteLine("Secventa nu este o secventa monotona rotita.");
        }

        static bool EsteSecventaMonotonaRotita(int[] secventa)
        {
            int lungime = secventa.Length;
            bool increasing = false;
            bool decreasing = false;

            int indiceMinim = GasesteIndiceMinim(secventa, lungime);

            for (int i = 0; i < lungime - 1; i++)
            {
                int indexCurent = (indiceMinim + i ) % lungime;
                int indexUrmator = (indiceMinim + i + 1) % lungime;

                if (secventa[indexCurent] > secventa[indexUrmator])
                    increasing = true;                
            }
            for (int i = 0; i < lungime - 1; i++)
            {
                int indexCurent = (indiceMinim + i + 1) % lungime;
                int indexUrmator = (indiceMinim + i + 2) % lungime;

                if (secventa[indexCurent] < secventa[indexUrmator])
                    decreasing = true;
            }
                if (increasing && decreasing)
                    return false;
                else
                    return true;
        }

        static int GasesteIndiceMinim(int[] secventa, int lungime)
        {
            int indiceMinim = 0;

            for (int i = 1; i < lungime; i++)
                if (secventa[i] < secventa[indiceMinim])
                    indiceMinim = i;

            return indiceMinim;
        }
    }
}

using System;

namespace pirmazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių (ribą):");
            int limitas = int.Parse(Console.ReadLine());
            AtspausdintiDaliklius(limitas);
        }

        public static void AtspausdintiDaliklius(int limitas)
        {
            Console.WriteLine($"Dalikliai skaičiaus {limitas}:");
            for (int i = 1; i <= limitas; i++)
            {
                if (limitas % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;

namespace pirmazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių (ribą):");
            int limitas = int.Parse(Console.ReadLine());
            AtspausdintiAtbulineTvarka(limitas);
        }

        public static void AtspausdintiAtbulineTvarka(int limitas)
        {
            for (int i = limitas; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace penktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių (ribą):");
            int limitas = int.Parse(Console.ReadLine());
            int suma = SumNelyginiųSkaičių(limitas);
            Console.WriteLine($"Nelyginių skaičių suma nuo 1 iki {limitas} yra: {suma}");
        }

        public static int SumNelyginiųSkaičių(int limitas)
        {
            int suma= 0;
            for (int i = 1; i <= limitas; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
    }
}

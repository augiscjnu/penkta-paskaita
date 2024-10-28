using System;

namespace KlasesIrFunkcijos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                int verteIsFunkcijos = SugeneruotasSkaicius();
                SpausdinkSkaiciu(verteIsFunkcijos);
            }

            Console.WriteLine();

            string zodis1 = IveskZodi();
            string zodis2 = IveskZodi();

            string sudetasZodis = SudekZodzius(zodis1, zodis2);

            Console.WriteLine(sudetasZodis);


        }

        public static void SpausdinkSkaiciu(int skaicius)
        {
            Console.WriteLine(skaicius);
        }

        public static int SugeneruotasSkaicius()
        {
            Random r = new Random();
            int sk = r.Next(1, 100);

            return sk;
        }

        public static string IveskZodi()
        {
            Console.WriteLine("Iveskite zodi: ");
            return Console.ReadLine();
        }

        public static string SudekZodzius(string pirmasZodis, string antrasZodis)
        {
            return pirmasZodis + " " + antrasZodis;
        }


    }
}
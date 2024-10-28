using System;

namespace ketvirtauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių (ribą):");
            int l = int.Parse(Console.ReadLine());
            string k = KvadrataiIkiRibos(l);
            Console.WriteLine($"Kvadratų rezultatai nuo 1 iki {l}: {k}");
        }

        public static string KvadrataiIkiRibos(int limitas)
        {
            string rezultatas = "";
            for (int i = 1; i <= limitas; i++)
            {
                rezultatas += (i * i).ToString(); 
                if (i < limitas) 
                {
                    rezultatas += ", ";
                }
            }
            return rezultatas;
        }
    }
}

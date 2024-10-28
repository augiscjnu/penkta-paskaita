using System;

namespace pirmazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių:");
            int s = int.Parse(Console.ReadLine());
            int r = SudetiIkiDuotoSkaičiaus(s);
            Console.WriteLine($"Suma nuo 1 iki {s} yra: {r}");
        }

        public static int SudetiIkiDuotoSkaičiaus(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

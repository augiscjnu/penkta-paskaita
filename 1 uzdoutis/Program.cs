using System;

namespace pirmazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo amžių:");
            int a = int.Parse(Console.ReadLine());
            string r = PatikrintiPilnametystę(a);
            Console.WriteLine(r);
        }

        public static string PatikrintiPilnametystę(int age)
        {
            if (age >= 18)
            {
                return "Pilnametis";
            }
            else
            {
                return "Nepilnametis";
            }
        }
    }
}

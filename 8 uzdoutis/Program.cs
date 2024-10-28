using System;

namespace pirmazudoutis
{
    public class Automobilis
    {
        private string marke;
        private string modelis;
        private int metai;
        private double kuroLikutis;

        public Automobilis(string marke, string modelis, int metai)
        {
            this.marke = marke;
            this.modelis = modelis;
            this.metai = metai;
            this.kuroLikutis = 0;
        }

        public void PildytiKura(double kiekis)
        {
            if (kiekis < 0)
            {
                Console.WriteLine("Negalima įpilti neigiamo kuro kiekio.");
                return;
            }
            kuroLikutis += kiekis;
            Console.WriteLine($"Pridėta {kiekis} litrų kuro. Dabartinis kuro likutis: {kuroLikutis} litrai.");
        }

        public void Vaziuoti(double atstumas)
        {
            double sunaudotaKuro = atstumas / 10;
            if (sunaudotaKuro > kuroLikutis)
            {
                Console.WriteLine("Neužtenka kuro nuvažiuoti šį atstumą.");
            }
            else
            {
                kuroLikutis -= sunaudotaKuro;
                Console.WriteLine($"Nuvažiavote {atstumas} km. Kuro likutis: {kuroLikutis} litrai.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Markė: {marke}, Modelis: {modelis}, Metai: {metai}, Kuro likutis: {kuroLikutis} litrai.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Automobilis manoAuto = new Automobilis("Toyota", "Corolla", 2020);

            while (true)
            {
                manoAuto.DisplayInfo();
                Console.WriteLine("Pasirinkite veiksmą:");
                Console.WriteLine("1. Pildyti kurą");
                Console.WriteLine("2. Važiuoti");
                Console.WriteLine("3. Išeiti");
                Console.Write("Įveskite savo pasirinkimą (1/2/3): ");

                string pasirinkimas = Console.ReadLine();

                if (pasirinkimas == "1")
                {
                    Console.Write("Įveskite kiekį litrų, kuriuos norite įpilti: ");
                    if (double.TryParse(Console.ReadLine(), out double kiekis))
                    {
                        manoAuto.PildytiKura(kiekis);
                    }
                    else
                    {
                        Console.WriteLine("Įvestas neteisingas skaičius.");
                    }
                }
                else if (pasirinkimas == "2")
                {
                    Console.Write("Įveskite atstumą (km), kurį norite nuvažiuoti: ");
                    if (double.TryParse(Console.ReadLine(), out double atstumas))
                    {
                        manoAuto.Vaziuoti(atstumas);
                    }
                    else
                    {
                        Console.WriteLine("Įvestas neteisingas skaičius.");
                    }
                }
                else if (pasirinkimas == "3")
                {
                    Console.WriteLine("Išeiti iš programos.");
                    break; 
                }
                else
                {
                    Console.WriteLine("Pasirinkimas neteisingas, bandykite dar kartą.");
                }
            }
        }
    }
}

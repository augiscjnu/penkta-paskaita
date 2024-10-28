using System;

namespace dvyliktauzdoutis
{
    public class BankoSaskaita
    {

        private string savininkoVardas;
        private string saskaitosNumeris;
        private double balansas;


        public BankoSaskaita(string savininkoVardas, string saskaitosNumeris, double pradiniaiPinigai)
        {
            this.savininkoVardas = savininkoVardas;
            this.saskaitosNumeris = saskaitosNumeris;
            this.balansas = pradiniaiPinigai;
        }


        public void IdetiPinigus(double suma)
        {
            if (suma <= 0)
            {
                Console.WriteLine("Suma turi būti teigiama.");
                return;
            }
            balansas += suma;
            Console.WriteLine($"Pridėta {suma} prie balanso. Naujas balansas: {balansas:F2}");
        }


        public void NusiimtiPinigus(double suma)
        {
            if (suma <= 0)
            {
                Console.WriteLine("Suma turi būti teigiama.");
                return;
            }

            if (suma > balansas)
            {
                Console.WriteLine("Nepakanka lėšų sąskaitoje.");
                return;
            }

            balansas -= suma;
            Console.WriteLine($"Nusiimta {suma} iš balanso. Naujas balansas: {balansas:F2}");
        }


        public string GautiInformacija()
        {
            return $"Savininko vardas: {savininkoVardas}, Sąskaitos numeris: {saskaitosNumeris}, Balansas: {balansas:F2}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BankoSaskaita saskaita = new BankoSaskaita("Jonas Jonaitis", "LT123456789012345678", 1000.00);

            while (true)
            {
                Console.WriteLine(saskaita.GautiInformacija());
                Console.WriteLine("Pasirinkite veiksmą:");
                Console.WriteLine("1. Įdėti pinigus");
                Console.WriteLine("2. Nusiimti pinigus");
                Console.WriteLine("3. Išeiti");
                Console.Write("Įveskite savo pasirinkimą (1/2/3): ");

                string pasirinkimas = Console.ReadLine();

                if (pasirinkimas == "1")
                {
                    Console.Write("Įveskite sumą, kurią norite įdėti: ");
                    if (double.TryParse(Console.ReadLine(), out double idetiSuma))
                    {
                        saskaita.IdetiPinigus(idetiSuma);
                    }
                    else
                    {
                        Console.WriteLine("Įvestas neteisingas skaičius.");
                    }
                }
                else if (pasirinkimas == "2")
                {
                    Console.Write("Įveskite sumą, kurią norite nusiimti: ");
                    if (double.TryParse(Console.ReadLine(), out double nusiimtiSuma))
                    {
                        saskaita.NusiimtiPinigus(nusiimtiSuma);
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
            
        
    










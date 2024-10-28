using System;

namespace pirmazudoutis
{
    public class Studentas
    {
        
        private string vardas;
        private string pavarde;
        private int amzius;
        private double vidurkis;
        private int pazymiuKiekis;

        
        public Studentas(string vardas, string pavarde, int amzius)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.vidurkis = 0; 
            this.pazymiuKiekis = 0; 
        }

        
        public void PridetiPazymi(double pazymys)
        {
            if (pazymys < 0 || pazymys > 10)
            {
                Console.WriteLine("Pažymys turi būti tarp 0 ir 10.");
                return;
            }

            
            vidurkis = ((vidurkis * pazymiuKiekis) + pazymys) / (++pazymiuKiekis);
            Console.WriteLine($"Pridėtas pažymys: {pazymys}. Naujas vidurkis: {vidurkis:F2}");
        }

        
        public bool ArPerejoISekanciaKlase()
        {
            return vidurkis >= 5;
        }

       
        public void DisplayInfo()
        {
            Console.WriteLine($"Vardas: {vardas}, Pavardė: {pavarde}, Amžius: {amzius}, Vidurkis: {vidurkis:F2}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
            Studentas studentas = new Studentas("Jonas", "Jonaitis", 18);

            
            studentas.DisplayInfo();

            
            string input;
            while (true)
            {
                Console.Write("Įveskite pažymį (0-10) arba 'baigti' baigti: ");
                input = Console.ReadLine();

                
                if (input.ToLower() == "baigti")
                {
                    break;
                }

                
                if (double.TryParse(input, out double pazymys))
                {
                    studentas.PridetiPazymi(pazymys);
                }
                else
                {
                    Console.WriteLine("Prašome įvesti galiojantį skaičių.");
                }
            }

           
            bool canAdvance = studentas.ArPerejoISekanciaKlase();
            Console.WriteLine($"Ar studentas pereina į sekantį lygį? {canAdvance}");
        }
    }
}

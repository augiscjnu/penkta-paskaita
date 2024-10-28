using System;

namespace venuoliktauzdoutis
{
    public class Knyga
    {
        
        private string pavadinimas;
        private string autorius;
        private int puslapiuSkaicius;
        private bool arPerskaityta;

        
        public Knyga(string pavadinimas, string autorius, int puslapiuSkaicius)
        {
            this.pavadinimas = pavadinimas;
            this.autorius = autorius;
            this.puslapiuSkaicius = puslapiuSkaicius;
            this.arPerskaityta = false;
        }

        
        public void PerskaitytiKnyga()
        {
            arPerskaityta = true;
            Console.WriteLine($"Knyga '{pavadinimas}' pažymėta kaip perskaityta.");
        }

        
        public string GautiAprasyma()
        {
            return $"Pavadinimas: {pavadinimas}, Autorius: {autorius}, Puslapių skaičius: {puslapiuSkaicius}, Perskaityta: {arPerskaityta}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
            Knyga knyga = new Knyga("Mielosios", "J.K. Rowling", 400);

            
            Console.WriteLine(knyga.GautiAprasyma());

           
            knyga.PerskaitytiKnyga();

           
            Console.WriteLine(knyga.GautiAprasyma());
        }
    }
}

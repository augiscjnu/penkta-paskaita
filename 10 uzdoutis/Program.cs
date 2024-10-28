using System;

namespace desimta
{
    public class Apskritimas
    {
        
        private double spindulys;

        
        public Apskritimas(double spindulys)
        {
            this.spindulys = spindulys;
        }

        
        public double SkaiciuotiPlota()
        {
            return Math.PI * Math.Pow(spindulys, 2);
        }

        
        public double SkaiciuotiPerimetra()
        {
            return 2 * Math.PI * spindulys;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Spindulys: {spindulys}");
            Console.WriteLine($"Plotas: {SkaiciuotiPlota():F2}");
            Console.WriteLine($"Perimetras: {SkaiciuotiPerimetra():F2}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite apskritimo spindulį:");
            double spindulys = double.Parse(Console.ReadLine());

            
            Apskritimas apskritimas = new Apskritimas(spindulys);

            
            apskritimas.DisplayInfo();
        }
    }
}

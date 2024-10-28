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
                break; // Exit the loop
            }
            else
            {
                Console.WriteLine("Pasirinkimas neteisingas, bandykite dar kartą.");
            }
        }
    }
}

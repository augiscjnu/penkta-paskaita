using System;

namespace treciazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite temperatura:");
            int a = int.Parse(Console.ReadLine());
            string r = KokiaTemp(a);
            Console.WriteLine(r);
        }

        public static string KokiaTemp(int temp)
        {
            if (temp < 0)
            {
                return "šalta";
            }
            else if (temp >= 20)
            {
                return "karšta";
            }
            else
            {
                return "vidutinė";
            
        
    

            
            }
        }
    }
}

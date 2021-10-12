using System;

namespace uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine("I vilket land är Joe biden president?");
            string svar = Console.ReadLine();
            while (svar != "usa")
            {
                Console.WriteLine("Du svarade fel, försök igen");
                svar = Console.ReadLine();
            }

            Console.WriteLine("Grattis! Du svarade rätt!");
        }
    }
}

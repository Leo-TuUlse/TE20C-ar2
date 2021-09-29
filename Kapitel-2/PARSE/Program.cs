using System;

namespace PARSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du? ");
            string ålder = Console.ReadLine();

            Console.WriteLine($"Du är {ålder} gammal");


            // konvertera forn string till heltal 
            int ålderTal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 -ålderTal} kvar tills du får gå till systemet"  );
            
            Console.WriteLine("hur mycket väger du? ");
            float vikt = float.Parse(Console.ReadLine());

            //Console.WriteLine($"Din vikt blir {vikt * 2.2} Lbs");

            float viktLbs = vikt * 2.2f;

            //formatera till snygg utskrift
            string viktString = viktLbs.ToString("0.##");
            Console.WriteLine($"Din vikt är {viktString} Lbs");
        
            
        }
    }
}

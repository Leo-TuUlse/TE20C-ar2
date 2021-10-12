using System;

namespace Gissa_ett_tal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Spel - Gissa ett tal mellan 1 och 100");

          // spela flera gånger
          while (true)
          {
                //slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1,101);



            //upprepa fråga 
            int räknare = 0;

            while (true)
            {
                // Räkna upp antal gissningar = varv
                räknare++;


            //fråga användaren om en gissning
            Console.WriteLine("Gissa ett tal (1-100) ");
            int gissning = int.Parse(Console.ReadLine());

            //Är gissningen rätt
            if (gissning == slumptal)
            {
                Console.WriteLine($"Bra gissat! Du gjorde på {räknare} försök");
                break;
            }


            //jämnför med slumptal
            if (gissning < slumptal)
            {
                Console.WriteLine("För lågt!");
            }
            else
            {
                Console.WriteLine("För högt!");
            }
            

            }
          }
        }
    }
}

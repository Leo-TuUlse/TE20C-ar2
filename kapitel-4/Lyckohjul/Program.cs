using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skapa ett program som ska fungera som ett lyckohjul
            Random slumpgenerator = new Random();
            int slumptal = slumpgenerator.Next(1, 11);


            //Användaren får 3 försök!
            for (int i = 1; i < 4; i++)
            {
                //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
                Console.WriteLine("Välkommen till Leos lyckohjul! välj ett nummer 1 - 10");
                int gissning = int.Parse(Console.ReadLine());

                //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
                //Console.WriteLine(slumptal);

                //Berätta också för användaren om hen vann eller förlorade
                if (gissning == slumptal)
                {
                    Console.WriteLine("Du gissade rätt, grattis!");
                }
                else
                {
                    Console.WriteLine("Tyvär fel gissat!");
                }

            }



        }
    }
}

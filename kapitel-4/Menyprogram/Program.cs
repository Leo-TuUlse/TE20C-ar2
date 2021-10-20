using System;

namespace Menyprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt meny program");

            //skape en slumpgenerator
            Random tärning = new Random();

            

            //program looper
            while (true)
            {
                   //slumpa fram ett tal
                   int slumptal = tärning.Next(1, 4);



                Console.WriteLine("Välj ett av förljande alternativ? ");
                Console.WriteLine("Väljer du sten? (1) ");
                Console.WriteLine("Väljer du sax (2) ");
                Console.WriteLine("Väljer du påse (3) ");
                Console.WriteLine("Vill du avsluta? (4) ");
                int valString = int.Parse(Console.ReadLine());
                
                //Vill användaren avsluta?
                if (valString == "4")
                {
                    break;
                }

                // Omvandla till en inte eftersom slumptal är en int 
                int val = int.Parse(valString);

                //Är det rätt svar
                if (val == slumptal)
                {
                    Console.WriteLine("Du vann");
                }
                else
                {
                    Console.WriteLine("Du förlora!");
                }
                

            }




        }
    }
}

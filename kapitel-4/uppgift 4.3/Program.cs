using System;

namespace uppgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Vem är rikast i världen");
            string svar = Console.ReadLine();
            int antalGissningar = 1;

            while (svar != "elon musk")
            {
                if (antalGissningar >= 5)
                {
                    Console.WriteLine("Dina gissningar är slut");
                    break;
                }
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
                antalGissningar++;
            }

            if (svar == "elon musk")
            {
                Console.WriteLine("Ditt svar är rätt!");
            }
        }
    }
}

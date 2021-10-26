using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program som skriver ut ASCII");

            // Be användaren mata in ett ord
            Console.Write("Ange ett ord: ");
            string ord = Console.ReadLine();
            Console.WriteLine("Ange en nyckel (1-9): ");
            int nyckel = int.Parse(Console.ReadLine());
            

            // Loopa igenom ordet bokstav-för-bokstav
            for (int i = 0; i < ord.Length; i++)
            {
                
                char bokstav = ord[i];
                int kod = (int)bokstav;
                // Tecken av ASCII-kod
                char bokstavKrypterad = (char)(kod);
                Console.WriteLine($"{bokstav} {kod} {kod += nyckel} {kod += bokstavKrypterad}");
            }
        }
    }
}

 using System;

namespace labb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("ASCII");

            // Be användaren mata in ett ord
            Console.Write("Ange ett ord: ");
            string ord = Console.ReadLine();
            Console.WriteLine("ange en nyckel (1-9)");
            int nyckel = int.Parse(Console.ReadLine());

           string meddelandeKrypterad = "";
           

            // Loopa igenom ordet bokstav-för-bokstav
            for (int i = 0; i < ord.Length; i++)
            {
                char bokstav = ord[i];
                int kod = (int)bokstav;

                // Lägg till nyckeln
                kod += nyckel;
                // Tecken av ASCII-kod
                char bokstavKrypterad = (char)(kod);

                meddelandeKrypterad += bokstavKrypterad.ToString();
              

               
                
            }
        
             Console.WriteLine($"{ord} blir {meddelandeKrypterad}");



        }
    }
}
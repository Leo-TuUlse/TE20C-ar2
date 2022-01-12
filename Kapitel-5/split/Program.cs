using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ord");

            Console.WriteLine("Ange en mening");
            string mening = Console.ReadLine();
            
            //Dela upp för att hitta alla ord
            //split = sax
            string[] orden = mening.Split(' ');

            //skriv ut alla ord var sin rad 
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            // Hur många ord finns det arrayen? 
            Console.WriteLine($"Antal ord i mening är {orden.Length}");

            // sätt samman en ny mening
          string nyMening =  string.Join('/', orden); 

          //skriv ut nya meningen
          Console.WriteLine(nyMening);


        }
    }
}

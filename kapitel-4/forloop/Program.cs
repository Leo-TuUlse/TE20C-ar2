using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Räkna 1 till 10");

           // for (int i = 1; i < 11; i++)
            //{
              //  Console.WriteLine($"loop nr {i}");
            //}

            // läs in ett meddelande 
            Console.WriteLine("skriv ett meddelande");
            string meddelande = Console.ReadLine();
            
            //Loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}

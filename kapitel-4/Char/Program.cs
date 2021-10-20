using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig!";
            
            //skriv ut hela strängen (string)
            Console.WriteLine("meddelande");

            //skriv ut första bokstaven 'H'
            Console.WriteLine(meddelande[0]);

            //Skriv ut sista bokstaven '!'
              Console.WriteLine(meddelande[10]);

              char bokstav = 'Z';

              //skriv ut alla tecken
              for (int i = 0; i < 11; i++)
              {
                  Console.WriteLine($"index {i} {meddelande[i]}");
              }


        }
    }
}

using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //skriv ut 1 till 5
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //summera alla siffror 1-10
            int summa = 0;
            for (int i = 1; i < 11; i++)
            {
                summa += i;
            }
            Console.WriteLine($"summa är {summa}");

            string namn = "Mohammad";

            //skriv ut andra bokstaven
            Console.WriteLine(namn[0]);  // M
            Console.WriteLine(namn[1]);  // o 
            Console.WriteLine(namn[3]);  // o 
            Console.WriteLine(namn[4]);  // o 

            //skriv ut baklänges
            for (int i = 7; i > -1; i--)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}

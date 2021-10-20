using System;

namespace uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string text = Console.ReadLine();

            int siffersumma = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string teckenString = text[i].ToString();
                int tal = int.Parse(teckenString);
                siffersumma += tal;
            }

            Console.WriteLine($"Siffersumman av talet {text} är {siffersumma}");
        }
    }
}

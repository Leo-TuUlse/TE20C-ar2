using System;

namespace uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
              string meddelande = "katten i tratten";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}

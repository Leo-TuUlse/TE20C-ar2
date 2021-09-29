using System;

namespace uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mata in 3 löner");

           // Ange lön 1
           int lön1 = int.Parse(Console.ReadLine());
           int lön2 = int.Parse(Console.ReadLine());
           int lön3 = int.Parse(Console.ReadLine());
           


           // räkna ut medelvärdet
            float medelvärde = (lön1 + lön2 + lön3) / 3;

            // Skriv ut resultatet
            Console.WriteLine($"Medelvärdet är {medelvärde}");
        }
    }
}

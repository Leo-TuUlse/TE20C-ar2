using System;

namespace uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uppgift 5.1");


            //skapa en array för 3 svenska städer 
            string[] städer = new string[3];

            städer[0] = "Malmö";
            städer[1] = "stockholm";

            //låt användaren få skriva in namnet på den tredje staden.
            Console.WriteLine("Nämn en svensk stad:");
            städer[2] = Console.ReadLine();

            //skriv avslitningsvis ut alla stadsnamnen på samma rad.
            Console.WriteLine($"{städer[0]},{städer[1]}, {städer[2]} ");

            // ett annnat sätt att skapa en array 
            string[] länder = {"sverige", "finland", "Danmark", "norge"};
            länder[0] = "Tyskland";

            //skriv ut alla länder
            //loopa igenom arrayen länder
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
            

        }
    }
}



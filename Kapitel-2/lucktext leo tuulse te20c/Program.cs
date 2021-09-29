using System;

namespace lucktext_leo_tuulse_te20c
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear(); 
            Console.WriteLine("tjenare pånken va gör du här");
            string yrke = Console.ReadLine();
            Console.WriteLine("jaha men så trevligt att du är intreserad av " + yrke );

            Console.Write("men vem fan är du egentligen ");
            string namn = Console.ReadLine();
            Console.WriteLine("tjenare " + namn );
            
            Console.Write("hur står det till ");
            string känslor = Console.ReadLine();
            Console.WriteLine ("jaha varför är det " + känslor);

            string för = Console.ReadLine();
            Console.WriteLine($"jaha så du ska {för} men nu måste jag gå så vi ses {namn}");
        }
    }

}

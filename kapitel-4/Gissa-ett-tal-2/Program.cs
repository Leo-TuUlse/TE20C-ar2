using System;

namespace Gissa_ett_tal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spelet Gissa ett tal!");

            //slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1,51);

            // loopa 5 gånger
            int räknare = 0;
            while (true)
            {
                //räkna upp varv
                räknare++;


                //bryt efter 5 varv
                if (räknare >= 5)
                {
                    break;
                }
            }


        }
    }
}

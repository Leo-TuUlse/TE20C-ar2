using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            //Berättar för användaren vad programmet är till för
            Console.WriteLine("Uträkning av nettolön");

            // Gör en linje så att programmet ser bättre ut för användaren
            Console.WriteLine("----------------------");

            //frågar programmet om användarens namn
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();



            Console.Write("Ange din bruttolön i kronor: ");
            float bruttolön = float.Parse(Console.ReadLine());
            // ser till att användaren använder rätt lön



            if (bruttolön <= 10000)
            {
                System.Console.WriteLine(namn + ", din bruttolön måste vara > 10000 kr!");
            }



            if (bruttolön >= 45000)
            {
                System.Console.WriteLine(namn + ", din Bruttolön måste vara < 45000 kr!");
            }



            if (bruttolön >= 10000 || bruttolön <= 45000)
            {

                System.Console.WriteLine("Ange din skattesats i %:   ");
                float skattesats = float.Parse(Console.ReadLine());

                if (skattesats <= 10)
                {
                    System.Console.WriteLine("Du måste ha en skattesats < 10");
                }

                if (skattesats >= 45)
                {
                    System.Console.WriteLine("Du måste ha en skattesats > 45");

                }


                if (skattesats >= 10 || skattesats <= 45)
                {
                    System.Console.WriteLine(bruttolön * (100 - skattesats) / 100);
                }
            }







        }
    }
}

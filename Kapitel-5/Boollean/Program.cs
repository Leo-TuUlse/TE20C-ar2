using System;

namespace Boollean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett ord!");

            Random generator = new Random();
            //spelaren välher hur många chanser hen vill ha

            int chanser = 0;
            bool chansbool = false;


            // spelaren väljer antal chanser,  hen måste välja minst 1 och max 5
            while (true)
            {
                //lista för  ord användaren ska försöka gissa
                string[] ordArray = { "blå", "grön", "svart", "vit", "röd", "gul", "lila", "rosa", "orange", "brun" };
                int randomord = generator.Next(0, 10);
                string ord = ordArray[randomord];
                //för att kunna ge ledtråd om vad första bokstaven är
                string sub1 = ord.Substring(0, 1);

                //parse
                chansbool = false;
                while (chansbool != true)
                {
                    Console.Write(" hur många chanser vill du ha (1-5)    ");
                    string chanserstring = Console.ReadLine();
                    chansbool = int.TryParse(chanserstring, out chanser);
                    if (chanser < 6 && chanser > 0)
                    {
                        chansbool = true;
                    }

                }
                Console.WriteLine("Vill du få ledtråd?(j/n)");
                string ledtråd = Console.ReadLine();
                if (ledtråd == "j")
                {
                    Console.WriteLine($"ordet börjar med bokstaven {sub1} och är ett färg");
                }

                //När spelaren sedan gissar, så ska hen få fortsätta gissa så länge hen inte fått rätt svar eller fått slut på gissningar
                while (chanser != 0)
                {
                    chanser--;


                    Console.WriteLine("Gissa ordet!");

                    string gissning = Console.ReadLine();

                    //avbryter loopen om svaret är lika med ordet
                    if (gissning == ord)
                    {
                        Console.WriteLine("RÄTT");
                        break;
                    }



                }

                //frågar användaren om hen vill köra om, om användaren inte svarar med j/n upprepas frågan
                // Console.WriteLine("vill du spela igen?(j/n)");
                string spelaOM = "";

                while (spelaOM != "j" || spelaOM != "n")
                {

                    Console.WriteLine("vill du spela om?(j/n)");
                    spelaOM = Console.ReadLine();
                    if (spelaOM == "n" || spelaOM == "j")
                    {
                        break;
                    }
                }
                if (spelaOM == "n")
                {
                    break;
                }


            }
        }
    }
}


using System;

namespace if_satser
{
    class Program
    {
        static void Main(string[] args)
        {

            //be användaren om åldern
            Console.Write("Hur gammal är du? (Heltal)");
             int ålder =  int.Parse(Console.ReadLine());
            
            // Om ålder större än 18 "Du får ta körkort!"

            if (ålder >= 18)

            System.Console.WriteLine("Du får ta körkort!");

            //om åldern är 15 eller högre får man ta am körkort!

            if (ålder >= 15)

            System.Console.WriteLine("Du får ta am körkort");



            //fråga användaren "Vad heter ABBAs senaste låt?"
            System.Console.WriteLine("Vad heter ABBAS senaste album?");
            string låt = Console.ReadLine();

            //är svaret korrekt?
            if (låt == "Voyage" || låt == "voyage")
            {
                Console.WriteLine("bra svarat!");
            }
            
                else
                {
                    Console.WriteLine("Fel! Albumet heter Voyage");
                }
            
            //sista Tp fråga

            System.Console.WriteLine("Vem missade straffen i Englad-Frankrike?");

            //läs in och tvinga till små bokstäver:
            //Mbappe -> mbappe
            //mBappe -> mbappe
            string spelare = Console.ReadLine().ToLower();
            

            if (spelare == "mbappe")
            {
                Console.WriteLine("Bra där, du hade rätt");
              }  
              else
                {
                    Console.WriteLine("Fel! det var Mbappe");
                }
            }
            

        }
    }


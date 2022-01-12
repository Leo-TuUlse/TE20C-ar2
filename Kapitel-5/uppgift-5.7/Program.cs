using System;

namespace uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // skapa en array med minst 5 heltal.
            int[] tallista = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop.
            int summa = 0;
            foreach (var tal in tallista)
            {
                summa += tal; 
            }

            Console.WriteLine(summa);
        }
    }
}

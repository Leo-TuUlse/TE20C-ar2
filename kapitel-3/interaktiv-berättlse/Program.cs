using System;
using System.Text;


namespace interaktiv_berättlse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
             Console.Clear();
            Console.WriteLine("Det var en kall kall natt och du såg en katt med en tratt");
           
            Console.WriteLine("tar du hans tratt?  (y/n) ");
            string answer1 = Console.ReadLine();
            if (answer1 == "y")
            {
                Console.Write("han drar fram ett fem meter långt svärd, springer du? (y/n) ");                              
                string answer2 = Console.ReadLine();
                if (answer2 =="y")
                {
                    Console.WriteLine("du kom undan och sprang hem till din mor  😆");
                }
                else
                {
                    Console.WriteLine("han hög dig i två, tips rör inte en katts tratt >:() 😙");
                }

            }
            else
            {
                Console.Write("han står och strirrar på dig med en mördar blick, men du ser en annan katt över kullen, skriker du på hjälp? (y/n)");
                string answer3 = Console.ReadLine();
                if (answer3 == "n")
                {
                    Console.Write("Katten med tratten går långsamt fram mot dig medans du står helt frusen, han tar tag i dig och slänger i dig i sin tratt där du långsamt glömms bort av nära och kära😩");
                }
                else
                {
                    Console.Write("katten kommer med en ännu större tratt och tar både dig och katten med tratten 😩😩😩😩😩");
                }
            };
        }
    }
}

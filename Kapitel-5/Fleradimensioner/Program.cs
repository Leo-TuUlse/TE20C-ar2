using System;

namespace Fleradimensioner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] rutor = new int[2,3];

            rutor[0, 0] = 1;
            rutor[1, 0] = 1;
            rutor[0, 1] = 1;
            rutor[1, 1] = 1;
            rutor[0, 2] = 1;
            rutor[1, 2] = 1;
        }
    }
}

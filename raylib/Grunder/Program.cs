using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //starta ett fönster
            Raylib.InitWindow(800, 600, "Ett raylib fönster");

            //ställ in fps
            Raylib.SetTargetFPS(60);

            //Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                //Börja rita 
                Raylib.BeginDrawing();

                //Tömma rit ytan
                Raylib.ClearBackground(Color.PURPLE);

                // rita en fyrkant   //x   y   w   h 
                Raylib.DrawRectangle(120, 120, 520, 320, Color.BLACK);

                Raylib.DrawRectangle(100, 100, 500, 300, Color.BLUE);
                Raylib.DrawRectangle(100, 225, 500, 50, Color.YELLOW);
                Raylib.DrawRectangle(225, 100, 50, 300, Color.YELLOW);


                //sluta rita 
                Raylib.EndDrawing();
            }
        }
    }
}

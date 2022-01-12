using System;
using Raylib_cs;


namespace RAF
{
    class Program
    {
        static void Main(string[] args)
        {
           //starta ett fönster
            Raylib.InitWindow(800,600,"Ett fönster");

            //ställ in fps
            Raylib.SetTargetFPS(60);

            //animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                 //börja rita
                 Raylib.BeginDrawing();

                 //tömma ritytan
                 Raylib.ClearBackground(Color.LIME);

                 //rita fyrkant
                 Raylib.DrawRectangle(0,0,200,600, Color.DARKBROWN);

                 //rite en cirkel
                 Raylib.DrawCircle(400,300,100);


                 //sluta rita
                 Raylib.EndDrawing();
        }
    }
}

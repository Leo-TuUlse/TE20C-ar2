using System;
using Raylib_cs;

namespace kollision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            // Variabler 
            int hastighet = 10;
            Random generator = new Random();
            int poäng = 0;

            /* Skapa objekt */
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle spelare2 = new Rectangle(generator.Next(400, 730), generator.Next(0, 530), 70, 70);


            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {

                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut objekt
                Raylib.DrawRectangleRec(spelare2, Color.DARKPURPLE);
                Raylib.DrawRectangleRec(spelare, Color.GREEN);
                // 

                
                // visa poängen 
                Raylib.DrawText($"poäng {poäng}", 500,50,50, Color.GOLD);

                //upptäcka kollision
                if (Raylib.CheckCollisionRecs(spelare, spelare2))
                {

                    poäng ++;

                    // spawna om fiende slump
                    spelare2.x = generator.Next(400, 730);
                    spelare2.y = generator.Next(0, 530);
                }

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användare */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += hastighet;
                }
                // 
            }
        }
    }
}

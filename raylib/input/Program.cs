using System;
using Raylib_cs;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Raylib!");

            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            //skapa en spelare av en rektangel 
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            Rectangle spelare2 = new Rectangle(100, 100, 50, 50);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.BEIGE);

                //rita ut spelaren
                Raylib.DrawRectangleRec(spelare, Color.BLUE);
                Raylib.DrawRectangleRec(spelare2, Color.RED);

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användaren */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                  if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 5;
                }

                // kontrolera spelare2
                  if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    spelare2.x += 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    spelare2.x -= 5;
                }
                  if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    spelare2.y -= 5;
                }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    spelare2.y += 5;
                }
            }
        }
    }
}

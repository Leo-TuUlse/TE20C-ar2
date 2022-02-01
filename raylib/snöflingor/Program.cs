using System;
using Raylib_cs;

namespace snöflingor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // skapa en snöflinga
            Random generator = new Random();

            // array för snöflingor 
            Rectangle[] flingor = new Rectangle[150];

            // array [] flr snäflingornas fallhastighet 
            int[] hastigheter = new int[150];
            
            // array för storlek
            int[] storlek = new int[150];

            // loopa igenom arrayen och fyll i snöflingornas Storlek
            for (int i = 0; i < flingor.Length; i++)
            {
                storlek[i] = generator.Next(3, 11);
            }
            //loopa igenom arrayen och fyll med snöflingor
            for (int i = 0; i < flingor.Length; i++)
            {
                flingor[i] = new Rectangle(0, 0, storlek[i], storlek[i]);
                flingor[i].x = generator.Next(0, fönsterB);
                flingor[i].y = generator.Next(0, fönsterB) - fönsterH;

            }



            // loopa igenom arrayen och fyll i snöflingornas hastighet
            for (int i = 0; i < flingor.Length; i++)
            {
                hastigheter[i] = generator.Next(1, 4);
            }

            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                for (int i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y += hastigheter[i];
                    if (flingor[i].y > fönsterH)
                    {
                        flingor[i].y = 0;

                    }
                }

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                for (int i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);

                }



                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------

            }
        }
    }
}
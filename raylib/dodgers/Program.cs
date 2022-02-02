using System;
using Raylib_cs;

namespace dodgers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;
            

            Raylib.InitWindow(fönsterB, fönsterH, "dodgers");
            Raylib.SetTargetFPS(60);
            Random generator = new Random();
            // TODO: Infoga variabler och objekt här
            //gamestate variabler
            int poäng = 0;
            int liv = 3;
            float tid = 0;
            int hastighet = 3;


            Rectangle mynt1 = new Rectangle(400, 0, 50, 50);
            Rectangle mynt2 = new Rectangle(200, -500, 50, 50);
            Rectangle monster = new Rectangle(300, -1000, 50, 50);
            Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);


            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                //räkna upp tiden
                tid += Raylib.GetFrameTime();
                if (tid > 30)
                {
                    hastighet++;
                }

                mynt1.y += hastighet;
                if (mynt1.y > fönsterH)
                {
                    mynt1.y = -100;
                    mynt1.x = generator.Next(0, fönsterB);
                }
                mynt2.y += hastighet;
                if (mynt2.y > fönsterH)
                {
                    mynt2.y = -100;
                    mynt2.x = generator.Next(0, fönsterB);
                }
                monster.y += 3;
                if (monster.y > fönsterH)
                {
                    monster.y = -100;
                    monster.x = generator.Next(0, fönsterB);
                }
                //----------------------------------------------------------------------------------
                //lyssna på tangenten
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    if (spelare.x < fönsterB - 100)
                    {
                        spelare.x += 5;

                    }
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    if (spelare.x > 0)
                    {
                        spelare.x -= 5;
                    }
                }
                //collission detection
                if (Raylib.CheckCollisionRecs(spelare,mynt1))
                {
                    mynt1.y = 0;
                    mynt1.x = generator.Next(0, fönsterB);
                    poäng += 1;
                }
                if (Raylib.CheckCollisionRecs(spelare,mynt2))
                {
                    mynt2.y = 0;
                    mynt2.x = generator.Next(0, fönsterB);
                    poäng += 1;
                }
                if (Raylib.CheckCollisionRecs(spelare,monster))
                {
                    monster.y = 0;
                    monster.x = generator.Next(0, fönsterB);
                    liv -= 1;
                }

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(mynt1, Color.GOLD);
                Raylib.DrawRectangleRec(mynt2, Color.GOLD);
                Raylib.DrawRectangleRec(monster, Color.RED);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);
                Raylib.DrawText($"Poäng:{poäng}    Liv:{liv}",10,10,20, Color.WHITE);
                Raylib.DrawText($"Poäng:{poäng}    Liv:{liv}   Tid:{(int)tid}",10,10,20, Color.WHITE);



                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
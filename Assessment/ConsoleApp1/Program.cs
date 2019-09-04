using Raylib;
using rl = Raylib.Raylib;
using System;

namespace ConsoleApp1
{
    static class Program
    {

        public static bool CheckCollisionV1(Player pl, Pickup pu)
        {
            bool rtn = false;
            Rectangle PickupCol; // = new Rectangle(pu.Position.x + 20, pu.Position.y + 20, 20, 20);
            //sprites
            float w = pu.texture.width * 1f;
            float h = pu.texture.height * 1f;

            PickupCol = new Rectangle(pu.Position.x, pu.Position.y, w, h);
            //debug
            //rl.DrawRectangle(pu.Position.x, pu.Position.y, (int)w, (int)h, Color.RED);
            PickupCol = new Rectangle(pu.Position.x, pu.Position.y, w, h);

            Rectangle PlayerCol = new Rectangle(pl.Position.x - 15, pl.Position.y + 5, 10, 40);
            //rl.DrawRectangleLines((int)PlayerCol.x, (int)PlayerCol.y, 10, 40, Color.RED);
            rtn = rl.CheckCollisionRecs(PlayerCol, PickupCol);
            if(rtn) { pu.Enabled = false;  }
            return rtn;
        }

        public static bool CheckCollisionV2(Player pl, Enemy e)
        {
            bool rtn = false;
            
            Rectangle EnemyCol;
            //sprites
            float Ew = e.Etexture.width * 1f;
            float Eh = e.Etexture.height * 1f;
            EnemyCol = new Rectangle(e.Position.x, e.Position.y, Ew, Eh);

            Rectangle PlayerCol = new Rectangle(pl.Position.x - 15, pl.Position.y + 5, 10, 40);
            //rl.DrawRectangleLines((int)PlayerCol.x, (int)PlayerCol.y, 10, 40, Color.RED);
            rtn = rl.CheckCollisionRecs(PlayerCol, EnemyCol);
            if (rtn) { e.isEnabled = false; }
            return rtn;
        }


        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            Random rand = new Random();
            Player player = new Player();
            Pickup[] Test = new Pickup[10];
            Enemy[] enemies = new Enemy[10];
            Enemy enemy = new Enemy();
            //Enemy enemyUp = new Enemy();
            //Enemy enemyDown = new Enemy();
            int screenWidth = 800;
            int screenHeight = 450;
            int score = 0;
            int timer = 0;
            int health = player.plHealth;
            bool winState = false;
            //rl.InitAudioDevice();
            //var pick = rl.LoadAudioStream("powerUp1.oog");


            rl.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

            int Enidx = 0;
            for (int i = 100; i < 700 && Enidx < 10; i += 40)
            {
                enemies[Enidx] = new Enemy();
                enemies[Enidx].Position.x = rand.Next(20, 780);
                enemies[Enidx].Position.y = rand.Next(30, 470);
                enemies[Enidx].EnemyTexture("bat.png");
                Enidx++;
            }

            int idx = 0;
            for (int x = 100; x < 700 && idx < 10; x += 40)
            {
                Test[idx] = new Pickup();
                Test[idx].Position.x = rand.Next(20, 780);
                Test[idx].Position.y = rand.Next(30, 420);
                //Test[idx].SprScale = idx * .1f;
                Test[idx].SetTexture("platformPack_item001.png");
                idx++;
            }

            player.Position.x = rand.Next(20, 780);
            player.Position.y = rand.Next(30, 420);



            rl.SetTargetFPS(60);
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!rl.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------
                player.RunUpdate();
                timer++;
                // Draw
                //----------------------------------------------------------------------------------
                rl.BeginDrawing();

                rl.ClearBackground(Color.MAROON);

                rl.DrawText("Score: " + score, 50, 50, 12,  Color.WHITE);

                rl.DrawText("Health: " + health, 50, 75, 12, Color.WHITE);

                rl.DrawText("Time: " + player.timer / 60, 750, 50, 12, Color.WHITE);
                if (player.timer/60 >= 15 && winState == false)
                {
                    rl.DrawText("Game Over", 250, 50, 20, Color.ORANGE);
                    rl.DrawText("BOI", 250, 75, 20, Color.ORANGE);
                    player.speed = 0;
                }
                player.Draw();

                foreach (Enemy en in enemies)
                {
                    if (en.isEnabled)
                    {
                        en.Draw();
                        if (CheckCollisionV2(player, en))
                        {
                            health--;
                        }
                        if (enemy.Position.x > player.Position.x)
                            enemy.Position.x--;
                        if (enemy.Position.x < player.Position.x)
                            enemy.Position.x++;
                        if (enemy.Position.y > player.Position.y)
                            enemy.Position.y--;
                        if (enemy.Position.y < player.Position.y)
                            enemy.Position.y++;
                        if (health <= 0)
                        {
                            rl.DrawText("Game Over", 250, 50, 20, Color.ORANGE);
                            rl.DrawText("BOI", 250, 75, 20, Color.ORANGE);
                            player.speed = 0;
                        }
                    }
                }
                foreach (Pickup pickup in Test)
                {
                    if (pickup.Enabled)
                    {
                        pickup.Draw();
                        score += CheckCollisionV1(player, pickup) ? 1 : 0;
                        //rl.PlayAudioStream(pick);
                        //if (CheckCollisionV1(player, pickup))
                        //    score++;
                    }
                }

                if (player.Position.x <= 0)
                    player.Position.x = 799;
                if (player.Position.x >= 800)
                    player.Position.x = 0;
                if (player.Position.y <= 0)
                    player.Position.y = 449;
                if (player.Position.y >= 450)
                    player.Position.y = 0;

                rl.EndDrawing();
                //----------------------------------------------------------------------------------
                if (score == 10)
                {
                    rl.DrawText("Oh goody, you won", 250, 50, 20, Color.ORANGE);
                    winState = true;
                    player.speed = 0;
                }
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            rl.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}
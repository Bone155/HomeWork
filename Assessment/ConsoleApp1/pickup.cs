using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    class Pickup
    {
        enum PickupType  { Ammo, Health, Score};
        public PickupType up;
        public Vector2Int Position = new Vector2Int();
        public bool Enabled = true;
        public Texture2D texture;
        public string file;
    }
    class Ammo : Pickup
    {
        int ammo;
        public Ammo()
        {
            up = PickupType.Ammo;
            ammo = 5;
            file = "platformPack_item001.png";
            texture = rl.LoadTexture(file);
        }

        public void Draw()
        {
            if (!(Enabled))
                return;
            rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, 1f, Color.RED);
        }
    }

    class Health : Pickup
    {
        int health;

        public Health()
        {
            up = PickupType.Health;
            health = 5;
            file = "platformPack_item017.png";
            texture = rl.LoadTexture(file);
        }

        public void Draw()
        {
            if (!(Enabled))
                return;
            rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, 1f, Color.RED);
        }
    }

    class Score : Pickup
    {
        int score;

        public Score()
        {
            up = PickupType.Score;
            score = 5;
            file = "platformPack_item009.png";
            texture = rl.LoadTexture(file);
        }

        public void Draw()
        {
            if (!(Enabled))
                return;
            rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, 1f, Color.RED);
        }
    }
}

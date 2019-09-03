using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    class Pickup
    {
        public Vector2Int Position;
        Color color = Color.RED;
        public bool Enabled = true;

        public Texture2D texture;
        public float SprScale = 1f;

        public void SetTexture(string file)
        {
            texture = rl.LoadTexture(file);
        }

        public void Draw()
        {
            if (!(Enabled))
                return;
            //rl.DrawRectangle(Position.x + 20, Position.y + 20, 20, 20, color);
            rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, SprScale, Color.WHITE);
            
        }

    }
}

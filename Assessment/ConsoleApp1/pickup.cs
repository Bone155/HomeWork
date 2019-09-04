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
        Color color;
        public bool Enabled;
        public Texture2D texture;
        public string file;


        public Pickup(Vector2Int Position, Color color, bool Enabled, Texture2D texture, string file)
        {
            this.Position = Position;
            this.color = Color.RED;
            this.Enabled = true;
            this.texture = texture;
            this.file = file;
        }

        public void SetTexture()
        {
            texture = rl.LoadTexture(file);
        }

    }
    class Ammo : Pickup
    {
        int ammo;

        public Ammo(Vector2Int Position, Color color, bool Enabled, Texture2D texture, string file, int ammo) : base(Position, color, Enabled, texture, file)
        {
            this.ammo = 5;
        }

        public void Draw()
        {
            if (!(Enabled))
                return;
            rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, 1f, color);
            
        }


        class Health : Pickup
        {
            int health;

            public Health(Vector2Int Position, Color color, bool Enabled, Texture2D texture, string file, int health) : base(Position, color, Enabled, texture, file)
            {
                this.health = 5;
            }

            public void Draw()
            {
                if (!(Enabled))
                    return;
                rl.DrawTextureEx(texture, new Vector2(Position.x, Position.y), 0f, 1f, color);

            }

        }
    }

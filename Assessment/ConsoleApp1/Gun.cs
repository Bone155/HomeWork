using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    class Gun
    {
        public Vector2Int Position = new Vector2Int();
        
        public void Draw()
        {
            rl.DrawLine(Position.x, Position.y, Position.x, Position.y + 5, Color.GREEN);
            rl.DrawLine(Position.x - 5, Position.y, Position.x + 10, Position.y, Color.GREEN);
        }
    }
}

﻿using Hugo.GameObjects.Enemies;
using Hugo.Utils;
using Hugo.Properties;
using Hugo.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects
{
    class Bomb : Enemy
    {
        public Bomb(Coord location)
            : base(location)
        {
        }
        public override void Draw(Graphics graphics)
        {
            if (IsVisible)
            {
                object bomb = Resources.bomb;
                if (bomb is Image)
                {
                    int cellSize = WFormDrawingEngine.CellSize;
                    Image obstacleImg = bomb as Image;
                    Point point = new Point(Location.X * cellSize, Location.Y * cellSize);
                    graphics.DrawImage(obstacleImg, point);
                }
            }
        }
    }
}

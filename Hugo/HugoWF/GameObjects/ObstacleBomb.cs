using Hugo.GameObjects.Enemies;
using Hugo.Helpers;
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
    class ObstacleBomb : Enemy
    {
        public ObstacleBomb(Coord location)
            : base(location)
        {
            this.IsVisible = true;
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
                    Point point = new Point((Location.X + 1) * cellSize, (Location.Y + 1) * cellSize);
                    graphics.DrawImage(obstacleImg, point);
                }
            }
        }
    }
}

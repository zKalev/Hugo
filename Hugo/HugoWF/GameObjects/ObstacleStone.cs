using Hugo.GameObjects.Enemies;
using Hugo.GameObjects.Players;
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
    class ObstacleStone : Enemy
    {

        public ObstacleStone(Coord location)
            : base(location)
        {
            this.IsVisible = true;
        }

        public override void ApplyEffects(IPlayer player)
        {
            // The stone does no damage
        }

        public override void Draw(Graphics graphics)
        {
            if (IsVisible)
            {
                object stone = Resources.stone;
                if (stone is Image)
                {
                    int cellSize = WFormDrawingEngine.CellSize;
                    Image obstacleImg = stone as Image;
                    Point point = new Point((Location.X + 1) * cellSize, (Location.Y + 1) * cellSize);
                    graphics.DrawImage(obstacleImg, point);
                }
            }
        }
    }
}

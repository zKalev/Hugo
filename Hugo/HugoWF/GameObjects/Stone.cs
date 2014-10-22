namespace Hugo.GameObjects
{
    using Hugo.Utils;
    using Hugo.Properties;
    using Hugo.UI;
    using System.Drawing;

    public class Stone : Obstacle
    {
        public Stone(Coord location)
            : base(location)
        {
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
                    Point point = new Point(Location.X * cellSize, Location.Y * cellSize);
                    graphics.DrawImage(obstacleImg, point);
                }
            }
        }
    }
}
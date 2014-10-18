using Hugo.GameObjects.Enemies;
using Hugo.Helpers;
using Hugo.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects
{
	class Obstacle: Enemy
	{

		public Obstacle(Coord location):base(location)
		{
		}
		public override void Draw(Graphics graphics)
		{
			//TODO
			//object obstacle = Properties.Resources.ResourceManager.GetObject("obstacle.png");
			//if (obstacle is Image)
			//{
			//	Image obstacleImg = obstacle as Image;
			//	Point point = new Point(Location.X, Location.Y);
			//	graphics.DrawImage(obstacleImg, point);
			//}

			int cellSize = WFormDrawingEngine.CellSize;
			graphics.FillRectangle(new SolidBrush(Color.BurlyWood), this.Location.X * cellSize, this.Location.Y * cellSize, cellSize, cellSize);
		}
	}
}

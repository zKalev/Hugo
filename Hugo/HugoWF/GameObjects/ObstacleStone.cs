﻿using Hugo.GameObjects.Enemies;
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
	class ObstacleStone: Enemy
	{

		public ObstacleStone(Coord location):base(location)
		{
		}

		public override void Apply(IPlayer player)
		{
			//TODO the stone does no damage but the player loses his turn
		}

		public override void Draw(Graphics graphics)
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

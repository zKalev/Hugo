﻿namespace Hugo.GameObjects
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Helpers;
	using System.Drawing;
	using Hugo.UI;

	public class Target : GameObject, ITarget
	{
		public Target(Coord location)
			: this(location, Color.Black)
		{
		}

		public Target(Coord location, Color objectColor)
			: base(location)
		{
			this.Color = objectColor;
			this.IsVisible = true;
		}

		public override void Draw(Graphics graphics)
		{
			int cellSize = WFormDrawingEngine.CellSize;
			graphics.FillRectangle(new SolidBrush(this.Color), this.Location.X * cellSize, this.Location.Y * cellSize, cellSize, cellSize);
		}
	}
}
namespace Hugo.UI
{
	using Hugo.Helpers;
	using Hugo.Players;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Windows.Forms;

	public class WFormDrawingEngine : IDrawingEngine
	{
		private static WFormDrawingEngine drawingEngine;
		private Form form;
		private static readonly Coord topLeft = new Coord();
		private static readonly Coord topCenter = new Coord(maxX / 2, 0);
		private static readonly Coord topRight = new Coord(maxX, 0);
		private static readonly Coord leftCenter = new Coord(0, maxY / 2);
		private static readonly Coord bottomLeft = new Coord(0, maxY);
		private static readonly Coord bottomCenter = new Coord(maxX, maxY / 2);
		private static readonly Coord bottomRight = new Coord(maxY, maxX);
		private static readonly Coord rightCenter = new Coord(maxY, maxX / 2);
		private const int margin = 2;
		private const int maxX = 24;
		private const int maxY = 24;
		private float cellSize = 20;

		private static readonly Coord marginCoord = new Coord(margin, margin);
		private IList<Coord> initialCoords = new List<Coord> { 
								WFormDrawingEngine.topLeft + marginCoord,
								WFormDrawingEngine.bottomRight + marginCoord,
								WFormDrawingEngine.topRight + marginCoord,
								WFormDrawingEngine.bottomLeft + marginCoord,
								WFormDrawingEngine.topCenter + marginCoord,
								WFormDrawingEngine.bottomCenter + marginCoord,
								WFormDrawingEngine.leftCenter + marginCoord,
								WFormDrawingEngine.rightCenter + marginCoord
		};

		public Form Form
		{
			get { return this.form; }
			set { this.form = value; }
		}
		public Coord TopLeft
		{
			get { return WFormDrawingEngine.topLeft; }
		}

		public Coord BottomRight
		{
			get { return WFormDrawingEngine.bottomRight; }
		}
		public IList<Coord> InitialCoords
		{
			get { return this.initialCoords; }
		}

		public int Margin
		{
			get { return WFormDrawingEngine.margin; }
		}

		public float CellSize
		{
			get { return this.cellSize; }
			set { this.cellSize = value; }
		}

		public static IDrawingEngine GetDrawingEngine()
		{
			if (null == WFormDrawingEngine.drawingEngine)
			{
				WFormDrawingEngine.drawingEngine = new WFormDrawingEngine();
			}

			return WFormDrawingEngine.drawingEngine;
		}

		public void DrawBoardFields()
		{
			Graphics g = form.CreateGraphics();
			Coord startPos = this.TopLeft;

			for (int x = (int)this.TopLeft.X - this.Margin; x <= this.BottomRight.X + this.Margin; x++)
			{
				for (int y = (int)this.TopLeft.Y - this.Margin; y <= this.BottomRight.Y + this.Margin; y++)
				{
					if ((x <= this.BottomRight.X && y <= this.BottomRight.Y) &&
						(x >= (int)this.TopLeft.X && y >= (int)this.TopLeft.Y))
					{
						g.FillRectangle(Brushes.GhostWhite, startPos.X, startPos.Y, cellSize, cellSize);
					}

					g.DrawRectangle(new Pen(Brushes.White), startPos.X, startPos.Y, cellSize, cellSize);

					startPos.ChangeToDown(cellSize);
				}

				startPos.Y = 0;
				startPos.ChangeToRight(cellSize);
			}
		}

		public void DrawPlayers(IEnumerable<IPlayer> players)
		{
			Graphics g = form.CreateGraphics();

			foreach (var player in players)
			{
				g.FillRectangle(
					new SolidBrush(player.Color),
					player.Location.X * cellSize,
					player.Location.Y * cellSize,
					cellSize,
					cellSize);
			}
		}

		public void DrawObjects(IList<GameObjects.IGameObject> gameObjects)
		{
			var g = form.CreateGraphics();

			foreach (var gameObject in gameObjects)
			{
				if (gameObject.IsVisible)
				{
					g.FillRectangle(
						new SolidBrush(gameObject.ObjectColor),
						(int)gameObject.Location.X * this.CellSize,
						(int)gameObject.Location.Y * this.CellSize,
						this.CellSize,
						this.CellSize
						);
				}
			}

		}
	}
}
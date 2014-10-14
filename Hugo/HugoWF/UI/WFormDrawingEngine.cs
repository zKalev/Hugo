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
        private readonly Coord topLeft = new Coord();
        private readonly Coord bottomRight = new Coord(30, 29);
        private float cellSize = 20;
        private Dictionary<Color, Brush> colors = new Dictionary<Color, Brush>();


        public Form Form
        {
            get { return this.form; }
            set { this.form = value; }
        }

        public float CellSize
        {
            get { return this.cellSize; }
            set { this.cellSize = value; }
        }

        public Coord TopLeft
        {
            get { return this.topLeft; }
        }

        public Coord BottomRight
        {
            get { return this.bottomRight; }
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

            for (int x = (int)this.TopLeft.X; x <= this.BottomRight.X; x++)
            {
                for (int y = (int)this.TopLeft.Y; y <= this.BottomRight.Y; y++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), startPos.X, startPos.Y, cellSize, cellSize);

                    if ((x != this.BottomRight.X && y != this.BottomRight.Y) && (x != (int)this.TopLeft.X && y != (int)this.TopLeft.Y))
                    {
                        g.FillRectangle(Brushes.Chocolate, startPos.X + 1, startPos.Y + 1, cellSize, cellSize);
                    }

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
                g.FillRectangle(new SolidBrush(player.Color), player.Location.X * cellSize, player.Location.Y * cellSize, cellSize, cellSize);
            }
        }

        public void DrawObjects(IList<GameObjects.IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }
    }
}
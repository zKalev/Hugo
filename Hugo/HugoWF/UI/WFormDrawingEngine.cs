namespace Hugo.UI
{
    using Hugo.Helpers;
    using Hugo.Players;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class WFormDrawingEngine : IDrawingEngine
    {
        private static WFormDrawingEngine drawingEngine;
        private Form form;
        private Dictionary<Colors, Brush> colors;

        public Form Form
        {
            get { return this.form; }
            set { this.form = value; }
        }

        public static WFormDrawingEngine GetDrawingEngine()
        {
            if (null == WFormDrawingEngine.drawingEngine)
            {
                WFormDrawingEngine.drawingEngine = new WFormDrawingEngine();
            }

            return WFormDrawingEngine.drawingEngine;
        }

        private const float ElementSize = 50;
        private const float PlayerSize = ElementSize / 2;
        private const float MovingUnit = ElementSize / 2;

        private const int XStartDrawingPoint = 5;
        private const int XEndDrawingPoint = 25;

        private const int YEndDrawingPoint = 23;
        private const int YStartDrawingPoint = 2;

        private const int FontSize = 15;


        public void DrawBoardFields()
        {
            Graphics g = form.CreateGraphics();
            for (int x = XStartDrawingPoint; x <= XEndDrawingPoint; x++)
            {
                for (int y = YStartDrawingPoint; y <= YEndDrawingPoint; y++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), x * MovingUnit, y * MovingUnit, ElementSize, ElementSize);

                    if ((x != XEndDrawingPoint && y != YEndDrawingPoint) && (x != XStartDrawingPoint && y != YStartDrawingPoint))
                    {
                        g.FillRectangle(Brushes.Chocolate, x * MovingUnit + 1, y * MovingUnit + 1, ElementSize, ElementSize);
                    }
                }
            }
        }

        public void DrawPlayers(IEnumerable<IPlayer> players)
        {
            throw new NotImplementedException();
        }

        public void DrawObjects(IList<GameObjects.IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }

        public Helpers.Coord TopLeft
        {
            get { throw new NotImplementedException(); }
        }

        public Helpers.Coord BottomRight
        {
            get { throw new NotImplementedException(); }
        }

        public string UIContent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IDrawingEngine IDrawingEngine.GetDrawingEngine()
        {
            throw new NotImplementedException();
        }

        
    }
}
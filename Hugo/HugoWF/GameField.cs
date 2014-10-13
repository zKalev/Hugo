using Hugo.Engine;
using Hugo.Helpers;
using Hugo.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoWF
{
    public partial class GameField : Form
    {

        private const float ElementSize = 50;
        private const float PlayerSize = ElementSize / 2;

        private const int XStartDrawingPoint = 5;
        private const int XEndDrawingPoint = 25;

        private const int YEndDrawingPoint = 23;
        private const int YStartDrawingPoint = 2;

        private const int FontSize = 15;

        public GameField()
        {
            InitializeComponent();
            SetStartPositionForPlayers();
        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            DrawField(e.Graphics);
            DrawPlayers(e.Graphics);
        }

        private void DrawField(Graphics g)
        {
            for (int x = XStartDrawingPoint; x <= XEndDrawingPoint; x++)
            {
                for (int y = YStartDrawingPoint; y <= YEndDrawingPoint; y++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), x * ElementSize / 2, y * ElementSize / 2, ElementSize, ElementSize);

                    if ((x != XEndDrawingPoint && y != YEndDrawingPoint) && (x != XStartDrawingPoint && y != YStartDrawingPoint))
                    {
                        g.FillRectangle(Brushes.Chocolate, x * ElementSize / 2 + 1, y * ElementSize / 2 + 1, ElementSize, ElementSize);
                    }
                }
            }
        }
        private void DrawPlayers(Graphics g)
        {
            Engine engine = Engine.GetInstance();
            IList<IPlayer> players = engine.Players;

            for (int player = 0; player < players.Count; player++)
            {
                float x = 28 * ElementSize / 2 + 1;
                float y = 4 * ElementSize / 2 + 1 + 35 * (player);

                g.FillRectangle(Brushes.Coral, x, y, PlayerSize, PlayerSize);

                float xStartPointForPrintingName = x + 40;
                PointF playerNamePrintStartPoint = new PointF(xStartPointForPrintingName, y);
                Font playerNameFont = new Font(String.Empty, FontSize);
                IPlayer currentPlayer = players.ElementAt(player);
                g.DrawString(currentPlayer.Name + " : " + currentPlayer.Points, playerNameFont, Brushes.Black, playerNamePrintStartPoint);

                //draw player on the field
               
                g.FillRectangle(Brushes.Coral, currentPlayer.Location.X, currentPlayer.Location.Y, PlayerSize, PlayerSize);
            }

        }

        private void SetStartPositionForPlayers()
        {
            float xFieldPlayeresDrawing = 5 * ElementSize / 2 + 1;
            float yFieldPlayersDrawing = 23 * ElementSize / 2 + 1;

            foreach (IPlayer p in Engine.GetInstance().Players)
            {
                xFieldPlayeresDrawing=xFieldPlayeresDrawing+ElementSize;
                p.Location = new Coord(xFieldPlayeresDrawing, yFieldPlayersDrawing);
            }
        }

    }
}
